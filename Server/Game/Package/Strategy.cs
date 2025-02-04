﻿using CommonClass;
using CommonClass.Game;
using CommonClassLibrary;
using SanguoshaServer.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static CommonClass.Game.CardUseStruct;
using static CommonClass.Game.Player;
using static SanguoshaServer.Package.FunctionCard;

namespace SanguoshaServer.Package
{
    public class Strategy : GeneralPackage
    {
        public Strategy() : base("Strategy")
        {
            skills = new List<Skill>
            {
                new Qiao(),
                new Chengshang(),
                new JianliangHegemony(),
                new WeimengHegemony(),
                new WeimengStrategy(),
                new YouyanHegemony(),
                new ZhuihuanHegemony(),
                new ZhuihuanEffectHegemony(),

                new Zhente(),
                new Zhiwei(),
                new Yusui(),
                new Boyan(),
                new BoyanStrategy(),
                
                new KuangcaiHegemony(),
                new KuangcaiHegemonyMax(),
                new KuangcaiHegemonyTar(),
                new ShejianHegemony(),
                new FenglueHegemony(),
                new FenglueStrategy(),
                new Anyong(),

            };

            skill_cards = new List<FunctionCard>
            {
                new WeimengHCard(),
                new WeimengSCard(),
                new FenglueCard(),
                new FenglueSCard(),
                new BoyanCard(),
                new BoyanSCard(),
            };

            related_skills = new Dictionary<string, List<string>>
            {
                { "kuangcai_hegemony", new List<string> { "#kuangcai_hegemony", "#kuangcai_hegemony-max" } },
                { "zhuihuan_hegemony", new List<string> { "#zhuihuan_hegemony" } },
            };
        }
    }



    //zongyu
    public class Qiao : TriggerSkill
    {
        public Qiao() : base("qiao")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.TargetConfirmed };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                foreach (Player p in room.GetAlivePlayers())
                    if (p.GetMark(Name) > 0) p.SetMark(Name, 0);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetConfirmed && base.Triggerable(player, room) && data is CardUseStruct use && use.From != null && use.From != player && use.From.Alive
                && !RoomLogic.WillBeFriendWith(room, player, use.From) && !use.From.IsAllNude() && RoomLogic.CanDiscard(room, player, use.From, "he") && player.GetMark(Name) < 2)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (!(fcard is SkillCard))
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && room.AskForSkillInvoke(player, Name, use.From, info.SkillPosition))
            {
                player.AddMark(Name);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, use.From.Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                List<int> ids = new List<int> { room.AskForCardChosen(player, use.From, "he", Name, false, HandlingMethod.MethodDiscard) };
                room.ThrowCard(ref ids,
                    new CardMoveReason(MoveReason.S_REASON_DISMANTLE, player.Name, use.From.Name, Name, string.Empty) { General = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition) }
                    , use.From, player);
                if (player.Alive && !player.IsNude() && RoomLogic.CanDiscard(room, player, player, "he"))
                    room.AskForDiscard(player, Name, 1, 1, false, true, "@qiao", false, info.SkillPosition);
            }

            return false;
        }
    }

    public class Chengshang : TriggerSkill
    {
        public Chengshang() : base("chengshang")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardFinished, TriggerEvent.Damage };
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && player.Phase == PlayerPhase.Play && base.Triggerable(player, room) && !player.HasFlag(Name) && damage.Card != null)
                damage.Card.SetFlags(Name);
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardFinished && base.Triggerable(player, room) && data is CardUseStruct use && !player.HasFlag(Name) && !use.Card.HasFlag(Name) && !Engine.IsSkillCard(use.Card.Name))
            {
                bool diff = false;
                foreach (Player p in use.To)
                {
                    if (!RoomLogic.WillBeFriendWith(room, player, p) && p.Alive && !p.IsNude())
                    {
                        diff = true;
                        break;
                    }
                }
                if (diff) return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in use.To)
                {
                    if (!RoomLogic.WillBeFriendWith(room, player, p) && p.Alive && !p.IsNude())
                        targets.Add(p);
                }

                if (targets.Count > 0)
                {
                    Player target = null;
                    if (targets.Count == 1 && room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
                        target = targets[0];
                    else if (targets.Count > 1)
                        target = room.AskForPlayerChosen(player, targets, Name, "@chengshang", true, true, info.SkillPosition);

                    if (target != null)
                    {
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                        room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                        room.SetTag(Name, target);
                        return info;
                    }
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is Player target && data is CardUseStruct use)
            {
                room.RemoveTag(Name);
                List<int> ids = room.AskForExchange(target, Name, 1, 1, "@chengshang-give:" + player.Name, string.Empty, "..", info.SkillPosition);
                if (ids.Count > 0)
                {
                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, target.Name, player.Name, Name, string.Empty);
                    room.ObtainCard(player, ref ids, reason, true);

                    WrappedCard card = room.GetCard(ids[0]);
                    if (player.Alive && (card.Number == use.Card.Number || card.Suit == use.Card.Suit))
                        player.SetFlags(Name);
                }
            }
            return false;
        }
    }


    //dengzhi
    public class JianliangHegemony : TriggerSkill
    {
        public JianliangHegemony() : base("jianliang_hegemony")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Draw)
            {
                int max = 1000;
                foreach (Player p in room.GetAlivePlayers())
                    if (p.HandcardNum < max)
                        max = p.HandcardNum;

                if (player.HandcardNum == max)
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, "@jianliang_hegemony", info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetAlivePlayers())
                if (RoomLogic.IsFriendWith(room, player, p))
                    targets.Add(p);

            foreach (Player p in targets)
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, p.Name);

            foreach (Player p in targets)
            {
                if (p.Alive)
                    room.DrawCards(p, new DrawCardStruct(1, player, Name));
            }

            return false;
        }
    }


    public class WeimengHegemony : ZeroCardViewAsSkill
    {
        public WeimengHegemony() : base("weimeng_hegemony") { }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(WeimengHCard.ClassName);

        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(WeimengHCard.ClassName) { Skill = Name, ShowSkill = Name };
    }

    public class WeimengHCard : SkillCard
    {
        public static string ClassName = "WeimengHCard";
        public WeimengHCard() : base(ClassName) { }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && Self != to_select && !to_select.IsKongcheng() && RoomLogic.CanGetCard(room, Self, to_select, "h");
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            List<string> patterns = new List<string>();
            for (int i = 0; i < Math.Max(1, Math.Min(player.Hp, target.HandcardNum)); i++)
                patterns.Add("h^false^get");

            List<int> ids = room.AskForCardsChosen(player, target, patterns, "weimeng_hegemony");
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_EXTRACTION, player.Name);
            room.ObtainCard(player, ref ids, reason, false);

            if (player.Alive && target.Alive)
            {
                int min = Math.Min(player.GetCardCount(true), ids.Count);
                List<int> give = room.AskForExchange(player, "weimeng_hegemony", min, min, string.Format("@weimeng:{0}::{1}", target.Name, min), string.Empty, "..", card_use.Card.SkillPosition);
                room.ObtainCard(target, ref give, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "weimeng_hegemony", string.Empty), false);
                if (target.Alive)
                    room.HandleAcquireDetachSkills(target, "weimeng_strategy", true);
            }
        }
    }

    public class WeimengStrategy : TriggerSkill
    {
        public WeimengStrategy() : base("weimeng_strategy")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            view_as_skill = new WeimengStrategyVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                room.HandleAcquireDetachSkills(player, "-weimeng_strategy", true);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class WeimengStrategyVS : ZeroCardViewAsSkill
    {
        public WeimengStrategyVS() : base("weimeng_strategy") { }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(WeimengSCard.ClassName);
        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(WeimengSCard.ClassName) { Skill = Name };
    }

    public class WeimengSCard : SkillCard
    {
        public static string ClassName = "WeimengSCard";
        public WeimengSCard() : base(ClassName) { }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && Self != to_select && !to_select.IsKongcheng() && RoomLogic.CanGetCard(room, Self, to_select, "h");
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            List<string> patterns = new List<string>();

            int id = room.AskForCardChosen(player, target, "h", "weimeng_strategy", false, HandlingMethod.MethodGet);
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_EXTRACTION, player.Name);
            room.ObtainCard(player, room.GetCard(id), reason, false);

            if (player.Alive && target.Alive)
            {
                List<int> give = room.AskForExchange(player, "weimeng_strategy", 1, 1, string.Format("@weimeng:{0}::{1}", target.Name, 1), string.Empty, "..", card_use.Card.SkillPosition);
                room.ObtainCard(target, ref give, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "weimeng_strategy", string.Empty), false);
            }
        }
    }

    public class YouyanHegemony : TriggerSkill
    {
        public YouyanHegemony() : base("youyan_hegemony")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime };
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardsMoveOneTimeStruct move && base.Triggerable(move.From, room) && move.From.Phase != PlayerPhase.NotActive
                && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && !move.From.HasFlag(Name))
            {
                List<WrappedCard.CardSuit> suits = new List<WrappedCard.CardSuit>();
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    int id = move.Card_ids[i];
                    if (move.From_places[i] == Place.PlaceHand || move.From_places[i] == Place.PlaceEquip)
                    {
                        WrappedCard.CardSuit suit = room.GetCard(id).Suit;
                        if (!suits.Contains(suit))
                            suits.Add(suit);
                    }
                }
                if (suits.Count < 4) return new TriggerStruct(Name, move.From);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                ask_who.SetFlags(Name);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardsMoveOneTimeStruct move)
            {
                List<WrappedCard.CardSuit> suits = new List<WrappedCard.CardSuit>();
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    int id = move.Card_ids[i];
                    if (move.From_places[i] == Place.PlaceHand || move.From_places[i] == Place.PlaceEquip)
                    {
                        WrappedCard.CardSuit suit = room.GetCard(id).Suit;
                        if (!suits.Contains(suit))
                            suits.Add(suit);
                    }
                }

                List<int> ids = room.GetNCards(4);
                List<int> gets = new List<int>(), drops = new List<int>();
                foreach (int id in ids)
                {
                    room.MoveCardTo(room.GetCard(id), ask_who, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_TURNOVER, ask_who.Name, Name, null), false);
                    Thread.Sleep(400);
                    if (!suits.Contains(room.GetCard(id).Suit))
                        gets.Add(id);
                    else
                        drops.Add(id);
                }

                room.MoveCards(new List<CardsMoveStruct>{
                new CardsMoveStruct(gets, ask_who, Place.PlaceHand, new CardMoveReason(MoveReason.S_REASON_GOTBACK, ask_who.Name, Name, null)) },
                    true);
                room.MoveCards(new List<CardsMoveStruct>{
                new CardsMoveStruct(drops, null, Place.DiscardPile, new CardMoveReason(MoveReason.S_REASON_NATURAL_ENTER, null, Name, null)) },
                    true);
            }

            return false;
        }
    }
    public class ZhuihuanHegemony : TriggerSkill
    {
        public ZhuihuanHegemony() : base("zhuihuan_hegemony")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.RoundStart };
            skill_type = SkillType.Wizzard;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.RoundStart && player != null && player.Alive && player.ContainsTag(Name) && player.GetTag(Name) is List<string> targets)
            {
                foreach (string target_name in targets)
                {
                    Player p = room.FindPlayer(target_name);
                    if (p != null)
                    {
                        p.SetMark("zhuihuan_0", 0);
                        p.SetMark("zhuihuan_1", 0);
                        room.RemovePlayerStringMark(p, Name);
                    }
                }
                player.RemoveTag(Name);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = room.AskForPlayersChosen(player, room.GetAlivePlayers(), Name, 0, 2, "@zhuihuan_hegemony", true, info.SkillPosition);
            if (targets.Count > 0)
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.NotifySkillInvoked(player, Name);
                room.SetTag(Name, targets);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is List<Player> targets)
            {
                room.RemoveTag(Name);
                List<string> choices = new List<string> { "damage", "discard" }, target_names = new List<string>();
                for (int i = 0; i < targets.Count; i++)
                {
                    Player target = targets[i];
                    string choice = room.AskForChoice(player, Name, string.Join("+", choices), new List<string> { "@to-player:" + target.Name }, target, info.SkillPosition);
                    choices.Remove(choice);
                    if (choice == "dammage")
                        target.SetMark("zhuihuan_0", 1);
                    else
                        target.SetMark("zhuihuan_1", 1);
                    room.SetPlayerStringMark(target, Name, string.Empty);
                    target_names.Add(target.Name);
                }
                player.SetTag(Name, target_names);
            }

            return false;
        }
    }

    public class ZhuihuanEffectHegemony : TriggerSkill
    {
        public ZhuihuanEffectHegemony() : base("#zhuihuan_hegemony")
        {
            events.Add(TriggerEvent.Damaged);
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DamageStruct damage && damage.From != null && damage.From.Alive && damage.From != player &&
                player.Alive && (player.GetMark("zhuihuan_0") > 0 || player.GetMark("zhuihuan_1") > 0))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, damage.From.Name);
                if (player.GetMark("zhuihuan_0") > 0)
                {
                    player.SetMark("zhuihuan_0", 0);
                    room.Damage(new DamageStruct("zhuihuan_hegemony", player, damage.From));
                }
                if (player.Alive && player.GetMark("zhuihuan_1") > 0)
                {
                    player.SetMark("zhuihuan_1", 0);
                    if (damage.From.Alive && !damage.From.IsKongcheng())
                        room.AskForDiscard(damage.From, "zhuihuan_hegemony", 2, 2, false, false, "@zhuihuan_discard:" + player.Name, false);
                }
            }
            room.RemovePlayerStringMark(player, "zhuihuan_hegemony");
            return false;
        }
    }


    public class Zhente : TriggerSkill
    {
        public Zhente() : base("zhente")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.TargetConfirmed, TriggerEvent.Death };
            skill_type = SkillType.Defense;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            bool clear = false;
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (p.HasFlag(Name))
                        p.SetFlags("-zhente");

                if (player.HasFlag("ZhenteTarget"))
                    clear = true;
            }

            if (triggerEvent == TriggerEvent.Death && player.HasFlag("ZhenteTarget"))
                clear = true;

            if (clear)
            {
                RoomLogic.RemovePlayerCardLimitation(player, Name);
                room.SetPlayerMark(player, "@qianxi_black", 0);
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetConfirmed && base.Triggerable(player, room) && data is CardUseStruct use && use.To.Contains(player)
                && !player.HasFlag(Name) && use.From != null && use.From != player && use.From.Alive)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if ((fcard is BasicCard || fcard.IsNDTrick()) && WrappedCard.IsBlack(use.Card.Suit))
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
            {
                player.SetFlags(Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player liushan, ref object data, Player ask_who, TriggerStruct info)
        {
            CardUseStruct use = (CardUseStruct)data;

            int index = 0, i;
            for (i = 0; i < use.EffectCount.Count; i++)
            {
                CardBasicEffect effect = use.EffectCount[i];
                if (effect.To == liushan)
                {
                    index++;
                    if (index == info.Times)
                    {
                        use.From.SetTag(Name, i);
                        break;
                    }
                }
            }

            if (room.AskForChoice(use.From, Name, "use+nulli", new List<string> { "@to-player:" + liushan.Name }, data, info.SkillPosition) == "nulli")
            {
                CardBasicEffect effect = use.EffectCount[i];
                effect.Nullified = true;

                data = use;
            }
            else
            {
                string color = "black";
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, liushan.Name, use.From.Name);

                string pattern = string.Format(".|{0}|.|hand$0", color);
                use.From.SetFlags("ZhenteTarget");
                room.AddPlayerMark(use.From, "@qianxi_" + color);
                RoomLogic.SetPlayerCardLimitation(use.From, Name, "use", pattern, false);

                LogMessage log = new LogMessage
                {
                    Type = "#NoColor",
                    From = use.From.Name,
                    Arg = "no_suit_" + color,
                    Arg2 = Name
                };
                room.SendLog(log);
            }

            use.From.RemoveTag(Name);

            return false;
        }
    }

    public class Zhiwei : TriggerSkill
    {
        public Zhiwei() : base("zhiwei")
        {
            events = new List<TriggerEvent> { TriggerEvent.GeneralShown, TriggerEvent.Damage, TriggerEvent.Damaged, TriggerEvent.Death,
                TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseEnd };
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.From.Phase == PlayerPhase.Discard
                && move.From == room.Current && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && base.Triggerable(move.From, room))
            {
                if (move.From.ContainsTag(Name) && move.From.GetTag(Name) is string target_name)
                {
                    Player target = room.FindPlayer(target_name);
                    if (target != null)
                    {
                        List<int> guzhengToGet = move.From.ContainsTag("zhiwei_give") ? (List<int>)move.From.GetTag("zhiwei_give") : new List<int>();
                        foreach (int card_id in move.Card_ids)
                        {
                            if (!guzhengToGet.Contains(card_id))
                                guzhengToGet.Add(card_id);
                        }

                        move.From.SetTag("zhiwei_give", guzhengToGet);
                    }
                }
            }
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.GeneralShown)
            {
                if (base.Triggerable(player, room) && !player.ContainsTag(Name))
                {
                    bool head = (bool)data;
                    if (head && RoomLogic.InPlayerHeadSkills(player, Name))
                    {
                        TriggerStruct trigger = new TriggerStruct(Name, player)
                        {
                            SkillPosition = "head"
                        };
                        triggers.Add(trigger);
                    }
                    else if (!head && RoomLogic.InPlayerDeputykills(player, Name))
                    {
                        TriggerStruct trigger = new TriggerStruct(Name, player)
                        {
                            SkillPosition = "deputy"
                        };
                        triggers.Add(trigger);
                    }
                }
            }
            else if ((triggerEvent == TriggerEvent.Damage || triggerEvent == TriggerEvent.Damaged) && player.ContainsTag("zhiwei_from")
                && player.GetTag("zhiwei_from") is List<string> froms)
            {
                foreach (string name in froms)
                {
                    Player p = room.FindPlayer(name);
                    if (p != null && RoomLogic.PlayerHasShownSkill(room, p, Name))
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }
            else if (triggerEvent == TriggerEvent.Death && player.ContainsTag("zhiwei_from")
                && player.GetTag("zhiwei_from") is List<string> _froms)
            {
                foreach (string name in _froms)
                {
                    Player p = room.FindPlayer(name);
                    if (p != null)
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseEnd && player.Phase == PlayerPhase.Discard && player.ContainsTag("zhiwei_give"))
                triggers.Add(new TriggerStruct(Name, player));

            return triggers;
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.GeneralShown)
            {
                Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@zhiwei-choose", false, true, info.SkillPosition);
                player.SetTag(Name, target.Name);
                List<string> zhiwei = new List<string>();
                if (target.ContainsTag("zhiwei_from")) zhiwei = (List<string>)target.GetTag("zhiwei_from");
                if (!zhiwei.Contains(player.Name)) zhiwei.Add(player.Name);
                target.SetTag("zhiwei_from", zhiwei);
            }
            else if (triggerEvent == TriggerEvent.Damaged && !ask_who.IsKongcheng())
            {
                room.AskForDiscard(ask_who, Name, 1, 1, false, false, "@zhiwei-discard:" + player.Name, false, info.SkillPosition);
            }
            else if (triggerEvent == TriggerEvent.Damage)
            {
                room.DrawCards(ask_who, 1, Name);
            }
            else if (triggerEvent == TriggerEvent.Death)
            {
                ask_who.RemoveTag(Name);
                if (ask_who.HasShownAllGenerals() && RoomLogic.PlayerHasShownSkill(room, ask_who, Name))
                    room.HideGeneral(ask_who, RoomLogic.InPlayerHeadSkills(ask_who, Name));
            }
            else if (triggerEvent == TriggerEvent.EventPhaseEnd && ask_who.ContainsTag(Name) && ask_who.GetTag(Name) is string target_name)
            {
                Player target = room.FindPlayer(target_name);
                if (base.Triggerable(player, room) && target != null && player.GetTag("zhiwei_give") is List<int> guzhengToGet)
                {
                    guzhengToGet.RemoveAll(t => room.GetCardPlace(t) != Place.DiscardPile);
                    if (guzhengToGet.Count > 0)
                    {
                        room.ObtainCard(target, ref guzhengToGet, new CardMoveReason(MoveReason.S_REASON_RECYCLE, player.Name, target.Name, Name, string.Empty));
                    }
                }
                player.RemoveTag("zhiwei_give");
            }

            return false;
        }
    }

    public class Yusui : TriggerSkill
    {
        public Yusui()  :base("yusui")
        {
            events.Add(TriggerEvent.TargetConfirmed);
            skill_type = SkillType.Masochism;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && use.From != null && use.From != player && !RoomLogic.WillBeFriendWith(room, player, use.From) && !Engine.IsSkillCard(use.Card.Name)
                && WrappedCard.IsBlack(use.Card.Suit) && !player.HasFlag(Name) && base.Triggerable(player, room) && player.Hp > 0)
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && room.AskForSkillInvoke(player, Name, use.From, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, use.From.Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                player.SetFlags(Name);
                room.LoseHp(player);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Alive && data is CardUseStruct use && use.From.Alive)
            {
                List<string> choices = new List<string>();
                if (!use.From.IsKongcheng())
                    choices.Add("discard");
                if (use.From.Hp > player.Hp)
                    choices.Add("losehp");

                if (choices.Count > 0)
                {
                    string choice = room.AskForChoice(player, Name, string.Join("+", choices), new List<string> { "@to-player:" + use.From.Name }, use.From, info.SkillPosition);
                    if (choice == "discard")
                    {
                        int count = Math.Min(use.From.HandcardNum, use.From.MaxHp);
                        room.AskForDiscard(use.From, Name, count, count, false, false, string.Format("@yusui:{0}::{1}", player.Name, count), false);
                    }
                    else
                        room.LoseHp(use.From, use.From.Hp - player.Hp);
                }
            }

            return false;
        }
    }

    public class Boyan : ZeroCardViewAsSkill
    {
        public Boyan() : base("boyan") { }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(BoyanCard.ClassName);
        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(BoyanCard.ClassName) { Skill = Name, ShowSkill = Name };
    }

    public class BoyanCard : SkillCard
    {
        public static string ClassName = "BoyanCard";
        public BoyanCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => to_select != Self && targets.Count == 0;
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            if (target.HandcardNum < target.MaxHp)
                room.DrawCards(target, new DrawCardStruct(target.MaxHp - target.HandcardNum, player, "boyan"));

            if (target.Alive)
            {
                string pattern = ".|.|.|hand";
                RoomLogic.SetPlayerCardLimitation(target, "boyan", "use,response", pattern, true);
                room.HandleAcquireDetachSkills(target, "boyan_strategy", true);
            }
        }
    }
    public class BoyanStrategy : TriggerSkill
    {
        public BoyanStrategy() : base("boyan_strategy")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            view_as_skill = new BoyanStrategyVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                room.HandleAcquireDetachSkills(player, "-boyan_strategy", true);
                foreach (Player p in room.GetAlivePlayers())
                    RoomLogic.RemovePlayerCardLimitation(p, "boyan");
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }
    public class BoyanStrategyVS : ZeroCardViewAsSkill
    {
        public BoyanStrategyVS() : base("boyan_strategy") { }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(BoyanSCard.ClassName);
        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(BoyanSCard.ClassName) { Skill = Name };
    }

    public class BoyanSCard : SkillCard
    {
        public static string ClassName = "BoyanSCard";
        public BoyanSCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => to_select != Self && targets.Count == 0;
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0];
            string pattern = ".|.|.|hand";
            RoomLogic.SetPlayerCardLimitation(target, "boyan", "use,response", pattern, true);
        }
    }

    //miheng
    public class KuangcaiHegemony : TriggerSkill
    {
        public KuangcaiHegemony() : base("kuangcai_hegemony")
        {
            frequency = Frequency.Compulsory;
            events = new List<TriggerEvent> { TriggerEvent.DamageDone, TriggerEvent.CardUsedAnnounced };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && player.Phase != PlayerPhase.NotActive && !player.HasFlag(Name))
                player.SetFlags("kuangcai_use");
            else if (triggerEvent == TriggerEvent.DamageDone && data is DamageStruct damage && damage.From != null && damage.From.Phase != PlayerPhase.NotActive)
                damage.From.SetFlags(Name);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class KuangcaiHegemonyTar : TargetModSkill
    {
        public KuangcaiHegemonyTar() : base("#kuangcai_hegemony", true)
        {
            pattern = "BasicCard#TrickCard";
        }

        public override int GetResidueNum(Room room, Player from, WrappedCard card)
        {
            if (RoomLogic.PlayerHasShownSkill(room, from, "kuangcai_hegemony"))
                return 1000;
            else
                return 0;
        }

        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern)
        {
            if (to != null && RoomLogic.PlayerHasShownSkill(room, from, "kuangcai_hegemony") && from.Phase != PlayerPhase.NotActive)
                return true;

            return false;
        }
    }

    public class KuangcaiHegemonyMax : MaxCardsSkill
    {
        public KuangcaiHegemonyMax() : base("#kuangcai_hegemony-max") { }
        public override int GetExtra(Room room, Player target)
        {
            if (RoomLogic.PlayerHasShownSkill(room, target, "kuangcai_hegemony"))
            {
                if (!target.HasFlag("kuangcai_use"))
                    return 1;
                else if (!target.HasFlag("kuangcai_hegemony"))
                    return -1;
            }

            return 0;
        }
    }

    public class ShejianHegemony : TriggerSkill
    {
        public ShejianHegemony() : base("shejian_hegemony")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetConfirmed };
            skill_type = SkillType.Attack;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && use.To.Count == 1 && base.Triggerable(player, room) && !player.IsKongcheng() && use.From != null && use.From.Alive
                && use.From != player && RoomLogic.CanDiscard(room, player, player, "h"))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is BasicCard || fcard is TrickCard)
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && room.AskForSkillInvoke(player, Name, "@shejian_hegemony:" + use.From.Name, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, use.From.Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);

                List<int> ids = room.ForceToDiscard(player, player.GetCards("h"), player.GetCardCount(false), true);
                room.ThrowCard(ref ids,
                    new CardMoveReason(MoveReason.S_REASON_THROW, player.Name, Name, string.Empty) { General = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition) },
                    player, null, Name);
                player.SetMark(Name, ids.Count);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && use.From.Alive)
            {
                List<string> choices = new List<string>();
                if (RoomLogic.CanDiscard(room, player, use.From, "he"))
                    choices.Add("discard");

                bool check = true;
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.HasFlag("Global_Dying"))
                    {
                        check = false;
                        break;
                    }
                }
                if (check) choices.Add("damage");
                if (choices.Count > 0)
                {
                    string choice = room.AskForChoice(player, Name, string.Join("+", choices), new List<string> { "@to-player:" + use.From.Name }, use.From, info.SkillPosition);
                    if (choice == "discard")
                    {
                        List<string> patterns = new List<string>();
                        for (int i = 0; i < Math.Min(player.GetMark(Name), use.From.GetCardCount(true)); i++)
                            patterns.Add("he^false^none");
                        List<int> ids = room.AskForCardsChosen(player, use.From, patterns, Name);
                        room.ThrowCard(ref ids, new CardMoveReason(MoveReason.S_REASON_DISMANTLE, player.Name, use.From.Name, Name, string.Empty), use.From, player);
                    }
                    else
                        room.Damage(new DamageStruct(Name, player, use.From));
                }
            }
            return false;
        }
    }

    public class FenglueHegemony : ZeroCardViewAsSkill
    {
        public FenglueHegemony() : base("fenglue_hegemony") { }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(FenglueCard.ClassName) && !player.IsKongcheng();

        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(FenglueCard.ClassName) { Skill = Name, ShowSkill = Name };
    }

    public class FenglueCard : SkillCard
    {
        public static string ClassName = "FenglueCard";
        public FenglueCard() : base(ClassName)
        { }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && to_select != Self && !to_select.IsKongcheng() && RoomLogic.CanBePindianBy(room, to_select, Self);

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            Player target = card_use.To[0];

            PindianStruct pd = room.PindianSelect(player, target, "fenglue_hegemony");
            room.Pindian(ref pd);

            if (pd.Success)
            {
                if (player.Alive && target.Alive && !target.IsAllNude())
                {
                    List<int> ids = new List<int>();
                    List<int> hej = target.GetCards("hej");
                    if (hej.Count <= 2)
                        ids = hej;
                    else
                    {
                        target.SetFlags("fenglue_hegemony");
                        List<int> judges = target.GetCards("j");
                        target.PileChange("#Judging", judges);
                        ids = room.AskForExchange(target, "fenglue_hegemony", 2, 2, string.Format("@fenglue_hegemony-give:{0}::{1}", player.Name, 2), "#Judging", "..", string.Empty);
                        target.SetFlags("-fenglue_hegemony");
                        target.PileChange("#Judging", judges, false);
                    }

                    room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, target.Name, player.Name, Name, string.Empty), false);
                }
            }
            else
            {
                if (player.Alive && target.Alive && !player.IsNude())
                {
                    List<int> ids = room.AskForExchange(player, "fenglue_hegemony", 1, 1, string.Format("@fenglue_hegemony-fail:{0}::1", target.Name), string.Empty, "..", card_use.Card.SkillPosition);
                    room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty), false);
                }
            }

            if (target.Alive) room.HandleAcquireDetachSkills(target, "fenglue_strategy", true);
        }
    }
    public class FenglueStrategy : TriggerSkill
    {
        public FenglueStrategy() : base("fenglue_strategy")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            view_as_skill = new FenglueStrategyVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                room.HandleAcquireDetachSkills(player, "-fenglue_strategy", true);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class FenglueStrategyVS : ZeroCardViewAsSkill
    {
        public FenglueStrategyVS() : base("fenglue_strategy") { }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(FenglueSCard.ClassName) && !player.IsKongcheng();
        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(FenglueSCard.ClassName) { Skill = Name };
    }

    public class FenglueSCard : SkillCard
    {
        public static string ClassName = "FenglueSCard";
        public FenglueSCard() : base(ClassName)
        { }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && to_select != Self && !to_select.IsKongcheng() && RoomLogic.CanBePindianBy(room, to_select, Self);

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            Player target = card_use.To[0];

            PindianStruct pd = room.PindianSelect(player, target, "fenglue_strategy");
            room.Pindian(ref pd);

            if (pd.Success)
            {
                if (player.Alive && target.Alive && !target.IsAllNude())
                {
                    target.SetFlags("fenglue_strategy");
                    List<int> judges = target.GetCards("j");
                    target.PileChange("#Judging", judges);
                    List<int> ids = room.AskForExchange(target, "fenglue_strategy", 1, 1, string.Format("@fenglue_hegemony-give:{0}::{1}", player.Name, 1), "#Judging", "..", string.Empty);
                    target.SetFlags("-fenglue_strategy");
                    target.PileChange("#Judging", judges, false);

                    room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, target.Name, player.Name, Name, string.Empty), false);
                }
            }
            else
            {
                if (player.Alive && target.Alive && !player.IsNude())
                {
                    List<int> ids = new List<int>();
                    if (player.GetCardCount(true) <= 2)
                        ids = player.GetCards("he");
                    else
                        ids = room.AskForExchange(player, "fenglue_strategy", 2, 2, string.Format("@fenglue_hegemony-fail:{0}::2", target.Name), string.Empty, "..", card_use.Card.SkillPosition);

                    room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty), false);
                }
            }
        }
    }

    public class Anyong : TriggerSkill
    {
        public Anyong() : base("anyong")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageCaused };
            skill_type = SkillType.Attack;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (data is DamageStruct damage && player != null && player.Alive && damage.To != player)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p != damage.To && !p.HasFlag(Name) && RoomLogic.WillBeFriendWith(room, p, player, Name))
                        triggers.Add(new TriggerStruct(Name, p));               
            }
            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                room.SetTag(Name, data);
                bool invoke = room.AskForSkillInvoke(ask_who, Name, string.Format("@anyong:{0}:{1}:{2}", player.Name, damage.To.Name, damage.Damage), info.SkillPosition);
                room.RemoveTag(Name);
                if (invoke)
                {
                    ask_who.SetFlags(Name);
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            DamageStruct damage = (DamageStruct)data;
            damage.Damage *= 2;

            LogMessage log = new LogMessage
            {
                Type = "#AddDamage",
                From = player.Name,
                To = new List<string> { damage.To.Name },
                Arg = Name,
                Arg2 = damage.Damage.ToString()
            };
            room.SendLog(log);

            data = damage;

            if (damage.To.HasShownAllGenerals())
            {
                room.LoseHp(ask_who);
                string skill = info.SkillPosition == "head" ? "-anyong" : "-anyong!";
                if (ask_who.Alive) room.HandleAcquireDetachSkills(ask_who, skill, false);
            }
            else if (damage.To.HasShownOneGeneral())
                room.AskForDiscard(ask_who, Name, 2, 2, false, false, "@anyong-discard", false, info.SkillPosition);

            return false;
        }
    }
}