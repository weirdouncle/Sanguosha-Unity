﻿using CommonClass;
using CommonClass.Game;
using CommonClassLibrary;
using SanguoshaServer.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.UI.WebControls;
using static CommonClass.Game.CardUseStruct;
using static CommonClass.Game.Player;
using static SanguoshaServer.Package.FunctionCard;

namespace SanguoshaServer.Package
{
    public class Naturefour : GeneralPackage
    {
        public Naturefour() : base("Naturefour")
        {
            skills = new List<Skill>
            {
                new LuanjiJX(),
                new Xueyi(),
                new XueyiMax(),
                new WeimuJX(),
                new WeimuJXPro(),
                new LuanwuJX(),
                new LeijiJX(),
                new Huangtian(),
                new HuangtianVS(),
                new Jiuchi(),
                new JiuchiInvalid(),
                new JiuchiTar(),
                new Roulin(),
                new Baonue(),
                new DuanchangJX(),
                new Guhuo(),
                new Canyuan(),
                new CanyuanInvalid(),
                new ShuangxiongJX(),
                new ShuangxiongJXGet(),
                new ShuangxiongJXVH(),
                new Huashen(),
                new Xinsheng(),
                new BeigeJX(),
                new JianchuJX(),
                new JianchuTar(),

                new FangquanJX(),
                new FangquanMax(),
                new LiegongJX(),
                //new LiegongRecord(),
                new LiegongTar(),
                new KuangguJX(),
                new Qimou(),
                new QimouTar(),
                new QimouDistance(),
                new Ruoyu(),
                new Zhiji(),
                new LierenJX(),
                new ZaiqiJX(),
                new TiaoxinJX(),
                new HuojiJX(),
                new HuojiJxEffect(),
                new BazhenJx(),
                new BazhenJxVH(),
                new KanpoJX(),
                new Cangzhuo(),
                new CangzhuoMax(),
                new LianhuanJX(),
                new LianhuanMax(),
                new NiepanJX(),

                new Songwei(),
                new DuanliangJX(),
                new DuanliangJXTargetMod(),
                new Jiezhi(),
                new JushouJX(),
                new Jiewei(),
                new JiemingJX(),
                new TuntianJX(),
                new TuntianJXDistance(),
                new Zaoxian(),
                new QiangxiJX(),
                new Ninger(),
                new ShensuJX(),
                new Shebian(),
                new QiaobianJX(),

                new BuquJX(),
                new BuquJXClear(),
                new BuquMax(),
                new FenjiJX(),
                new TianxiangJX(),
                new TianxiangSecond(),
                new HongyanJX(),
                new JiangJX(),
                new JiangClear(),
                new Hunzi(),
                new Zhiba(),
                new ZhibaVS(),
                new PoluSJ(),
                new ZhijianJX(),
                new GuzhengJx(),
                new Hanzhan(),
                new HaoshiClassic(),
                new HaoshiCGive(),
                new DimengClassic(),
                new DimengClassicEffect(),
            };
            skill_cards = new List<FunctionCard>
            {
                new QimouCard(),
                new HuangtianCard(),
                new ZhibaCard(),
                new GuhuoCard(),
                new TiaoxinJXCard(),
                new ShensuJXCard(),
                new HaoshiCCard(),
                new DimengCCard(),
                new JieweiCard(),
                new LuanwuJXCard(),
                new ZhijianJxCard(),
            };
            related_skills = new Dictionary<string, List<string>>
            {
                { "xueyi", new List<string>{ "#xueyi-max" } },
                { "qimou", new List<string>{ "#qimou-tar", "#qimou-distance" } },
                { "duanliang_jx", new List<string>{ "#jxduanliang-target" } },
                { "buqu_jx", new List<string>{ "#buqu_jx-clear", "#buqu-max" } },
                { "tianxiang_jx", new List<string>{ "#tianxian-second" } },
                { "jiuchi", new List<string>{ "#jiuchi-invalid", "#jiuchi-tar" } },
                { "tuntian_jx", new List<string>{ "#tuntian_jx" } },
                { "fangquan_jx", new List<string>{ "#fangquan-max" } },
                { "cangzhuo", new List<string>{ "#cangzhuo-max" } },
                { "lianhuan_jx", new List<string>{ "#lianhuan_jx" } },
                { "jianchu_jx", new List<string>{ "#jianchu-tar" } },
                { "haoshi_classic", new List<string>{ "#haoshi_classic" } },
                { "dimeng_classic", new List<string>{ "#dimeng_classic" } },
                { "weimu_jx", new List<string>{ "#weimu_jx" } },
                { "jiang_jx", new List<string>{ "#jiang-clear" } },
                { "liegong_jx", new List<string>{ "#liegong-tar" } },
                { "canyuan", new List<string>{ "#canyuan" } },
                { "shuangxiong_jx", new List<string>{ "#shuangxiong_jx-get", "#shuangxiong-vs" } },
                { "huoji_jx", new List<string>{ "#huoji_jx" } },
                { "bazhen_jx", new List<string>{ "#bazhen_jx_vh" } },
            };
        }
    }
    //袁绍
    public class LuanjiJX : TriggerSkill
    {
        public LuanjiJX() : base("luanji_jx")
        {
            events.Add(TriggerEvent.TargetChosen);
            frequency = Frequency.Limited;
            skill_type = SkillType.Alter;
            view_as_skill = new LuanjiJXVS();
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && use.To.Count > 0 && use.Card.Name == ArcheryAttack.ClassName && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                room.SetTag(Name, data);
                Player target = room.AskForPlayerChosen(ask_who, new List<Player>(use.To), Name, "@luanjijx", true, true, info.SkillPosition);
                room.RemoveTag(Name);
                if (target != null)
                {
                    room.SetTag(Name, target);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = (Player)room.GetTag(Name);
            room.RemoveTag(Name);
            if (data is CardUseStruct use)
            {
                for (int i = 0; i < use.EffectCount.Count; i++)
                {
                    CardBasicEffect effect = use.EffectCount[i];
                    if (effect.To == target)
                    {
                        effect.Nullified = true;
                        use.EffectCount[i] = effect;
                    }
                }

                data = use;
            }

            return false;
        }
    }


    public class LuanjiJXVS : ViewAsSkill
    {
        public LuanjiJXVS() : base("luanji_jx")
        {
            response_or_use = true;
            skill_type = SkillType.Alter;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return true;
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (selected.Count > 1 || room.GetCardPlace(to_select.Id) == Player.Place.PlaceEquip) return false;
            if (selected.Count == 1)
                return selected[0].Suit == to_select.Suit;

            return true;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count < 2) return null;
            WrappedCard aa = new WrappedCard(ArcheryAttack.ClassName) { Skill = Name };
            aa.AddSubCards(cards);
            return aa;
        }
    }

    public class Xueyi : TriggerSkill
    {
        public Xueyi() : base("xueyi")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.EventPhaseStart };
            frequency = Frequency.Compulsory;
            lord_skill = true;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Play && base.Triggerable(player, room) && player.GetMark("@xueyi") > 0)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.GameStart)
            {
                room.SendCompulsoryTriggerLog(player, Name, true);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                return info;
            }
            else
            {
                if (room.AskForSkillInvoke(player, Name, "@xueyi-draw", info.SkillPosition))
                {
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                    room.AddPlayerMark(player, "@xueyi", -1);
                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                room.DrawCards(player, 1, Name);
            }
            else
            {
                int count = 0;
                foreach (Player p in room.GetAlivePlayers())
                    if (p.Kingdom == "qun") count++;

                room.AddPlayerMark(player, "@xueyi", count * 2);
            }
            return false;
        }
    }
    public class XueyiMax : MaxCardsSkill
    {
        public XueyiMax() : base("#xueyi-max")
        {
        }

        public override int GetExtra(Room room, Player target)
        {
            if (RoomLogic.PlayerHasShownSkill(room, target, "xueyi"))
                return target.GetMark("@xueyi");

            return 0;
        }
    }

    public class WeimuJX : TriggerSkill
    {
        public WeimuJX() : base("weimu_jx")
        {
            events.Add(TriggerEvent.DamageInflicted);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Defense;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase != PlayerPhase.NotActive)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            LogMessage log = new LogMessage
            {
                Type = "#damaged-prevent",
                From = player.Name,
                Arg = Name
            };
            room.SendLog(log);

            if (data is DamageStruct damage && damage.Damage > 0)
                room.DrawCards(player, damage.Damage * 2, Name);

            return true;
        }
    }

    public class WeimuJXPro : ProhibitSkill
    {
        public WeimuJXPro() : base("#weimu_jx")
        {
            frequency = Frequency.Compulsory;
        }

        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if (card != null && to != null && RoomLogic.PlayerHasShownSkill(room, to, "weimu_jx"))
            {
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                return fcard is TrickCard && WrappedCard.IsBlack(RoomLogic.GetCardSuit(room, card));
            }

            return false;
        }
    }

    public class LuanwuJXCard : SkillCard
    {
        public static string ClassName = "LuanwuJXCard";
        public LuanwuJXCard() : base("LuanwuJXCard")
        {
            target_fixed = true;
        }
        public override void OnUse(Room room, CardUseStruct card_use)
        {
            room.SetPlayerMark(card_use.From, "@chaos", 0);
            room.BroadcastSkillInvoke("luanwu", card_use.From, card_use.Card.SkillPosition);
            room.DoSuperLightbox(card_use.From, card_use.Card.SkillPosition, "luanwu");
            card_use.To = room.GetOtherPlayers(card_use.From);
            room.SortByActionOrder(ref card_use);
            base.OnUse(room, card_use);
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            base.Use(room, card_use);
            if (card_use.From.Alive)
            {
                WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_luanwu_jx", DistanceLimited = false };
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetOtherPlayers(card_use.From))
                    if (RoomLogic.IsProhibited(room, card_use.From, p, slash) == null)
                        targets.Add(p);

                if (targets.Count > 0)
                {
                    Player target = room.AskForPlayerChosen(card_use.From, targets, "luanwu_jx", "@luanwu-victim", true, true, card_use.Card.SkillPosition);
                    if (target != null)
                        room.UseCard(new CardUseStruct(slash, card_use.From, target), false, true);
                }
            }
        }

        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            List<Player> players = room.GetOtherPlayers(effect.To);
            List<int> distance_list = new List<int>();
            int nearest = 1000;
            foreach (Player player in players)
            {
                int distance = RoomLogic.DistanceTo(room, effect.To, player);
                distance_list.Add(distance);
                if (distance != -1)
                    nearest = Math.Min(nearest, distance);
            }

            List<Player> luanwu_targets = new List<Player>();
            for (int i = 0; i < distance_list.Count; i++)
            {
                if (distance_list[i] == nearest && RoomLogic.CanSlash(room, effect.To, players[i]))
                    luanwu_targets.Add(players[i]);
            }

            if (luanwu_targets.Count == 0 || room.AskForUseSlashTo(effect.To, luanwu_targets, "@luanwu-slash", null) == null)
            {
                room.LoseHp(effect.To);
                Thread.Sleep(500);
            }
        }
    }
    public class LuanwuJX : ZeroCardViewAsSkill
    {
        public LuanwuJX() : base("luanwu_jx")
        {
            frequency = Frequency.Limited;
            limit_mark = "@chaos";
            skill_type = SkillType.Wizzard;
        }
        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard card = new WrappedCard(LuanwuJXCard.ClassName)
            {
                ShowSkill = Name,
                Skill = Name,
                Mute = true
            };
            return card;
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => player.GetMark("@chaos") >= 1;
    }

    public class LeijiJX : TriggerSkill
    {
        public LeijiJX() : base("leiji_jx")
        {
            events.Add(TriggerEvent.CardResponded);
            skill_type = SkillType.Attack;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardResponded && base.Triggerable(player, room) && data is CardResponseStruct resp)
            {
                WrappedCard card_star = resp.Card;
                if (card_star.Name == Jink.ClassName)
                    skill_list.Add(new TriggerStruct(Name, player));
            }

            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetAlivePlayers(), Name, "@leiji-invoke", true, true, info.SkillPosition);
            if (target != null)
            {
                room.SetTag(Name, target);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player zhangjiao, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is Player target)
            {
                room.RemoveTag(Name);
                JudgeStruct judge = new JudgeStruct
                {
                    Pattern = ".|black",
                    Good = true,
                    Negative = true,
                    Reason = Name,
                    Who = target,
                    PlayAnimation = true
                };

                room.Judge(ref judge);

                if (!judge.IsGood())
                {
                    if (judge.JudgeSuit == WrappedCard.CardSuit.Spade)
                    {
                        if (target.Alive)
                            room.Damage(new DamageStruct(Name, zhangjiao, target, 2, DamageStruct.DamageNature.Thunder));
                    }
                    else
                    {
                        if (zhangjiao.Alive && zhangjiao.GetLostHp() > 0)
                        {
                            RecoverStruct recover = new RecoverStruct
                            {
                                Recover = 1,
                                Who = zhangjiao
                            };
                            room.Recover(zhangjiao, recover, true);
                        }
                        if (target.Alive)
                            room.Damage(new DamageStruct(Name, zhangjiao, target, 1, DamageStruct.DamageNature.Thunder));
                    }
                }
            }

            return false;
        }
    }

    public class Huangtian : TriggerSkill
    {
        public Huangtian() : base("huangtian")
        {
            lord_skill = true;
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.EventAcquireSkill, TriggerEvent.Revived };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Revived)
            {
                Player lord = RoomLogic.FindPlayerBySkillName(room, Name);
                if (lord == player)
                {
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.Kingdom == "qun" || p.General1 == "zuoci")
                            room.HandleAcquireDetachSkills(p, "huangtianvs", true, false);
                    }
                }
                else if (player.Kingdom == "qun" || player.General1 == "zuoci")
                {
                    room.HandleAcquireDetachSkills(player, "huangtianvs", true, false);
                }
                return;
            }

            bool add = false;
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                add = true;
            else if (triggerEvent == TriggerEvent.EventAcquireSkill && data is InfoStruct info && info.Info == Name)
                add = true;

            if (add)
            {
                if (!room.Skills.Contains("huangtianvs"))
                    room.Skills.Add("huangtianvs");
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.Kingdom == "qun" || p.General1 == "zuoci")
                        room.HandleAcquireDetachSkills(p, "huangtianvs", true, false);
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return new TriggerStruct();
        }
    }

    public class HuangtianVS : OneCardViewAsSkill
    {
        public HuangtianVS() : base("huangtianvs")
        {
            attached_lord_skill = true;
            frequency = Frequency.Compulsory;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            List<Player> jiaozhu = RoomLogic.FindPlayersBySkillName(room, "huangtian");
            return jiaozhu.Count > 0 && player.Kingdom == "qun" && !player.HasUsed(HuangtianCard.ClassName);
        }

        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            return to_select.Name == Jink.ClassName || (room.GetCardPlace(to_select.Id) == Place.PlaceHand && to_select.Suit == WrappedCard.CardSuit.Spade);
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard ht = new WrappedCard(HuangtianCard.ClassName);
            ht.AddSubCard(card);
            return ht;
        }
    }

    public class HuangtianCard : SkillCard
    {
        public static string ClassName = "HuangtianCard";
        public HuangtianCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            List<Player> jiaozhu = RoomLogic.FindPlayersBySkillName(room, "huangtian");
            if (jiaozhu.Count < 2) return false;

            return targets.Count == 0 && jiaozhu.Contains(to_select);
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            List<Player> jiaozhu = RoomLogic.FindPlayersBySkillName(room, "huangtian");
            return (jiaozhu.Count == 1 && targets.Count == 0) || (targets.Count == 1 && jiaozhu.Contains(targets[0]));
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            List<Player> jiaozhu = RoomLogic.FindPlayersBySkillName(room, "huangtian");
            Player target = null, player = card_use.From;
            if (jiaozhu.Count == 1 && card_use.To.Count == 0)
                target = jiaozhu[0];
            else if (card_use.To.Count == 1 && jiaozhu.Contains(card_use.To[0]))
                target = card_use.To[0];

            room.BroadcastSkillInvoke("huangtian", target);
            room.NotifySkillInvoked(target, "huangtian");
            room.ObtainCard(target, card_use.Card, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "huangtian", string.Empty));

            ResultStruct result = card_use.From.Result;
            result.Assist++;
            card_use.From.Result = result;
        }
    }

    public class Jiuchi : TriggerSkill
    {
        public Jiuchi() : base("jiuchi")
        {
            events.Add(TriggerEvent.DamageComplete);
            skill_type = SkillType.Alter;
            view_as_skill = new JiuchiVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is DamageStruct damage && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName) && damage.Drank && base.Triggerable(damage.From, room)
                && room.Current == damage.From && !damage.From.HasFlag(Name) && damage.Damage > 0)
            {
                damage.From.SetFlags(Name);

                LogMessage log = new LogMessage
                {
                    Type = "#jiuchi",
                    From = damage.From.Name
                };
                room.SendLog(log);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class JiuchiInvalid : InvalidSkill
    {
        public JiuchiInvalid() : base("#jiuchi-invalid") { }

        public override bool Invalid(Room room, Player player, string skill)
        {
            if (player.HasFlag("jiuchi") && skill == "benghuai")
                return true;

            return false;
        }
    }

    public class JiuchiVS : OneCardViewAsSkill
    {
        public JiuchiVS() : base("jiuchi")
        {
            response_or_use = true;
        }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            return to_select.Suit == WrappedCard.CardSuit.Spade && room.GetCardPlace(to_select.Id) != Place.PlaceEquip
                && !RoomLogic.IsCardLimited(room, player, to_select, HandlingMethod.MethodUse);
        }
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern) =>
            MatchAnaleptic(respond) && room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE;
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard dismantlement = new WrappedCard(Analeptic.ClassName);
            dismantlement.AddSubCard(card);
            dismantlement.Skill = Name;
            dismantlement.ShowSkill = Name;
            dismantlement = RoomLogic.ParseUseCard(room, dismantlement);
            return dismantlement;
        }
    }

    public class JiuchiTar : TargetModSkill
    {
        public JiuchiTar() : base("#jiuchi-tar", true)
        {
            pattern = Analeptic.ClassName;
        }

        public override bool CheckSpecificAssignee(Room room, Player from, Player to, WrappedCard card, string pattern)
        {
            return from == to && RoomLogic.PlayerHasSkill(room, from, "jiuchi");
        }
    }

    public class Roulin : TriggerSkill
    {
        public Roulin() : base("roulin")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.TargetConfirmed };
            skill_type = SkillType.Wizzard;
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            CardUseStruct use = (CardUseStruct)data;
            if (triggerEvent == TriggerEvent.TargetChosen && use.Card != null && use.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room))
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in use.To)
                    if (p.IsFemale()) targets.Add(p);
                if (targets.Count > 0)
                    return new TriggerStruct(Name, player, targets);

            }
            else if (triggerEvent == TriggerEvent.TargetConfirmed && use.Card != null && use.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room)
                && use.From.Alive && use.From.IsFemale())
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);

            CardUseStruct use = (CardUseStruct)data;
            if (triggerEvent == TriggerEvent.TargetChosen)
            {
                int index = 0;
                for (int i = 0; i < use.EffectCount.Count; i++)
                {
                    CardBasicEffect effect = use.EffectCount[i];
                    if (effect.To == target)
                    {
                        index++;
                        if (index == info.Times)
                        {
                            if (effect.Effect2 == 1)
                                effect.Effect2 = 2;
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < use.EffectCount.Count; i++)
                {
                    CardBasicEffect effect = use.EffectCount[i];
                    if (effect.To == ask_who && !effect.Triggered)
                    {
                        if (effect.Effect2 == 1)
                            effect.Effect2 = 2;
                        break;
                    }
                }
            }

            data = use;

            return false;
        }
    }

    public class Baonue : TriggerSkill
    {
        public Baonue() : base("baonue")
        {
            events.Add(TriggerEvent.DamageComplete);
            lord_skill = true;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            Player dongzhuo = RoomLogic.FindPlayerBySkillName(room, Name);
            if (dongzhuo != null && data is DamageStruct damage && damage.From != null && damage.From.Alive && !damage.Prevented
                && damage.From.Kingdom == "qun" && damage.From != dongzhuo && damage.Damage > 0)
            {
                TriggerStruct trigger = new TriggerStruct(Name, damage.From)
                {
                    Times = damage.Damage
                };
                return trigger;
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player dongzhuo = RoomLogic.FindPlayerBySkillName(room, Name);
            if (room.AskForSkillInvoke(ask_who, Name, dongzhuo))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, dongzhuo.Name);
                room.NotifySkillInvoked(dongzhuo, Name);
                room.BroadcastSkillInvoke(Name, player);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player dongzhuo = RoomLogic.FindPlayerBySkillName(room, Name);
            JudgeStruct judge = new JudgeStruct
            {
                Who = dongzhuo,
                Pattern = ".|spade",
                Good = true,
                PlayAnimation = true,
                Reason = Name,
                Negative = false
            };

            room.Judge(ref judge);
            if (judge.IsGood() && dongzhuo.Alive)
            {
                if (dongzhuo.IsWounded())
                {
                    RecoverStruct recover = new RecoverStruct
                    {
                        Who = ask_who,
                        Recover = 1
                    };
                    room.Recover(dongzhuo, recover, true);
                }

                if (dongzhuo.Alive && room.GetCardOwner(judge.Card.Id) == null && room.GetCardPlace(judge.Card.Id) == Place.DiscardPile)
                    room.ObtainCard(dongzhuo, judge.Card);
            }

            return false;
        }
    }

    public class DuanchangJX : TriggerSkill
    {
        public DuanchangJX() : base("duanchang_jx")
        {
            events.Add(TriggerEvent.Death);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Wizzard;
        }
        public override bool CanPreShow() => false;
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player != null && RoomLogic.PlayerHasSkill(room, player, Name) && data is DeathStruct death && death.Damage.From != null)
            {


                Player target = death.Damage.From;
                if (!target.General1.Contains("sujiang"))
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            return info;
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            DeathStruct death = (DeathStruct)data;
            Player target = death.Damage.From;

            room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);

            List<string> skills = target.GetSkills(true, false);
            foreach (string skill in skills)
            {
                Skill _s = Engine.GetSkill(skill);
                if (_s != null && !_s.Attached_lord_skill)
                    room.DetachSkillFromPlayer(target, skill, false, player.GetAcquiredSkills().Contains(skill), true);
            }

            if (death.Damage.From.Alive)
            {
                target.DuanChang = "head";
                room.BroadcastProperty(target, "DuanChang");
                room.SetPlayerMark(target, "@duanchang", 1);
            }

            return false;
        }
    }

    public class Guhuo : ViewAsSkill
    {
        public Guhuo() : base("guhuo")
        {
            response_or_use = true;
            skill_type = SkillType.Wizzard;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasFlag(Name);
        }

        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
        {
            return !player.HasFlag(Name) && (MatchBasic(respond) || MatchNTTrick(respond));
        }

        public override bool IsEnabledAtNullification(Room room, Player player)
        {
            return !player.HasFlag(Name) && (!player.IsKongcheng() || player.GetHandPile().Count > 0);
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> all_cards = new List<WrappedCard>();
            if (cards.Count == 1)
            {
                string pattern = room.GetRoomState().GetCurrentCardUsePattern(player);
                List<string> names = GetGuhuoCards(room, "bt");
                foreach (string name in names)
                {
                    WrappedCard card = new WrappedCard(name);
                    card.AddSubCard(cards[0]);
                    card = RoomLogic.ParseUseCard(room, card);
                    if (string.IsNullOrEmpty(pattern) || Engine.MatchExpPattern(room, pattern, player, card))
                    {
                        WrappedCard new_card = new WrappedCard(name);
                        new_card.AddSubCard(cards[0]);
                        all_cards.Add(new_card);
                    }
                }
            }

            return all_cards;
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            HandlingMethod method = HandlingMethod.MethodUse;
            if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE)
                method = HandlingMethod.MethodResponse;
            return selected.Count == 0 && room.GetCardPlace(to_select.Id) != Place.PlaceEquip && !RoomLogic.IsCardLimited(room, player, to_select, method);
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
            {
                WrappedCard gh = new WrappedCard(GuhuoCard.ClassName) { Skill = Name, UserString = cards[0].Name };
                gh.AddSubCard(cards[0].GetEffectiveId());
                return gh;
            }

            return null;
        }
    }

    public class GuhuoCard : SkillCard
    {
        public static string ClassName = "GuhuoCard";
        public GuhuoCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            WrappedCard real = new WrappedCard(card.UserString);
            real.AddSubCard(card);
            real = RoomLogic.ParseUseCard(room, real);
            FunctionCard fcard = Engine.GetFunctionCard(real.Name);
            return fcard.TargetFilter(room, targets, to_select, Self, real);
        }
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            WrappedCard real = new WrappedCard(card.UserString);
            real.AddSubCard(card);
            real = RoomLogic.ParseUseCard(room, real);
            FunctionCard fcard = Engine.GetFunctionCard(real.Name);
            return fcard.TargetsFeasible(room, targets, Self, real);
        }

        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            Player player = use.From;
            room.NotifySkillInvoked(player, "guhuo");
            room.BroadcastSkillInvoke("guhuo", player, use.Card.SkillPosition);
            player.SetFlags("guhuo");

            LogMessage log = new LogMessage
            {
                Type = "#guhuo",
                From = player.Name,
                Arg = "guhuo",
                Arg2 = use.Card.UserString
            };
            room.SendLog(log);

            WrappedCard guhuo = new WrappedCard(use.Card.UserString);

            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_ANNOUNCE, player.Name, null, "guhuo", null)
            {
                Card = guhuo,
                General = RoomLogic.GetGeneralSkin(room, player, "guhuo", use.Card.SkillPosition)
            };
            if (use.To.Count == 1)
                reason.TargetId = use.To[0].Name;
            CardsMoveStruct move = new CardsMoveStruct(use.Card.GetEffectiveId(), null, Place.PlaceTable, reason);
            room.MoveCardsAtomic(new List<CardsMoveStruct> { move }, false);

            WrappedCard real = room.GetCard(use.Card.GetEffectiveId());
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (!RoomLogic.PlayerHasSkill(room, p, "canyuan"))
                {
                    player.SetTag("guhuo", use.Card.UserString);
                    string choice = room.AskForChoice(p, "guhuo", "doubt+cancel", new List<string> { string.Format("@guhuo:{0}::{1}", player.Name, use.Card.UserString) }, player);
                    player.RemoveTag("guhuo");
                    if (choice == "doubt")
                    {
                        log = new LogMessage
                        {
                            Type = "#guhuo-doubt",
                            From = p.Name
                        };
                        room.SendLog(log);

                        CardsMoveStruct _move = new CardsMoveStruct(use.Card.GetEffectiveId(), null, player, Place.DrawPile,
                            Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_DEMONSTRATE, player.Name, "guhuo", string.Empty));
                        room.NotifyMoveCards(true, new List<CardsMoveStruct> { _move }, true);
                        room.NotifyMoveCards(false, new List<CardsMoveStruct> { _move }, true);

                        if (real.Name != use.Card.UserString)
                        {
                            LogMessage log1 = new LogMessage
                            {
                                Type = "#guhuo-false",
                                From = p.Name
                            };
                            room.SendLog(log1);

                            List<int> table_cardids = room.GetCardIdsOnTable(use.Card);
                            reason = new CardMoveReason(MoveReason.S_REASON_DEMONSTRATE, player.Name, "guhuo", string.Empty);
                            if (table_cardids.Count > 0)
                            {
                                CardsMoveStruct move1 = new CardsMoveStruct(table_cardids, player, null, Place.PlaceTable, Place.DiscardPile, reason);
                                room.MoveCardsAtomic(new List<CardsMoveStruct> { move1 }, true);
                            }

                            return null;
                        }
                        else
                        {
                            LogMessage log1 = new LogMessage
                            {
                                Type = "#guhuo-true",
                                From = p.Name
                            };
                            room.SendLog(log1);

                            room.HandleAcquireDetachSkills(p, "canyuan", true);
                        }

                        break;
                    }
                    else
                    {
                        log = new LogMessage
                        {
                            Type = "#guhuo-undoubt",
                            From = p.Name
                        };
                        room.SendLog(log);
                    }
                }
            }
            guhuo.Skill = "_guhuo";
            guhuo.AddSubCard(use.Card);
            guhuo = RoomLogic.ParseUseCard(room, guhuo);

            CardMoveReasonStruct virtual_reason = new CardMoveReasonStruct
            {
                PlayerId = player.Name,
                TargetId = string.Empty,
                SkillName = "_guhuo",
                EventName = string.Empty,
                Reason = MoveReason.S_REASON_USE,
                CardString = RoomLogic.CardToString(room, guhuo),
                General = RoomLogic.GetGeneralSkin(room, player, "guhuo", use.Card.SkillPosition)
            };
            ClientCardsMoveStruct virtual_move = new ClientCardsMoveStruct(use.Card.GetEffectiveId(), null, Place.PlaceTable, virtual_reason)
            {
                From_place = Place.PlaceUnknown,
                From = player.Name,
                Is_last_handcard = false,
            };
            room.NotifyUsingVirtualCard(RoomLogic.CardToString(room, guhuo), virtual_move);

            return guhuo;
        }

        public override WrappedCard ValidateInResponse(Room room, Player player, WrappedCard card)
        {
            room.NotifySkillInvoked(player, "guhuo");
            room.BroadcastSkillInvoke("guhuo", player, card.SkillPosition);
            player.SetFlags("guhuo");

            LogMessage log = new LogMessage
            {
                Type = "#guhuo",
                From = player.Name,
                Arg = "guhuo",
                Arg2 = card.UserString
            };
            room.SendLog(log);

            WrappedCard guhuo = new WrappedCard(card.UserString);

            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_ANNOUNCE, player.Name, null, "guhuo", null)
            {
                Card = guhuo,
                General = RoomLogic.GetGeneralSkin(room, player, "guhuo", card.SkillPosition)
            };

            CardsMoveStruct move = new CardsMoveStruct(card.GetEffectiveId(), null, Place.PlaceTable, reason);
            room.MoveCardsAtomic(new List<CardsMoveStruct> { move }, false);

            WrappedCard real = room.GetCard(card.GetEffectiveId());
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (!RoomLogic.PlayerHasSkill(room, p, "canyuan"))
                {
                    player.SetTag("guhuo", card.UserString);
                    string choice = room.AskForChoice(p, "guhuo", "doubt+cancel", new List<string> { string.Format("@guhuo:{0}::{1}", player.Name, card.UserString) }, player);
                    player.RemoveTag("guhuo");
                    if (choice ==  "doubt")
                    {
                        log = new LogMessage
                        {
                            Type = "#guhuo-doubt",
                            From = p.Name
                        };
                        room.SendLog(log);

                        CardsMoveStruct _move = new CardsMoveStruct(card.GetEffectiveId(), null, player, Place.DrawPile,
                            Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_DEMONSTRATE, player.Name, "guhuo", string.Empty));
                        room.NotifyMoveCards(true, new List<CardsMoveStruct> { _move }, true);
                        room.NotifyMoveCards(false, new List<CardsMoveStruct> { _move }, true);

                        if (real.Name != card.UserString)
                        {
                            LogMessage log1 = new LogMessage
                            {
                                Type = "#guhuo-false",
                                From = p.Name
                            };
                            room.SendLog(log1);

                            List<int> table_cardids = room.GetCardIdsOnTable(card);
                            reason = new CardMoveReason(MoveReason.S_REASON_NATURAL_ENTER, player.Name, "guhuo", string.Empty);
                            if (table_cardids.Count > 0)
                            {
                                CardsMoveStruct move1 = new CardsMoveStruct(table_cardids, player, null, Place.PlaceTable, Place.DiscardPile, reason);
                                room.MoveCardsAtomic(new List<CardsMoveStruct> { move1 }, true);
                            }

                            return null;
                        }
                        else
                        {
                            LogMessage log1 = new LogMessage
                            {
                                Type = "#guhuo-true",
                                From = p.Name
                            };
                            room.SendLog(log1);

                            room.HandleAcquireDetachSkills(p, "canyuan", true);
                        }

                        break;
                    }
                    else
                    {
                        log = new LogMessage
                        {
                            Type = "#guhuo-undoubt",
                            From = p.Name
                        };
                        room.SendLog(log);
                    }
                }
            }

            guhuo.Skill = "_guhuo";
            guhuo.AddSubCard(card);
            guhuo = RoomLogic.ParseUseCard(room, guhuo);

            CardMoveReasonStruct virtul_reason = new CardMoveReasonStruct
            {
                Reason = MoveReason.S_REASON_RESPONSE,
                PlayerId = player.Name,
                TargetId = null,
                SkillName = "_guhuo",
                EventName = null,
                CardString = RoomLogic.CardToString(room, guhuo),
                General = RoomLogic.GetGeneralSkin(room, player, "guhuo", card.SkillPosition)
            };
            if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE)
                reason.Reason = MoveReason.S_REASON_LETUSE;
            ClientCardsMoveStruct virtul_move = new ClientCardsMoveStruct(card.GetEffectiveId(), player, Place.PlaceTable, virtul_reason)
            {
                From_place = Place.PlaceUnknown,
                From = player.Name,
                Is_last_handcard = false,
            };
            room.NotifyUsingVirtualCard(RoomLogic.CardToString(room, guhuo), virtul_move);

            return guhuo;
        }
    }

    public class Canyuan : TriggerSkill
    {
        public Canyuan() : base("canyuan")                              //获得/失去技能时，以及体力变化后，需要刷新一遍锁定视为技
        {
            events = new List<TriggerEvent> { TriggerEvent.HpChanged, TriggerEvent.EventAcquireSkill, TriggerEvent.EventLoseSkill };
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventAcquireSkill && data is InfoStruct info && info.Info == Name && player.Hp == 1)
            {
                player.SetMark(Name, 1);
            }
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name)
            {
                player.SetMark(Name, 0);
                if (player.Hp == 1) room.FilterCards(player, player.GetCards("he"), true);
            }
            else if (triggerEvent == TriggerEvent.HpChanged && base.Triggerable(player, room))
            {
                if (player.GetMark(Name) == 0 && player.Hp == 1)
                {
                    player.SetMark(Name, 1);
                    room.FilterCards(player, player.GetCards("he"), true);
                }
                else if (player.Hp != 1 && player.GetMark(Name) > 0)
                {
                    player.SetMark(Name, 0);
                    room.FilterCards(player, player.GetCards("he"), true);
                }
            }
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class CanyuanInvalid : InvalidSkill
    {
        public CanyuanInvalid() : base("#canyuan")
        {
        }

        public override bool Invalid(Room room, Player player, string skill)
        {
            Skill s = Engine.GetSkill(skill);
            if (s == null || s.Attached_lord_skill || player.Hp != 1 || skill == "canyuan") return false;
            if (player.HasEquip(skill)) return false;
            if (player.GetAcquiredSkills().Contains("canyuan")) return true;
            return false;
        }
    }

    public class ShuangxiongVS : OneCardViewAsSkill
    {
        public ShuangxiongVS() : base("shuangxiong_jx")
        {
            response_or_use = true;
        }
        public override bool IsAvailable(Room room, Player player, CardUseReason reason, RespondType respond, string pattern, string position = null)
        {
            return reason == CardUseReason.CARD_USE_REASON_PLAY && player.HasFlag("shuangxiong_jx_" + position) && player.GetMark("shuangxiong_jx") != 0;
        }
        public override bool ViewFilter(Room room, WrappedCard card, Player player)
        {
            if (player.HasEquip(card.Name))
                return false;

            int value = player.GetMark(Name);
            if (value == 1)
                return WrappedCard.IsBlack(card.Suit);
            else if (value == 2)
                return WrappedCard.IsRed(card.Suit);

            return false;
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard duel = new WrappedCard(Duel.ClassName);
            duel.AddSubCard(card);
            duel.Skill = Name;
            duel.ShowSkill = Name;
            duel = RoomLogic.ParseUseCard(room, duel);
            return duel;
        }
    }
    public class ShuangxiongJX : TriggerSkill
    {
        public ShuangxiongJX() : base("shuangxiong_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.EventPhaseChanging, TriggerEvent.CardFinished, TriggerEvent.CardResponded };
            view_as_skill = new ShuangxiongVS();
            skill_type = SkillType.Attack;
        }
        public override bool CanPreShow() => true;

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetMark(Name) > 0)
                player.SetMark(Name, 0);
            else if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && use.Card.Name == Duel.ClassName
                && use.Card.Skill == Name && use.From.ContainsTag(RoomLogic.CardToString(room, use.Card)))
                use.From.RemoveTag(RoomLogic.CardToString(room, use.Card));
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Card.Name.Contains(Slash.ClassName) && resp.Card.SubCards.Count > 0
                && resp.Data is CardEffectStruct effect && effect.Card != null && effect.Card.Name == Duel.ClassName && effect.Card.Skill == Name && player != effect.From)
            {
                string str = RoomLogic.CardToString(room, effect.Card);
                List<int> ids = effect.From.ContainsTag(str) ? (List<int>)effect.From.GetTag(str) : new List<int>();
                ids.AddRange(resp.Card.SubCards);
                effect.From.SetTag(str, ids);
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Draw && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player shuangxiong, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(shuangxiong, Name, null, info.SkillPosition))
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, shuangxiong, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> card_ids = room.GetNCards(2);
            foreach (int id in card_ids)
            {
                room.MoveCardTo(room.GetCard(id), player, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_TURNOVER, player.Name, Name, null), false);
                Thread.Sleep(400);
            }
            AskForMoveCardsStruct result = room.AskForMoveCards(player, card_ids, new List<int>(), false, Name, 1, 1, false, true, card_ids, info.SkillPosition);
            List<int> get = new List<int>(), drop = new List<int>();
            if (result.Success)
            {
                get = result.Bottom;
                drop = result.Top;
            }
            else
            {
                get.Add(card_ids[0]);
                drop.Add(card_ids[1]);
            }

            room.SetPlayerFlag(player, "shuangxiong_jx_" + info.SkillPosition);

            room.MoveCards(new List<CardsMoveStruct>
            {
                new CardsMoveStruct(get, player, Place.PlaceHand, new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name, Name, null)) },
                true);

            player.SetMark(Name, WrappedCard.IsRed(room.GetCard(get[0]).Suit) ? 1 : 2);

            room.MoveCards(new List<CardsMoveStruct>
            {
                new CardsMoveStruct(drop, null, Place.DiscardPile, new CardMoveReason(MoveReason.S_REASON_NATURAL_ENTER, null, Name, null)) },
                true);

            return true;
        }

        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            index = 2;
        }
    }

    public class ShuangxiongJXVH : ViewHasSkill
    {
        public ShuangxiongJXVH() : base("#shuangxiong-vs") { viewhas_skills.Add("shuangxiong_jx"); }
        public override bool ViewHas(Room room, Player player, string skill_name)
        {
            if (skill_name == "shuangxiong_jx" && (player.HasFlag("shuangxiong_jx_head") || player.HasFlag("shuangxiong_jx_deputy")) && player.GetMark("shuangxiong_jx") != 0)
                return true;

            return false;
        }
    }

    public class ShuangxiongJXGet : TriggerSkill
    {
        public ShuangxiongJXGet() : base("#shuangxiong_jx-get")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged };
            frequency = Frequency.Compulsory;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct damage && damage.Card != null && damage.Card.Name == Duel.ClassName
                && damage.Card.Skill == "shuangxiong_jx" && player.ContainsTag(RoomLogic.CardToString(room, damage.Card)) && player.Alive
                && player.GetTag(RoomLogic.CardToString(room, damage.Card)) is List<int> ids && ids.Count > 0)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage && player.GetTag(RoomLogic.CardToString(room, damage.Card)) is List<int> ids)
            {
                List<int> get = new List<int>();
                foreach (int id in ids)
                {
                    if (room.GetCardPlace(id) == Place.DiscardPile)
                        get.Add(id);
                }

                if (get.Count > 0)
                    room.ObtainCard(player, ref get, new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name, Name, string.Empty));
            }

            return false;
        }
    }

    public class Huashen : TriggerSkill
    {
        public Huashen() : base("huashen")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.EventPhaseStart, TriggerEvent.EventLoseSkill, TriggerEvent.Death };
            skill_type = SkillType.Wizzard;
            priority = new Dictionary<TriggerEvent, double>
            {
                { TriggerEvent.GameStart, 3 },
                { TriggerEvent.EventPhaseStart, 3 },
                { TriggerEvent.EventLoseSkill, 3 },
                { TriggerEvent.Death, 0 },
            };
        }
        
        public static void Acquiregenerals(Room room, Player zuoci, int n)
        {
            List<string> huashens = zuoci.ContainsTag("huashen") ? (List<string>)zuoci.GetTag("huashen") : new List<string>();
            List<string> acquired = GetavailableGenerals(room, zuoci, n);

            if (acquired.Count == 0) return;

            foreach (string general in acquired)
                room.HandleUsedGeneral(general);

            huashens.AddRange(acquired);
            zuoci.SetTag("huashen", huashens);

            foreach (string general in huashens)
            {
                foreach (string skill in Engine.GetGeneralSkills(general, room.Setting.GameMode))
                {
                    room.AddSkill2Game(skill);
                }

                foreach (string skill in Engine.GetGeneralRelatedSkills(general, room.Setting.GameMode))
                {
                    room.AddSkill2Game(skill);
                }
            }

            List<Player> others = new List<Player>();
            List<Client> clients = new List<Client>();
            foreach (Player p in room.GetOtherPlayers(zuoci))
            {
                Client c = room.GetClient(p);
                if (c != room.GetClient(zuoci) && !clients.Contains(c))
                {
                    others.Add(p);
                    clients.Add(c);
                }
            }
            LogMessage log = new LogMessage
            {
                Type = "#gethuashendetail",
                From = zuoci.Name,
                Arg = "huashen",
                Arg2 = string.Join("\\, \\", acquired),
            };

            LogMessage log1 = new LogMessage
            {
                Type = "#gethuashen",
                From = zuoci.Name,
                Arg = "huashen",
                Arg2 = acquired.Count.ToString()
            };

            room.SendLog(log, zuoci);
            room.SendLog(log1, new List<Player> { zuoci });

            List<string> unkonwns = new List<string>();
            for (int i = 0; i < acquired.Count; i++)
                unkonwns.Add("-1");

            room.DoAnimate(AnimateType.S_ANIMATE_HUASHEN, string.Join("+", acquired), string.Format("null+{0}+huashen", zuoci.Name), new List<Player> { zuoci });
            room.DoAnimate(AnimateType.S_ANIMATE_HUASHEN, string.Join("+", unkonwns), string.Format("null+{0}", zuoci.Name), others);
            Thread.Sleep(1500);
            room.SetPlayerStringMark(zuoci, "huashen", huashens.Count.ToString(), room.GetClient(zuoci));
        }

        public static void RemoveHuashen(Room room, Player zuoci, List<string> generals)
        {
            List<string> huashens = zuoci.ContainsTag("huashen") ? (List<string>)zuoci.GetTag("huashen") : new List<string>();
            List<string> remove = new List<string>();
            foreach (string name in generals)
            {
                if (huashens.Contains(name))
                {
                    remove.Add(name);
                    room.HandleUsedGeneral("-" + name);
                }
            }
            if (remove.Count == 0) return;

            huashens.RemoveAll(t => remove.Contains(t));
            zuoci.SetTag("huashen", huashens);

            LogMessage log = new LogMessage
            {
                Type = "#drophuashendetail",
                From = zuoci.Name,
                Arg = "huashen",
                Arg2 = string.Join("\\, \\", remove)
            };
            room.SendLog(log);

            room.DoAnimate(AnimateType.S_ANIMATE_HUASHEN, string.Join("+", remove), string.Format("{0}+null+huashen", zuoci.Name));
            Thread.Sleep(1500);
            if (huashens.Count == 0)
                room.RemovePlayerStringMark(zuoci, "huashen");
            else
                room.SetPlayerStringMark(zuoci, "huashen", huashens.Count.ToString(), room.GetClient(zuoci));
        }

        public static List<string> GetavailableGenerals(Room room, Player zuoci, int n)
        {
            List<string> available = new List<string>(), ban = Engine.GetHuashenBanList();
            foreach (string name in room.Generals)
            {
                General general = Engine.GetGeneral(name, room.Setting.GameMode);
                if (general.Kingdom.Contains(General.KingdomENUM.TobeDicede)) continue;
                if (!room.UsedGeneral.Contains(name) && !ban.Contains(name))
                {
                    available.Add(name);
                    foreach (General g in Engine.GetConverPairs(name, room.Setting.GameMode))
                    {
                        if (!room.UsedGeneral.Contains(g.Name) && !ban.Contains(g.Name) && !available.Contains(g.Name))
                            available.Add(g.Name);
                    }
                }
            }
            List<string> result = new List<string>();
            Shuffle.shuffle(ref available);
            for (int i = 0; i < Math.Min(available.Count, n); i++)
                result.Add(available[i]);

            return result;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player zuoci, ref object data)
        {
            bool remove = false;
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(zuoci, room))
                Acquiregenerals(room, zuoci, 3);
            else if (triggerEvent == TriggerEvent.Death && zuoci.GetSkills(true, false).Contains(Name))
            {
                remove = true;
            }
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name)
            {
                remove = true;
            }

            if (remove)
            {
                List<string> huashens = zuoci.ContainsTag("huashen") ? (List<string>)zuoci.GetTag("huashen") : new List<string>();
                RemoveHuashen(room, zuoci, huashens);

                string general = zuoci.ContainsTag("huashen_general") ? zuoci.GetTag("huashen_general").ToString() : string.Empty;
                if (!string.IsNullOrEmpty(general))
                {
                    List<string> args = new List<string>
                    {
                        GameEventType.S_GAME_EVENT_HUASHEN.ToString(),
                        zuoci.Name,
                        string.Empty
                    };
                    room.DoBroadcastNotify(CommandType.S_COMMAND_LOG_EVENT, args);
                }
                zuoci.RemoveTag("huashen_general");

                string skill = zuoci.ContainsTag("huashen_skill") ? zuoci.GetTag("huashen_skill").ToString() : string.Empty;
                if (!string.IsNullOrEmpty(skill))
                    room.HandleAcquireDetachSkills(zuoci, string.Format("-{0}", skill), true);
                zuoci.RemoveTag("huashen_skill");


                General real_general = Engine.GetGeneral(zuoci.General1, room.Setting.GameMode);
                if (General.GetKingdom(zuoci) != real_general.Kingdom[0])
                {
                    zuoci.Kingdom = General.GetKingdom(real_general.Kingdom[0]);
                    room.BroadcastProperty(zuoci, "Kingdom");
                }
                if (zuoci.PlayerGender != real_general.GeneralGender)
                {
                    zuoci.PlayerGender = real_general.GeneralGender;
                    room.BroadcastProperty(zuoci, "PlayerGender");
                }
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && (player.Phase == PlayerPhase.NotActive || player.Phase == PlayerPhase.RoundStart))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.GameStart)
            {
                room.NotifySkillInvoked(player, Name);
                return info;
            }
            else
            {
                string choice = room.AskForChoice(player, Name, "change+remove+cancel", null, null, info.SkillPosition);
                if (choice == "cancel") return new TriggerStruct();
                bool remove = choice == "change";
                if (remove)
                {
                    string general = player.ContainsTag("huashen_general") ? player.GetTag("huashen_general").ToString() : string.Empty;
                    if (!string.IsNullOrEmpty(general))
                    {
                        List<string> args = new List<string>
                        {
                            GameEventType.S_GAME_EVENT_HUASHEN.ToString(),
                            player.Name,
                            string.Empty
                        };
                        room.DoBroadcastNotify(CommandType.S_COMMAND_LOG_EVENT, args);
                    }
                    player.RemoveTag("huashen_general");

                    string skill = player.ContainsTag("huashen_skill") ? player.GetTag("huashen_skill").ToString() : string.Empty;
                    if (!string.IsNullOrEmpty(skill))
                        room.HandleAcquireDetachSkills(player, string.Format("-{0}", skill), true);
                    player.RemoveTag("huashen_skill");
                }
            }

            return info;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            List<string> huashens = (List<string>)player.GetTag("huashen");

            if (triggerEvent == TriggerEvent.EventPhaseStart && player.ContainsTag("huashen_general") && player.GetTag("huashen_general") is string used)
            {
                List<string> removes = new List<string>(), origin = new List<string>(huashens);
                origin.Remove(used);
                string general = room.AskforGeneral(player, origin, Name, false, "@huashen-discard", data, info.SkillPosition);
                origin.Remove(general);
                removes.Add(general);

                if (origin.Count > 0)
                {
                    general = room.AskforGeneral(player, origin, Name, true, "@huashen-discard", data, info.SkillPosition);
                    if (!string.IsNullOrEmpty(general))
                        removes.Add(general);
                }

                LogMessage log = new LogMessage
                {
                    Type = "#drophuashendetail",
                    From = player.Name,
                    Arg = "huashen",
                    Arg2 = string.Join("\\, \\", removes)
                };
                room.SendLog(log);

                room.DoAnimate(AnimateType.S_ANIMATE_HUASHEN, string.Join("+", removes), string.Format("{0}+null+huashen", player.Name));
                Thread.Sleep(500);

                Acquiregenerals(room, player, removes.Count);
                huashens.RemoveAll(t => removes.Contains(t));
                foreach (string name in removes)
                    room.HandleUsedGeneral("-" + name);
                room.SetPlayerStringMark(player, "huashen", huashens.Count.ToString(), room.GetClient(player));
            }
            else
            {
                if (huashens.Count > 0)
                {
                    string general = room.AskForGeneral(player, huashens, null);
                    General g = Engine.GetGeneral(general, room.Setting.GameMode);
                    if (g != null)
                    {
                        player.PlayerGender = g.GeneralGender;
                        player.Kingdom = General.GetKingdom(g.Kingdom[0]);
                        room.BroadcastProperty(player, "PlayerGender");
                        room.BroadcastProperty(player, "Kingdom");
                        
                        List<string> args = new List<string>
                        {
                            GameEventType.S_GAME_EVENT_HUASHEN.ToString(),
                            player.Name,
                            general
                        };
                        room.DoBroadcastNotify(CommandType.S_COMMAND_LOG_EVENT, args);

                        player.SetTag("huashen_general", general);

                        List<string> skills = new List<string>();
                        foreach (string skill_name in Engine.GetGeneralSkills(general, room.Setting.GameMode, true))
                        {
                            Skill s = Engine.GetSkill(skill_name);
                            if (s != null && s.SkillFrequency != Frequency.Limited && s.SkillFrequency != Frequency.Wake && !s.LordSkill && !s.Attached_lord_skill)
                                skills.Add(skill_name);
                        }

                        if (skills.Count > 0)
                        {
                            string skill = room.AskForSkill(player, Name, string.Join("+", skills), "@choose-skill", 1, 1, false, info.SkillPosition);
                            player.SetTag("huashen_skill", skill);
                            room.HandleAcquireDetachSkills(player, skill, true);
                            room.FilterCards(player, player.GetCards("he"), true);
                        }
                    }
                }
            }
            return false;
        }
    }

    public class Xinsheng : MasochismSkill
    {
        public Xinsheng() : base("xinsheng")
        {
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DamageStruct damage)
            {
                TriggerStruct trigger = new TriggerStruct(Name, player)
                {
                    Times = damage.Damage
                };
                return trigger;
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override void OnDamaged(Room room, Player target, DamageStruct damage, TriggerStruct info)
        {
            Huashen.Acquiregenerals(room, target, 1);
        }
    }

    public class BeigeJX : TriggerSkill
    {
        public BeigeJX() : base("beige_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged };
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (player == null) return skill_list;
            if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct damage && damage.Card != null && damage.To.Alive)
            {
                FunctionCard fcard = Engine.GetFunctionCard(damage.Card.Name);
                if (fcard is Slash)
                {
                    List<Player> caiwenjis = RoomLogic.FindPlayersBySkillName(room, Name);
                    foreach (Player caiwenji in caiwenjis)
                        if (RoomLogic.CanDiscard(room, caiwenji, caiwenji, "he"))
                            skill_list.Add(new TriggerStruct(Name, caiwenji));
                }

            }

            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player caiwenji, TriggerStruct info)
        {
            if (data is DamageStruct @struct && player.Alive && caiwenji.Alive)
            {
                room.SetTag("beige_data", data);
                bool invoke = room.AskForDiscard(caiwenji, Name, 1, 1, true, true, "@beige:" + player.Name, true, info.SkillPosition);
                room.RemoveTag("beige_data");

                if (invoke)
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, caiwenji.Name, @struct.To.Name);
                    room.BroadcastSkillInvoke(Name, caiwenji, info.SkillPosition);
                    return info;
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player caiwenji, TriggerStruct info)
        {
            DamageStruct damage = (DamageStruct)data;

            JudgeStruct judge = new JudgeStruct
            {
                Good = true,
                PlayAnimation = false,
                Who = player,
                Reason = Name
            };

            room.Judge(ref judge);

            WrappedCard.CardSuit suit = judge.JudgeSuit;
            switch (suit)
            {
                case WrappedCard.CardSuit.Heart:
                    {
                        RecoverStruct recover = new RecoverStruct
                        {
                            Who = caiwenji,
                            Recover = damage.Damage
                        };
                        room.Recover(player, recover, true);

                        break;
                    }
                case WrappedCard.CardSuit.Diamond:
                    {
                        room.DrawCards(player, 3, Name);
                        break;
                    }
                case WrappedCard.CardSuit.Club:
                    {
                        if (damage.From != null && damage.From.Alive)
                            room.AskForDiscard(damage.From, Name, 2, 2, false, true, "@beige-discard");

                        break;
                    }
                case WrappedCard.CardSuit.Spade:
                    {
                        if (damage.From != null && damage.From.Alive)
                            room.TurnOver(damage.From);

                        break;
                    }
                default:
                    break;
            }
            return false;
        }
    }

    public class JianchuJX : TriggerSkill
    {
        public JianchuJX() : base("jianchu_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
            frequency = Frequency.Frequent;
            skill_type = SkillType.Attack;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To_place == Place.PlaceTable
                && move.From != null && move.Reason.Reason == MoveReason.S_REASON_DISMANTLE && move.Reason.SkillName == Name
                && move.From.Name == move.Reason.TargetId && move.Card_ids.Count == 1)
            {
                bool basic = Engine.GetFunctionCard(room.GetCard(move.Card_ids[0]).Name) is BasicCard;
                string tag_name = string.Format("{0}_{1}", Name, move.Reason.TargetId);
                Player pangde = room.FindPlayer(move.Reason.PlayerId, true);
                pangde.SetTag(tag_name, basic);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.GetMark(Name) > 0)
                player.SetMark(Name, 0);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && base.Triggerable(player, room) && data is CardUseStruct use && use.Card != null)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash)
                {
                    List<Player> targets = new List<Player>();
                    foreach (Player p in use.To)
                    {
                        if (!p.IsNude() && p.Alive && RoomLogic.CanDiscard(room, player, p, "he"))
                            targets.Add(p);
                    }
                    if (targets.Count > 0)
                        return new TriggerStruct(Name, player, targets);
                }
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player pangde, TriggerStruct info)
        {
            if (!player.IsNude() && RoomLogic.CanDiscard(room, pangde, player, "he") && room.AskForSkillInvoke(pangde, Name, player, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, pangde.Name, player.Name);
                room.BroadcastSkillInvoke(Name, pangde, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player pangde, TriggerStruct info)
        {
            int to_throw = room.AskForCardChosen(pangde, target, "he", Name, false, HandlingMethod.MethodDiscard);
            List<int> ids = new List<int> { to_throw };
            string tag_name = string.Format("{0}_{1}", Name, target.Name);
            pangde.RemoveTag(tag_name);
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_DISMANTLE, pangde.Name, target.Name, Name, string.Empty)
            {
                General = RoomLogic.GetGeneralSkin(room, pangde, Name, info.SkillPosition)
            };
            room.ThrowCard(ref ids, reason, target, pangde);
            CardUseStruct use = (CardUseStruct)data;
            if (ids.Count > 0)
            {
                if (!(bool)pangde.GetTag(tag_name))
                {
                    if (pangde.Alive && pangde.Phase == PlayerPhase.Play) pangde.AddMark(Name); 
                    int index = 0;
                    for (int i = 0; i < use.EffectCount.Count; i++)
                    {
                        CardBasicEffect effect = use.EffectCount[i];
                        if (effect.To == target)
                        {
                            index++;
                            if (index == info.Times)
                            {
                                effect.Effect2 = 0;
                                break;
                            }
                        }
                    }

                    data = use;
                }
                else
                {
                    List<int> card_ids = room.GetCardIdsOnTable(room.GetSubCards(use.Card));
                    if (card_ids.Count > 0 && card_ids.SequenceEqual(use.Card.SubCards))
                    {
                        room.RemoveSubCards(use.Card);
                        room.ObtainCard(target, ref card_ids, new CardMoveReason(MoveReason.S_REASON_GOTBACK, target.Name));
                    }
                }
            }

            return false;
        }
    }

    public class JianchuTar : TargetModSkill
    {
        public JianchuTar() : base("#jianchu-tar", false)
        {
        }

        public override int GetResidueNum(Room room, Player from, WrappedCard card)
        {
            return from.GetMark("jianchu_jx");
        }
    }

    //caopi
    public class Songwei : TriggerSkill
    {
        public Songwei() : base("songwei")
        {
            events.Add(TriggerEvent.FinishJudge);
            skill_type = SkillType.Replenish;
            lord_skill = true;
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> result = new List<TriggerStruct>();
            if (player.Kingdom == "wei" && data is JudgeStruct judge && player.Alive && WrappedCard.IsBlack(judge.Card.Suit))
            {
                List<Player> caopis = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in caopis)
                {
                    if (player != p)
                        result.Add(new TriggerStruct(Name, player, p));
                }
            }

            return result;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player caopi = room.FindPlayer(info.SkillOwner);
            if (ask_who.Alive && caopi.Alive)
            {
                caopi.SetFlags("songwei_target");
                bool invoke = room.AskForSkillInvoke(ask_who, Name, caopi);
                caopi.SetFlags("-songwei_target");

                room.NotifySkillInvoked(caopi, Name);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, info.SkillOwner);
                room.BroadcastSkillInvoke(Name, caopi, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.DrawCards(player, new DrawCardStruct(1, ask_who, Name));
            return false;
        }
    }

    //徐晃
    public class DuanliangJX : TriggerSkill
    {
        public DuanliangJX() : base("duanliang_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageDone };
            skill_type = SkillType.Alter;
            view_as_skill = new DuanliangJXVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is DamageStruct damage && damage.From != null && damage.From.Alive)
                damage.From.SetFlags(Name);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class DuanliangJXVS : OneCardViewAsSkill
    {
        public DuanliangJXVS() : base("duanliang_jx")
        {
            filter_pattern = "BasicCard,EquipCard|black";
            response_or_use = true;
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => true;
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard shortage = new WrappedCard(SupplyShortage.ClassName)
            {
                Skill = Name,
                ShowSkill = Name
            };
            shortage.AddSubCard(card);
            shortage = RoomLogic.ParseUseCard(room, shortage);

            return shortage;
        }
    }

    public class DuanliangJXTargetMod : TargetModSkill
    {
        public DuanliangJXTargetMod() : base("#jxduanliang-target")
        {
            pattern = "SupplyShortage";
        }
        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern)
        {
            if (to != null && RoomLogic.PlayerHasSkill(room, from, "duanliang_jx") && !from.HasFlag("duanliang_jx"))
                return true;
            else
                return false;
        }
    }

    public class Jiezhi : TriggerSkill
    {
        public Jiezhi() : base("jiezhi")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseEnd, TriggerEvent.EventPhaseSkipping };
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseEnd && player != null && player.Alive && player.Phase == PlayerPhase.Draw && player.GetMark(Name) > 0)
            {
                player.SetMark(Name, 0);
                room.RemovePlayerStringMark(player, Name);
                player.AddPhase(PlayerPhase.Draw);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseSkipping && data is PhaseChangeStruct change && change.To == Player.PlayerPhase.Draw && player.Alive)
            {
                List<Player> xuhuangs = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in xuhuangs)
                    if (p != player)
                        triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(ask_who, room.GetAlivePlayers(), Name, "@jiezhi", true, true, info.SkillPosition);
            if (target != null)
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.SetTag(Name, target);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is Player target)
            {
                room.RemoveTag(Name);
                int count = 999;
                foreach (Player p in room.GetAlivePlayers())
                    if (p.HandcardNum < count)
                        count = p.HandcardNum;

                if (target.GetMark(Name) == 0 && target.HandcardNum == count)
                {
                    target.AddMark(Name);
                    room.SetPlayerStringMark(target, Name, string.Empty);
                }
                else
                    room.DrawCards(target, new DrawCardStruct(1, ask_who, Name));
            }
            return false;
        }
    }

    //曹仁
    public class JieweiVS : ViewAsSkill
    {
        public JieweiVS() : base("jiewei")
        {
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (room.GetRoomState().GetCurrentCardUsePattern() == "Nullification")
                return selected.Count == 0 && room.GetCardPlace(to_select.Id) == Place.PlaceEquip;
            else
                return selected.Count == 0 && room.GetCardPlace(to_select.Id) == Place.PlaceHand && RoomLogic.CanDiscard(room, player, player, to_select.Id);
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => false;
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern) => pattern == "Nullification" || pattern == "@@jiewei";
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1)
            {
                if (room.GetRoomState().GetCurrentCardUsePattern() == "Nullification")
                {
                    WrappedCard ncard = new WrappedCard(Nullification.ClassName) { Skill = Name };
                    ncard.AddSubCards(cards);
                    ncard = RoomLogic.ParseUseCard(room, ncard);
                    return ncard;
                }
                else
                {
                    WrappedCard card = new WrappedCard(JieweiCard.ClassName) { Skill = Name };
                    card.AddSubCards(cards);
                    return card;
                }
            }
            return null;
        }
        public override bool IsEnabledAtNullification(Room room, Player player)
        {
            return player.HasEquip();
        }
    }

    public class JieweiCard : SkillCard
    {
        public static string ClassName = "JieweiCard";
        public JieweiCard() : base(ClassName)
        {
            will_throw = true;
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card) => targets.Count == 2;
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard qiaobian)
        {
            if (targets.Count == 0)
                return true;
            else if (targets.Count == 1)
                return room.CheckStageCardMove(targets[0], to_select, StageArea.Both);
            return false;
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            int card_id = room.AskforMoveStageCard(card_use.From, "jiewei", card_use.To[0], card_use.To[1], StageArea.Both, false, card_use.Card.SkillPosition);
            Player from = card_use.To[0].GetCards("ej").Contains(card_id) ? card_use.To[0] : card_use.To[1];
            Player to = from == card_use.To[0] ? card_use.To[1] : card_use.To[0];
            Place place = room.GetCardPlace(card_id);

            if ((place == Place.PlaceDelayedTrick && from != card_use.From) || (place == Place.PlaceEquip && to != card_use.From))
            {
                ResultStruct result = card_use.From.Result;
                result.Assist++;
                card_use.From.Result = result;
            }

            room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, from.Name, to.Name);
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_TRANSFER, card_use.From.Name, "jiewei", null)
            {
                Card = room.GetCard(card_id)
            };
            room.MoveCardTo(room.GetCard(card_id), from, to, place, reason);
        }
    }

    public class JushouJXVS : OneCardViewAsSkill
    {
        public JushouJXVS() : base("jushou_jx")
        {
            response_pattern = "@@jushou_jx";
        }

        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            FunctionCard fcard = Engine.GetFunctionCard(to_select.Name);
            return room.GetCardPlace(to_select.Id) == Place.PlaceHand && (fcard is EquipCard && fcard.IsAvailable(room, player, to_select)
                || RoomLogic.CanDiscard(room, player, player, to_select.Id));
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard jushou = new WrappedCard(JushouCard.ClassName)
            {
                Mute = true,
                Skill = Name
            };
            jushou.AddSubCard(card);
            return jushou;
        }
    }

    public class Jiewei : TriggerSkill
    {
        public Jiewei() : base("jiewei")
        {
            events.Add(TriggerEvent.TurnedOver);
            view_as_skill = new JieweiVS();
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return (base.Triggerable(player, room) && player.FaceUp && player.Alive) ? new TriggerStruct(Name, player) : new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.AskForUseCard(player, RespondType.Skill, "@@jiewei", "@jiewei", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
            return new TriggerStruct();
        }
    }
    public class JushouJX : PhaseChangeSkill
    {
        public JushouJX() : base("jushou_jx")
        {
            view_as_skill = new JushouJXVS();
            frequency = Frequency.Frequent;
            skill_type = SkillType.Defense;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish ?
                new TriggerStruct(Name, player) : new TriggerStruct(); ;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool OnPhaseChange(Room room, Player caoren, TriggerStruct info)
        {
            room.TurnOver(caoren);
            room.DrawCards(caoren, 4, Name);

            List<int> ids = caoren.GetCardCount(false) == 1 ? caoren.GetCards("h") : new List<int>();
            if (ids.Count == 0)
            {
                WrappedCard use = room.AskForUseCard(caoren, RespondType.Skill, "@@jushou_jx", "@jushou", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
                if (use != null)
                    ids = new List<int>(use.SubCards);
                else
                    ids = room.ForceToDiscard(caoren, caoren.GetCards("h"), 1);
            }

            if (ids.Count == 1)
            {
                int id = ids[0];
                WrappedCard card = room.GetCard(id);

                bool discard = true;
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                if (fcard is EquipCard && fcard.IsAvailable(room, caoren, card))
                {
                    if (RoomLogic.CanDiscard(room, caoren, caoren, id))
                        discard = room.AskForChoice(caoren, Name, "use+discard", null, null, info.SkillPosition) == "discard";
                    else
                        discard = false;
                }

                if (discard)
                {
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, caoren, info.SkillPosition);
                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_DISCARD, caoren.Name, null, Name, null)
                    {
                        General = gsk
                    };
                    room.ThrowCard(ref ids, reason, caoren, caoren);
                }
                else
                    room.UseCard(new CardUseStruct(card, caoren, new List<Player>(), true));
            }

            return false;
        }
    }

    public class FangquanVS : OneCardViewAsSkill
    {
        public FangquanVS() : base("fangquan_jx")
        {
            filter_pattern = ".!";
            response_pattern = "@@fangquan_jx";
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard fangquan = new WrappedCard(FangquanCard.ClassName);
            fangquan.AddSubCard(card);
            fangquan.Skill = Name;
            return fangquan;
        }
    }

    public class FangquanJX : TriggerSkill
    {
        public FangquanJX() : base("fangquan_jx")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            view_as_skill = new FangquanVS();
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is PhaseChangeStruct change)
            {
                if (base.Triggerable(player, room) && change.To == PlayerPhase.Play && !player.IsSkipped(PlayerPhase.Play))
                {
                    return new TriggerStruct(Name, player);
                }
                else if (change.To == PlayerPhase.NotActive && player.HasFlag(Name) && RoomLogic.CanDiscard(room, player, player, "h"))
                {
                    TriggerStruct trigger = new TriggerStruct(Name, player)
                    {
                        SkillPosition = (string)player.GetTag(Name)
                    };
                    return trigger;
                }
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            PhaseChangeStruct change = (PhaseChangeStruct)data;
            if (change.To == PlayerPhase.Play)
            {
                if (room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
                {
                    room.SkipPhase(player, PlayerPhase.Play);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                    return info;
                }
            }
            else if (change.To == PlayerPhase.NotActive)
                room.AskForUseCard(player, RespondType.Skill, "@@fangquan_jx", "@fangquan-discard", null, -1, HandlingMethod.MethodDiscard, true, info.SkillPosition);

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player liushan, ref object data, Player ask_who, TriggerStruct info)
        {
            PhaseChangeStruct change = (PhaseChangeStruct)data;
            if (change.To == PlayerPhase.Play)
            {
                liushan.SetTag(Name, info.SkillPosition);
                liushan.SetFlags(Name);
            }
            return false;
        }

        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            index = 2;
        }
    }

    public class FangquanMax : MaxCardsSkill
    {
        public FangquanMax() : base("#fangquan-max") { }
        public override int GetFixed(Room room, Player target) => target.HasFlag("fangquan_jx") ? target.MaxHp : -1;
    }

    public class LiegongJX : TriggerSkill
    {
        public LiegongJX() : base("liegong_jx")
        {
            events.Add(TriggerEvent.TargetChosen);
            skill_type = SkillType.Attack;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && base.Triggerable(player, room))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash)
                {
                    List<Player> targets = new List<Player>();
                    foreach (Player to in use.To)
                    {
                        if (to.HandcardNum <= player.HandcardNum || to.Hp >= player.Hp)
                            targets.Add(to);
                    }
                    if (targets.Count > 0)
                        return new TriggerStruct(Name, player, targets);
                }
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player skill_target, ref object data, Player player, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, skill_target, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player player, TriggerStruct info)
        {
            List<string> choices = new List<string>();
            if (target.HandcardNum <= player.HandcardNum)
                choices.Add("nojink");
            if (target.Hp >= player.Hp)
                choices.Add("damage");

            if (choices.Count == 0)
                return false;

            CardUseStruct use = (CardUseStruct)data;
            while (choices.Count > 0)
            {
                string choice = room.AskForChoice(player, Name, string.Join("+", choices), null, info.SkillPosition);
                if (choice == "nojink")
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "#NoJink",
                        From = target.Name
                    };
                    room.SendLog(log);

                    int index = 0;
                    for (int i = 0; i < use.EffectCount.Count; i++)
                    {
                        CardBasicEffect effect = use.EffectCount[i];
                        if (effect.To == target)
                        {
                            index++;
                            if (index == info.Times)
                            {
                                effect.Effect2 = 0;
                                data = use;
                                break;
                            }
                        }
                    }
                }
                else if (choice == "damage")
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "#add_damage",
                        From = target.Name,
                        To = new List<string> { target.Name },
                        Arg = "1"
                    };
                    room.SendLog(log);

                    int index = 0;
                    for (int i = 0; i < use.EffectCount.Count; i++)
                    {
                        CardBasicEffect effect = use.EffectCount[i];
                        if (effect.To == target)
                        {
                            index++;
                            if (index == info.Times)
                            {
                                effect.Effect1++;
                                data = use;
                                break;
                            }
                        }
                    }
                }
                else
                    break;

                choices.Remove(choice);
                if (choices.Count > 0 && !choices.Contains("cancel"))
                    choices.Add("cancel");
                else
                    break;
            }

            return false;
        }
    }
    /*
    public class LiegongRecord : TriggerSkill
    {
        public LiegongRecord() : base("#liegong-damage")
        {
            events = new List<TriggerEvent> { TriggerEvent.ConfirmDamage, TriggerEvent.CardFinished };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName))
            {
                string tag = string.Format("liegong_{0}", RoomLogic.CardToString(room, use.Card));
                use.From.RemoveTag(tag);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.ConfirmDamage && data is DamageStruct damage && damage.From != null && damage.Card != null
                && damage.Card.Name.Contains(Slash.ClassName) && !damage.Transfer && !damage.Chain)
            {
                string tag = string.Format("liegong_{0}", RoomLogic.CardToString(room, damage.Card));
                List<string> targets = player.ContainsTag(tag) ? (List<string>)player.GetTag(tag) : new List<string>();
                if (targets.Contains(damage.To.Name))
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                string tag = string.Format("liegong_{0}", RoomLogic.CardToString(room, damage.Card));
                List<string> targets = (List<string>)damage.From.GetTag(tag);
                targets.Remove(damage.To.Name);
                player.SetTag(tag, targets);
                damage.Damage++;
                data = damage;
            }

            return false;
        }
    }
    */
    public class LiegongTar : TargetModSkill
    {
        public LiegongTar() : base("#liegong-tar")
        {
        }

        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern)
        {
            if (from != null && RoomLogic.PlayerHasSkill(room, from, "liegong_jx") && to != null)
            {
                int distance = RoomLogic.DistanceTo(room, from, to, card);
                return distance > 0 && RoomLogic.GetCardNumber(room, card) >= distance;
            }

            return false;
        }

        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ModType type, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            index = -2;
        }
    }

    public class KuangguJX : TriggerSkill
    {
        public KuangguJX() : base("kuanggu_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.PreDamageDone };
            skill_type = SkillType.Recover;
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (player != null && triggerEvent == TriggerEvent.PreDamageDone && data is DamageStruct damage)
            {
                Player weiyan = damage.From;
                if (weiyan != null)
                {
                    if (RoomLogic.DistanceTo(room, weiyan, damage.To) != -1 && RoomLogic.DistanceTo(room, weiyan, damage.To) <= 1)
                        weiyan.SetTag("InvokeKuanggu", damage.Damage);
                    else
                        weiyan.RemoveTag("InvokeKuanggu");
                }
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && triggerEvent == TriggerEvent.Damage && data is DamageStruct damage)
            {
                int recorded_damage = player.ContainsTag("InvokeKuanggu") ? (int)player.GetTag("InvokeKuanggu") : 0;
                if (recorded_damage > 0)
                {
                    TriggerStruct skill_list = new TriggerStruct(Name, player)
                    {
                        Times = damage.Damage
                    };
                    return skill_list;
                }
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            return info;
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            List<string> choices = new List<string> { "draw" };
            if (player.IsWounded())
                choices.Add("recover");
            string result = room.AskForChoice(player, Name, string.Join("+", choices), null, info.SkillPosition);
            if (result == "draw")
                room.DrawCards(player, 1, Name);
            else
                room.Recover(player, 1);

            return false;
        }
    }

    public class QimouVS : ZeroCardViewAsSkill
    {
        public QimouVS() : base("qimou") { }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return player.Hp > 0 && player.GetMark("@mou") > 0;
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard qimou = new WrappedCard(QimouCard.ClassName)
            {
                Skill = Name,
                Mute = true
            };
            return qimou;
        }
    }

    public class Qimou : TriggerSkill
    {
        public Qimou() : base("qimou")
        {
            limit_mark = "@mou";
            skill_type = SkillType.Attack;
            events.Add(TriggerEvent.EventPhaseChanging);
            view_as_skill = new QimouVS();
            frequency = Frequency.Limited;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetMark(Name) > 0)
                player.SetMark(Name, 0);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class QimouTar : TargetModSkill
    {
        public QimouTar() : base("#qimou-tar", false) { }

        public override int GetResidueNum(Room room, Player from, WrappedCard card)
        {
            return Engine.MatchExpPattern(room, pattern, from, card) ? from.GetMark("qimou") : 0;
        }
    }

    public class QimouDistance : DistanceSkill
    {
        public QimouDistance() : base("#qimou-distance") { }

        public override int GetCorrect(Room room, Player from, Player to, WrappedCard card = null)
        {
            return -from.GetMark("qimou");
        }
    }

    public class QimouCard : SkillCard
    {
        public static string ClassName = "QimouCard";
        public QimouCard() : base(ClassName)
        {
            target_fixed = true;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            room.SetPlayerMark(card_use.From, "@mou", 0);
            room.BroadcastSkillInvoke("qimou", card_use.From, card_use.Card.SkillPosition);
            room.DoSuperLightbox(card_use.From, card_use.Card.SkillPosition, "qimou");
            base.OnUse(room, card_use);
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            if (player.Alive && player.Hp > 0)
            {
                List<string> choices = new List<string>();
                for (int i = player.Hp; i > 0; i--)
                    choices.Add(i.ToString());

                int lose = int.Parse(room.AskForChoice(player, "qimou", string.Join("+", choices), new List<string> { "@qimou-lose" }, null, card_use.Card.SkillPosition));
                room.LoseHp(player, lose);

                if (player.Alive)
                {
                    player.SetMark("qimou", lose);
                    room.DrawCards(player, lose, "qimou");
                }
            }
        }
    }

    public class Ruoyu : PhaseChangeSkill
    {
        public Ruoyu() : base("ruoyu")
        {
            frequency = Frequency.Wake;
            lord_skill = true;
            skill_type = SkillType.Recover;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Start && base.Triggerable(player, room) && player.GetMark(Name) == 0)
            {
                int min = 100;
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.Hp < min)
                        min = p.Hp;
                }
                if (player.Hp == min)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            room.SetPlayerMark(player, Name, 1);
            room.SendCompulsoryTriggerLog(player, Name);
            if (player.Alive)
            {
                player.MaxHp++;
                room.BroadcastProperty(player, "MaxHp");

                LogMessage log = new LogMessage
                {
                    Type = "$GainMaxHp",
                    From = player.Name,
                    Arg = "1"
                };
                room.SendLog(log);

                room.RoomThread.Trigger(TriggerEvent.MaxHpChanged, room, player);
                RecoverStruct recover = new RecoverStruct
                {
                    Who = player,
                    Recover = 1
                };
                room.Recover(player, recover, true);

                room.HandleAcquireDetachSkills(player, "jijiang", true);
            }

            return false;
        }
    }

    public class Zhiji : PhaseChangeSkill
    {
        public Zhiji() : base("zhiji")
        {
            frequency = Frequency.Wake;
            skill_type = SkillType.Recover;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if ((player.Phase == PlayerPhase.Start || player.Phase == PlayerPhase.Finish) && player.GetMark(Name) == 0 && base.Triggerable(player, room) && player.IsKongcheng())
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            room.SetPlayerMark(player, Name, 1);
            room.SendCompulsoryTriggerLog(player, Name);

            List<string> choices = new List<string> { "draw" };
            if (player.GetLostHp() > 0)
            {
                choices.Add("recover");
            }
            if (room.AskForChoice(player, Name, string.Join("+", choices), null, null, info.SkillPosition) == "recover")
            {
                RecoverStruct recover = new RecoverStruct
                {
                    Recover = 1,
                    Who = player
                };
                room.Recover(player, recover, true);
            }
            else
                room.DrawCards(player, 2, Name);

            room.LoseMaxHp(player);
            if (player.Alive)
                room.HandleAcquireDetachSkills(player, "guanxing_jx", true);

            return false;
        }
    }

    public class LierenJX : TriggerSkill
    {
        public LierenJX() : base("lieren_jx")
        {
            events.Add(TriggerEvent.TargetChosen);
            skill_type = SkillType.Attack;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player zhurong, ref object data, Player ask_who)
        {
            if (base.Triggerable(zhurong, room) && data is CardUseStruct use && use.Card != null)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash && !zhurong.IsKongcheng())
                {
                    List<Player> targets = new List<Player>();
                    foreach (Player p in use.To)
                        if (RoomLogic.CanBePindianBy(room, p, zhurong)) targets.Add(p);

                    if (targets.Count > 0)
                        return new TriggerStruct(Name, zhurong, targets);
                }
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player zhurong, TriggerStruct info)
        {
            if (!zhurong.IsKongcheng() && RoomLogic.CanBePindianBy(room, target, zhurong))
            {
                target.SetFlags("lieren_target");
                bool invoke = room.AskForSkillInvoke(zhurong, Name, target, info.SkillPosition);
                target.SetFlags("-lieren_target");

                if (invoke)
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, zhurong.Name, target.Name);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, zhurong, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                    PindianStruct pd = room.PindianSelect(zhurong, target, Name);
                    room.SetTag("lieren_pd", pd);
                    return info;
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player zhurong, TriggerStruct info)
        {
            PindianStruct pd = (PindianStruct)room.GetTag("lieren_pd");
            room.RemoveTag("lieren_pd");
            room.Pindian(ref pd);
            if (pd.Success)
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, zhurong, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                if (RoomLogic.CanGetCard(room, zhurong, target, "he"))
                {
                    int card_id = room.AskForCardChosen(zhurong, target, "he", Name, false, HandlingMethod.MethodGet);
                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_EXTRACTION, zhurong.Name);
                    room.ObtainCard(zhurong, room.GetCard(card_id), reason, room.GetCardPlace(card_id) != Place.PlaceHand);
                }
            }
            else
            {
                List<CardsMoveStruct> moves = new List<CardsMoveStruct>();
                if (room.GetCardPlace(pd.From_card.Id) == Place.DiscardPile)
                {
                    CardsMoveStruct move1 = new CardsMoveStruct(pd.From_card.Id, target, Place.PlaceHand,
                        new CardMoveReason(MoveReason.S_REASON_GOTBACK, target.Name, Name, string.Empty));
                    moves.Add(move1);
                }
                if (room.GetCardPlace(pd.To_cards[0].Id) == Place.DiscardPile)
                {
                    CardsMoveStruct move2 = new CardsMoveStruct(pd.To_cards[0].Id, zhurong, Place.PlaceHand,
                        new CardMoveReason(MoveReason.S_REASON_GOTBACK, zhurong.Name, Name, string.Empty));
                    moves.Add(move2);
                }
                if (moves.Count > 0)
                    room.MoveCardsAtomic(moves, true);
            }

            return false;
        }
    }

    public class ZaiqiJX : TriggerSkill
    {
        public ZaiqiJX() : base("zaiqi_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseEnd, TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To_place == Place.DiscardPile)
            {
                int count = room.ContainsTag(Name) ? (int)room.GetTag(Name) : 0;
                foreach (int id in move.Card_ids)
                    if (WrappedCard.IsRed(room.GetCard(id).Suit)) count++;

                room.SetTag(Name, count);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                room.RemoveTag(Name);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseEnd && base.Triggerable(player, room) && player.Phase == PlayerPhase.Discard && room.ContainsTag(Name)
                && room.GetTag(Name) is int count && count > 0)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is int count)
            {
                List<Player> targets = room.AskForPlayersChosen(player, room.GetAlivePlayers(), Name, 0, count, "@zaiqi-target:::" + count.ToString(), true, info.SkillPosition);
                if (targets.Count > 0)
                {
                    room.SortByActionOrder(ref targets);
                    room.SetTag("tuxi_invoke" + player.Name, targets);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            string str = "tuxi_invoke" + player.Name;
            List<Player> targets = room.ContainsTag(str) ? (List<Player>)room.GetTag(str) : new List<Player>();
            room.RemoveTag(str);

            foreach (Player p in targets)
            {
                if (p.Alive)
                {
                    List<string> choices = new List<string> { "draw" };
                    List<string> prompts = new List<string> { "@zaiqi:" + player.Name };
                    if (player.Alive && player.IsWounded())
                        choices.Add("heal");

                    if (room.AskForChoice(p, Name, string.Join("+", choices), null, player) == "draw")
                        room.DrawCards(p, new DrawCardStruct(1, player, Name));
                    else
                    {
                        RecoverStruct recover = new RecoverStruct
                        {
                            Recover = 1,
                            Who = p
                        };
                        room.Recover(player, recover, true);
                    }
                }
            }

            return false;
        }
    }

    public class TiaoxinJXCard : SkillCard
    {
        public static string ClassName = "TiaoxinJXCard";
        public TiaoxinJXCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && to_select != Self && RoomLogic.InMyAttackRange(room, to_select, Self);
        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            Player slasher = effect.To;
            slasher.SetFlags("slashTargetFix");
            slasher.SetFlags("slashTargetFixToOne");
            effect.From.SetFlags("SlashAssignee");
            WrappedCard slash = room.AskForUseCard(slasher, RespondType.Slash, "Slash:tiaoxin_jx", "@tiaoxin_jx-slash:" + effect.From.Name, null, -1, HandlingMethod.MethodUse, true);
            bool discard = false;
            if (slash == null)
            {
                discard = true;
                slasher.SetFlags("-slashTargetFix");
                slasher.SetFlags("-slashTargetFixToOne");
                effect.From.SetFlags("-SlashAssignee");
            }
            else
            {
                if (effect.From.HasFlag("tiaoxin_damage"))
                    effect.From.SetFlags("-tiaoxin_damage");
                else
                    discard = true;
            }
            if (discard && effect.From.Alive)
            {
                effect.From.SetFlags("tiaoxin_jx");
                if (slasher.Alive && !slasher.IsNude() && RoomLogic.CanDiscard(room, effect.From, effect.To, "he"))
                {
                    int id = room.AskForCardChosen(effect.From, effect.To, "he", "tiaoxin_jx", false, HandlingMethod.MethodDiscard);
                    room.ThrowCard(id, effect.To, effect.From);
                }
            }
        }
    }

    public class TiaoxinJX : TriggerSkill
    {
        public TiaoxinJX() : base("tiaoxin_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.CardUsedAnnounced };
            view_as_skill = new TiaoxinJXVS();
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName) && use.Pattern == "Slash:tiaoxin_jx")
                use.Card.SetFlags(Name);
            else if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && damage.Card != null && damage.To.Phase == PlayerPhase.Play && damage.Card.HasFlag(Name))
                damage.To.SetFlags("tiaoxin_damage");
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class TiaoxinJXVS : ZeroCardViewAsSkill
    {
        public TiaoxinJXVS() : base("tiaoxin_jx")
        {
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => player.UsedTimes(TiaoxinJXCard.ClassName) <= (player.HasFlag(Name) ? 1 : 0);
        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard card = new WrappedCard(TiaoxinJXCard.ClassName)
            {
                Skill = Name,
                ShowSkill = Name
            };
            return card;
        }
    }

    public class HuojiJX : OneCardViewAsSkill
    {
        public HuojiJX() : base("huoji_jx")
        {
            filter_pattern = ".|red|.|hand";
            response_or_use = true;
            skill_type = SkillType.Attack;
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard fire_attack = new WrappedCard(FireAttack.ClassName);
            fire_attack.AddSubCard(card);
            fire_attack.Skill = Name;
            fire_attack.ShowSkill = Name;
            fire_attack = RoomLogic.ParseUseCard(room, fire_attack);
            return fire_attack;
        }

    }

    public class HuojiJxEffect : TriggerSkill
    {
        public HuojiJxEffect() : base("#huoji_jx")
        {
            events.Add(TriggerEvent.CardEffectModified);
            frequency = Frequency.Compulsory;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardEffectStruct effect && effect.Card.Name == FireAttack.ClassName && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardEffectStruct effect && !effect.To.IsKongcheng())
            {
                int id = room.AskForCardShow(effect.To, player, FireAttack.ClassName, effect);
                room.ShowCard(effect.To, id, FireAttack.ClassName);

                WrappedCard.CardSuit suit = RoomLogic.GetCardSuit(room, room.GetCard(id));
                string suit_str = WrappedCard.GetSuitString(suit);
                string prompt = string.Format("@fire-attack:{0}::<color={2}>{1}</color>", effect.To.Name, WrappedCard.GetSuitIcon(RoomLogic.GetCardSuit(room, room.GetCard(id))), WrappedCard.IsBlack(suit) ? "black" : "red");
                if (player.Alive)
                {
                    List<int> tops = room.GetNCards(4, false);
                    List<string> patterns = new List<string>();
                    foreach (int card_id in tops)
                        if (room.GetCard(card_id).Suit == suit) patterns.Add(card_id.ToString());
                    foreach (int card_id in player.GetCards("h"))
                        if (RoomLogic.CanDiscard(room, player, player, card_id) && room.GetCard(card_id).Suit == suit) patterns.Add(card_id.ToString());

                    string pattern = string.Join("#", patterns);
                    if (string.IsNullOrEmpty(pattern)) pattern = string.Format(".{0}!", suit_str.Substring(0, 1).ToUpper());

                    room.SetTag("huoji_jx", data);
                    List<int> ids = room.NotifyChooseCards(player, tops, "huoji_jx", 1, 0, prompt, pattern, info.SkillPosition);
                    room.RemoveTag("huoji_jx");
                    if (ids.Count == 1)
                    {
                        room.ThrowCard(ref ids, player, null, FireAttack.ClassName);
                        room.SetEmotion(player, "fire_attack");
                        room.Damage(new DamageStruct(effect.Card, player, effect.To, 1 + effect.ExDamage + effect.BasicEffect.Effect1, DamageStruct.DamageNature.Fire));
                    }
                    else
                    {
                        player.SetFlags("FireAttackFailedPlayer_" + effect.To.Name); // For AI
                        player.SetFlags("FireAttackFailed_" + suit_str); // For AI
                    }
                }
            }
            return true;
        }
    }

    public class BazhenJx : TriggerSkill
    {
        public BazhenJx() : base("bazhen_jx")
        {
            events.Add(TriggerEvent.FinishJudge);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Defense;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.FinishJudge && data is JudgeStruct judage && judage.Reason == EightDiagram.ClassName && judage.IsBad() && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.FinishJudge)
            {
                room.SendCompulsoryTriggerLog(player, Name, true);
                room.DrawCards(player, 1, Name);
            }
            else
            {
                room.SetEmotion(player, "eightdiagram");
                JudgeStruct judge = new JudgeStruct
                {
                    Pattern = ".|red",
                    Good = true,
                    Reason = EightDiagram.ClassName,
                    Who = player
                };

                room.Judge(ref judge);
                Thread.Sleep(400);
                if (judge.IsGood())
                {
                    WrappedCard jink = new WrappedCard(Jink.ClassName)
                    {
                        Skill = Name,
                        SkillPosition = info.SkillPosition
                    };
                    room.Provide(jink);

                    return true;
                }
            }

            return false;
        }
    }

    public class BazhenJxVH : ViewHasSkill
    {
        public BazhenJxVH() : base("#bazhen_jx_vh")
        {
            viewhas_armors.Add(EightDiagram.ClassName);
        }
        public override bool ViewHas(Room room, Player player, string skill_name)
        {
            if (player.Alive && RoomLogic.PlayerHasSkill(room, player, "bazhen_jx") && !player.GetArmor())
                return true;
            return false;
        }
    }

    public class KanpoJX : OneCardViewAsSkill
    {
        public KanpoJX() : base("kanpo_jx")
        {
            filter_pattern = ".|black";
            response_or_use = true;
            response_pattern = Nullification.ClassName;
            skill_type = SkillType.Alter;
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard ncard = new WrappedCard(Nullification.ClassName);
            ncard.AddSubCard(card);
            ncard.Skill = Name;
            ncard.ShowSkill = Name;
            ncard = RoomLogic.ParseUseCard(room, ncard);
            return ncard;
        }
        public override bool IsEnabledAtNullification(Room room, Player player)
        {
            List<WrappedCard> handlist = RoomLogic.GetPlayerHandcards(room, player);
            handlist.AddRange(RoomLogic.GetPlayerEquips(room, player));
            foreach (int id in player.GetHandPile())
            {
                WrappedCard ca = room.GetCard(id);
                handlist.Add(ca);
            }
            foreach (WrappedCard ca in handlist)
            {
                if (WrappedCard.IsBlack(ca.Suit))
                    return true;
            }
            return false;
        }
    };

    public class Cangzhuo : TriggerSkill
    {
        public Cangzhuo() : base("cangzhuo")
        {
            events.Add(TriggerEvent.CardUsedAnnounced);
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is CardUseStruct use && player == room.Current && player.Alive && Engine.GetFunctionCard(use.Card.Name) is TrickCard
                && !player.HasFlag(Name))
            {
                player.SetFlags(Name);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class CangzhuoMax : MaxCardsSkill
    {
        public CangzhuoMax() : base("#cangzhuo-max") { }

        public override bool Ingnore(Room room, Player player, int card_id)
        {
            return RoomLogic.PlayerHasSkill(room, player, Name) && !player.HasFlag("cangzhuo")
                && Engine.GetFunctionCard(room.GetCard(card_id).Name) is TrickCard;
        }
    }

    public class LianhuanJX : OneCardViewAsSkill
    {
        public LianhuanJX() : base("lianhuan_jx")
        {
            filter_pattern = ".|club";
            response_or_use = true;
            skill_type = SkillType.Alter;
        }
        public override WrappedCard ViewAs(Room room, WrappedCard originalCard, Player player)
        {
            WrappedCard chain = new WrappedCard(IronChain.ClassName);
            chain.AddSubCard(originalCard);
            chain.Skill = Name;
            chain.ShowSkill = Name;
            chain.CanRecast = true;
            chain = RoomLogic.ParseUseCard(room, chain);
            return chain;
        }
    }

    public class LianhuanMax : TargetModSkill
    {
        public LianhuanMax() : base("#lianhuan_jx", false)
        {
            pattern = IronChain.ClassName;
        }

        public override int GetExtraTargetNum(Room room, Player from, WrappedCard card)
        {
            if (RoomLogic.PlayerHasSkill(room, from, "lianhuan_jx")) return 1;
            return 0;
        }
    }

    public class NiepanJX : TriggerSkill
    {
        public NiepanJX() : base("niepan_jx")
        {
            events.Add(TriggerEvent.AskForPeaches);
            frequency = Frequency.Limited;
            limit_mark = "@nirvana";
            skill_type = SkillType.Recover;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player ask_who)
        {
            if (data is DyingStruct dying && dying.Who == target && target.Hp <= 0
                && base.Triggerable(target, room) && target.GetMark("@nirvana") > 0)
                return new TriggerStruct(Name, target);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player pangtong, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(pangtong, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, pangtong, info.SkillPosition);
                room.DoSuperLightbox(pangtong, info.SkillPosition, Name);
                room.SetPlayerMark(pangtong, "@nirvana", 0);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player pangtong, ref object data, Player ask_who, TriggerStruct info)
        {
            room.ThrowAllCards(pangtong);
            RecoverStruct recover = new RecoverStruct
            {
                Recover = Math.Min(3, pangtong.MaxHp) - pangtong.Hp
            };
            room.Recover(pangtong, recover);

            room.DrawCards(pangtong, 3, Name);

            if (pangtong.Chained)
                room.SetPlayerChained(pangtong, false);

            if (!pangtong.FaceUp)
                room.TurnOver(pangtong);

            if (pangtong.Alive)
            {
                string skill = room.AskForSkill(pangtong, Name, "bazhen+huoji+kanpo_jx", "@choose-skill", 1, 1, false, info.SkillPosition);
                room.HandleAcquireDetachSkills(pangtong, skill, true);
            }

            return false; //return pangtong.Hp > 0 || pangtong.isDead();
        }
    }

    public class JiemingJX : TriggerSkill
    {
        public JiemingJX() : base("jieming_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged, TriggerEvent.Death };
            skill_type = SkillType.Masochism;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && base.Triggerable(player, room) && data is DamageStruct damage)
            {
                return new TriggerStruct(Name, player)
                {
                    Times = damage.Damage
                };
            }
            else if (triggerEvent == TriggerEvent.Death && RoomLogic.PlayerHasSkill(room, player, Name))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetAlivePlayers(), Name, "@jieming-invoke", true, true, info.SkillPosition);
            if (target != null)
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", (target == player ? 2 : 1), gsk.General, gsk.SkinId);
                room.SetTag(Name, target);

                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is Player to)
            {
                room.RemoveTag(Name);
                int upper = Math.Min(5, to.MaxHp);
                room.DrawCards(to, new DrawCardStruct(upper, player, Name));
                if (to.Alive && to.HandcardNum > upper)
                {
                    int count = to.HandcardNum - upper;
                    room.AskForDiscard(to, Name, count, count, false, false, string.Format("@jieming_jx-disacard:::{0}", count), false, info.SkillPosition);
                }
            }

            return false;
        }
    }

    public class TuntianJX : TriggerSkill
    {
        public TuntianJX() : base("tuntian_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.FinishJudge, TriggerEvent.EventLoseSkill };
            priority.Add(TriggerEvent.CardsMoveOneTime, 3);
            priority.Add(TriggerEvent.FinishJudge, -1);
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move
                && move.From != null && base.Triggerable(move.From, room) && move.From.Phase == PlayerPhase.NotActive
                && (move.From_places.Contains(Place.PlaceHand) || move.From_places.Contains(Place.PlaceEquip))
                    && !(move.To == move.From && (move.To_place == Place.PlaceHand || move.To_place == Place.PlaceEquip)))
                move.From.AddMark("tuntian_jx_postpone");
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name)
                room.ClearOnePrivatePile(player, "field");
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null
                && base.Triggerable(move.From, room) && move.From.Phase != PlayerPhase.NotActive && move.From.GetMark("tuntian_jx_postpone") > 0
                && (move.From_places.Contains(Place.PlaceHand) || move.From_places.Contains(Place.PlaceEquip))
                    && !(move.To == move.From && (move.To_place == Place.PlaceHand || move.To_place == Place.PlaceEquip)))
            {
                if (!room.ContainsTag("judge") || (int)room.GetTag("judge") == 0)
                    skill_list.Add(new TriggerStruct(Name, move.From));
            }
            else
            {
                List<Player> dengais = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player dengai in dengais)
                {
                    int postponed = dengai.GetMark("tuntian_jx_postpone");
                    if (postponed > 0)
                        skill_list.Add(new TriggerStruct(Name, dengai));
                }
            }

            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player dengai, TriggerStruct info)
        {
            dengai.RemoveMark("tuntian_jx_postpone");
            if (room.AskForSkillInvoke(dengai, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, dengai, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player dengai, TriggerStruct info)
        {
            JudgeStruct judge = new JudgeStruct
            {
                Pattern = ".",
                Good = true,
                PlayAnimation = false,
                Reason = Name,
                Who = dengai
            };
            room.Judge(ref judge);
            if (dengai.Alive)
            {
                if (judge.Card.Suit == WrappedCard.CardSuit.Heart)
                    room.ObtainCard(dengai, judge.Card);
                else
                {
                    room.AddToPile(dengai, "field", judge.Card);
                    Thread.Sleep(300);
                }
            }

            return false;
        }
    }

    public class TuntianJXDistance : DistanceSkill
    {
        public TuntianJXDistance() : base("#tuntian_jx")
        {
        }
        public override int GetCorrect(Room room, Player from, Player to, WrappedCard card = null)
        {
            if (RoomLogic.PlayerHasShownSkill(room, from, "tuntian_jx"))
            {
                int correct = 0;
                if (card != null)
                    foreach (int id in card.SubCards)
                        if (from.GetPile("field").Contains(id))
                            correct += 1;
                return -from.GetPile("field").Count + correct;
            }
            else
                return 0;
        }
    }

    public class Zaoxian : PhaseChangeSkill
    {
        public Zaoxian() : base("zaoxian")
        {
            frequency = Frequency.Wake;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Start && player.GetMark(Name) == 0 && base.Triggerable(player, room) && player.GetPile("field").Count >= 3)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            room.SetPlayerMark(player, Name, 1);
            room.SendCompulsoryTriggerLog(player, Name);

            room.LoseMaxHp(player);
            if (player.Alive)
                room.HandleAcquireDetachSkills(player, "jixi", true);

            return false;
        }
    }

    public class QiangxiJXCard : SkillCard
    {
        public static string ClassName = "QiangxiJXCard";
        public QiangxiJXCard() : base(ClassName)
        {
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (targets.Count > 0 || to_select == Self || Self.HasFlag(string.Format("qiangxi-{0}", to_select.Name)))
                return false;

            return true;
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            card_use.From.SetFlags(string.Format("qiangxi-{0}", card_use.To[0].Name));
            if (card_use.Card.SubCards.Count == 0)
                room.Damage(new DamageStruct("qiangxi_jx", null, card_use.From));

            base.Use(room, card_use);
        }
        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            room.Damage(new DamageStruct("qiangxi_jx", effect.From, effect.To));
        }
    }

    public class QiangxiJX : TriggerSkill
    {
        public QiangxiJX() : base("qiangxi_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging };
            view_as_skill = new QiangxiJXVS();
            skill_type = SkillType.Attack;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play)
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (p.HasFlag(string.Format("qiangxi-{0}", p.Name)))
                        p.SetFlags(string.Format("-qiangxi-{0}", p.Name));
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return new TriggerStruct();
        }
    }

    public class QiangxiJXVS : ViewAsSkill
    {
        public QiangxiJXVS() : base("qiangxi_jx")
        {
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => player.UsedTimes(QiangxiJXCard.ClassName) < 2;
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            //if (player.HasFlag("qiangxi_weapon")) return false;
            FunctionCard fcard = Engine.GetFunctionCard(to_select.Name);
            return selected.Count == 0 && fcard is Weapon && !RoomLogic.IsJilei(room, player, to_select);
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 0)
            {
                WrappedCard card = new WrappedCard(QiangxiJXCard.ClassName)
                {
                    Skill = Name,
                    ShowSkill = Name
                };
                return card;
            }
            else if (cards.Count == 1)
            {
                WrappedCard card = new WrappedCard(QiangxiJXCard.ClassName)
                {
                    Skill = Name,
                    ShowSkill = Name
                };
                card.AddSubCards(cards);
                return card;
            }
            else
                return null;
        }

        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            index = 2 - card.SubCards.Count;
        }
    }

    public class Ninger : TriggerSkill
    {
        public Ninger() : base("ninger")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Replenish;
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Damaged)
                player.AddMark(Name);
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                foreach (Player p in room.GetAlivePlayers())
                    p.SetMark(Name, 0);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && player != null && player.GetMark(Name) == 2 && data is DamageStruct damage)
            {
                if (base.Triggerable(player, room))
                    return new TriggerStruct(Name, player);
                else if (base.Triggerable(damage.From, room))
                    return new TriggerStruct(Name, damage.From);
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            room.DrawCards(ask_who, 1, Name);
            if (ask_who.Alive && player.Alive && RoomLogic.CanDiscard(room, ask_who, player, "ej") && player.GetCards("ej").Count > 0)
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                int id = room.AskForCardChosen(ask_who, player, "ej", Name, false, HandlingMethod.MethodDiscard);
                if (id >= 0) room.ThrowCard(id, player, ask_who);
            }
            return false;
        }
    }

    public class ShensuJXCard : SkillCard
    {
        public static string ClassName = "ShensuJXCard";
        public ShensuJXCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            WrappedCard slash = new WrappedCard(Slash.ClassName)
            {
                Skill = "shensu_jx",
                DistanceLimited = false
            };
            return Slash.Instance.TargetFilter(room, targets, to_select, Self, slash);
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            if (room.GetRoomState().GetCurrentCardUsePattern().EndsWith("3"))
                room.TurnOver(card_use.From);

            List<Player> targets = new List<Player>(card_use.To);
            if (targets.Count > 0)
            {

                room.SetTag("shensu_invoke" + card_use.From.Name, targets);
            }
        }
    }

    public class ShensuVS : ViewAsSkill
    {
        public ShensuVS() : base("shensu_jx")
        {
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => false;
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern) => pattern.StartsWith("@@shensu_jx");
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (room.GetRoomState().GetCurrentCardUsePattern().EndsWith("1"))
                return false;
            else
                return selected.Count == 0 && Engine.GetFunctionCard(to_select.Name) is EquipCard && !RoomLogic.IsJilei(room, player, to_select);
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (room.GetRoomState().GetCurrentCardUsePattern().EndsWith("1") || room.GetRoomState().GetCurrentCardUsePattern().EndsWith("3"))
            {
                if (cards.Count == 0)
                {
                    WrappedCard card = new WrappedCard(ShensuJXCard.ClassName)
                    {
                        Skill = Name
                    };
                    return card;
                }
            }
            else if (cards.Count == 1)
            {
                WrappedCard card = new WrappedCard(ShensuJXCard.ClassName)
                {
                    Skill = Name
                };
                card.AddSubCards(cards);
                return card;
            }
            return null;
        }
    }

    public class ShensuJX : TriggerSkill
    {
        public ShensuJX() : base("shensu_jx")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            view_as_skill = new ShensuVS();
            skill_type = SkillType.Attack;
        }
        public override bool CanPreShow() => true;
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player xiahouyuan, ref object data, Player ask_who)
        {
            if (!base.Triggerable(xiahouyuan, room) || !Slash.IsAvailable(room, xiahouyuan))
                return new TriggerStruct();

            PhaseChangeStruct change = (PhaseChangeStruct)data;
            if (change.To == PlayerPhase.Judge && !xiahouyuan.IsSkipped(PlayerPhase.Judge) && !xiahouyuan.IsSkipped(PlayerPhase.Draw))
            {
                return new TriggerStruct(Name, xiahouyuan);
            }
            else if (change.To == PlayerPhase.Play && RoomLogic.CanDiscard(room, xiahouyuan, xiahouyuan, "he") && !xiahouyuan.IsSkipped(PlayerPhase.Play))
            {
                return new TriggerStruct(Name, xiahouyuan);
            }
            if (change.To == PlayerPhase.Discard && !xiahouyuan.IsSkipped(PlayerPhase.Discard))
            {
                return new TriggerStruct(Name, xiahouyuan);
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player xiahouyuan, ref object data, Player ask_who, TriggerStruct info)
        {
            PhaseChangeStruct change = (PhaseChangeStruct)data;
            if (change.To == PlayerPhase.Judge && room.AskForUseCard(xiahouyuan, RespondType.Skill, "@@shensu_jx1", "@shensu_jx1", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition) != null)
            {
                if (room.ContainsTag("shensu_invoke" + xiahouyuan.Name))
                {
                    room.SkipPhase(xiahouyuan, PlayerPhase.Judge);
                    room.SkipPhase(xiahouyuan, PlayerPhase.Draw);
                    return info;
                }
            }
            else if (change.To == PlayerPhase.Play && room.AskForUseCard(xiahouyuan, RespondType.Skill, "@@shensu_jx2", "@shensu_jx2", null, -1, HandlingMethod.MethodDiscard, true, info.SkillPosition) != null)
            {
                if (room.ContainsTag("shensu_invoke" + xiahouyuan.Name))
                {
                    room.SkipPhase(xiahouyuan, PlayerPhase.Play);
                    return info;
                }
            }
            else if (change.To == PlayerPhase.Discard && room.AskForUseCard(xiahouyuan, RespondType.Skill, "@@shensu_jx3", "@shensu_jx3", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition) != null)
            {
                if (room.ContainsTag("shensu_invoke" + xiahouyuan.Name))
                {
                    room.SkipPhase(xiahouyuan, PlayerPhase.Discard);
                    return info;
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Alive && data is PhaseChangeStruct)
            {
                List<Player> targets = (List<Player>)room.GetTag("shensu_invoke" + player.Name);
                room.RemoveTag("shensu_invoke" + player.Name);

                WrappedCard slash = new WrappedCard(Slash.ClassName)
                {
                    Skill = "_shensu",
                    DistanceLimited = false
                };

                room.UseCard(new CardUseStruct(slash, player, targets) { Reason = CardUseReason.CARD_USE_REASON_RESPONSE_USE });
            }

            return false;
        }

        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            index = card.SubCards.Count + 1;
        }
    }

    public class Shebian : TriggerSkill
    {
        public Shebian() : base("shebian")
        {
            events.Add(TriggerEvent.TurnedOver);
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return base.Triggerable(player, room) ? new TriggerStruct(Name, player) : new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetAlivePlayers())
            {
                if (p.GetCards("e").Count > 0)
                    targets.Add(p);
            }
            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@shebian", true, true, info.SkillPosition);
                if (target != null)
                {
                    room.SetTag(Name, target);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target1 = (Player)room.GetTag(Name);
            room.RemoveTag(Name);

            int card_id = room.AskForCardChosen(player, target1, "e", Name);
            WrappedCard card = room.GetCard(card_id);
            Place place = room.GetCardPlace(card_id);

            FunctionCard fcard = Engine.GetFunctionCard(card.Name);
            EquipCard equip = (EquipCard)fcard;
            int equip_index = (int)equip.EquipLocation();

            List<Player> tos = new List<Player>();
            foreach (Player p in room.GetAlivePlayers())
            {
                if (p.GetEquip(equip_index) < 0 && RoomLogic.CanPutEquip(player, card))
                    tos.Add(p);
            }

            room.SetTag("MouduanTarget", target1);
            string position = info.SkillPosition;
            Player to = room.AskForPlayerChosen(player, tos, Name, "@shebian-to:::" + card.Name, false, false, position);
            room.RemoveTag("MouduanTarget");
            if (to != null)
            {
                if (to != player)
                {
                    ResultStruct result = player.Result;
                    result.Assist++;
                    player.Result = result;
                }

                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, target1.Name, to.Name);
                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_TRANSFER, player.Name, Name, null)
                {
                    Card = card
                };
                room.MoveCardTo(card, target1, to, place, reason);
            }

            return false;
        }
    }

    public class QiaobianJX : TriggerSkill
    {
        public QiaobianJX() : base("qiaobian_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.EventPhaseStart, TriggerEvent.GameStart, TriggerEvent.EventLoseSkill };
            view_as_skill = new QiaobianJXVS();
            skill_type = SkillType.Wizzard;
        }
        private readonly List<string> phase_strings = new List<string> { "round_start" , "start" , "judge" , "draw"
                , "play" , "discard", "finish" , "not_active" };

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
            {
                player.AddMark(Name, 2);
                room.SetPlayerStringMark(player, Name, "2");
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish)
            {
                List<int> ids = player.ContainsTag(Name) ? (List<int>)player.GetTag(Name) : new List<int>();
                if (ids.Count == 0 || !ids.Contains(player.HandcardNum))
                {
                    player.AddMark(Name);
                    room.SetPlayerStringMark(player, Name, player.GetMark(Name).ToString());
                    ids.Add(player.HandcardNum);
                    player.SetTag(Name, ids);
                }
            }
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name)
            {
                player.RemoveTag(Name);
                player.SetMark(Name, 0);
                room.RemovePlayerStringMark(player, Name);
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && base.Triggerable(player, room)
                && (change.To == PlayerPhase.Judge || change.To == PlayerPhase.Draw || change.To == PlayerPhase.Play || change.To == PlayerPhase.Discard)
                && (!player.IsNude() && RoomLogic.CanDiscard(room, player, player, "he") || player.GetMark(Name) > 0))
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player zhanghe, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is PhaseChangeStruct change)
            {
                int index = (int)(change.To);
                string prompt = string.Format("@qiaobian_jx:::{0}", phase_strings[index]);
                if (room.AskForSkillInvoke(zhanghe, Name, prompt, info.SkillPosition))
                {
                    bool lose_mark = false;
                    if (!zhanghe.IsNude() && RoomLogic.CanDiscard(room, zhanghe, zhanghe, "he"))
                    {
                        bool option = zhanghe.GetMark(Name) > 0;
                        lose_mark = !room.AskForDiscard(zhanghe, Name, 1, 1, option, true, option ? "@qiaobian_jx-optional" : "@qiaobian_jx-discard", true, info.SkillPosition);
                    }

                    if (lose_mark)
                    {
                        zhanghe.AddMark(Name, -1);
                        if (zhanghe.GetMark(Name) > 0)
                            room.SetPlayerStringMark(zhanghe, Name, zhanghe.GetMark(Name).ToString());
                        else
                            room.RemovePlayerStringMark(zhanghe, Name);
                    }

                    if (zhanghe.Alive)
                    {
                        room.BroadcastSkillInvoke(Name, zhanghe, info.SkillPosition);
                        room.SkipPhase(zhanghe, change.To);
                        return info;
                    }
                }
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            PhaseChangeStruct change = (PhaseChangeStruct)data;
            int index = 0;
            switch (change.To)
            {
                case PlayerPhase.RoundStart:
                case PlayerPhase.Start:
                case PlayerPhase.Finish:
                case PlayerPhase.PhaseNone:
                case PlayerPhase.NotActive: return false;

                case PlayerPhase.Judge: index = 1; break;
                case PlayerPhase.Draw: index = 2; break;
                case PlayerPhase.Play: index = 3; break;
                case PlayerPhase.Discard: index = 4; break;
            }
            if (index == 2 || index == 3)
            {
                player.SetMark("qiaobianPhase", (int)change.To);
                string use_prompt = string.Format("@qiaobian-{0}", index);
                room.AskForUseCard(player, RespondType.Skill, "@@qiaobian_jx", use_prompt, null, index, HandlingMethod.MethodUse, true, info.SkillPosition);
            }
            return false;
        }
    }

    public class QiaobianJXVS : ZeroCardViewAsSkill
    {
        public QiaobianJXVS() : base("qiaobian_jx") { }

        public override bool IsAvailable(Room room, Player invoker, CardUseReason reason, RespondType respond, string pattern, string position = null)
        {
            return reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE && pattern == "@@qiaobian_jx";
        }
        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(QiaobianCard.ClassName)
            {
                Skill = Name,
                Mute = true
            };
        }
    }

    #region 吴
    public class BuquJX : TriggerSkill
    {
        public BuquJX() : base("buqu_jx")
        {
            events.Add(TriggerEvent.AskForPeaches);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Defense;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DyingStruct dying && dying.Who == player && base.Triggerable(player, room) && player.Hp <= 0)
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (RoomLogic.PlayerHasShownSkill(room, player, Name) || room.AskForSkillInvoke(player, Name, null, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name, true);
            int id = room.GetNCards(1)[0];
            int num = room.GetCard(id).Number;
            bool duplicate = false;
            List<int> buqu = player.GetPile(Name);
            room.AddToPile(player, Name, id);
            Thread.Sleep(500);

            foreach (int card_id in buqu)
            {
                if (room.GetCard(card_id).Number == num)
                {
                    duplicate = true;
                    LogMessage log = new LogMessage
                    {
                        Type = "#BuquDuplicate",
                        From = player.Name
                    };
                    List<string> number_string = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
                    log.Arg = number_string[num - 1];
                    room.SendLog(log);

                    log = new LogMessage
                    {
                        Type = "$BuquDuplicateItem",
                        From = player.Name,
                        Card_str = card_id.ToString()
                    };
                    room.SendLog(log);
                    break;
                }
            }
            if (duplicate)
            {
                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_REMOVE_FROM_PILE, null, Name, null);
                List<int> ints = new List<int> { id };
                room.ThrowCard(ref ints, reason, null);
                Thread.Sleep(1000);
            }
            else
            {
                RecoverStruct recover = new RecoverStruct
                {
                    Recover = 1 - player.Hp,
                    Who = player
                };
                room.Recover(player, recover, true);
            }

            return false;
        }
    }

    public class BuquMax : MaxCardsSkill
    {
        public BuquMax() : base("#buqu-max") { }

        public override int GetFixed(Room room, Player target)
        {
            if (target.GetPile("buqu_jx").Count > 0)
                return target.GetPile("buqu_jx").Count;

            return -1;
        }
    }

    public class BuquJXClear : DetachEffectSkill
    {
        public BuquJXClear() : base("buqu_jx", "buqu_jx")
        {
            frequency = Frequency.Compulsory;
        }
    }
    public class FenjiJX : TriggerSkill
    {
        public FenjiJX() : base("fenji_jx")
        {
            events.Add(TriggerEvent.CardsMoveOneTime);
            skill_type = SkillType.Replenish;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (data is CardsMoveOneTimeStruct move && move.From != null && move.From.Alive && move.From_places.Contains(Place.PlaceHand))
            {
                if ((move.Reason.Reason == MoveReason.S_REASON_EXTRACTION
                    || (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD)
                    && !string.IsNullOrEmpty(move.Reason.PlayerId) && move.Reason.PlayerId != move.From.Name)
                {
                    List<Player> zhoutais = RoomLogic.FindPlayersBySkillName(room, Name);
                    foreach (Player p in zhoutais)
                    {
                        triggers.Add(new TriggerStruct(Name, p));
                    }
                }
            }

            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardsMoveOneTimeStruct move && move.From.Alive && ask_who.Alive)
            {
                move.From.SetFlags("fenji_target");
                bool invoke = room.AskForSkillInvoke(ask_who, Name, move.From, info.SkillPosition);
                move.From.SetFlags("-fenji_target");

                if (invoke)
                {
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, move.From.Name);
                    return info;
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardsMoveOneTimeStruct move && move.From.Alive)
            {
                room.DrawCards(move.From, new DrawCardStruct(2, ask_who, Name));
                if (ask_who.Alive)
                    room.LoseHp(ask_who);
            }

            return false;
        }
    }

    public class TianxiangJXViewAsSkill : OneCardViewAsSkill
    {
        public TianxiangJXViewAsSkill() : base("tianxiang_jx")
        {
        }
        public override bool IsAvailable(Room room, Player invoker, CardUseReason reason, RespondType respond, string pattern, string position = null)
        {
            return reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE && pattern == "@@tianxiang_jx";
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard tianxiangCard = new WrappedCard(TianxiangCard.ClassName);
            tianxiangCard.AddSubCard(card);
            tianxiangCard.Skill = Name;
            return tianxiangCard;
        }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            if (RoomLogic.IsJilei(room, player, to_select)) return false;
            string pat = ".|heart|.|hand";
            CardPattern pattern = Engine.GetPattern(pat);
            return pattern.Match(player, room, to_select);
        }
    }

    public class TianxiangJX : TriggerSkill
    {
        public TianxiangJX() : base("tianxiang_jx")
        {
            events.Add(TriggerEvent.DamageDefined);
            skill_type = SkillType.Defense;
            view_as_skill = new TianxiangJXViewAsSkill();
        }
        public override bool CanPreShow() => true;
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player xiaoqiao, ref object data, Player ask_who)
        {
            if (base.Triggerable(xiaoqiao, room) && RoomLogic.CanDiscard(room, xiaoqiao, xiaoqiao, "h"))
                return new TriggerStruct(Name, xiaoqiao);
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player xiaoqiao, ref object data, Player ask_who, TriggerStruct info)
        {
            xiaoqiao.SetFlags("-tianxiang_invoke");
            room.SetTag("TianxiangDamage", data);
            room.AskForUseCard(xiaoqiao, RespondType.Skill, "@@tianxiang_jx", "@tianxiang_jx-card", null, -1, HandlingMethod.MethodDiscard, true, info.SkillPosition);
            room.RemoveTag("TianxiangDamage");
            if (xiaoqiao.HasFlag("tianxiang_invoke"))
                return info;

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player xiaoqiao, ref object data, Player ask_who, TriggerStruct info)
        {
            LogMessage log = new LogMessage
            {
                Type = "#damaged-prevent",
                From = xiaoqiao.Name,
                Arg = Name
            };
            room.SendLog(log);

            return true;
        }
    }

    public class TianxiangSecond : TriggerSkill
    {
        public TianxiangSecond() : base("#tianxian-second")
        {
            events.Add(TriggerEvent.DamageComplete);
            frequency = Frequency.Compulsory;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DamageStruct damage && damage.To == player && player.ContainsTag("tianxiang_target") && player.HasFlag("tianxiang_invoke"))
            {
                Player target = room.FindPlayer((string)player.GetTag("tianxiang_target"));
                if (target != null && target.Alive)
                {
                    return new TriggerStruct(Name, player);
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player xiaoqiao, ref object data, Player player, TriggerStruct info)
        {
            Player target = room.FindPlayer((string)xiaoqiao.GetTag("tianxiang_target"));
            xiaoqiao.SetFlags("-tianxiang_invoke");
            DamageStruct damage = (DamageStruct)data;
            room.SetTag("TianxiangDamage", data);
            string choice = room.AskForChoice(xiaoqiao, "tianxiang_jx", "damage+losehp", new List<string> { "@to-player:" + target.Name }, null, info.SkillPosition);
            room.RemoveTag("TianxiangDamage");
            xiaoqiao.RemoveTag("tianxiang_target");

            if (choice == "damage")
            {
                room.Damage(new DamageStruct("tianxiang_jx", damage.From, target));
                if (target.Alive)
                    room.DrawCards(target, Math.Min(5, target.GetLostHp()), "tianxiang_jx");
            }
            else if (xiaoqiao.GetTag("tianxiang_card") is int id)
            {
                room.LoseHp(target);
                if (target.Alive && room.GetCardPlace(id) == Place.DiscardPile)
                    room.ObtainCard(target, room.GetCard(id), new CardMoveReason(MoveReason.S_REASON_RECYCLE, target.Name, "tianxiang_jx", string.Empty));
            }
            xiaoqiao.RemoveTag("tianxiang_card");

            return false;
        }
    }

    public class HongyanJXFilter : FilterSkill
    {
        public HongyanJXFilter() : base("hongyan_jx")
        {
        }

        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            int id = to_select.GetEffectiveId();
            return to_select.Suit == WrappedCard.CardSuit.Spade
                    && (room.GetCardPlace(id) == Place.PlaceEquip
                        || room.GetCardPlace(id) == Place.PlaceHand || room.GetCardPlace(id) == Place.PlaceJudge);
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            return base.ViewAs(room, cards, player);
        }
        public override void ViewAs(Room room, ref RoomCard card, Player player)
        {
            card.Skill = Name;
            card.SetSuit(WrappedCard.CardSuit.Heart);
        }
    }
    public class HongyanJX : TriggerSkill
    {
        public HongyanJX() : base("hongyan_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.FinishRetrial };
            frequency = Frequency.Compulsory;
            view_as_skill = new HongyanJXFilter();
            skill_type = SkillType.Alter;
        }

        public override bool CanPreShow() => true;
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.FinishRetrial && base.Triggerable(player, room) && !RoomLogic.PlayerHasShownSkill(room, player, Name)
                && data is JudgeStruct judge && judge.Who == player && judge.Card.Suit == WrappedCard.CardSuit.Spade)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null
                && (move.From_places.Contains(Place.PlaceEquip) || move.From_places.Contains(Place.PlaceHand)) && base.Triggerable(move.From, room)
                && (move.To != move.From || move.To_place != Place.PlaceHand) && move.From.Phase == PlayerPhase.NotActive
                && ((move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_RESPONSE
                || (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_USE
                || (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD))
            {
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    if ((move.From_places[i] == Place.PlaceEquip || move.From_places[i] == Place.PlaceHand) && room.GetCard(move.Card_ids[i]).Suit == WrappedCard.CardSuit.Heart)
                        return new TriggerStruct(Name, move.From);
                }
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.FinishRetrial)
                return room.AskForSkillInvoke(player, Name, data, info.SkillPosition) ? info : new TriggerStruct();
            else return RoomLogic.PlayerHasShownSkill(room, ask_who, Name) || room.AskForSkillInvoke(ask_who, Name, null, info.SkillPosition) ? info : new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.FinishRetrial && data is JudgeStruct judge)
            {
                List<int> cards = new List<int> { judge.Card.GetEffectiveId() };
                room.FilterCards(player, cards, true);
                room.UpdateJudgeResult(ref judge);
                data = judge;
            }
            else
            {
                room.SendCompulsoryTriggerLog(ask_who, Name, true);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.DrawCards(ask_who, 1, Name);
            }
            return false;
        }
        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            index = -2;
        }
    }

    public class JiangJX : TriggerSkill
    {
        public JiangJX() : base("jiang_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetConfirmed, TriggerEvent.TargetChosen, TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
            frequency = Frequency.Frequent;
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD
                && move.To_place == Place.PlaceTable && base.Triggerable(move.From, room) && room.ContainsTag(Name))
            {
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    int card_id = move.Card_ids[i];
                    WrappedCard card = room.GetCard(card_id);
                    if (room.GetCardPlace(card_id) == Place.PlaceTable && move.From_places[i] == Place.PlaceHand && (card.Name.Contains(Slash.ClassName) && WrappedCard.IsRed(card.Suit) || card.Name == Duel.ClassName))
                    {
                        card.SetFlags(Name);
                        room.SetTag(Name, true);
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                room.RemoveTag(Name);
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && move.To_place == Place.DiscardPile)
            {
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    int card_id = move.Card_ids[i];
                    if (room.GetCardPlace(card_id) == Place.DiscardPile && move.From_places[i] == Place.PlaceTable && room.GetCard(card_id).HasFlag(Name))
                    {
                        foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                            triggers.Add(new TriggerStruct(Name, p));
                        break;
                    }
                }
            }
            else if ((triggerEvent == TriggerEvent.TargetChosen || triggerEvent == TriggerEvent.TargetConfirmed) && base.Triggerable(player, room) && data is CardUseStruct use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Duel || (fcard is Slash && WrappedCard.IsRed(RoomLogic.GetCardSuit(room, use.Card))))
                {
                    if (triggerEvent == TriggerEvent.TargetChosen || use.To.Contains(player))
                        triggers.Add(new TriggerStruct(Name, player));
                }
            }
            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player sunce, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move)
            {
                List<int> ids = new List<int>();
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    int card_id = move.Card_ids[i];
                    if (room.GetCardPlace(card_id) == Place.DiscardPile && move.From_places[i] == Place.PlaceTable && room.GetCard(card_id).HasFlag(Name))
                        ids.Add(card_id);
                }
                if (ids.Count > 0)
                {
                    List<int> gets = room.NotifyChooseCards(ask_who, ids, Name, 1, 0, "@jiang_jx", string.Empty, info.SkillPosition);
                    if (gets.Count > 0)
                    {
                        ask_who.SetTag(Name, gets);
                        room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                        room.NotifySkillInvoked(ask_who, Name);
                        room.LoseHp(ask_who);
                        return info;
                    }
                }
            }
            else if (room.AskForSkillInvoke(sunce, Name, data, info.SkillPosition) && data is CardUseStruct use)
            {
                int index = 1;
                if (use.From != sunce)
                    index = 2;
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, sunce, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", index, gsk.General, gsk.SkinId);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime)
            {
                if (ask_who.Alive && ask_who.GetTag(Name) is List<int> ids)
                {
                    ask_who.RemoveTag(Name);
                    room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, ask_who.Name, Name, string.Empty));
                }
            }
            else
            {
                room.DrawCards(player, 1, Name);
            }
            return false;
        }
    }
    public class JiangClear : TriggerSkill
    {
        public JiangClear() : base("#jiang-clear")
        {
            events.Add(TriggerEvent.CardsMoveOneTime);
        }
        public override int Priority => 0;
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            CardsMoveOneTimeStruct move = (CardsMoveOneTimeStruct)data;
            if (move.From != null && move.To_place == Place.DiscardPile && move.From_places.Contains(Place.PlaceTable))
            {
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    WrappedCard card = room.GetCard(move.Card_ids[i]);
                    if (move.From_places[i] == Place.PlaceTable && card.HasFlag("jiang_jx"))
                        card.SetFlags("-jiang_jx");
                }
            }
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class Hunzi : PhaseChangeSkill
    {
        public Hunzi() : base("hunzi")
        {
            frequency = Frequency.Wake;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Start && player.GetMark(Name) == 0 && base.Triggerable(player, room) && player.Hp == 1)
                return new TriggerStruct(Name, player);
            else if (player.Phase == PlayerPhase.Finish && player.Alive && player.HasFlag(Name))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            if (player.Phase == PlayerPhase.Start)
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.DoSuperLightbox(player, info.SkillPosition, Name);
                room.SetPlayerMark(player, Name, 1);
                room.SendCompulsoryTriggerLog(player, Name);

                room.LoseMaxHp(player);
                if (player.Alive)
                {
                    player.SetFlags(Name);
                    List<string> skills = new List<string> { "yinghun_sunce", "yingzi_sunce" };
                    room.HandleAcquireDetachSkills(player, skills);
                }
            }
            else
            {
                List<string> choices = new List<string> { "draw" };
                if (player.IsWounded())
                    choices.Add("recover");
                string choice = room.AskForChoice(player, Name, string.Join("+", choices), null, null, info.SkillPosition);
                if (choice == "draw")
                    room.DrawCards(player, 2, Name);
                else
                    room.Recover(player);
            }

            return false;
        }
    }

    public class Zhiba : TriggerSkill
    {
        public Zhiba() : base("zhiba")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.EventAcquireSkill, TriggerEvent.Revived };
            lord_skill = true;
            view_as_skill = new ZhibaLordVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Revived)
            {
                Player lord = RoomLogic.FindPlayerBySkillName(room, Name);
                if (lord == player)
                {
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.Kingdom == "wu" || p.General1 == "zuoci")
                            room.HandleAcquireDetachSkills(p, "zhibavs", true, false);
                    }
                }
                else if (player.Kingdom == "wu" || player.General1 == "zuoci")
                {
                    room.HandleAcquireDetachSkills(player, "zhibavs", true, false);
                }
                return;
            }
            bool add = false;
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                add = true;
            else if (triggerEvent == TriggerEvent.EventAcquireSkill && data is InfoStruct info && info.Info == Name)
                add = true;

            if (add)
            {
                if (!room.Skills.Contains("zhibavs"))
                    room.Skills.Add("zhibavs");
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.Kingdom == "wu" || p.General1 == "zuoci")
                        room.HandleAcquireDetachSkills(p, "zhibavs", true, false);
                }
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return new TriggerStruct();
        }
    }

    public class ZhibaLordVS : ZeroCardViewAsSkill
    {
        public ZhibaLordVS() : base("zhiba")
        {
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(ZhibaCard.ClassName) && !player.IsKongcheng();
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard zb = new WrappedCard(ZhibaCard.ClassName)
            {
                Skill = Name
            };
            return zb;
        }
    }

    public class ZhibaVS : ZeroCardViewAsSkill
    {
        public ZhibaVS() : base("zhibavs")
        {
            attached_lord_skill = true;
            frequency = Frequency.Compulsory;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            List<Player> jiaozhu = RoomLogic.FindPlayersBySkillName(room, "zhiba");
            return jiaozhu.Count > 0 && player.Kingdom == "wu" && !player.HasUsed(ZhibaCard.ClassName) && !player.IsKongcheng();
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard zb = new WrappedCard(ZhibaCard.ClassName)
            {
                Skill = Name
            };
            return zb;
        }
    }

    public class ZhibaCard : SkillCard
    {
        public static string ClassName = "ZhibaCard";
        public ZhibaCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (card.Skill == "zhiba")
            {
                return targets.Count == 0 && to_select != Self && to_select.Kingdom == "wu" && RoomLogic.CanBePindianBy(room, to_select, Self);
            }
            else
            {
                List<Player> jiaozhu = RoomLogic.FindPlayersBySkillName(room, "zhiba");
                if (jiaozhu.Count == 1 && RoomLogic.CanBePindianBy(room, jiaozhu[0], Self)) return false;

                return targets.Count == 0 && jiaozhu.Contains(to_select) && RoomLogic.CanBePindianBy(room, to_select, Self);
            }
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            if (card.Skill == "zhiba")
            {
                return targets.Count == 1;
            }
            else
            {
                List<Player> jiaozhu = RoomLogic.FindPlayersBySkillName(room, "zhiba");
                return (jiaozhu.Count == 1 && targets.Count == 0 && RoomLogic.CanBePindianBy(room, jiaozhu[0], Self)) || (targets.Count == 1 && jiaozhu.Contains(targets[0]));
            }
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            if (card_use.Card.Skill == "zhiba")
            {
                Player player = card_use.From;
                Player target = card_use.To[0];
                room.BroadcastSkillInvoke("zhiba", player);
                room.NotifySkillInvoked(player, "zhiba");

                PindianStruct pd = room.PindianSelect(player, target, "zhiba");
                room.Pindian(ref pd);
                if (pd.From_number >= pd.To_numbers[0] && room.AskForSkillInvoke(player, "zhiba", "@zhiba"))
                {
                    List<int> ids = new List<int>();
                    if (room.GetCardPlace(pd.From_card.Id) == Place.DiscardPile)
                        ids.Add(pd.From_card.Id);
                    if (room.GetCardPlace(pd.To_cards[0].Id) == Place.DiscardPile)
                        ids.Add(pd.To_cards[0].Id);

                    if (ids.Count > 0 && player.Alive)
                        room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name));
                }
            }
            else
            {
                List<Player> jiaozhu = RoomLogic.FindPlayersBySkillName(room, "zhiba");
                Player target = null, player = card_use.From;
                if (jiaozhu.Count == 1 && card_use.To.Count == 0)
                    target = jiaozhu[0];
                else if (card_use.To.Count == 1 && jiaozhu.Contains(card_use.To[0]))
                    target = card_use.To[0];

                bool do_pd = room.AskForSkillInvoke(target, "zhiba", "@zhiba-refuse:" + player.Name);
                //if (target.GetMark("hunzi") > 0)
                //   do_pd = room.AskForSkillInvoke(target, "zhiba", "@zhiba-refuse:" + player.Name);

                if (do_pd)
                {
                    room.BroadcastSkillInvoke("zhiba", target);
                    room.NotifySkillInvoked(target, "zhiba");

                    PindianStruct pd = room.PindianSelect(player, target, "zhibavs");
                    room.Pindian(ref pd);
                    if (!pd.Success && room.AskForSkillInvoke(target, "zhiba", "@zhiba"))
                    {
                        List<int> ids = new List<int>();
                        if (room.GetCardPlace(pd.From_card.Id) == Place.DiscardPile)
                            ids.Add(pd.From_card.Id);
                        if (room.GetCardPlace(pd.To_cards[0].Id) == Place.DiscardPile)
                            ids.Add(pd.To_cards[0].Id);

                        if (ids.Count > 0 && target.Alive)
                            room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GOTBACK, target.Name));
                    }
                }
            }
        }
    }

    public class PoluSJ : TriggerSkill
    {
        public PoluSJ() : base("polu_sj")
        {
            events.Add(TriggerEvent.Death);
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DeathStruct death)
            {
                if (RoomLogic.PlayerHasSkill(room, player, Name))
                    return new TriggerStruct(Name, player);
                else if (death.Damage.From != null && base.Triggerable(death.Damage.From, room))
                    return new TriggerStruct(Name, death.Damage.From);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player p, ref object data, Player player, TriggerStruct info)
        {
            int count = player.ContainsTag(Name) ? (int)player.GetTag(Name) : 0;
            List<Player> targets = room.AskForPlayersChosen(player, room.GetAlivePlayers(), Name, 0, room.AliveCount(), string.Format("@polu_sj:::{0}", count + 1), true, info.SkillPosition);
            if (targets.Count > 0)
            {
                room.SortByActionOrder(ref targets);
                room.SetTag("tuxi_invoke" + player.Name, targets);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            string str = "tuxi_invoke" + ask_who.Name;
            List<Player> targets = room.ContainsTag(str) ? (List<Player>)room.GetTag(str) : new List<Player>();
            room.RemoveTag(str);

            int count = ask_who.ContainsTag(Name) ? (int)ask_who.GetTag(Name) : 0;
            count++;
            ask_who.SetTag(Name, count);

            foreach (Player p in targets)
                if (p.Alive)
                    room.DrawCards(p, new DrawCardStruct(count, ask_who, Name));

            return false;
        }
    }

    public class ZhijianJX : TriggerSkill
    {
        public ZhijianJX() : base("zhijian_jx")
        {
            view_as_skill = new ZhijianJXVS();
            events = new List<TriggerEvent> { TriggerEvent.CardUsed };
            skill_type = SkillType.Replenish;
        }


        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is EquipCard)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.DrawCards(ask_who, 1, Name);
            return false;
        }
    }

    public class ZhijianJXVS : OneCardViewAsSkill
    {
        public ZhijianJXVS() : base("zhijian_jx")
        {
            filter_pattern = "EquipCard|.|.|hand";
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard zhijian_card = new WrappedCard(ZhijianJxCard.ClassName);
            zhijian_card.AddSubCard(card);
            zhijian_card.Skill = Name;
            zhijian_card.ShowSkill = Name;
            return zhijian_card;
        }
    }

    public class ZhijianJxCard : SkillCard
    {
        public static string ClassName = "ZhijianJxCard";
        public ZhijianJxCard() : base(ClassName)
        {
            will_throw = false;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (targets.Count > 0 || to_select == Self)
                return false;
            WrappedCard equip_card = room.GetCard(card.SubCards[0]);
            FunctionCard fcard = Engine.GetFunctionCard(equip_card.Name);
            EquipCard equip = (EquipCard)fcard;
            int equip_index = (int)equip.EquipLocation();
            return to_select.GetEquip(equip_index) < 0 && RoomLogic.CanPutEquip(to_select, equip_card);
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            ResultStruct result = card_use.From.Result;
            result.Assist++;
            card_use.From.Result = result;


            FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(card_use.Card.GetEffectiveId()).Name);
            if (fcard is EquipCard equip)
            {
                int equipped_id = -1;
                int index = (int)equip.EquipLocation();
                Player target = card_use.To[0];
                if (target.HasEquip(index)) equipped_id = target.GetEquip(index);

                List<CardsMoveStruct> exchangeMove = new List<CardsMoveStruct> { };
                CardsMoveStruct move1 = new CardsMoveStruct(card_use.Card.GetEffectiveId(), target, Place.PlaceEquip, new CardMoveReason(MoveReason.S_REASON_PUT, card_use.From.Name, card_use.To[0].Name, "zhijian", string.Empty));
                move1.Reason.Card = card_use.Card;
                exchangeMove.Add(move1);
                if (equipped_id != -1)
                {
                    CardsMoveStruct move2 = new CardsMoveStruct(equipped_id, target, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_CHANGE_EQUIP, target.Name));
                    exchangeMove.Add(move2);
                }
                room.MoveCardsAtomic(exchangeMove, true);

                LogMessage log = new LogMessage
                {
                    Type = "$ZhijianEquip",
                    From = card_use.To[0].Name,
                    Card_str = card_use.Card.GetEffectiveId().ToString()
                };
                room.SendLog(log);

                if (equipped_id != -1)
                {
                    if (room.GetCardPlace(equipped_id) == Place.PlaceTable)
                    {
                        CardsMoveStruct move3 = new CardsMoveStruct(equipped_id, null, Place.DiscardPile, new CardMoveReason(MoveReason.S_REASON_CHANGE_EQUIP, target.Name));
                        room.MoveCardsAtomic(new List<CardsMoveStruct> { move3 }, true);
                    }
                }
            }
            base.Use(room, card_use);
        }
        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            room.DrawCards(effect.From, 1, "zhijian");
        }
    }

    public class GuzhengJx : TriggerSkill
    {
        public GuzhengJx() : base("guzheng_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.CardsMoveOneTime };
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging)
            {
                foreach (Player p in room.GetAlivePlayers())
                    p.SetFlags("-guzheng_jx");
            }
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.From.Alive && move.To_place == Place.DiscardPile
                && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && move.Card_ids.Count > 1)
            {
                int count = 0;
                foreach (int id in move.Card_ids)
                {
                    if (room.GetCardPlace(id) == Place.DiscardPile)
                    {
                        count++;
                        break;
                    }
                }

                if (count > 0)
                {
                    foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                        if (p != move.From && !p.HasFlag(Name))
                            skill_list.Add(new TriggerStruct(Name, p));
                }
            }

            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player erzhang, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move)
            {
                List<int> cards = new List<int>();
                foreach (int id in move.Card_ids)
                {
                    if (room.GetCardPlace(id) == Place.DiscardPile)
                        cards.Add(id);
                }
                if (cards.Count > 0)
                {
                    List<int> result = room.NotifyChooseCards(erzhang, cards, Name, 1, 0, "@guzheng:" + player.Name, null, info.SkillPosition);
                    if (result.Count > 0)
                    {
                        erzhang.SetFlags(Name);
                        ResultStruct assit = erzhang.Result;
                        assit.Assist++;
                        erzhang.Result = assit;

                        room.BroadcastSkillInvoke(Name, erzhang, info.SkillPosition);
                        room.NotifySkillInvoked(erzhang, Name);
                        int to_back = result[0];
                        room.ObtainCard(player, room.GetCard(to_back));
                        cards.Remove(to_back);
                        erzhang.SetTag("GuzhengCards", cards);
                        return info;
                    }
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player p, ref object data, Player player, TriggerStruct info)
        {
            List<int> cards = (List<int>)player.GetTag("GuzhengCards");
            player.RemoveTag("GuzhengCards");
            if (cards.Count > 0 && room.AskForSkillInvoke(player, Name, "#GuzhengObtain", info.SkillPosition))
                room.ObtainCard(player, ref cards, new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name));

            return false;
        }
    }
    
    public class Hanzhan : TriggerSkill
    {
        public Hanzhan() : base("hanzhan")
        {
            events = new List<TriggerEvent> { TriggerEvent.PindianCard, TriggerEvent.Pindian };
            priority = new Dictionary<TriggerEvent, double>
            {
                { TriggerEvent.PindianCard, 4 },
                { TriggerEvent.Pindian, 3 },
            };
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.PindianCard && data is PindianInfo info)
            {
                if (base.Triggerable(info.From, room))
                {
                    List<Player> targets = new List<Player>();
                    foreach (Player p in info.Cards.Keys)
                        if (p != info.From && info.Cards[p] == null && !p.IsKongcheng())
                            targets.Add(p);

                    if (targets.Count > 0)
                        triggers.Add(new TriggerStruct(Name, info.From, targets));
                }

                if (info.Cards[info.From] == null && !info.From.IsKongcheng())
                {
                    foreach (Player p in info.Cards.Keys)
                    {
                        if (p == info.From) continue;
                        if (base.Triggerable(p, room))
                        {
                            List<Player> targets = new List<Player>
                            {
                                info.From
                            };
                            triggers.Add(new TriggerStruct(Name, p, targets));
                        }
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.Pindian && data is PindianStruct pd)
            {
                int index = pd.Index;
                if (base.Triggerable(pd.From, room))
                {
                    if (room.GetCard(pd.From_card.Id).Name.Contains(Slash.ClassName) && room.GetCardPlace(pd.From_card.Id) == Place.PlaceTable)
                        triggers.Add(new TriggerStruct(Name, player));
                    else if (room.GetCard(pd.To_cards[index].Id).Name.Contains(Slash.ClassName) && room.GetCardPlace(pd.To_cards[index].Id) == Place.PlaceTable)
                        triggers.Add(new TriggerStruct(Name, player));
                }
                if (base.Triggerable(pd.Tos[index], room))
                {
                    if (room.GetCard(pd.From_card.Id).Name.Contains(Slash.ClassName) && room.GetCardPlace(pd.From_card.Id) == Place.PlaceTable)
                        triggers.Add(new TriggerStruct(Name, pd.Tos[index]));
                    else if (room.GetCard(pd.To_cards[index].Id).Name.Contains(Slash.ClassName) && room.GetCardPlace(pd.To_cards[index].Id) == Place.PlaceTable)
                        triggers.Add(new TriggerStruct(Name, pd.Tos[index]));
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.PindianCard && data is PindianInfo pindian && pindian.Cards[player] == null && !player.IsKongcheng())
            {
                player.SetFlags(Name);
                bool invoke = room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition);
                player.SetFlags("-hanzhan");
                if (invoke)
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                    return info;
                }
            }
            else if (triggerEvent == TriggerEvent.Pindian)
            {
                if (room.AskForSkillInvoke(ask_who, Name, data, info.SkillPosition))
                {
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.PindianCard && data is PindianInfo pindian)
            {
                List<int> hands = player.GetCards("h");
                Shuffle.shuffle(ref hands);
                int id = hands[0];
                pindian.Cards[player] = room.GetCard(id);
                data = pindian;
            }
            else if (triggerEvent == TriggerEvent.Pindian && data is PindianStruct pd)
            {
                int index = pd.To_numbers.Count - 1;
                List<int> ids = new List<int>();
                if (room.GetCard(pd.From_card.Id).Name.Contains(Slash.ClassName) && room.GetCardPlace(pd.From_card.Id) == Place.PlaceTable)
                    ids.Add(pd.From_card.Id);
                if (room.GetCard(pd.To_cards[index].Id).Name.Contains(Slash.ClassName) && room.GetCardPlace(pd.To_cards[index].Id) == Place.PlaceTable)
                    ids.Add(pd.To_cards[index].Id);

                if (ids.Count > 1)
                {
                    int from = pd.From_card.Number;
                    int to = pd.To_cards[index].Number;
                    if (from == to)
                    {
                        room.FillAG(Name, ids, ask_who, null, null, "@hanzhan");
                        int id = room.AskForAG(ask_who, ids, false, Name);
                        room.ClearAG(ask_who);
                        ids = new List<int> { id };
                    }
                    else if (from > to)
                        ids.RemoveAt(1);
                    else
                        ids.RemoveAt(0);
                }
                if (ids.Count == 1)
                    room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_GOTBACK, ask_who.Name, Name, string.Empty));
            }

            return false;
        }
    }

    public class HaoshiCCard : SkillCard
    {
        public static string ClassName = "HaoshiCCard";
        public HaoshiCCard() : base(ClassName)
        {
            will_throw = false;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (targets.Count > 0 || to_select == Self)
                return false;

            return to_select.HandcardNum == Self.GetMark("haoshi_classic");
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, card_use.From.Name,
                card_use.To[0].Name, "haoshi_classic", null);

            card_use.From.SetTag("haoshi_target", card_use.To[0].Name);
            room.SetPlayerStringMark(card_use.To[0], "haoshi_classic", string.Empty);

            ResultStruct result = card_use.From.Result;
            result.Assist += card_use.Card.SubCards.Count;
            card_use.From.Result = result;

            room.MoveCardTo(card_use.Card, card_use.To[0], Place.PlaceHand, reason);
        }
    }
    public class HaoshiClassicViewAsSkill : ViewAsSkill
    {
        public HaoshiClassicViewAsSkill() : base("haoshi_classic")
        {
        }
        public override bool IsAvailable(Room room, Player invoker, CardUseReason reason, RespondType respond, string pattern, string position = null)
        {
            return reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE && pattern == "@@haoshi_classic!";
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (player.HasEquip(to_select.Name))
                return false;

            int length = player.HandcardNum / 2;
            return selected.Count < length;
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count != player.HandcardNum / 2)
                return null;

            WrappedCard card = new WrappedCard(HaoshiCCard.ClassName)
            {
                Skill = "_haoshi_classic",
                Mute = true
            };
            card.AddSubCards(cards);
            return card;
        }
    }
    public class HaoshiClassic : TriggerSkill
    {
        public HaoshiClassic() : base("haoshi_classic")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseProceeding, TriggerEvent.TargetConfirmed, TriggerEvent.TurnStart, TriggerEvent.Death };
            view_as_skill = new HaoshiClassicViewAsSkill();
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if ((triggerEvent == TriggerEvent.TurnStart || triggerEvent == TriggerEvent.Death) && player.ContainsTag("haoshi_target") && player.GetTag("haoshi_target") is string target_name)
            {
                player.RemoveTag("haoshi_target");
                Player target = room.FindPlayer(target_name);
                if (target != null)
                    room.RemovePlayerStringMark(target, Name);
            }

        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseProceeding && base.Triggerable(player, room) && player.Phase == PlayerPhase.Draw && (int)data >= 0)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.TargetConfirmed && player.Alive && data is CardUseStruct use && player.ContainsTag("haoshi_target") && player.GetTag("haoshi_target") is string target_name)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash || fcard.IsNDTrick())
                {
                    Player target = room.FindPlayer(target_name);
                    if (target != null && !target.IsKongcheng())
                        return new TriggerStruct(Name, target);
                }
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseProceeding && room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                player.SetTag(Name, info.SkillPosition);
                return info;
            }
            else if (triggerEvent == TriggerEvent.TargetConfirmed)
                return info;

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseProceeding && data is int count)
            {
                count += 2;
                data = count;
                player.SetFlags(Name);
            }
            else if (data is CardUseStruct use)
            {
                room.SetTag(Name, player);
                List<int> ids = room.AskForExchange(ask_who, Name, 1, 0, string.Format("@haoshi-give:{0}:{1}:{2}", player.Name, use.From.Name, use.Card.Name), string.Empty, ".", null);
                room.RemoveTag(Name);
                if (ids.Count > 0)
                    room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, ask_who.Name, player.Name, Name, string.Empty), false);
            }

            return false;
        }
    }
    public class HaoshiCGive : TriggerSkill
    {
        public HaoshiCGive() : base("#haoshi_classic")
        {
            events.Add(TriggerEvent.AfterDrawNCards);
            frequency = Frequency.Compulsory;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player lusu, ref object data, Player ask_who)
        {
            if (lusu == null || !lusu.Alive) return new TriggerStruct();
            if (lusu.HasFlag("haoshi_classic"))
            {
                if (lusu.HandcardNum <= 5)
                {
                    lusu.SetFlags("-haoshi_classic");
                    return new TriggerStruct();
                }
                TriggerStruct trigger = new TriggerStruct(Name, lusu)
                {
                    SkillPosition = (string)lusu.GetTag("haoshi_classic")
                };
                return trigger;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player lusu, ref object data, Player ask_who, TriggerStruct info)
        {
            lusu.SetFlags("-haoshi_classic");
            lusu.RemoveTag("haoshi_classic");
            List<Player> other_players = room.GetOtherPlayers(lusu);
            int least = 1000;
            foreach (Player player in other_players)
                least = Math.Min(player.HandcardNum, least);
            lusu.SetMark("haoshi_classic", least);

            if (room.AskForUseCard(lusu, RespondType.Skill, "@@haoshi_classic!", "@haoshi", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition) == null)
            {
                // force lusu to give his half cards
                Player beggar = null;
                foreach (Player player in other_players)
                {
                    if (player.HandcardNum == least)
                    {
                        beggar = player;
                        break;
                    }
                }

                int n = lusu.HandcardNum / 2;
                List<int> to_give = new List<int>(), hands = lusu.GetCards("h");
                for (int i = 0; i < n; i++)
                    to_give.Add(hands[i]);

                ResultStruct result = lusu.Result;
                result.Assist += to_give.Count;
                lusu.Result = result;


                lusu.SetTag("haoshi_target", beggar.Name);
                room.SetPlayerStringMark(beggar, "haoshi_classic", string.Empty);

                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, lusu.Name, beggar.Name, "haoshi_classic", null);
                CardsMoveStruct move = new CardsMoveStruct(to_give, beggar, Place.PlaceHand, reason);
                List<CardsMoveStruct> moves = new List<CardsMoveStruct> { move };
                room.MoveCardsAtomic(moves, false);
            }
            return false;
        }
    }
    public class DimengCCard : SkillCard
    {
        public static string ClassName = "DimengCCard";
        public DimengCCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (to_select == Self) return false;

            if (targets.Count == 0) return true;

            if (targets.Count == 1)
                return (!targets[0].IsKongcheng() || !to_select.IsKongcheng()) && Math.Abs(targets[0].HandcardNum - to_select.HandcardNum) <= Self.GetCardCount(true);

            return false;
        }
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card) => targets.Count == 2;
        public override void OnUse(Room room, CardUseStruct card_use)
        {
            Player a = card_use.To[0];
            Player b = card_use.To[1];
            a.SetFlags("DimengTarget");
            b.SetFlags("DimengTarget");
            base.OnUse(room, card_use);
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player a = card_use.To[0];
            Player b = card_use.To[1];

            int n1 = a.HandcardNum;
            int n2 = b.HandcardNum;

            ResultStruct result = card_use.From.Result;
            result.Assist += Math.Abs(n1 - n2);
            card_use.From.Result = result;

            CardsMoveStruct move1 = new CardsMoveStruct(a.GetCards("h"), b, Place.PlaceHand,
                new CardMoveReason(MoveReason.S_REASON_SWAP, a.Name, b.Name, "dimeng_classic", null));
            CardsMoveStruct move2 = new CardsMoveStruct(b.GetCards("h"), a, Place.PlaceHand,
                new CardMoveReason(MoveReason.S_REASON_SWAP, b.Name, a.Name, "dimeng_classic", null));
            List<CardsMoveStruct> exchangeMove = new List<CardsMoveStruct> { move1, move2 };
            room.MoveCards(exchangeMove, false);

            LogMessage log = new LogMessage
            {
                Type = "#Dimeng",
                From = a.Name,
                To = new List<string> { b.Name },
                Arg = n1.ToString(),
                Arg2 = n2.ToString()
            };
            room.SendLog(log);
            a.SetFlags("-DimengTarget");
            b.SetFlags("-DimengTarget");

            if (card_use.From.Alive)
            {
                List<string> names = new List<string> { a.Name, b.Name };
                card_use.From.SetTag("dimeng_classic", names);
            }

            Thread.Sleep(500);
        }
    }

    public class DimengClassicEffect : TriggerSkill
    {
        public DimengClassicEffect() : base("#dimeng_classic")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseEnd };
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Play && player.Alive && player.ContainsTag("dimeng_classic"))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.GetTag("dimeng_classic") is List<string> names)
            {
                player.RemoveTag("dimeng_classic");
                Player a = room.FindPlayer(names[0]);
                Player b = room.FindPlayer(names[1]);
                if (a != null && b != null && a.HandcardNum != b.HandcardNum && !player.IsNude())
                {
                    int count = Math.Abs(a.HandcardNum - b.HandcardNum);
                    room.AskForDiscard(player, "dimeng_classic", count, count, false, true, "@dimeng-discard:::" + count.ToString(), false, info.SkillPosition);
                }
            }

            return false;
        }
    }

    public class DimengClassic : ZeroCardViewAsSkill
    {
        public DimengClassic() : base("dimeng_classic")
        {
            skill_type = SkillType.Wizzard;
        }
        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard card = new WrappedCard(DimengCCard.ClassName)
            {
                Skill = Name,
                ShowSkill = Name
            };
            return card;
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(DimengCCard.ClassName);
        }
    }

    #endregion
}