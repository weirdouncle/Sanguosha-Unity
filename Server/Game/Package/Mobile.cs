﻿using CommonClass.Game;
using CommonClassLibrary;
using SanguoshaServer.Game;
using System;
using System.Collections.Generic;
using static CommonClass.Game.Player;
using static SanguoshaServer.Package.FunctionCard;
using System.Linq;
using static CommonClass.Game.CardUseStruct;
using CommonClass;
using System.IO;
using log4net.Util;
using System.Text;

namespace SanguoshaServer.Package
{
    public class Mobile : GeneralPackage
    {
        public Mobile() : base("Mobile")
        {
            skills = new List<Skill>
            {
                new Qiancong(),
                new QiancongTar(),
                new QiancongVH(),
                new Shangjian(),
                new Zhanyi(),
                new ZhanyiEffect(),
                new Daigong(),
                new Zhaoxin(),
                new ZhaoxinClear(),
                //new Zhongzuo(),
                new Tongqu(),
                new TongquDraw(),
                new Wanlan(),
                new QiaiMobile(),
                new ShanxiWC(),
                new ShanxiEffect(),
                new WanweiClassic(),
                new YuejianClassic(),
                new YuejianClassicMax(),
                new YinjuSP(),
                new ChijieSP(),
                new Xunde(),
                new Chenjie(),
                new Yajun(),
                new YajunMax(),
                new Zundi(),
                new YanjiaoSP(),
                new Difei(),
                new Hongyi(),
                new HongyiEffect(),
                new Quanfeng(),

                new Zhaohuo(),
                new Yixiang(),
                new Yirang(),
                new Kuangcai(),
                new KuangcaiDraw(),
                new KuangcaiTar(),
                new Shejian(),
                new ChijieNSM(),
                new Waishi(),
                new Renshe(),
                new Zhaohan(),
                new Rangjie(),
                new Yizheng(),
                new YizhengEffect(),
                new Zhouxuan(),
                new ZhouxuanEffect(),
                new Fengji(),
                new FengjiMax(),
                new Chengzhao(),
                new Jinfan(),
                new Sheque(),
                new ShequeTag(),
                new Weifeng(),
                new ZhiyanXH(),
                new ZhiyanPro(),
                new Zhilue(),
                new ZhilueMax(),
                new Juliao(),
                new Taomie(),
                new TaomieEffect(),
                new TaomieRange(),
                new Jianzhan(),
                new Duoji(),
                new Wuku(),
                new Sanchen(),
                new Miewu(),
                new Huantu(),
                new HuantuEffect(),
                new Bihuo(),
                new BihuoDistance(),
                new Jungong(),
                new Dengli(),
                new Jibing(),
                new Wangjing(),
                new Mouchuan(),
                new Binghuo(),
                new Shidi(),
                new ShidiDistance(),
                new Yishi(),
                new Qishe(),
                new QisheMax(),
                new Lueying(),
                new Yingwu(),
                new LijianSp(),
                new BiyueSp(),

                new Renshi(),
                new Wuyuan(),
                new Huaizi(),
                new Yizan(),
                new Longyuan(),
                new Qingren(),
                new Zhiyi(),
                new Duoduan(),
                new Gongshun(),
                new Jimeng(),
                new Shuaiyan(),
                new Xuewei(),
                new XueweiDamage(),
                new Liechi(),
                new Shameng(),
                new ShengxiClassic(),
                new Jianyu(),
                new CunsiClassic(),
                new CunsiEffect(),
                new GuixiuClassic(),
                new Xiangzhen(),
                new SavageAssaultAvoid("xiangzhen"),
                new XiangzhenClear(),
                new Xizhan(),
                new Fangzong(),
                new FangzongPro(),
                new Mingxuan(),
                new Xianchou(),
                new LiegongMobile(),
                new LiegongMobileTar(),
                new YanyuMobile(),
                new QiaoshiMobile(),
                new TunchuJX(),
                new TunchuJxAdd(),
                new TunchuProhibitJX(),
                new ShuliangJX(),
                new RendeJx(),
                new ZhangwuJx(),
                new RendeJxVirtual(),

                new Yingjian(),
                new Shixin(),
                new Fenyin(),
                new FenyinRecord(),
                new Fubi(),
                new FubiMax(),
                new FubiEffect(),
                new FubiExta(),
                new Zuici(),
                new Qinzheng(),
                new Heji(),
                new HejiTag(),
                new Jianyi(),
                new JianyiClear(),
                new ShangyiClassic(),
                new DiaoduClassic(),
                new DiancaiClassic(),
                new Yanji(),
            };

            skill_cards = new List<FunctionCard>
            {
                new ZhanyiCard(),
                new WuyuanCard(),
                new ZhaoxinCard(),
                new WaishiCard(),
                new YizhengCard(),
                new ZhouxuanCard(),
                new JinfanCard(),
                new ZhiyanCard(),
                new ZhilueCard(),
                new TongquCard(),
                new DuojiCard(),
                new JianzhanCard(),
                new ShamengCard(),
                new QiaiCard(),
                new ShanxiWCCard(),
                new JianyuCard(),
                new WanweiCCard(),
                new MiewuCard(),
                new CunsiCCard(),
                new YinjuSPCard(),
                new JungongCard(),
                new YajunCard(),
                new ZundiCard(),
                new YanjiaoSPCard(),
                new ShangyiCCard(),
                new DiaoduCard(),
                new GongshunCard(),
                new HongyiCard(),
                new YanyuMobileCard(),
                new LijianSpCard(),
                new RendeJxCard(),
                new ZhangwuJxCard(),
            };

            related_skills = new Dictionary<string, List<string>>
            {
                { "kuangcai", new List<string>{ "#kuangcai", "#kuangcai-tar" } },
                { "fenyin", new List<string>{ "#fenyin" } },
                { "qiancong", new List<string>{ "#qiancong", "#qiancong-tar" } },
                { "zhanyi", new List<string>{ "#zhanyi" } },
                { "zhaoxin", new List<string> { "#zhaoxin-clear" } },
                //{ "zhiyi", new List<string> { "#zhiyi" } },
                { "yizheng", new List<string> { "#yizheng" } },
                { "zhouxuan", new List<string> { "#zhouxuan" } },
                { "fengji", new List<string> { "#fengji" } },
                { "zhiyan_xh", new List<string> { "#zhiyan_xh" } },
                { "zhilue", new List<string> { "#zhilue" } },
                { "xuewei", new List<string> { "#xuewei" } },
                { "tongqu", new List<string> { "#tongqu-draw" } },
                { "sheque", new List<string> { "#sheque" } },
                { "taomie", new List<string> { "#taomie", "#taomie-range" } },
                { "fubi", new List<string> { "#fubi-effect", "#fubi", "#fubi-extra" } },
                { "shanxi_wc", new List<string> { "#shanxi_wc" } },
                { "yuejian_classic", new List<string> { "#yuejian_classic" } },
                { "cunsi_classic", new List<string> { "#cunsi_classic" } },
                { "heji", new List<string> { "#heji" } },
                { "huantu", new List<string> { "#huantu" } },
                { "bihuo", new List<string> { "#bihuo" } },
                { "xiangzhen", new List<string> { "#sa_avoid_xiangzhen", "#xiangzhen" } },
                { "fangzong", new List<string> { "#fangzong" } },
                { "yajun", new List<string> { "#yajun" } },
                { "jianyi", new List<string> { "#jianyi" } },
                { "shidi", new List<string> { "#shidi" } },
                { "qishe", new List<string> { "#qishe" } },
                { "liegong_mobile", new List<string> { "#liegong_mobile-tar" } },
                { "hongyi", new List<string> { "#hongyi" } },
                { "tunchu_jx", new List<string> { "#tunchu_jx-add", "#tunchu_jx-prohibit" } },
            };
        }
    }

    public class Qiancong : TriggerSkill
    {
        public Qiancong() : base("qiancong")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            frequency = Frequency.Compulsory;
        }

        public override bool Triggerable(Player target, Room room)
        {
            if (base.Triggerable(target, room) && target.Phase == PlayerPhase.Play)
            {
                bool red = false, black = false;
                foreach (int id in target.GetEquips())
                {
                    if (WrappedCard.IsBlack(room.GetCard(id).Suit))
                        black = true;
                    else
                        red = true;
                }

                return (!red && !black) || (red && black);
            }

            return false;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            string choice = room.AskForChoice(player, Name, "basic+trick", null, null, info.SkillPosition);
            LogMessage log = new LogMessage
            {
                Type = "#nolimit",
                From = player.Name
            };
            if (choice == "basic")
            {
                player.SetFlags("qiancong_basic");
                log.Arg = "basic";
            }
            else
            {
                player.SetFlags("qiancong_trick");
                log.Arg = "trick";
            }
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.SendLog(log);

            return false;
        }
    }

    public class QiancongTar : TargetModSkill
    {
        public QiancongTar() : base("#qiancong-tar", false) { pattern = "."; }

        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseStruct.CardUseReason reason, string pattern)
        {
            if (from != null && (Engine.GetFunctionCard(card.Name).TypeID == CardType.TypeBasic && from.HasFlag("qiancong_basic"))
                || (Engine.GetFunctionCard(card.Name).TypeID == CardType.TypeTrick && from.HasFlag("qiancong_trick")))
            {
                return true;
            }

            return false;
        }

        public override int GetResidueNum(Room room, Player from, WrappedCard card)
        {
            if (Engine.GetFunctionCard(card.Name).TypeID == CardType.TypeBasic && from != null && from.HasFlag("qiancong_basic"))
            {
                return 999;
            }

            return 0;
        }
    }

    public class QiancongVH : ViewHasSkill
    {
        public QiancongVH() : base("#qiancong")
        {
            viewhas_skills = new List<string> { "weimu_jx", "mingzhe" };
        }
        public override bool ViewHas(Room room, Player player, string skill_name)
        {
            if (player.Alive && RoomLogic.PlayerHasSkill(room, player, Name) && player.HasEquip())
            {
                List<WrappedCard.CardSuit> suits = new List<WrappedCard.CardSuit>();
                foreach (int id in player.GetEquips())
                {
                    WrappedCard.CardSuit suit = room.GetCard(id).Suit;
                    if (!suits.Contains(suit)) suits.Add(suit);
                }

                if (skill_name == "weimu_jx" && !suits.Contains(WrappedCard.CardSuit.Diamond) && !suits.Contains(WrappedCard.CardSuit.Heart)) return true;
                if (skill_name == "mingzhe" && !suits.Contains(WrappedCard.CardSuit.Club) && !suits.Contains(WrappedCard.CardSuit.Spade)) return true;
            }
            return false;
        }
    }

    public class Shangjian : TriggerSkill
    {
        public Shangjian() : base("shangjian")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseStart, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (p.GetMark(Name) > 0) p.SetMark(Name, 0);
            }
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.From.Phase == PlayerPhase.NotActive
                && (move.From_places.Contains(Place.PlaceHand) || move.From_places.Contains(Place.PlaceEquip))
                && !(move.To == move.From && (move.To_place == Place.PlaceHand || move.To_place == Place.PlaceEquip)))
                move.From.AddMark(Name, move.Card_ids.Count);
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish)
            {
                List<Player> players = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in players)
                {
                    if (p.GetMark(Name) > 0 && p.GetMark(Name) <= p.Hp)
                        skill_list.Add(new TriggerStruct(Name, p));
                }
            }

            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, null, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            int count = ask_who.GetMark(Name);
            room.DrawCards(ask_who, count, Name);
            return false;
        }
    }

    public class Zhanyi : ViewAsSkill
    {
        public Zhanyi() : base("zhanyi")
        {
            skill_type = SkillType.Attack;
            response_or_use = true;
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (selected.Count > 0) return false;

            if (!player.HasUsed(ZhanyiCard.ClassName))
                return (room.GetCardPlace(to_select.Id) == Place.PlaceHand || room.GetCardPlace(to_select.Id) == Place.PlaceEquip)
                    && !RoomLogic.IsCardLimited(room, player, to_select, HandlingMethod.MethodDiscard);
            else if (player.HasFlag("zhanyi_basic"))
                return Engine.GetFunctionCard(to_select.Name).TypeID == CardType.TypeBasic;

            return false;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(ZhanyiCard.ClassName) || player.HasFlag("zhanyi_basic");
        }

        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
        {
            return player.HasFlag("zhanyi_basic") && room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE && MatchBasic(respond);
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player Self)
        {
            List<WrappedCard> all_cards = new List<WrappedCard>();
            if (Self.HasFlag("zhanyi_basic") && cards.Count == 1)
            {
                CardUseStruct.CardUseReason reason = room.GetRoomState().GetCurrentCardUseReason();
                if (reason == CardUseStruct.CardUseReason.CARD_USE_REASON_PLAY)
                {
                    List<string> names = GetGuhuoCards(room, "b");
                    foreach (string name in names)
                    {
                        if (name == Jink.ClassName) continue;
                        WrappedCard card = new WrappedCard(name);
                        card.AddSubCards(cards);
                        all_cards.Add(card);
                    }
                }
                else
                {
                    string pattern = room.GetRoomState().GetCurrentCardUsePattern(Self);
                    WrappedCard slash = new WrappedCard(Slash.ClassName);
                    slash.AddSubCards(cards);
                    WrappedCard fslash = new WrappedCard(FireSlash.ClassName);
                    fslash.AddSubCards(cards);
                    WrappedCard tslash = new WrappedCard(ThunderSlash.ClassName);
                    tslash.AddSubCards(cards);
                    WrappedCard jink = new WrappedCard(Jink.ClassName);
                    jink.AddSubCards(cards);
                    WrappedCard peach = new WrappedCard(Peach.ClassName);
                    peach.AddSubCards(cards);
                    WrappedCard ana = new WrappedCard(Analeptic.ClassName);
                    ana.AddSubCards(cards);

                    if (Engine.MatchExpPattern(room, pattern, Self, slash))
                        all_cards.Add(slash);
                    if (Engine.MatchExpPattern(room, pattern, Self, fslash))
                        all_cards.Add(fslash);
                    if (Engine.MatchExpPattern(room, pattern, Self, tslash))
                        all_cards.Add(tslash);
                    if (Engine.MatchExpPattern(room, pattern, Self, jink))
                        all_cards.Add(jink);
                    if (Engine.MatchExpPattern(room, pattern, Self, peach))
                        all_cards.Add(peach);
                    if (Engine.MatchExpPattern(room, pattern, Self, ana))
                        all_cards.Add(ana);
                }
            }

            return all_cards;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count != 1) return null;

            if (!player.HasUsed(ZhanyiCard.ClassName))
            {
                WrappedCard zy = new WrappedCard(ZhanyiCard.ClassName) { Skill = Name };
                zy.AddSubCards(cards);
                return zy;
            }
            else if (player.HasFlag("zhanyi_basic") && cards[0].IsVirtualCard())
            {
                WrappedCard card = RoomLogic.ParseUseCard(room, cards[0]);
                card.Skill = Name;
                return card;
            }

            return null;
        }
        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            if (card.Name == ZhanyiCard.ClassName)
                index = 1;
            else
                index = -2;
        }
    }

    public class ZhanyiCard : SkillCard
    {
        public static string ClassName = "ZhanyiCard";
        public ZhanyiCard() : base(ClassName) { target_fixed = true; }
        public override void Use(Room room, CardUseStruct card_use)
        {
            WrappedCard card = room.GetCard(card_use.Card.GetEffectiveId());
            FunctionCard fcard = Engine.GetFunctionCard(card.Name);
            Player player = card_use.From;
            room.LoseHp(player);
            if (!player.Alive) return;

            switch (fcard.TypeID)
            {
                case CardType.TypeBasic:
                    player.SetFlags("zhanyi_basic");
                    break;
                case CardType.TypeEquip:
                    player.SetFlags("zhanyi_equip");
                    break;
                case CardType.TypeTrick:
                    player.SetFlags("zhanyi_trick");
                    room.DrawCards(player, 3, "zhanyi");
                    break;
            }
        }
    }

    public class ZhanyiEffect : TriggerSkill
    {
        public ZhanyiEffect() : base("#zhanyi")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.TargetChosen, TriggerEvent.CardUsedAnnounced, TriggerEvent.CardResponded, TriggerEvent.CardsMoveOneTime };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play
                && (player.HasFlag("zhanyi_basic") || player.HasFlag("zhanyi_trick") || player.HasFlag("zhanyi_equip")))
            {
                player.SetFlags("-zhanyi_basic");
                player.SetFlags("-zhanyi_trick");
                player.SetFlags("-zhanyi_equip");
                player.SetMark(Name, 0);
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use && player.HasFlag("zhanyi_basic"))
                player.AddMark(Name);
            else if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && player.HasFlag("zhanyi_basic")
                && Engine.GetFunctionCard(use.Card.Name).TypeID == CardType.TypeBasic)
                player.AddMark(Name);
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To_place == Place.PlaceTable && move.From != null && move.Reason.Card == null
                && move.Reason.Reason == MoveReason.S_REASON_THROW && move.Reason.SkillName == "zhanyi" && move.From.Name == move.Reason.PlayerId && move.Card_ids.Count > 0)
            {
                move.From.SetTag(Name, move.Card_ids);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && ((player.GetMark(Name) == 1 && player.HasFlag("zhanyi_basic")
                && (use.Card.Name.Contains(Slash.ClassName) || use.Card.Name == Peach.ClassName || use.Card.Name == Analeptic.ClassName))
                || (Engine.GetFunctionCard(use.Card.Name).IsNDTrick() && player.HasFlag("zhanyi_trick"))))
            {
                return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct _use && _use.Card.Name.Contains(Slash.ClassName) && player.HasFlag("zhanyi_equip"))
            {
                return new TriggerStruct(Name, player, _use.To);
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, "zhanyi", info.SkillPosition);
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use)
            {
                room.SendCompulsoryTriggerLog(ask_who, "zhanyi");
                room.BroadcastSkillInvoke("zhanyi", "male", 2, gsk.General, gsk.SkinId);

                if (use.Card.Name.Contains(Slash.ClassName) || use.Card.Name == Peach.ClassName || use.Card.Name == Analeptic.ClassName)
                {
                    use.ExDamage++;
                    data = use;

                    if (use.Card.Name.Contains(Slash.ClassName))
                    {
                        LogMessage log = new LogMessage
                        {
                            Type = "#card-damage",
                            From = player.Name,
                            Arg = "zhanyi",
                            Arg2 = use.Card.Name
                        };
                        room.SendLog(log);
                    }
                    else
                    {
                        if (use.Card.Name != Analeptic.ClassName || player.HasFlag("Global_Dying"))
                        {
                            LogMessage log = new LogMessage
                            {
                                Type = "#card-recover",
                                From = player.Name,
                                Arg = "zhanyi",
                                Arg2 = use.Card.Name
                            };

                            room.SendLog(log);
                        }
                    }
                }
                else
                {
                    use.Cancelable = false;
                    data = use;
                }
            }
            else if (triggerEvent == TriggerEvent.TargetChosen)
            {
                if (!player.IsNude())
                {
                    room.SendCompulsoryTriggerLog(ask_who, "zhanyi");
                    room.BroadcastSkillInvoke("zhanyi", "male", 2, gsk.General, gsk.SkinId);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    room.AskForDiscard(player, "zhanyi", 2, 2, false, true, "@zhanyi:" + ask_who.Name);

                    if (player.ContainsTag(Name) && player.GetTag(Name) is List<int> ids)
                    {
                        player.RemoveTag(Name);

                        List<int> get = new List<int>();
                        foreach (int id in ids)
                            if (room.GetCardPlace(id) == Place.DiscardPile)
                                get.Add(id);

                        if (ask_who.Alive && get.Count > 0)
                        {
                            if (get.Count > 1)
                            {
                                room.FillAG("zhanyi", get, ask_who, null, null, "@zhanyi-get");
                                int card_id = room.AskForAG(ask_who, get, false, "zhanyi");
                                room.ClearAG();
                                get = new List<int> { card_id };
                            }

                            room.ObtainCard(ask_who, ref get, new CardMoveReason(MoveReason.S_REASON_RECYCLE, ask_who.Name, "zhanyi", string.Empty));
                        }
                    }
                 }
            }

            return false;
        }
    }

    public class Daigong : TriggerSkill
    {
        public Daigong() : base("daigong")
        {
            events.Add(TriggerEvent.DamageInflicted);
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DamageStruct damage && damage.From != null && damage.From.Alive && damage.From != player && !player.IsKongcheng()
                && base.Triggerable(player, room) && !player.HasFlag(Name))
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                room.SetTag(Name, data);
                bool invoke = room.AskForSkillInvoke(player, Name, damage.From, info.SkillPosition);
                room.RemoveTag(Name);

                if (invoke)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, damage.From.Name);
                    room.ShowAllCards(player);
                    player.SetFlags(Name);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                List<string> patterns = new List<string> { "diamond", "heart", "club", "spade" };
                List<string> suits = new List<string> { "♠", "♥", "♣", "♦" };
                foreach (int id in player.GetCards("h"))
                {
                    patterns.Remove(WrappedCard.GetSuitString(room.GetCard(id).Suit));
                    suits.Remove(WrappedCard.GetSuitIcon(room.GetCard(id).Suit));
                }
                bool prevent = false;
                if (patterns.Count == 0 || damage.From.IsNude())
                    prevent = true;
                else
                {
                    List<string> builder = new List<string>();
                    foreach (string p in patterns)
                        builder.Add(string.Format(".|{0}", p));

                    room.SetTag(Name, data);
                    List<int> ids = room.AskForExchange(damage.From, Name, 1, 0, string.Format("@daigong:{0}::{1}", player.Name, string.Join(",", suits)),
                        string.Empty, string.Join("#", builder), string.Empty);
                    room.RemoveTag(Name);
                    if (ids.Count > 0)
                    {
                        room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, damage.From.Name, player.Name, Name, string.Empty));
                    }
                    else
                        prevent = true;
                }

                if (prevent)
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "#damaged-prevent",
                        From = player.Name,
                        Arg = Name
                    };
                    room.SendLog(log);
                    return true;
                }
            }

            return false;
        }
    }

    public class Zhaoxin : TriggerSkill
    {
        public Zhaoxin() : base("zhaoxin")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventLoseSkill, TriggerEvent.EventPhaseEnd };
            view_as_skill = new ZhaoxinVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name)
            {
                room.ClearOnePrivatePile(player, "ambition");
            }
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseEnd && player.Phase == PlayerPhase.Draw)
            {
                List<Player> smz = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in smz)
                {
                    if (p.GetPile("ambition").Count > 0 && (p == player || RoomLogic.InMyAttackRange(room, p, player)))
                    {
                        triggers.Add(new TriggerStruct(Name, player, p));
                    }
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (ask_who.Name == info.SkillOwner)
            {
                List<int> ids = room.AskForExchange(ask_who, Name, 1, 0, "@zhaoxin", "ambition", string.Empty, info.SkillPosition);
                if (ids.Count > 0)
                {
                    room.NotifySkillInvoked(player, Name);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "zhaoxin", info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                    room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, Name, string.Empty));
                    return info;
                }
            }
            else
            {
                Player owner = room.FindPlayer(info.SkillOwner);
                bool invoke = room.AskForSkillInvoke(ask_who, Name, string.Format("@zhaoxin-get-from:{0}", info.SkillOwner));
                if (invoke)
                {
                    room.NotifySkillInvoked(owner, Name);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, owner, "zhaoxin", info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);

                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player owner = room.FindPlayer(info.SkillOwner);
            if (ask_who != owner)
            {
                List<int> ids = room.AskForExchange(owner, Name, 1, 1, string.Format("@zhaoxin-give:{0}", ask_who.Name), "ambition", string.Empty, info.SkillPosition);
                room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_GOTCARD, ask_who.Name, Name, string.Empty));

                if (owner.Alive && ask_who.Alive && room.AskForSkillInvoke(owner, Name, ask_who, info.SkillPosition))
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, owner.Name, ask_who.Name);
                    room.Damage(new DamageStruct(Name, owner, ask_who));
                }
            }

            return false;
        }
    }

    public class ZhaoxinVS : ViewAsSkill
    {
        public ZhaoxinVS() : base("zhaoxin") { }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            List<int> ids = player.GetPile("ambition");
            return selected.Count + ids.Count < 3;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            List<int> ids = player.GetPile("ambition");
            return ids.Count < 3 && !player.HasUsed(ZhaoxinCard.ClassName);
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
            {
                WrappedCard zx = new WrappedCard(ZhaoxinCard.ClassName) { Skill = Name, Mute = true };
                zx.AddSubCards(cards);
                return zx;
            }
            return null;
        }
    }

    public class ZhaoxinCard : SkillCard
    {
        public static string ClassName = "ZhaoxinCard";
        public ZhaoxinCard() : base(ClassName)
        {
            target_fixed = true;
            will_throw = false;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "zhaoxin", card_use.Card.SkillPosition);
            room.BroadcastSkillInvoke("zhaoxin", "male", 1, gsk.General, gsk.SkinId);

            room.AddToPile(player, "ambition", card_use.Card);
            if (player.Alive)
                room.DrawCards(player, card_use.Card.SubCards.Count, "zhaoxin");
        }
    }

    public class ZhaoxinClear : DetachEffectSkill
    {
        public ZhaoxinClear() : base("zhaoxin", "ambition") { }
    }
    /*
    public class Zhongzuo : TriggerSkill
    {
        public Zhongzuo() : base("zhongzuo")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.Damaged, TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Replenish;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if ((triggerEvent == TriggerEvent.Damage || triggerEvent == TriggerEvent.Damaged))
                player.SetFlags(Name);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish)
            {
                List<Player> jys = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in jys)
                    if (p.HasFlag(Name))
                        triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(ask_who, room.GetAlivePlayers(), Name, "@zhongzuo", true, true, info.SkillPosition);
            if (target != null)
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                ask_who.SetTag(Name, target.Name);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.FindPlayer((string)ask_who.GetTag(Name));
            ask_who.RemoveTag(Name);
            room.DrawCards(target, new DrawCardStruct(2, ask_who, Name));
            if (ask_who != target && ask_who.Alive && target.IsWounded())
                room.DrawCards(ask_who, 1, Name);

            return false;
        }
    }
    */
    public class Tongqu : TriggerSkill
    {
        public Tongqu() : base("tongqu")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.Damaged };
            view_as_skill = new TongquVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Damaged && player.Alive && player.GetMark(Name) > 0)
            {
                player.SetMark(Name, 0);
                room.RemovePlayerStringMark(player, Name);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetAlivePlayers())
            {
                if (p.GetMark(Name) == 0) targets.Add(p);
            }

            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@tongqu-mark", true, true, info.SkillPosition);
                if (target != null)
                {
                    room.SetTag(Name, target);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                    return info;
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                Player target = (Player)room.GetTag(Name);
                room.RemoveTag(Name);
                target.SetMark(Name, 1);
                room.SetPlayerStringMark(target, Name, string.Empty);
            }

            return false;
        }
    }

    public class TongquDraw : TriggerSkill
    {
        public TongquDraw() : base("#tongqu-draw")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseProceeding, TriggerEvent.AfterDrawNCards, TriggerEvent.GameStart };
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseProceeding && player.GetMark("tongqu") > 0 && player.Phase == PlayerPhase.Draw)
            {
                Player luji = RoomLogic.FindPlayerBySkillName(room, "tongqu");
                if (luji != null)
                    return new TriggerStruct(Name, luji);
            }
            else if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.AfterDrawNCards && player.HasFlag(Name) && player.Alive && !player.IsNude())
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseProceeding && data is int count)
            {
                room.SendCompulsoryTriggerLog(ask_who, "tongqu");
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                count++;
                data = count;
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, "tongqu", info.SkillPosition);
                room.BroadcastSkillInvoke("tongqu", "male", 2, gsk.General, gsk.SkinId);
                player.SetFlags(Name);
            }
            else if (triggerEvent == TriggerEvent.GameStart)
            {
                player.SetMark("tongqu", 1);
                room.SetPlayerStringMark(player, "tongqu", string.Empty);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "tongqu", info.SkillPosition);
                room.BroadcastSkillInvoke("tongqu", "male", 1, gsk.General, gsk.SkinId);
                room.NotifySkillInvoked(player, "tongqu");
            }
            else if (triggerEvent == TriggerEvent.AfterDrawNCards)
            {
                if (room.AskForUseCard(player, RespondType.Skill, "@@tongqu!", "@tongqu-give", null, -1) == null)
                {
                    List<int> ids = room.ForceToDiscard(player, player.GetCards("he"), 1, true);
                    room.ThrowCard(ref ids,
                        new CardMoveReason(MoveReason.S_REASON_THROW, player.Name, "tongqu", string.Empty) { General = RoomLogic.GetGeneralSkin(room, player, "tongqu", info.SkillPosition) },
                        player);
                }

                player.SetFlags("-#tongqu-draw");
            }

            return false;
        }
    }
    public class TongquVS : OneCardViewAsSkill
    {
        public TongquVS() : base("tongqu")
        {
            filter_pattern = "..";
        }

        public override bool IsAvailable(Room room, Player invoker, CardUseReason reason, RespondType respond, string pattern, string position = null)
        {
            return reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE && pattern.Contains("@tongqu");
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard tq = new WrappedCard(TongquCard.ClassName) { Skill = Name };
            tq.AddSubCard(card);
            return tq;
        }
    }

    public class TongquCard : SkillCard
    {
        public static string ClassName = "TongquCard";
        public TongquCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select.GetMark("tongqu") > 0 && to_select != Self;
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            if (targets.Count == 0)
                return RoomLogic.CanDiscard(room, Self, Self, card.GetEffectiveId());

            return true;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            List<int> ids = new List<int> { card_use.Card.GetEffectiveId() };
            if (card_use.To.Count == 0)
            {
                room.ThrowCard(ref ids,
                    new CardMoveReason(MoveReason.S_REASON_THROW, card_use.From.Name, "tongqu", string.Empty)
                    { General = RoomLogic.GetGeneralSkin(room, card_use.From, "tongqu", card_use.Card.SkillPosition) },
                card_use.From);
            }
            else
            {
                Player player = card_use.From;
                Player target = card_use.To[0];
                room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "tongqu", string.Empty), false);
            }
        }
    }
    
    public class Wanlan : TriggerSkill
    {
        public Wanlan() : base("wanlan")
        {
            events.Add(TriggerEvent.DamageDefined);
            skill_type = SkillType.Defense;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (data is DamageStruct damage && player.Alive && damage.Damage >= player.Hp)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> ids = new List<int>();
            foreach (int id in ask_who.GetCards("he"))
            {
                FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(id).Name);
                if (!(fcard is BasicCard) && RoomLogic.CanDiscard(room, ask_who, ask_who, id))
                    ids.Add(id);
            }

            if (ids.Count >= 2)
            {
                player.SetFlags(Name);
                bool invoke = room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition);
                player.SetFlags("-wanlan");
                if (invoke)
                {
                    room.NotifySkillInvoked(ask_who, Name);
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    room.ThrowCard(ref ids, ask_who, null, Name);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            ResultStruct result = ask_who.Result;
            result.Assist += 2;
            ask_who.Result = result;

            LogMessage log = new LogMessage
            {
                Type = "#damaged-prevent",
                From = player.Name,
                Arg = Name
            };
            room.SendLog(log);

            return true;
        }
    }


    public class QiaiMobile : OneCardViewAsSkill
    {
        public QiaiMobile() : base("qiai_mobile")
        {
            filter_pattern = "^BasicCard";
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(QiaiCard.ClassName);
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard qa = new WrappedCard(QiaiCard.ClassName) { Skill = Name };
            qa.AddSubCard(card);
            return qa;
        }
    }

    public class QiaiCard : SkillCard
    {
        public static string ClassName = "QiaiCard";
        public QiaiCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && Self != to_select;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            List<int> ids = new List<int>(card_use.Card.SubCards);
            Player target = card_use.To[0], player = card_use.From;
            room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "qiai_mobile", string.Empty));
            if (target.Alive && player.Alive)
            {
                List<string> choices = new List<string> { "draw" };
                if (player.IsWounded())
                    choices.Add("recover");

                string choice = room.AskForChoice(target, "qiai_mobile", string.Join("+", choices), new List<string> { "@to-player:" + player.Name }, player);
                if (choice == "draw")
                    room.DrawCards(player, 2, "qiai_mobile");
                else
                    room.Recover(player);
            }
        }
    }

    public class ShanxiWC : TriggerSkill
    {
        public ShanxiWC() : base("shanxi_wc")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Attack;
            view_as_skill = new ShanxiWCVS();
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Play)
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = room.GetOtherPlayers(player);
            targets.RemoveAll(t => t.GetMark(Name) > 0);
            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@shanxi_wc", true, true, info.SkillPosition);
                if (target != null)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.SetTag(Name, target);
                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is Player target)
            {
                room.RemoveTag(Name);
                target.AddMark(Name);
                if (player.ContainsTag("shanxi_target") && player.GetTag("shanxi_target") is string target_name)
                {
                    Player old = room.FindPlayer(target_name);
                    if (old != null)
                    {
                        old.RemoveTag("shanxi_from");
                        old.SetMark(Name, 0);
                        room.RemovePlayerStringMark(old, Name);
                    }
                }

                player.SetTag("shanxi_target", target.Name);
                target.SetTag("shanxi_from", player.Name);
                room.SetPlayerStringMark(target, Name, string.Empty);
            }
            return false;
        }
    }

    public class ShanxiWCVS : ViewAsSkill
    {
        public ShanxiWCVS() : base("shanxi_wc")
        {
            response_pattern = "@@shanxi_wc";
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => selected.Count < 2;

        public override bool IsAvailable(Room room, Player invoker, CardUseReason reason, RespondType respond, string pattern, string position = null)
        {
            return reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE && pattern == response_pattern;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 2)
            {
                WrappedCard sx = new WrappedCard(ShanxiWCCard.ClassName);
                sx.AddSubCards(cards);
                return sx;
            }
            return null;
        }
    }

    public class ShanxiWCCard : SkillCard
    {
        public static string ClassName = "ShanxiWCCard";
        public ShanxiWCCard() : base(ClassName)
        {
            target_fixed = true;
            will_throw = false;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
        }
    }


    public class ShanxiEffect :TriggerSkill
    {
        public ShanxiEffect() : base("#shanxi_wc")
        {
            events.Add(TriggerEvent.HpRecover);
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Alive && player.GetMark("shanxi_wc") > 0 && !player.HasFlag("Global_Dying") && player.ContainsTag("shanxi_from")
                && player.GetTag("shanxi_from") is string from_name)
            {
                Player from = room.FindPlayer(from_name);
                if (from != null)
                {
                    return new TriggerStruct(Name, player);
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.GetTag("shanxi_from") is string from_name)
            {
                LogMessage log = new LogMessage
                {
                    Type = "#shanxi_wc",
                    From = player.Name
                };
                room.SendLog(log);

                Player from = room.FindPlayer(from_name);
                bool give = false;
                if (player.GetCardCount(true) >= 2)
                {
                    WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@shanxi_wc", "@shanxi_give:" + from_name, null);
                    if (card != null)
                    {
                        List<int> ids = new List<int>(card.SubCards);
                        give = true;
                        room.ObtainCard(from, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, from.Name, string.Empty), false);
                    }
                }
                if (!give)
                    room.LoseHp(player);
            }

                return false;
        }
    }

    public class WanweiClassic : TriggerSkill
    {
        public WanweiClassic() : base("wanwei_classic")
        {
            skill_type = SkillType.Recover;
            events = new List<TriggerEvent> { TriggerEvent.Dying };
            view_as_skill = new WanweiCVS();
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.Alive && player.HasFlag("Global_Dying"))
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (room.Round > p.GetMark(Name) && p.Hp > 0) triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player dyer, ref object data, Player player, TriggerStruct info)
        {
            dyer.SetFlags(Name);
            bool invoke = room.AskForSkillInvoke(player, Name, dyer, info.SkillPosition);
            dyer.SetFlags("-wanwei_classic");
            if (invoke)
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                player.SetMark(Name, room.Round);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, dyer.Name);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.Recover(player, Math.Min(ask_who.Hp + 1, player.GetLostHp()));
            if (ask_who.Alive)
                room.LoseHp(ask_who, ask_who.Hp);
            return false;
        }
    }

    public class WanweiCVS : ZeroCardViewAsSkill
    {
        public WanweiCVS() : base("wanwei_classic") { }
        public override bool IsEnabledAtPlay(Room room, Player player) => room.Round > player.GetMark(Name);
        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(WanweiCCard.ClassName) { Skill = Name };
    }

    public class WanweiCCard : SkillCard
    {
        public static string ClassName = "WanweiCCard";
        public WanweiCCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && Self != to_select;
        public override void Use(Room room, CardUseStruct card_use)
        {
            room.Recover(card_use.To[0], Math.Min(card_use.From.Hp + 1, card_use.To[0].GetLostHp()));
            if (card_use.From.Alive)
                room.LoseHp(card_use.From, card_use.From.Hp);
        }
    }

    public class YuejianClassic : TriggerSkill
    {
        public YuejianClassic() : base("yuejian_classic")
        {
            events.Add(TriggerEvent.AskForPeaches);
            skill_type = SkillType.Recover;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DyingStruct dying && dying.Who == player && base.Triggerable(player, room) && player.Hp <= 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForDiscard(player, Name, 2, 2, true, true, "@yuejian-recover", true, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.Recover(player, 1);
            return false;
        }
    }

    public class YuejianClassicMax : MaxCardsSkill
    {
        public YuejianClassicMax() : base("#yuejian_classic")
        {
        }
        public override int GetFixed(Room room, Player target) => RoomLogic.PlayerHasSkill(room, target, "yuejian_classic") ? target.MaxHp : -1;
    }

    public class YinjuSPVS : ZeroCardViewAsSkill
    {
        public YinjuSPVS() : base("yinju_sp") {}
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(YinjuSPCard.ClassName);
        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(YinjuSPCard.ClassName) { Skill = Name };
        }
    }

    public class YinjuSPCard : SkillCard
    {
        public static string ClassName = "YinjuSPCard";
        public YinjuSPCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }
        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            bool use_slash = false;
            if (RoomLogic.CanSlash(room, effect.To, effect.From))
                use_slash = room.AskForUseSlashTo(effect.To, effect.From, "@yinju_sp-slash:" + effect.From.Name, null) != null;
            if (!use_slash)
            {
                effect.To.AddMark("yinju_sp");
                room.SetPlayerStringMark(effect.To, "yinju_sp", string.Empty);
            }
        }
    }

    public class YinjuSP : TriggerSkill
    {
        public YinjuSP() : base("yinju_sp")
        {
            skill_type = SkillType.Wizzard;
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
            view_as_skill = new YinjuSPVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (player.Phase == PlayerPhase.Start && player.GetMark(Name) > 0)
            {
                player.SetMark(Name, 0);
                room.RemovePlayerStringMark(player, Name);
                room.SkipPhase(player, PlayerPhase.Play);
                room.SkipPhase(player, PlayerPhase.Discard);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class ChijieSP : TriggerSkill
    {
        public ChijieSP() : base("chijie_sp")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetConfirming };
            skill_type = SkillType.Defense;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && base.Triggerable(player, room) && use.From != null && use.To.Count == 1 && use.From != use.To[0] && !player.HasFlag(Name))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (!(fcard is SkillCard))
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, data, info.SkillPosition))
            {
                player.SetFlags(Name);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                JudgeStruct judge = new JudgeStruct
                {
                    Pattern = ".|.|7~",
                    Good = true,
                    Reason = Name,
                    Who = player
                };

                room.Judge(ref judge);

                if (judge.IsEffected())
                {
                    room.CancelTarget(ref use, player); // Room::cancelTarget(use, player);
                    data = use;
                    return true;
                }
            }

            return false;
        }
    }

    public class Xunde : TriggerSkill
    {
        public Xunde() : base("xunde")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged };
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (player == null || !player.Alive) return skill_list;
            if (triggerEvent == TriggerEvent.Damaged)
            {
                    List<Player> caiwenjis = RoomLogic.FindPlayersBySkillName(room, Name);
                    foreach (Player caiwenji in caiwenjis)
                        if (caiwenji == player || RoomLogic.DistanceTo(room, caiwenji, player) == 1)
                            skill_list.Add(new TriggerStruct(Name, caiwenji));
            }

            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player caiwenji, TriggerStruct info)
        {
            if (caiwenji != null)
            {
                room.SetTag("beige_data", data);
                bool invoke = room.AskForSkillInvoke(caiwenji, Name, player, info.SkillPosition);
                room.RemoveTag("beige_data");

                if (invoke)
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, caiwenji.Name, ((DamageStruct)data).To.Name);
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
                Who = caiwenji,
                Reason = Name
            };
            room.Judge(ref judge);

            int number = judge.Card.Number;
            if (number >= 6 && caiwenji.Alive && player.Alive)
                room.ObtainCard(player, judge.Card, new CardMoveReason(MoveReason.S_REASON_RECYCLE, caiwenji.Name, player.Name, Name, string.Empty));
            if (number <= 6 && caiwenji.Alive && damage.From != null && damage.From.Alive && !damage.From.IsKongcheng())
                room.AskForDiscard(damage.From, Name, 1, 1, false, false, string.Format("@xunce:{0}:{1}", player.Name, caiwenji.Name));

            return false;
        }
    }

    public class Chenjie : TriggerSkill
    {
        public Chenjie() : base("chenjie")
        {
            events.Add(TriggerEvent.AskForRetrial);
            skill_type = SkillType.Wizzard;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (!base.Triggerable(player, room)) return new TriggerStruct();
            if (player.IsNude() && player.GetHandPile().Count == 0)
                return new TriggerStruct();
            return new TriggerStruct(Name, player);
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            JudgeStruct judge = (JudgeStruct)data;

            List<string> prompt_list = new List<string> { "@chenjie", judge.Who.Name, string.Empty, Name, judge.Reason };
            string prompt = string.Join(":", prompt_list);

            room.SetTag(Name, data);
            WrappedCard card = room.AskForCard(player, Name, RespondType.Retrial, ".|" + WrappedCard.GetSuitString(judge.Card.Suit), prompt, data, HandlingMethod.MethodResponse, judge.Who, true);
            room.RemoveTag(Name);
            if (card != null)
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.Retrial(card, player, ref judge, Name, false, info.SkillPosition);
                data = judge;
                return info;
            }


            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            JudgeStruct judge = (JudgeStruct)data;
            room.UpdateJudgeResult(ref judge);
            data = judge;
            if (player.Alive) room.DrawCards(player, 2, Name);
            return false;
        }
    }

    public class Yajun : TriggerSkill
    {
        public Yajun() : base("yajun")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseProceeding, TriggerEvent.EventPhaseStart, TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
            view_as_skill = new YajunVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move)
            {
                if (move.To != null && move.To_place == Place.PlaceHand && move.To.Phase != PlayerPhase.NotActive)
                {
                    foreach (int id in move.Card_ids)
                    {
                        WrappedCard card = room.GetCard(id);
                        card.SetFlags("yajun");
                    }
                }
                else if (move.From != null && move.From_places.Contains(Place.PlaceHand))
                {
                    foreach (int id in move.Card_ids)
                    {
                        WrappedCard card = room.GetCard(id);
                        if (card.HasFlag(Name))
                            card.SetFlags("-yajun");
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                foreach (int id in player.GetCards("h"))
                {
                    WrappedCard card = room.GetCard(id);
                    if (card.HasFlag(Name))
                        card.SetFlags("-yajun");
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseProceeding && player.Phase == PlayerPhase.Draw && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Play && base.Triggerable(player, room) && !player.IsKongcheng())
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseProceeding)
                return info;
            else
                room.AskForUseCard(player, RespondType.Skill, "@@yajun", "@yajun", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseProceeding && data is int count)
            {
                room.SendCompulsoryTriggerLog(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                count++;
                data = count;
            }

            return false;
        }
    }

    public class YajunVS : OneCardViewAsSkill
    {
        public YajunVS() : base("yajun") { response_pattern = "@@yajun"; }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            return room.GetCardPlace(to_select.Id) == Place.PlaceHand && to_select.HasFlag(Name);
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard yj = new WrappedCard(YajunCard.ClassName) { Skill = Name };
            yj.AddSubCard(card);
            return yj;
        }
    }

    public class YajunCard : SkillCard
    {
        public static string ClassName = "YajunCard";
        public YajunCard() : base(ClassName) { will_throw = false; }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && Self != to_select && RoomLogic.CanBePindianBy(room, to_select, Self);
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            Player target = card_use.To[0];
            PindianStruct pd = room.PindianSelect(player, target, "yajun", room.GetCard(card_use.Card.GetEffectiveId()));
            room.Pindian(ref pd);
            if (pd.Success)
            {
                if (player.Alive)
                {
                    int from = pd.From_card.Id;
                    int to = pd.To_cards[0].Id;
                    List<int> ids = new List<int>();
                    if (room.GetCardPlace(from) == Place.DiscardPile) ids.Add(from);
                    if (room.GetCardPlace(to) == Place.DiscardPile) ids.Add(to);
                    if (ids.Count > 0)
                    {
                        List<int> put = room.NotifyChooseCards(player, ids, "yajun", 1, 0, "@yajun-put", null, card_use.Card.SkillPosition);
                        if (put.Count > 0)
                        {
                            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_PUT, player.Name, "yajun", string.Empty)
                            { General = RoomLogic.GetGeneralSkin(room, player, "yajun", card_use.Card.SkillPosition) };
                            CardsMoveStruct move = new CardsMoveStruct(put, null, Place.DrawPile, reason)
                            {
                                To_pile_name = string.Empty,
                                From = player.Name
                            };
                            List<CardsMoveStruct> moves = new List<CardsMoveStruct> { move };
                            room.MoveCardsAtomic(moves, true);
                        }
                    }
                }
            }
            else if (player.Alive)
            {
                player.AddMark("yajun");
            }
        }
    }

    public class YajunMax : MaxCardsSkill
    {
        public YajunMax() : base("#yajun") { }
        public override int GetExtra(Room room, Player target) => -target.GetMark("yajun");
    }

    public class Zundi : OneCardViewAsSkill
    {
        public Zundi() : base("zundi") { filter_pattern = ".!"; skill_type = SkillType.Wizzard; }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.IsKongcheng() && !player.HasUsed(ZundiCard.ClassName);
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard yj = new WrappedCard(ZundiCard.ClassName) { Skill = Name };
            yj.AddSubCard(card);
            return yj;
        }
    }

    public class ZundiCard : SkillCard
    {
        public static string ClassName = "ZundiCard";
        public ZundiCard() : base(ClassName) { will_throw = true; }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0;
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.To[0];

            JudgeStruct judge = new JudgeStruct
            {
                Good = true,
                PlayAnimation = false,
                Who = card_use.From,
                Reason = "zundi"
            };

            room.Judge(ref judge);
            WrappedCard.CardSuit suit = judge.JudgeSuit;
            if (WrappedCard.IsBlack(suit))
            {
                if (player.Alive)
                    room.DrawCards(player, 3, "zundi");
            }
            else if (player.Alive)
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetAlivePlayers())
                    if (p.GetCards("ej").Count > 0) targets.Add(p);
                if (targets.Count > 0)
                {
                    Player from = room.AskForPlayerChosen(player, targets, "zundi", "@zundi-from", true, false, card_use.Card.SkillPosition);
                    if (from != null)
                    {
                        room.SetTag("QiaobianTarget", from);
                        int card_id = room.AskForCardChosen(player, from, "ej", "zundi");
                        WrappedCard card = room.GetCard(card_id);
                        Place place = room.GetCardPlace(card_id);

                        FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                        int equip_index = -1;
                        if (place == Place.PlaceEquip)
                        {
                            EquipCard equip = (EquipCard)fcard;
                            equip_index = (int)equip.EquipLocation();
                        }

                        List<Player> tos = new List<Player>();
                        foreach (Player p in room.GetOtherPlayers(from))
                        {
                            if (equip_index != -1)
                            {
                                if (p.GetEquip(equip_index) < 0 && RoomLogic.CanPutEquip(p, card))
                                    tos.Add(p);
                            }
                            else if (RoomLogic.IsProhibited(room, null, p, card) == null && !RoomLogic.PlayerContainsTrick(room, p, card.Name) && p.JudgingAreaAvailable)
                                tos.Add(p);
                        }

                        if (tos.Count > 0)
                        {
                            string position = card_use.Card.SkillPosition;
                            Player to = room.AskForPlayerChosen(player, tos, "zundi", "@zundi-to:::" + card.Name, false, false, position);
                            if (to != null)
                            {
                                if ((place == Place.PlaceDelayedTrick && from != player) || (place == Place.PlaceEquip && to != player))
                                {
                                    ResultStruct result = player.Result;
                                    result.Assist++;
                                    player.Result = result;
                                }

                                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, from.Name, to.Name);
                                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_TRANSFER, player.Name, "zundi", null)
                                {
                                    Card = card
                                };
                                room.MoveCardTo(card, from, to, place, reason);
                            }
                            room.RemoveTag("QiaobianTarget");
                        }
                    }
                }
            }
        }
    }
    public class YanjiaoSP : TriggerSkill
    {
        public YanjiaoSP() : base("yanjiao_sp")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Attack;
            view_as_skill = new YanjiaoSPVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (player.Alive && player.Phase == PlayerPhase.RoundStart && player.GetMark(Name) > 0)
            {
                int count = player.GetMark(Name);
                player.SetMark(Name, 0);
                room.DrawCards(player, count, Name);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }
    public class YanjiaoSPVS : ZeroCardViewAsSkill
    {
        public YanjiaoSPVS() : base("yanjiao_sp")
        {}

        public override bool IsEnabledAtPlay(Room room, Player player) => !player.IsKongcheng() && !player.HasUsed(YanjiaoSPCard.ClassName);

        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(YanjiaoSPCard.ClassName) { Skill = Name };
    }

    public class YanjiaoSPCard : SkillCard
    {
        public static string ClassName = "YanjiaoSPCard";
        public YanjiaoSPCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && to_select != Self;
        public override void Use(Room room, CardUseStruct card_use)
        {
            List<string> suits = new List<string>();
            Player player = card_use.From;
            Player target = card_use.To[0];
            foreach (int id in player.GetCards("h"))
            {
                WrappedCard card = room.GetCard(id);
                string suit = WrappedCard.GetSuitString(card.Suit);
                if (!suits.Contains(suit))
                    suits.Add(suit);
            }

            string choice = room.AskForChoice(player, "yanjiao_sp", string.Join("+", suits), new List<string> { "@yanjiao_sp-give:" + target.Name }, target, card_use.Card.SkillPosition);
            List<int> ids = new List<int>();
            foreach (int id in player.GetCards("h"))
            {
                WrappedCard card = room.GetCard(id);
                if (WrappedCard.GetSuitString(card.Suit) == choice)
                    ids.Add(id);

            }
            if (ids.Count > 0)
            {
                player.AddMark("yanjiao_sp", ids.Count);
                room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "yanjiao_sp", string.Empty), false);
            }

            if (player.Alive && target.Alive)
                room.Damage(new DamageStruct("yanjiao_sp", player, target));
        }
    }

    public class Difei : TriggerSkill
    {
        public Difei() : base("difei")
        {
            events.Add(TriggerEvent.Damaged);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Defense;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && !player.HasFlag(Name))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                player.SetFlags(Name);
                if (player.IsKongcheng() || !room.AskForDiscard(player, Name, 1, 1, true, false, "@difei", false, info.SkillPosition))
                    room.DrawCards(player, 1, Name);

                if (!player.IsKongcheng() && player.Alive && damage.Card != null)
                {
                    room.ShowAllCards(player, null, Name, info.SkillPosition);
                    bool same = false;
                    foreach (int id in player.GetCards("h"))
                    {
                        if (room.GetCard(id).Suit == damage.Card.Suit)
                        {
                            same = true;
                            break;
                        }
                    }

                    if (!same && player.Alive && player.IsWounded())
                        room.Recover(player);
                }
            }

            return false;
        }
    }

    //meiyanyan
    public class Hongyi : ZeroCardViewAsSkill
    {
        public Hongyi() : base("hongyi") { skill_type = SkillType.Wizzard; }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(HongyiCard.ClassName);
        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(HongyiCard.ClassName) { Skill = Name };
    }

    public class HongyiCard : SkillCard
    {
        public static string ClassName = "HongyiCard";
        public HongyiCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && to_select != Self;

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            player.SetTag("hongyi", target.Name);
            target.AddMark("hongyi");
            room.SetPlayerStringMark(target, "hongyi", string.Empty);
        }
    }

    public class HongyiEffect : TriggerSkill
    {
        public HongyiEffect() : base("#hongyi")
        {
            events = new List<TriggerEvent> { TriggerEvent.TurnStart, TriggerEvent.DamageCaused, TriggerEvent.Death };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if ((triggerEvent == TriggerEvent.TurnStart || triggerEvent == TriggerEvent.Death) && player.ContainsTag("hongyi") && player.GetTag("hongyi") is string target_name)
            {
                Player target = room.FindPlayer(target_name);
                if (target != null)
                {
                    target.AddMark("hongyi", -1);
                    if (target.GetMark("hongyi") == 0) room.RemovePlayerStringMark(target, "hongyi");
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.DamageCaused && player.Alive && player.GetMark("hongyi") > 0)
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            DamageStruct damage = (DamageStruct)data;
            JudgeStruct judge = new JudgeStruct
            {
                Good = true,
                PlayAnimation = false,
                Who = player,
                Reason = "hongyi"
            };

            room.Judge(ref judge);

            WrappedCard.CardSuit suit = judge.JudgeSuit;
            switch (suit)
            {
                case WrappedCard.CardSuit.Heart:
                case WrappedCard.CardSuit.Diamond:
                    {
                        if (damage.To.Alive) room.DrawCards(damage.To, 1, "hongyi");
                        break;
                    }
                case WrappedCard.CardSuit.Club:
                case WrappedCard.CardSuit.Spade:
                    {
                        LogMessage log = new LogMessage
                        {
                            Type = "#ReduceDamage2",
                            From = player.Name,
                            To = new List<string> { damage.To.Name },
                            Arg = "hongyi",
                            Arg2 = "1"
                        };
                        room.SendLog(log);
                        damage.Damage--;
                        if (damage.Damage < 1) return true;
                        data = damage;
                        break;
                    }
            }
            return false;
        }
    }

    public class Quanfeng : TriggerSkill
    {
        public Quanfeng() : base("quanfeng")
        {
            events = new List<TriggerEvent> { TriggerEvent.Death, TriggerEvent.Dying };
            frequency = Frequency.Limited;
            skill_type = SkillType.Recover;
            limit_mark = "@quanfeng";
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.Death)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p != player && p.GetMark(limit_mark) > 0)
                        triggers.Add(new TriggerStruct(Name, p));
            }
            else
            {
                if (base.Triggerable(player, room) && player.GetMark(limit_mark) > 0)
                    triggers.Add(new TriggerStruct(Name, player));
            }
            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.DoSuperLightbox(ask_who, info.SkillPosition, Name);
                room.SetPlayerMark(ask_who, limit_mark, 0);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.Death)
            {
                List<string> skills = new List<string> ();
                foreach (string skill_name in Engine.GetGeneralSkills(player.ActualGeneral1, room.Setting.GameMode, true))
                {
                    Skill s = Engine.GetSkill(skill_name);
                    if (!s.LordSkill && s.SkillFrequency < Frequency.Limited)
                        skills.Add(skill_name);                    
                }
                room.HandleAcquireDetachSkills(ask_who, "-hongyi", false);
                if (ask_who.Alive && skills.Count > 0)
                    room.HandleAcquireDetachSkills(ask_who, skills, true);

                room.FilterCards(ask_who, ask_who.GetCards("he"), true);

                if (ask_who.Alive)
                {
                    ask_who.MaxHp++;
                    room.BroadcastProperty(ask_who, "MaxHp");

                    LogMessage log = new LogMessage
                    {
                        Type = "$GainMaxHp",
                        From = ask_who.Name,
                        Arg = "1"
                    };
                    room.SendLog(log);

                    room.RoomThread.Trigger(TriggerEvent.MaxHpChanged, room, ask_who);
                    room.Recover(ask_who, 1);
                }
            }
            else
            {
                ask_who.MaxHp += 2;
                room.BroadcastProperty(ask_who, "MaxHp");

                LogMessage log = new LogMessage
                {
                    Type = "$GainMaxHp",
                    From = ask_who.Name,
                    Arg = "2"
                };
                room.SendLog(log);

                room.RoomThread.Trigger(TriggerEvent.MaxHpChanged, room, ask_who);
                room.Recover(ask_who, 4);
            }

            return false;
        }
    }

    public class Zhaohuo : TriggerSkill
    {
        public Zhaohuo() : base("zhaohuo")
        {
            skill_type = SkillType.Masochism;
            events = new List<TriggerEvent> { TriggerEvent.Dying };
            frequency = Frequency.Compulsory;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.Dying)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p != player && p.MaxHp > 1) triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);

            int count = ask_who.MaxHp - 1;
            room.LoseMaxHp(ask_who, count);
            if (ask_who.Alive)
                room.DrawCards(ask_who, count, Name);

            return false;
        }
    }
    public class Yixiang : TriggerSkill
    {
        public Yixiang() : base("yixiang")
        {
            events.Add(TriggerEvent.TargetConfirmed);
            skill_type = SkillType.Defense;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && base.Triggerable(player, room) && use.From != null && use.From.Alive && use.From.Hp > player.Hp
                && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill && !player.HasFlag(Name))
            {
                bool slash = false, jink = false, peach = false, ana = false;
                foreach (int id in player.GetCards("h"))
                {
                    WrappedCard card = room.GetCard(id);
                    if (card.Name.Contains(Slash.ClassName))
                        slash = true;
                    else if (card.Name == Jink.ClassName)
                        jink = true;
                    else if (card.Name == Peach.ClassName)
                        peach = true;
                    else if (card.Name == Analeptic.ClassName)
                        ana = true;
                }
                if (!slash || !jink || !peach || !ana)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, data , info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            player.SetFlags(Name);

            bool slash = false, jink = false, peach = false, ana = false;
            foreach (int id in player.GetCards("h"))
            {
                WrappedCard card = room.GetCard(id);
                if (card.Name.Contains(Slash.ClassName))
                    slash = true;
                else if (card.Name == Jink.ClassName)
                    jink = true;
                else if (card.Name == Peach.ClassName)
                    peach = true;
                else if (card.Name == Analeptic.ClassName)
                    ana = true;
            }

            List<int> get = new List<int>();
            foreach (int id in room.DrawPile)
            {
                WrappedCard card = room.GetCard(id);
                if (card.Name.Contains(Slash.ClassName) && !slash)
                {
                    get.Add(id);
                    break;
                }
                else if (card.Name == Jink.ClassName && !jink)
                {
                    get.Add(id);
                    break;
                }
                else if (card.Name == Peach.ClassName && !peach)
                {
                    get.Add(id);
                    break;
                }
                else if (card.Name == Analeptic.ClassName && !ana)
                {
                    get.Add(id);
                    break;
                }
            }

            if (get.Count > 0)
                room.ObtainCard(player, ref get, new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, Name, string.Empty));

            return false;
        }
    }

    public class Yirang : TriggerSkill
    {
        public Yirang() : base("yirang")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Recover;
        }

        public override bool Triggerable(Player target, Room room)
        {
            if (base.Triggerable(target, room) && target.Phase == PlayerPhase.Play && !target.IsNude())
            {
                bool check = false;
                foreach (int id in target.GetCards("he"))
                {
                    if (Engine.GetFunctionCard(room.GetCard(id).Name).TypeID != CardType.TypeBasic)
                    {
                        check = true;
                        break;
                    }
                }

                if (check)
                {
                    foreach (Player p in room.GetOtherPlayers(target))
                        if (p.MaxHp > target.MaxHp)
                            return true;
                }
            }

            return false;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (p.MaxHp > player.MaxHp) targets.Add(p);

            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@yirang", true, true, info.SkillPosition);
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
            Player target = (Player)room.GetTag(Name);
            room.RemoveTag(Name);

            int count = target.MaxHp - player.MaxHp;
            bool equip = false, trick = false;
            List<int> ids = new List<int>();
            foreach (int id in player.GetCards("he"))
            {
                CardType type = Engine.GetFunctionCard(room.GetCard(id).Name).TypeID;
                if (type == CardType.TypeBasic) continue;
                if (type == CardType.TypeTrick)
                    trick = true;
                else if (type == CardType.TypeEquip)
                    equip = true;

                ids.Add(id);
            }
            int heal = 0;
            if (equip) heal++;
            if (trick) heal++;

            ResultStruct result = player.Result;
            result.Assist += ids.Count;
            player.Result = result;

            room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty), false);

            if (player.Alive)
            {
                player.MaxHp += count;
                room.BroadcastProperty(player, "MaxHp");

                LogMessage log = new LogMessage
                {
                    Type = "$GainMaxHp",
                    From = player.Name,
                    Arg = count.ToString()
                };
                room.SendLog(log);

                room.RoomThread.Trigger(TriggerEvent.MaxHpChanged, room, player);
            }
            if (player.Alive && player.IsWounded())
            {
                RecoverStruct recover = new RecoverStruct
                {
                    Who = player,
                    Recover = Math.Min(heal, player.GetLostHp())
                };
                room.Recover(player, recover, true);
            }

            return false;
        }
    }

    public class Kuangcai : TriggerSkill
    {
        public Kuangcai() : base("kuangcai")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.HasFlag(Name))
            {
                room.SetPlayerFlag(player, "-kuangcai");
                room.SetPlayerMark(player, Name, 0);
                room.RemovePlayerStringMark(player, Name);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, null, info.SkillPosition))
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SetPlayerFlag(player, Name);
            room.SetPlayerStringMark(player, Name, "0");
            return false;
        }
    }

    public class KuangcaiDraw : TriggerSkill
    {
        public KuangcaiDraw() : base("#kuangcai")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded };
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && player.HasFlag("kuangcai") && data is CardUseStruct use
                && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill && player.GetMark("kuangcai") < 5)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.CardResponded && player.HasFlag("kuangcai") && data is CardResponseStruct resp && resp.Use && player.GetMark("kuangcai") < 5)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, "kuangcai");
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, "kuangcai", info.SkillPosition);
            room.BroadcastSkillInvoke("kuangcai", "male", 2, gsk.General, gsk.SkinId);
            room.AddPlayerMark(player, "kuangcai");
            room.SetPlayerStringMark(player, "kuangcai", player.GetMark("kuangcai").ToString());

            if (player.GetMark("kuangcai") >= 5)
                player.SetFlags("Global_PlayPhaseTerminated");

            room.DrawCards(player, 1, "kuangcai");

            return false;
        }
    }

    public class KuangcaiTar : TargetModSkill
    {
        public KuangcaiTar() : base("#kuangcai-tar", false) { pattern = "."; }

        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseStruct.CardUseReason reason, string pattern) => from.HasFlag("kuangcai") ? true : false;
        public override int GetResidueNum(Room room, Player from, WrappedCard card) => from.HasFlag("kuangcai") ? 999 : 0;
    }

    public class Shejian : TriggerSkill
    {
        public Shejian() : base("shejian")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseEnd, TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Attack;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && base.Triggerable(move.From, room)
                && move.From.Phase == PlayerPhase.Discard && move.From == room.Current && move.Reason.PlayerId == move.From.Name
                && (move.From_places.Contains(Place.PlaceEquip) || move.From_places.Contains(Place.PlaceHand))
                && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD)
            {
                List<int> ids = move.From.ContainsTag(Name) ? (List<int>)move.From.GetTag(Name) : new List<int>();
                foreach (int id in move.Card_ids)
                    if (!ids.Contains(id)) ids.Add(id);

                move.From.SetTag(Name, ids);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Discard && player.ContainsTag(Name))
                player.RemoveTag(Name);
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseEnd && player.Phase == PlayerPhase.Discard && base.Triggerable(player, room) && player.ContainsTag(Name)
                && player.GetTag(Name) is List<int> ids)
            {
                if (ids.Count > 1)
                {
                    bool check = true;
                    for (int x = 0; x < ids.Count; x++)
                    {
                        WrappedCard card = room.GetCard(ids[x]);
                        for (int y = x + 1; y < ids.Count; y++)
                        {
                            WrappedCard card2 = room.GetCard(ids[y]);
                            if (card.Suit == card2.Suit)
                            {
                                check = false;
                                break;
                            }
                        }

                        if (!check) break;
                    }

                    if (check) return new TriggerStruct(Name, player);
                }
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player erzhang, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (!p.IsNude() && RoomLogic.CanDiscard(room, player, p, "he"))
                    targets.Add(p);

            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@shejian", true, true, info.SkillPosition);
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
            Player target = (Player)room.GetTag(Name);
            room.RemoveTag(Name);
            int id = room.AskForCardChosen(ask_who, target, "he", Name, false, FunctionCard.HandlingMethod.MethodDiscard);
            room.ThrowCard(id, target, ask_who);

            return false;
        }
    }

    public class ChijieNSM : TriggerSkill
    {
        public ChijieNSM() : base("chijie_nsm")
        {
            events.Add(TriggerEvent.GameStart);
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<string> kingdoms = new List<string>();
            foreach (Player p in room.GetAlivePlayers())
            {
                if (p.Kingdom != player.Kingdom && !kingdoms.Contains(p.Kingdom))
                    kingdoms.Add(p.Kingdom);
            }
            if (kingdoms.Count > 0)
            {
                kingdoms.Add("cancel");
                string choice = room.AskForChoice(player, Name, string.Join("+", kingdoms), null, null, info.SkillPosition);
                if (choice != "cancel")
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.NotifySkillInvoked(player, Name);
                    player.SetTag(Name, choice);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.ContainsTag(Name) && player.GetTag(Name) is string kingdom)
            {
                player.Kingdom = kingdom;
                room.BroadcastProperty(player, "Kingdom");

                LogMessage log = new LogMessage
                {
                    Type = "#change_kingdom",
                    From = player.Name,
                    Arg = kingdom
                };
                room.SendLog(log);
            }

            return false;
        }
    }

    public class Waishi : ViewAsSkill
    {
        public Waishi() : base("waishi")
        {
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            List<string> kingdoms = new List<string>();
            foreach (Player p in room.GetAlivePlayers())
            {
                if (!kingdoms.Contains(p.Kingdom))
                    kingdoms.Add(p.Kingdom);
            }
            return selected.Count < kingdoms.Count;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.IsNude() && player.UsedTimes(WaishiCard.ClassName) < 1 + player.GetMark("renshe");
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
            {
                WrappedCard ws = new WrappedCard(WaishiCard.ClassName) { Skill = Name };
                ws.AddSubCards(cards);
                return ws;
            }

            return null;
        }
    }

    public class WaishiCard : SkillCard
    {
        public static string ClassName = "WaishiCard";
        public WaishiCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && card.SubCards.Count <= to_select.HandcardNum && to_select != Self;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player a = card_use.From;
            Player b = card_use.To[0];

            List<int> from = new List<int>(card_use.Card.SubCards);
            List<int> tos = new List<int>(b.GetCards("h")), to = new List<int>();
            Shuffle.shuffle(ref tos);
            for (int i = 0; i < from.Count; i++)
                to.Add(tos[i]);

            CardsMoveStruct move1 = new CardsMoveStruct(from, b, Place.PlaceHand,
                new CardMoveReason(MoveReason.S_REASON_SWAP, a.Name, b.Name, "waishi", null));
            CardsMoveStruct move2 = new CardsMoveStruct(to, a, Place.PlaceHand,
                new CardMoveReason(MoveReason.S_REASON_SWAP, b.Name, a.Name, "waishi", null));
            List<CardsMoveStruct> exchangeMove = new List<CardsMoveStruct> { move1, move2 };
            room.MoveCards(exchangeMove, false);

            if (b.Kingdom == a.Kingdom || b.HandcardNum > a.HandcardNum)
                room.DrawCards(a, 1, "waishi");
        }
    }

    public class Renshe : TriggerSkill
    {
        public Renshe() : base("renshe")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Masochism;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && player.GetMark(Name) > 0)
            {
                if (change.To == PlayerPhase.Play)
                    player.SetFlags(Name);
                if (change.From == PlayerPhase.Play && player.HasFlag(Name))
                {
                    player.SetFlags("-renshe");
                    player.SetMark(Name, 0);
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<string> choices = new List<string> { "more", "draw" };
            List<string> kingdoms = new List<string>();
            foreach (Player p in room.GetAlivePlayers())
            {
                if (p.Kingdom != player.Kingdom && !kingdoms.Contains(p.Kingdom))
                    kingdoms.Add(p.Kingdom);
            }
            if (kingdoms.Count > 0)
                choices.Add("change");

            choices.Add("cancel");
            string choice = room.AskForChoice(player, Name, string.Join("+", choices), null, null, info.SkillPosition);
            if (choice != "cancel")
            {
                player.SetTag(Name, choice);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.NotifySkillInvoked(player, Name);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.GetTag(Name) is string choice)
            {
                player.RemoveTag(Name);
                switch (choice)
                {
                    case "more":
                        player.AddMark(Name);
                        break;
                    case "draw":
                        Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@renshe", false, true, info.SkillPosition);
                        List<Player> targets = new List<Player> { player, target };
                        room.SortByActionOrder(ref targets);
                        foreach (Player p in targets)
                            room.DrawCards(p, new DrawCardStruct(1, player, Name));
                        break;
                    case "change":
                        List<string> kingdoms = new List<string>();
                        foreach (Player p in room.GetAlivePlayers())
                        {
                            if (p.Kingdom != player.Kingdom && !kingdoms.Contains(p.Kingdom))
                                kingdoms.Add(p.Kingdom);
                        }
                        string kingdom = room.AskForChoice(player, Name, string.Join("+", kingdoms), null, null, info.SkillPosition);
                        player.Kingdom = kingdom;
                        room.BroadcastProperty(player, "Kingdom");

                        LogMessage log = new LogMessage
                        {
                            Type = "#change_kingdom",
                            From = player.Name,
                            Arg = kingdom
                        };
                        room.SendLog(log);
                        break;
                }
            }

            return false;
        }
    }

    public class Zhaohan : TriggerSkill
    {
        public Zhaohan() : base("zhaohan")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Start && player.GetMark(Name) < 7)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            return info;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name, true);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            if (player.GetMark(Name) < 4)
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
            }
            else
            {
                room.LoseMaxHp(player);
            }
            if (player.Alive)
                player.AddMark(Name);

            return false;
        }
    }

    public class Rangjie : MasochismSkill
    {
        public Rangjie() : base("rangjie")
        {
            view_as_skill = new YijiVS();
            frequency = Frequency.Frequent;
            skill_type = SkillType.Masochism;
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
            List<string> choices = new List<string> { "get", "cancel" };
            foreach (Player p in room.GetAlivePlayers())
            {
                if (p.GetCards("ej").Count > 0)
                {
                    choices.Insert(0, "move");
                    break;
                }
            }

            string choice = room.AskForChoice(player, Name, string.Join("+", choices), null, null, info.SkillPosition);
            if (choice != "cancel")
            {
                player.SetTag(Name, choice);
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override void OnDamaged(Room room, Player player, DamageStruct damage, TriggerStruct info)
        {
            if (player.GetTag(Name) is string choice)
            {
                player.RemoveTag(Name);
                if (choice == "move")
                {
                    List<Player> targets = new List<Player>();
                    foreach (Player p in room.GetAlivePlayers())
                        if (p.GetCards("ej").Count > 0) targets.Add(p);

                    if (targets.Count > 0)
                    {
                        Player from = room.AskForPlayerChosen(player, targets, Name, "@rangjie-move", false, false, info.SkillPosition);

                        room.SetTag("QiaobianTarget", from);
                        int card_id = room.AskForCardChosen(player, from, "ej", Name);
                        WrappedCard card = room.GetCard(card_id);
                        Place place = room.GetCardPlace(card_id);

                        FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                        int equip_index = -1;
                        if (place == Place.PlaceEquip)
                        {
                            EquipCard equip = (EquipCard)fcard;
                            equip_index = (int)equip.EquipLocation();
                        }

                        List<Player> tos = new List<Player>();
                        foreach (Player p in room.GetOtherPlayers(from))
                        {
                            if (equip_index != -1)
                            {
                                if (p.GetEquip(equip_index) < 0 && RoomLogic.CanPutEquip(p, card))
                                    tos.Add(p);
                            }
                            else if (RoomLogic.IsProhibited(room, null, p, card) == null && !RoomLogic.PlayerContainsTrick(room, p, card.Name) && p.JudgingAreaAvailable)
                                tos.Add(p);
                        }

                        Player to = room.AskForPlayerChosen(player, tos, Name, "@rangjie-to:::" + card.Name, false, false, info.SkillPosition);
                        if (to != null)
                        {
                            if ((place == Place.PlaceDelayedTrick && from != player) || (place == Place.PlaceEquip && to != player))
                            {
                                ResultStruct result = player.Result;
                                result.Assist++;
                                player.Result = result;
                            }

                            room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, from.Name, to.Name);
                            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_TRANSFER, player.Name, Name, null)
                            {
                                Card = card
                            };
                            room.MoveCardTo(card, from, to, place, reason);
                        }
                        room.RemoveTag("QiaobianTarget");
                    }
                }
                else
                {
                    choice = room.AskForChoice(player, Name, "basic+equip+trick", new List<string> { "@rangjie" }, null, info.SkillPosition);
                    List<int> ids = new List<int>();
                    foreach (int id in room.DrawPile)
                    {
                        WrappedCard card = room.GetCard(id);
                        FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                        if (fcard.TypeID == CardType.TypeBasic && choice == "basic")
                        {
                            ids.Add(id);
                            break;
                        }
                        else if (fcard.TypeID == CardType.TypeEquip && choice == "equip")
                        {
                            ids.Add(id);
                            break;
                        }
                        else if (fcard.TypeID == CardType.TypeTrick && choice == "trick")
                        {
                            ids.Add(id);
                            break;
                        }
                    }
                    if (ids.Count > 0)
                    {
                        CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name, Name, string.Empty);
                        room.ObtainCard(player, ref ids, reason, true);
                    }
                }

                if (player.Alive)
                    room.DrawCards(player, 1, Name);
            }
        }
    }

    public class Yizheng : ZeroCardViewAsSkill
    {
        public Yizheng() : base("yizheng")
        {
            skill_type = SkillType.Attack;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(YizhengCard.ClassName) && !player.IsKongcheng();
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(YizhengCard.ClassName) { Skill = Name };
        }
    }

    public class YizhengCard : SkillCard
    {
        public static string ClassName = "YizhengCard";
        public YizhengCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self && RoomLogic.CanBePindianBy(room, to_select, Self) && to_select.Hp <= Self.Hp;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0], player = card_use.From;
            PindianStruct pd = room.PindianSelect(player, target, "yizheng");

            room.Pindian(ref pd);
            if (pd.Success)
            {
                if (target.Alive)
                {
                    target.AddMark("yizheng", 1);
                    room.SetPlayerStringMark(target, "yizheng", target.GetMark("yizheng").ToString());
                }
            }
            else
            {
                room.LoseMaxHp(player);
            }
        }
    }

    public class YizhengEffect : TriggerSkill
    {
        public YizhengEffect() : base("#yizheng")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.GetMark("yizheng") > 0 && data is PhaseChangeStruct change && change.To == PlayerPhase.Draw)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            LogMessage log = new LogMessage
            {
                Type = "$SkipPhase",
                From = player.Name,
                Arg = "draw"
            };
            room.SendLog(log);

            player.AddMark("yizheng", -1);
            if (player.GetMark("yizheng") == 0)
                room.RemovePlayerStringMark(player, "yizheng");
            else
                room.SetPlayerStringMark(player, "yizheng", player.GetMark("yizheng").ToString());

            return true;
        }
    }

    public class Zhouxuan : TriggerSkill
    {
        public Zhouxuan() : base("zhouxuan")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.CardUsedAnnounced, TriggerEvent.CardResponded };
            skill_type = SkillType.Wizzard;
            view_as_skill = new ZhouxuanVS();
            priority = new Dictionary<TriggerEvent, double>
            {
                { TriggerEvent.EventPhaseStart, 3 },
                { TriggerEvent.CardUsedAnnounced, 2 },
                {TriggerEvent.CardResponded, 2 }
            };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if ((triggerEvent == TriggerEvent.CardUsedAnnounced || triggerEvent == TriggerEvent.CardResponded) && player.ContainsTag(Name))
                player.RemoveTag(Name);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish && !player.IsNude())
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.AskForUseCard(player, RespondType.Skill, "@@zhouxuan", "@zhouxuan", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
            return new TriggerStruct();
        }
    }

    public class ZhouxuanVS : OneCardViewAsSkill
    {
        public ZhouxuanVS() : base("zhouxuan")
        {
            response_pattern = "@@zhouxuan";
        }

        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            return RoomLogic.CanDiscard(room, player, player, to_select.Id);
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard zx = new WrappedCard(ZhouxuanCard.ClassName) { Skill = Name };
            zx.AddSubCard(card);
            return zx;
        }
    }

    public class ZhouxuanCard : SkillCard
    {
        public static string ClassName = "ZhouxuanCard";
        public ZhouxuanCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            List<string> choices = new List<string> { "trick", "equip" };
            List<string> basic = ViewAsSkill.GetGuhuoCards(room, "b");
            foreach (string card in basic)
            {
                if (card != Slash.ClassName && card.Contains(Slash.ClassName)) continue;
                choices.Add(card);
            }

            string choice = room.AskForChoice(player, "zhouxuan", string.Join("+", choices), new List<string> { "@zhouxuan-ann:" + target.Name }, target, card_use.Card.SkillPosition);
            Dictionary<string, string> zhouxuan_dic = target.ContainsTag("zhouxuan") ? (Dictionary<string, string>)target.GetTag("zhouxuan") : new Dictionary<string, string>();
            zhouxuan_dic.Remove(player.Name);
            zhouxuan_dic.Add(player.Name, choice);
            target.SetTag("zhouxuan", zhouxuan_dic);
        }
    }

    public class ZhouxuanEffect : TriggerSkill
    {
        public ZhouxuanEffect() : base("#zhouxuan")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsedAnnounced, TriggerEvent.CardResponded };
            frequency = Frequency.Compulsory;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.ContainsTag("zhouxuan") && player.GetTag("zhouxuan") is Dictionary<string, string> zhouxuan)
            {
                string card_name = string.Empty;
                if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use)
                    card_name = use.Card.Name;
                else if (data is CardResponseStruct resp)
                    card_name = resp.Card.Name;

                FunctionCard fcard = Engine.GetFunctionCard(card_name);
                foreach (string player_name in zhouxuan.Keys)
                {
                    Player p = room.FindPlayer(player_name);
                    if (p != null)
                    {
                        string choice = zhouxuan[player_name];
                        if (choice == "trick" && fcard is TrickCard)
                            triggers.Add(new TriggerStruct(Name, p));
                        else if (choice == "equip" && fcard is EquipCard)
                            triggers.Add(new TriggerStruct(Name, p));
                        else if (card_name.Contains(choice))
                            triggers.Add(new TriggerStruct(Name, p));
                    }
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player guojia, TriggerStruct info)
        {
            List<int> yiji_cards = room.GetNCards(3);
            List<int> origin_yiji = new List<int>(yiji_cards);

            while (guojia.Alive && yiji_cards.Count > 0)
            {
                guojia.PileChange("#zhouxuan", yiji_cards);
                if (!room.AskForYiji(guojia, ref yiji_cards, "zhouxuan", true, false, true, -1, room.GetAlivePlayers(), null, "@zhouxuan-atri", "#zhouxuan", false, info.SkillPosition))
                    break;

                guojia.Piles["#zhouxuan"].Clear();
            }
            if (guojia.GetPile("#zhouxuan").Count > 0) guojia.Piles["#zhouxuan"].Clear();
            if (yiji_cards.Count > 0)
                room.ReturnToDrawPile(yiji_cards, false);

            return false;
        }
    }

    public class Fengji : TriggerSkill
    {
        public Fengji() : base("fengji")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.EventPhaseChanging };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Replenish;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (player.Alive && triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                player.SetTag(Name, player.HandcardNum);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.RoundStart && player.ContainsTag(Name) && player.GetTag(Name) is int count
                && player.HandcardNum >= count)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name, true);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            player.SetFlags(Name);
            room.DrawCards(player, 2, Name);
            return false;
        }
    }

    public class FengjiMax : MaxCardsSkill
    {
        public FengjiMax() : base("#fengji")
        {
        }
        public override int GetFixed(Room room, Player target)
        {
            if (target.HasFlag("fengji"))
            {
                return target.MaxHp;
            }
            return -1;
        }
    }

    public class Chengzhao : TriggerSkill
    {
        public Chengzhao() : base("chengzhao")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.EventPhaseStart, TriggerEvent.CardsMoveOneTime, TriggerEvent.TargetChosen };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To != null && move.To_place == Place.PlaceHand)
            {
                move.To.AddMark(Name, move.Card_ids.Count);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (p.GetMark(Name) > 0)
                        p.SetMark(Name, 0);
            }
            else if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use)
            {
                if (use.Card != null && use.Card.GetSkillName() == Name)
                {
                    foreach (Player p in use.To)
                        if (p.HasFlag(Name))
                            p.AddQinggangTag(RoomLogic.CardToString(room, use.Card));
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p.GetMark(Name) >= 2 && !p.IsKongcheng()) triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(ask_who))
            {
                if (!p.IsKongcheng() && RoomLogic.CanBePindianBy(room, p, ask_who))
                    targets.Add(p);
            }

            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(ask_who, targets, Name, "@chengzhao", true, true, info.SkillPosition);
                if (target != null)
                {
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    ask_who.SetTag(Name, target.Name);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (ask_who.GetTag(Name) is string player_name)
            {
                Player target = room.FindPlayer(player_name);
                ask_who.RemoveTag(Name);

                PindianStruct pd = room.PindianSelect(ask_who, target, Name);
                room.Pindian(ref pd);

                if (pd.Success)
                {
                    target.SetFlags(Name);
                    WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_chengzhao" };
                    room.UseCard(new CardUseStruct(slash, ask_who, target));
                }
            }

            return false;
        }
    }

    public class Jinfan : TriggerSkill
    {
        public Jinfan() : base("jinfan")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime };
            view_as_skill = new JinfanVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From_pile_names.Contains("&ring")
                && move.From_places.Contains(Place.PlaceSpecial) && base.Triggerable(move.From, room))
            {
                List<WrappedCard.CardSuit> suits = new List<WrappedCard.CardSuit>();
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    if (move.From_pile_names[i] == "&ring")
                    {
                        WrappedCard.CardSuit suit = room.GetCard(move.Card_ids[i]).Suit;
                        if (!suits.Contains(suit))
                            suits.Add(suit);
                    }
                }

                if (suits.Count > 0)
                {
                    List<int> get = new List<int>();
                    foreach (int id in room.DrawPile)
                    {
                        WrappedCard.CardSuit suit = room.GetCard(id).Suit;
                        if (suits.Contains(suit))
                        {
                            suits.Remove(suit);
                            get.Add(id);
                        }
                        if (suits.Count == 0)
                            break;
                    }

                    if (get.Count > 0)
                        room.ObtainCard(move.From, ref get, new CardMoveReason(MoveReason.S_REASON_GOTCARD, move.From.Name, Name, string.Empty));
                }
            }
            /*
            else if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.RoundStart && player.GetPile("&ring").Count > 0)
            {
                List<int> ids = player.GetPile("&ring");
                room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_EXCHANGE_FROM_PILE, player.Name, Name, string.Empty), false);
            }
            */
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Discard && !player.IsKongcheng()
                && player.GetPile("&ring").Count < 4)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.AskForUseCard(player, RespondType.Skill, "@@jinfan", "@jinfan", null, -1, HandlingMethod.MethodUse, false, info.SkillPosition);
            return new TriggerStruct();
        }
    }

    public class JinfanVS : ViewAsSkill
    {
        public JinfanVS() : base("jinfan")
        {
            response_pattern = "@@jinfan";
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            List<string> patterns = new List<string> { "spade", "heart", "club", "diamond" };
            foreach (int id in player.GetPile("&ring"))
                patterns.Remove(WrappedCard.GetSuitString(room.GetCard(id).Suit));

            foreach (WrappedCard card in selected)
                patterns.Remove(WrappedCard.GetSuitString(card.Suit));

            return selected.Count < 4 - player.GetPile("&ring").Count && patterns.Contains(WrappedCard.GetSuitString(to_select.Suit));
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
            {
                WrappedCard jf = new WrappedCard(JinfanCard.ClassName) { Skill = Name };
                jf.AddSubCards(cards);
                return jf;
            }
            else
                return null;
        }
    }

    public class JinfanCard : SkillCard
    {
        public static string ClassName = "JinfanCard";
        public JinfanCard() : base(ClassName)
        {
            will_throw = false;
            target_fixed = true;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            room.AddToPile(card_use.From, "&ring", card_use.Card.SubCards, false);
        }
    }
    public class Sheque : TriggerSkill
    {
        public Sheque() : base("sheque")
        {
            skill_type = SkillType.Attack;
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.TargetChosen, TriggerEvent.CardUsedAnnounced };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && use.Pattern == "Slash:sheque")
            {
                room.ShowSkill(player, Name, string.Empty);
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player);
            }
            else if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct _use && _use.Pattern == "Slash:sheque")
            {
                foreach (Player p in _use.To)
                    p.AddQinggangTag(RoomLogic.CardToString(room, _use.Card));
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.Start && player.HasEquip())
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (player != p) triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Alive && ask_who.Alive)
            {
                ask_who.SetFlags("slashTargetFix");
                player.SetFlags("SlashAssignee");

                WrappedCard used = room.AskForUseCard(ask_who, RespondType.Slash, "Slash:sheque", "@sheque-slash:" + player.Name, null, -1, HandlingMethod.MethodUse, false, info.SkillPosition);
                if (used == null)
                {
                    ask_who.SetFlags("-slashTargetFix");
                    player.SetFlags("-SlashAssignee");
                }
            }

            return new TriggerStruct();
        }
    }

    public class ShequeTag : TargetModSkill
    {
        public ShequeTag() : base("#sheque", false) { }
        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseStruct.CardUseReason reason, string pattern)
        {
            if (reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE && to.HasFlag("SlashAssignee")
                && (room.GetRoomState().GetCurrentResponseSkill() == "sheque" || pattern == "Slash:sheque"))
                return true;

            return false;
        }
    }

    public class Weifeng : TriggerSkill
    {
        public Weifeng() : base("weifeng")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageInflicted, TriggerEvent.CardFinished, TriggerEvent.EventPhaseStart, TriggerEvent.Death };
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.DamageInflicted && data is DamageStruct damage && damage.Card != null && player.Alive
                && player.ContainsTag(Name) && player.GetTag(Name) is KeyValuePair<string, string> wei)
            {
                string card = damage.Card.Name.Contains(Slash.ClassName) ? Slash.ClassName : damage.Card.Name;
                if (wei.Value == card)
                {
                    damage.Damage++;
                    data = damage;
                }
                else
                {
                    Player from = room.FindPlayer(wei.Key);
                    if (from != null && !player.IsNude() && RoomLogic.CanGetCard(room, from, player, "he"))
                    {
                        int card_id = room.AskForCardChosen(from, player, "he", Name, false, HandlingMethod.MethodGet);
                        CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_EXTRACTION, from.Name);
                        room.ObtainCard(from, room.GetCard(card_id), reason, room.GetCardPlace(card_id) != Place.PlaceHand);
                    }
                }
            }
            else if ((triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Start) || triggerEvent == TriggerEvent.Death)
            {
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.ContainsTag(Name) && p.GetTag(Name) is KeyValuePair<string, string> weifeng)
                    {
                        if (weifeng.Key == player.Name)
                        {
                            room.RemovePlayerStringMark(p, Name);
                            p.RemoveTag(Name);
                        }
                    }
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardFinished && !player.HasFlag(Name) && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play
                && data is CardUseStruct use && (use.Card.Name.Contains(Slash.ClassName) || use.Card.Name == Duel.ClassName || use.Card.Name == FireAttack.ClassName
                || use.Card.Name == ArcheryAttack.ClassName || use.Card.Name == SavageAssault.ClassName))
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            player.SetFlags(Name);
            List<Player> targets = new List<Player>();
            if (data is CardUseStruct use)
            {
                foreach (Player p in use.To)
                {
                    if (p != player && !p.ContainsTag(Name))
                        targets.Add(p);
                }

                if (targets.Count > 0)
                {
                    string card = use.Card.Name.Contains(Slash.ClassName) ? Slash.ClassName : use.Card.Name;
                    Player target = room.AskForPlayerChosen(player, targets, Name, "@weifeng:::" + card, false, true, info.SkillPosition);
                    if (target != null)
                    {
                        room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                        room.SetPlayerStringMark(target, Name, card);
                        target.SetTag(Name, new KeyValuePair<string, string>(player.Name, card));
                        return info;
                    }
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            return false;
        }
    }

    public class ZhiyanXH : TriggerSkill
    {
        public ZhiyanXH() : base("zhiyan_xh")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            view_as_skill = new ZhiyanXHVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is PhaseChangeStruct change && change.From == PlayerPhase.Play)
            {
                if (player.HasFlag(Name))
                    player.SetFlags("-zhiyan_xh");

                if (player.GetMark(Name) > 0)
                    player.SetMark(Name, 0);

                if (player.GetMark("zhiyan_used") > 0)
                    player.SetMark("zhiyan_used", 0);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class ZhiyanXHVS : ViewAsSkill
    {
        public ZhiyanXHVS() : base("zhiyan_xh")
        {
            response_pattern = "@@zhiyan_xh";
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            if (player.GetMark("zhiyan_used") < 2)
            {
                int mark = player.GetMark(Name);
                List<string> choices = new List<string>();
                if ((mark == 2 || mark == 0) && player.HandcardNum < player.MaxHp) choices.Add("draw");
                if (mark <= 1 && player.HandcardNum - player.Hp > 0) choices.Add("give");

                return choices.Count > 0;
            }

            return false;
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (room.GetRoomState().GetCurrentCardUsePattern() == response_pattern)
                return selected.Count < player.HandcardNum - player.Hp && player.GetCards("he").Contains(to_select.Id);
            else
                return false;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (room.GetRoomState().GetCurrentCardUsePattern() == response_pattern)
            {
                if (cards.Count == player.HandcardNum - player.Hp)
                {
                    WrappedCard card = new WrappedCard(ZhiyanCard.ClassName) { Skill = Name, Mute = true };
                    card.AddSubCards(cards);
                    return card;
                }
            }
            else
                return new WrappedCard(ZhiyanCard.ClassName) { Skill = Name };

            return null;
        }
    }

    public class ZhiyanCard : SkillCard
    {
        public static string ClassName = "ZhiyanCard";
        public ZhiyanCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (card.SubCards.Count > 0)
                return targets.Count == 0 && to_select != Self;
            else
                return false;
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            if (card.SubCards.Count > 0)
                return targets.Count == 1;
            else
                return true;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            if (card_use.Pattern == "@@zhiyan_xh")
            {
                ResultStruct result = card_use.From.Result;
                result.Assist += card_use.Card.SubCards.Count;
                card_use.From.Result = result;

                Player target = card_use.To[0];
                List<int> give = new List<int>(card_use.Card.SubCards);
                room.ObtainCard(target, ref give, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "zhiyan_sp", string.Empty), false);
            }
            else
            {
                player.AddMark("zhiyan_used");
                string choice = player.GetMark("zhiyan_xh") == 1 ? "give" : "draw";
                if (player.GetMark("zhiyan_xh") == 0)
                {
                    List<string> choices = new List<string>();
                    if (player.HandcardNum < player.MaxHp) choices.Add("draw");
                    if (player.HandcardNum - player.Hp > 0) choices.Add("give");
                    choice = room.AskForChoice(player, "zhiyan_xh", string.Join("+", choices), null, null, card_use.Card.SkillPosition);
                }

                player.SetMark("zhiyan_xh", choice == "give" ? 2 : 1);
                if (choice == "draw")
                {
                    room.DrawCards(player, player.MaxHp - player.HandcardNum, "zhiyan_xh");
                    player.SetFlags("zhiyan_xh");
                }
                else
                {
                    WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@zhiyan_xh", string.Format("@zhiyan_xh:::{0}", player.HandcardNum - player.Hp),
                        null, -1, HandlingMethod.MethodUse, true, card_use.Card.SkillPosition);
                    if (card == null)
                    {
                        List<int> cards = player.GetCards("h");
                        List<Player> targets = room.GetOtherPlayers(player);
                        Shuffle.shuffle(ref cards);
                        Shuffle.shuffle(ref targets);

                        Player target = targets[0];
                        List<int> give = new List<int>();
                        for (int i = 0; i < player.HandcardNum - player.Hp; i++)
                            give.Add(cards[i]);

                        ResultStruct result = card_use.From.Result;
                        result.Assist += give.Count;
                        card_use.From.Result = result;

                        room.ObtainCard(target, ref give, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "zhiyan_xh", string.Empty), false);
                    }
                }
            }
        }
    }

    public class ZhiyanPro : ProhibitSkill
    {
        public ZhiyanPro() : base("#zhiyan_xh") { }
        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if (from != null && to != from && from.HasFlag("zhiyan_xh"))
            {
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                return fcard != null && !(fcard is SkillCard);
            }

            return false;
        }
    }

    public class Zhilue : TriggerSkill
    {
        public Zhilue() : base("zhilue")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            view_as_skill = new ZhilueVS();
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

    public class ZhilueVS : ZeroCardViewAsSkill
    {
        public ZhilueVS() : base("zhilue") { }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return player.Hp > 0 && !player.HasUsed(ZhilueCard.ClassName);
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(ZhilueCard.ClassName) { Skill = Name };
        }
    }

    public class ZhilueCard : SkillCard
    {
        public static string ClassName = "ZhilueCard";
        public ZhilueCard() : base(ClassName)
        {
            target_fixed = true;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            room.LoseHp(player);
            if (player.Alive)
            {
                player.AddMark("zhilue");
                List<string> choices = new List<string> { "draw" };
                List<Player> froms = new List<Player>();
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.HasEquip() || p.JudgingArea.Count > 0) froms.Add(p);
                }
                if (froms.Count > 0) choices.Add("move");
                string choice = room.AskForChoice(player, "zhilue", string.Join("+", choices), null, null, card_use.Card.SkillPosition);
                if (choice == "draw")
                {
                    room.DrawCards(player, 1, "zhilue");
                    if (player.Alive)
                    {
                        WrappedCard slash = new WrappedCard(Slash.ClassName)
                        {
                            DistanceLimited = false,
                            Skill = "_zhilue"
                        };
                        List<Player> targets = new List<Player>();
                        foreach (Player p in room.GetAlivePlayers())
                        {
                            if (RoomLogic.CanSlash(room, player, p, slash))
                                targets.Add(p);
                        }
                        if (targets.Count > 0)
                        {
                            Player slasher = room.AskForPlayerChosen(player, targets, "zhilue", "@dummy-slash", false, false, card_use.Card.SkillPosition);
                            room.UseCard(new CardUseStruct(slash, player, slasher), false);
                        }
                    }
                }
                else
                {
                    Player from = room.AskForPlayerChosen(player, froms, "zhilue", "@zhilue", false, false, card_use.Card.SkillPosition);
                    if (from != null && from.GetCards("ej").Count > 0)
                    {
                        room.SetTag("QiaobianTarget", from);
                        int card_id = room.AskForCardChosen(card_use.From, from, "ej", "zhilue");
                        WrappedCard card = room.GetCard(card_id);
                        Place place = room.GetCardPlace(card_id);

                        FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                        int equip_index = -1;
                        if (place == Place.PlaceEquip)
                        {
                            EquipCard equip = (EquipCard)fcard;
                            equip_index = (int)equip.EquipLocation();
                        }

                        List<Player> tos = new List<Player>();
                        foreach (Player p in room.GetAlivePlayers())
                        {
                            if (equip_index != -1)
                            {
                                if (p.GetEquip(equip_index) < 0 && RoomLogic.CanPutEquip(p, card))
                                    tos.Add(p);
                            }
                            else if (RoomLogic.IsProhibited(room, null, p, card) == null && !RoomLogic.PlayerContainsTrick(room, p, card.Name) && p.JudgingAreaAvailable)
                                tos.Add(p);
                        }

                        string position = card_use.Card.SkillPosition;
                        Player to = room.AskForPlayerChosen(card_use.From, tos, "zhilue", "@zhilue-to:::" + card.Name, false, false, position);
                        if (to != null)
                        {
                            if ((place == Place.PlaceDelayedTrick && from != card_use.From) || (place == Place.PlaceEquip && to != card_use.From))
                            {
                                ResultStruct result = card_use.From.Result;
                                result.Assist++;
                                card_use.From.Result = result;
                            }

                            room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, from.Name, to.Name);
                            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_TRANSFER, card_use.From.Name, "zhilue", null)
                            {
                                Card = card
                            };
                            room.MoveCardTo(card, from, to, place, reason);
                        }
                        room.RemoveTag("QiaobianTarget");
                    }
                }
            }
        }
    }

    public class ZhilueMax : MaxCardsSkill
    {
        public ZhilueMax() : base("#zhilue") { }
        public override int GetExtra(Room room, Player target)
        {
            return target.GetMark("zhilue");
        }
    }

    public class Juliao : DistanceSkill
    {
        public Juliao() : base("juliao")
        {
        }

        public override int GetCorrect(Room room, Player from, Player to, WrappedCard card = null)
        {
            if (to != null && RoomLogic.PlayerHasShownSkill(room, to, Name) && from != null)
            {
                int count = Zishou.GetAliveKingdoms(room);
                return count - 1;
            }
            return 0;
        }
    }

    public class Taomie : TriggerSkill
    {
        public Taomie() : base("taomie")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.Damaged, TriggerEvent.Death, TriggerEvent.EventLoseSkill };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Death && player.ContainsTag(Name) && player.GetTag(Name) is string target)
            {
                player.RemoveTag(Name);
                Player old_one = room.FindPlayer(target);
                if (old_one != null)
                {
                    old_one.SetMark(Name, 0);
                    room.RemovePlayerStringMark(old_one, Name);
                }
            }
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name
                && player.ContainsTag(Name) && player.GetTag(Name) is string old)
            {
                player.RemoveTag(Name);
                Player old_one = room.FindPlayer(old);
                if (old_one != null)
                {
                    old_one.SetMark(Name, 0);
                    room.RemovePlayerStringMark(old_one, Name);
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room))
            {
                Player target = null;
                if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && damage.To.Alive && damage.To.GetMark(Name) == 0)
                    target = damage.To;
                else if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct _damage && _damage.From != null && _damage.From.Alive && _damage.From.GetMark(Name) == 0)
                    target = _damage.From;

                if (target != null)
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = null;
            if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && damage.To.Alive && damage.To.GetMark(Name) == 0)
                target = damage.To;
            else if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct _damage && _damage.From.Alive && _damage.From.GetMark(Name) == 0)
                target = _damage.From;

            if (room.AskForSkillInvoke(player, Name, target, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = null;
            if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && damage.To.Alive && damage.To.GetMark(Name) == 0)
                target = damage.To;
            else if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct _damage && _damage.From.Alive && _damage.From.GetMark(Name) == 0)
                target = _damage.From;

            if (player.ContainsTag(Name) && player.GetTag(Name) is string old)
            {
                Player old_one = room.FindPlayer(old);
                if (old_one != null)
                {
                    old_one.SetMark(Name, 0);
                    room.RemovePlayerStringMark(old_one, Name);
                }
            }
            player.SetTag(Name, target.Name);
            target.SetMark(Name, 1);
            room.SetPlayerStringMark(target, Name, string.Empty);

            return false;
        }
    }

    public class TaomieEffect : TriggerSkill
    {
        public TaomieEffect() : base("#taomie")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageCaused, TriggerEvent.DamageComplete };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.DamageComplete && player.HasFlag("taomie") && player.GetMark("taomie") > 0)
            {
                player.SetFlags("-taomie");
                player.SetMark("taomie", 0);
                room.RemovePlayerStringMark(player, "taomie");
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.DamageCaused && base.Triggerable(player, room) && player.ContainsTag("taomie") && player.GetTag("taomie") is string target
                && data is DamageStruct damage && damage.To.GetMark("taomie") > 0 && target ==  damage.To.Name)
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<string> choices = new List<string> { "damage" };
            if (data is DamageStruct damage)
            {
                if (!damage.To.IsAllNude())
                {
                    choices.Add("get");
                    choices.Add("all");
                }
                string choice = room.AskForChoice(player, "taomie", string.Join("+", choices), new List<string> { "@to-player:" + damage.To.Name }, damage.To, info.SkillPosition);
                bool get =false, dam = false;
                switch (choice)
                {
                    case "get":
                        get = true;
                        break;
                    case "damage":
                        dam = true;
                        break;
                    case "all":
                        get = true;
                        dam = true;
                        player.RemoveTag("taomie");
                        damage.To.SetFlags("taomie");
                        break;
                }

                if (dam)
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "#AddDamage",
                        From = player.Name,
                        To = new List<string> { damage.To.Name },
                        Arg = Name,
                        Arg2 = (++damage.Damage).ToString()
                    };
                    room.SendLog(log);

                    data = damage;
                }
                if (get)
                {
                    int id = room.AskForCardChosen(player, damage.To, "hej", "taomie", false, HandlingMethod.MethodGet);
                    List<int> ids = new List<int> { id };
                    room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_EXTRACTION, player.Name, damage.To.Name, "taomie", string.Empty), false);
                    if (player.Alive && room.GetCardOwner(id) == player && room.GetCardPlace(id) == Place.PlaceHand)
                    {
                        List<Player> targets = room.GetOtherPlayers(damage.To);
                        targets.Remove(player);
                        Player target = room.AskForPlayerChosen(player, targets, "taomie", "@taomie-give:::" + room.GetCard(id).Name, true, false, info.SkillPosition);
                        if (target != null)
                            room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "taomie", string.Empty), false);
                    }
                }
            }

            return false;
        }
    }

    public class TaomieRange : TargetModSkill
    {
        public TaomieRange() : base("#taomie-range") { }
        public override bool InAttackRange(Room room, Player from, Player to, WrappedCard card)
        {
            if (from.ContainsTag("taomie") && from.GetTag(Name) is string to_name && to_name == to.Name && to.GetMark("taomie") == 1)
                return true;
            else if (to.ContainsTag("taomie") && to.GetTag(Name) is string from_name && from_name == from.Name && from.GetMark("taomie") == 1)
                return true;
            return false;
        }
    }

    public class Duoji : TriggerSkill
    {
        public Duoji() : base("duoji")
        {
            skill_type = SkillType.Wizzard;
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.CardsMoveOneTime, TriggerEvent.Death, TriggerEvent.EventLoseSkill };
            view_as_skill = new DuojiVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if ((triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name)
                || (triggerEvent == TriggerEvent.Death && RoomLogic.PlayerHasSkill(room, player, Name)))
            {
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.GetPile(Name).Count > 0 && p.ContainsTag(Name) && p.GetTag(Name) is string player_name && player_name == player.Name)
                    {
                        room.ClearOnePrivatePile(p, Name);
                        p.RemoveTag(Name);
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetPile(Name).Count > 0
                && player.ContainsTag(Name) && player.GetTag(Name) is string player_name)
            {
                Player from = room.FindPlayer(player_name);
                if (from != null)
                {
                    List<int> ids = player.GetPile(Name);
                    room.ObtainCard(from, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, from.Name, player.Name, Name, string.Empty));
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To != null && move.To.Alive
                && move.To_place == Place.PlaceEquip && move.To.GetPile(Name).Count > 0 && (move.Reason.Reason == MoveReason.S_REASON_USE || move.Reason.Reason == MoveReason.S_REASON_LETUSE)
                && move.To.ContainsTag(Name) && move.To.GetTag(Name) is string from_name)
            {
                Player from = room.FindPlayer(from_name);
                if (from != null)
                {
                    List<int> ids = new List<int>();
                    foreach (int id in move.Card_ids)
                        if (RoomLogic.CanGetCard(room, from, move.To, id))
                            ids.Add(id);

                    if (ids.Count > 0)
                        return new TriggerStruct(Name, from);
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardsMoveOneTimeStruct move)
            {
                List<int> ids = new List<int>();
                foreach (int id in move.Card_ids)
                    if (RoomLogic.CanGetCard(room, ask_who, move.To, id))
                        ids.Add(id);

                room.SendCompulsoryTriggerLog(ask_who, Name);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, "duoji", info.SkillPosition);
                room.BroadcastSkillInvoke("duoji", "male", 1, gsk.General, gsk.SkinId);

                room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_EXTRACTION, ask_who.Name, move.To.Name, Name, string.Empty));
                if (move.To.Alive)
                {
                    room.ClearOnePrivatePile(move.To, Name);
                    move.To.RemoveTag(Name);
                    room.DrawCards(move.To, 1, Name);
                }
            }

            return false;
        }
    }

    public class DuojiVS : OneCardViewAsSkill
    {
        public DuojiVS() : base("duoji")
        {
            filter_pattern = "..";
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(DuojiCard.ClassName);

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard dy = new WrappedCard(DuojiCard.ClassName) { Skill = Name, Mute = true };
            dy.AddSubCard(card);
            return dy;
        }
    }

    public class DuojiCard : SkillCard
    {
        public static string ClassName = "DuojiCard";
        public DuojiCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self && to_select.GetPile("duoji").Count == 0;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0], player = card_use.From;

            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "duoji", card_use.Card.SkillPosition);
            room.BroadcastSkillInvoke("duoji", "male", 1, gsk.General, gsk.SkinId);

            room.AddToPile(target, "duoji", card_use.Card, true);
            target.SetTag("duoji", player.Name);
        }
    }

    public class Jianzhan : ZeroCardViewAsSkill
    {
        public Jianzhan() : base("jianzhan")
        {
            skill_type = SkillType.Wizzard;
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(JianzhanCard.ClassName);

        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(JianzhanCard.ClassName) { Skill = Name };
    }

    public class JianzhanCard : SkillCard
    {
        public static string ClassName = "JianzhanCard";
        public JianzhanCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (targets.Count == 0)
                return to_select != Self;
            else if (targets.Count == 1)
            {
                Player target = targets[0];
                WrappedCard slash = new WrappedCard(Slash.ClassName);
                return RoomLogic.InMyAttackRange(room, target, to_select) && to_select.HandcardNum < target.HandcardNum
                    && RoomLogic.IsProhibited(room, target, to_select, slash) == null;
            }
            return false;
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            if (targets.Count == 2)
                return true;
            else if (targets.Count == 1)
            {
                Player target = targets[0];
                WrappedCard slash = new WrappedCard(Slash.ClassName);
                foreach (Player p in room.GetOtherPlayers(target))
                    if (RoomLogic.InMyAttackRange(room, target, p) && p.HandcardNum < target.HandcardNum && RoomLogic.IsProhibited(room, target, p, slash) == null)
                        return false;

                return true;
            }
            return false;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            Player diaochan = card_use.From;

            object data = card_use;
            RoomThread thread = room.RoomThread;

            thread.Trigger(TriggerEvent.PreCardUsed, room, diaochan, ref data);
            room.BroadcastSkillInvoke("jianzhan", diaochan, card_use.Card.SkillPosition);

            LogMessage log = new LogMessage
            {
                From = diaochan.Name,
                To = new List<string>(),
                Type = "#UseCard",
                Card_str = RoomLogic.CardToString(room, card_use.Card)
            };
            foreach (Player p in card_use.To)
                log.To.Add(p.Name);
            room.SendLog(log);

            thread.Trigger(TriggerEvent.CardUsedAnnounced, room, diaochan, ref data);
            thread.Trigger(TriggerEvent.CardTargetAnnounced, room, diaochan, ref data);
            thread.Trigger(TriggerEvent.CardUsed, room, diaochan, ref data);
            thread.Trigger(TriggerEvent.CardFinished, room, diaochan, ref data);
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0], player = card_use.From, victim = null;
            if (card_use.To.Count > 1)
                victim = card_use.To[1];
            List<string> descriptions = new List<string> { "@jianzhan" , "@jianzhan-draw:" + player.Name };
            List<string> choices = new List<string> { "draw" };
            if (victim != null)
            {
                choices.Add("slash");
                descriptions.Add("@jianzhan-slash:" + victim.Name);
            }
            string choice = room.AskForChoice(target, "jianzhan", string.Join("+", choices), descriptions, card_use);
            if (choice == "draw")
                room.DrawCards(player, 1, "jianzhan");
            else
            {
                WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_jianzhan" };
                room.UseCard(new CardUseStruct(slash, target, victim));
            }
        }
    }

    public class Wuku : TriggerSkill
    {
        public Wuku() : base("wuku")
        {
            events.Add(TriggerEvent.CardUsed);
            frequency = Frequency.Compulsory;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (data is CardUseStruct use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is EquipCard)
                {
                    foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                        if (p.GetMark(Name) < 3)
                            triggers.Add(new TriggerStruct(Name, p));
                }
            }
            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            ask_who.AddMark(Name);
            room.SetPlayerStringMark(ask_who, Name, ask_who.GetMark(Name).ToString());
            return false;
        }
    }

    public class Sanchen : PhaseChangeSkill
    {
        public Sanchen() : base("sanchen")
        {
            frequency = Frequency.Wake;
            skill_type = SkillType.Recover;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Finish && base.Triggerable(player, room) && player.GetMark(Name) == 0 && player.GetMark("wuku") >= 3)
                return new TriggerStruct(Name, player);

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

                room.HandleAcquireDetachSkills(player, "miewu", true);
            }

            return false;
        }
    }

    public class Miewu : TriggerSkill
    {
        public Miewu() : base("miewu")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            skill_type = SkillType.Alter;
            view_as_skill = new MiewuVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                foreach (Player p in room.GetAlivePlayers())
                    if (p.HasFlag(Name)) p.SetFlags("-miewu");
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class MiewuVS : ViewAsSkill
    {
        public MiewuVS() : base("miewu")
        {
            response_or_use = true;
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasFlag(Name) && player.GetMark("wuku") > 0;

        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
            => !player.HasFlag(Name) && player.GetMark("wuku") > 0 && (MatchBasic(respond) || MatchNTTrick(respond));

        public override bool IsEnabledAtNullification(Room room, Player player) => !player.HasFlag(Name) && player.GetMark("wuku") > 0 && (!player.IsNude() || player.GetHandPile().Count > 0);

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> all_cards = new List<WrappedCard>();
            if (cards.Count == 1)
            {
                string pattern = room.GetRoomState().GetCurrentCardUsePattern(player);
                List<string> names = GetGuhuoCards(room, "bt");
                names.Remove(HegNullification.ClassName);
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
            return selected.Count == 0 && !RoomLogic.IsCardLimited(room, player, to_select, method);
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
            {
                WrappedCard gh = new WrappedCard(MiewuCard.ClassName) { Skill = Name, UserString = cards[0].Name };
                gh.AddSubCard(cards[0].GetEffectiveId());
                return gh;
            }

            return null;
        }
    }

    public class MiewuCard : SkillCard
    {
        public static string ClassName = "MiewuCard";
        public MiewuCard() : base(ClassName)
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
            player.SetFlags("miewu");

            WrappedCard guhuo = new WrappedCard(use.Card.UserString);
            guhuo.AddSubCard(use.Card);
            guhuo = RoomLogic.ParseUseCard(room, guhuo);
            player.SetMark("wuku", player.GetMark("wuku") - 1);
            if (player.GetMark("wuku") == 0)
                room.RemovePlayerStringMark(player, "wuku");
            else
                room.SetPlayerStringMark(player, "wuku", player.GetMark("wuku").ToString());
            room.DrawCards(player, 1, "miewu");
            return guhuo;
        }

        public override WrappedCard ValidateInResponse(Room room, Player player, WrappedCard card)
        {
            player.SetFlags("miewu");
            WrappedCard guhuo = new WrappedCard(card.UserString);
            guhuo.Skill = guhuo.ShowSkill = "miewu";
            guhuo.AddSubCard(card);
            guhuo = RoomLogic.ParseUseCard(room, guhuo);
            player.SetMark("wuku", player.GetMark("wuku") - 1);
            if (player.GetMark("wuku") == 0)
                room.RemovePlayerStringMark(player, "wuku");
            else
                room.SetPlayerStringMark(player, "wuku", player.GetMark("wuku").ToString());
            room.DrawCards(player, 1, "miewu");
            return guhuo;
        }
    }

    public class Huantu : TriggerSkill
    {
        public Huantu() : base("huantu")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.RoundStart };
            skill_type = SkillType.Wizzard;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.RoundStart)
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.GetMark(Name) > 0)
                        p.SetMark(Name, 0);
                }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.Draw)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                {
                    if (p != player && p.GetMark(Name) == 0 && RoomLogic.InMyAttackRange(room, p, player) && !p.IsNude())
                        triggers.Add(new TriggerStruct(Name, p));
                }

            }
            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> ids = room.AskForExchange(ask_who, Name, 1, 0, "@huantu:" + player.Name, string.Empty, "..", info.SkillPosition);
            if (ids.Count > 0)
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.NotifySkillInvoked(ask_who, Name);
                room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, ask_who.Name, player.Name, Name, string.Empty), false);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            ask_who.AddMark(Name);
            ask_who.SetFlags(Name);
            return true;
        }
    }

    public class HuantuEffect : TriggerSkill
    {
        public HuantuEffect() : base("#huantu")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Wizzard;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.Alive && player.Phase == PlayerPhase.Finish)
            {
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.HasFlag("huantu"))
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            string choice = room.AskForChoice(ask_who, "huantu", "recover+draw", new List<string> { "@to-player:" + player.Name }, player, info.SkillPosition);
            if (choice == "recover")
            {
                if (player.IsWounded())
                {
                    RecoverStruct recover = new RecoverStruct
                    {
                        Recover = 1,
                        Who = ask_who
                    };
                    room.Recover(player, recover, true);
                }
                if (player.Alive) room.DrawCards(player, new DrawCardStruct(2, ask_who, "huantu"));
            }
            else
            {
                room.DrawCards(ask_who, 3, "huantu");
                if (player.Alive && ask_who.Alive && !ask_who.IsKongcheng())
                {
                    List<int> ids = room.AskForExchange(ask_who, "huantu", 2, 2, "@huantu-give:" + player.Name, string.Empty, ".", info.SkillPosition);
                    if (ids.Count > 0)
                        room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, ask_who.Name, player.Name, "huantu", string.Empty), false);
                }
            }
            return true;
        }
    }

    public class Bihuo : TriggerSkill
    {
        public Bihuo() : base("bihuo")
        {
            events = new List<TriggerEvent> { TriggerEvent.QuitDying, TriggerEvent.RoundStart };
            skill_type = SkillType.Defense;
            frequency = Frequency.Limited;
            limit_mark = "@bihuo";
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.RoundStart)
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.GetMark(Name) > 0)
                    {
                        p.SetMark(Name, 0);
                        room.RemovePlayerStringMark(p, Name);
                    }
                }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.QuitDying && player.Alive)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p.GetMark(limit_mark) > 0) triggers.Add(new TriggerStruct(Name, p));
            }
            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.DoSuperLightbox(ask_who, info.SkillPosition, Name);
                room.SetPlayerMark(ask_who, limit_mark, 0);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.DrawCards(player, new DrawCardStruct(3, ask_who, Name));
            player.AddMark(Name, room.AliveCount());
            room.SetPlayerStringMark(player, Name, player.GetMark(Name).ToString());
            return false;
        }
    }

    public class BihuoDistance : DistanceSkill
    {
        public BihuoDistance() : base("#bihuo") { }
        public override int GetCorrect(Room room, Player from, Player to, WrappedCard card = null) => to.GetMark("bihuo");
    }

    public class Renshi : TriggerSkill
    {
        public Renshi() : base("renshi")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageInflicted };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Masochism;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.DamageInflicted && base.Triggerable(player, room) && player.IsWounded() && data is DamageStruct damage
                && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            if (data is DamageStruct damage)
            {
                LogMessage log = new LogMessage
                {
                    Type = "#damaged-prevent",
                    From = player.Name,
                    Arg = Name
                };
                room.SendLog(log);

                int id = -1;
                foreach (int card_id in room.DrawPile)
                {
                    if (room.GetCard(card_id).Name.Contains(Slash.ClassName))
                    {
                        id = card_id;
                        break;
                    }
                }
                if (id == -1)
                {
                    foreach (int card_id in room.DiscardPile)
                    {
                        if (room.GetCard(card_id).Name.Contains(Slash.ClassName))
                        {
                            id = card_id;
                            break;
                        }
                    }
                }
                if (id > -1)
                    room.ObtainCard(player, room.GetCard(id), new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, Name, string.Empty));

                if (player.Alive) room.LoseMaxHp(player);
            }

            return true;
        }
    }

    public class Jungong : TriggerSkill
    {
        public Jungong() : base("jungong")
        {
            events.Add(TriggerEvent.Damage);
            skill_type = SkillType.Attack;
            view_as_skill = new JungongVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is DamageStruct damage && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName) && damage.Card.GetSkillName() == Name && damage.From != null && damage.From.Alive)
                damage.From.SetFlags(Name);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }
    public class JungongVS : ViewAsSkill
    {
        public JungongVS() : base("jungong") { }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return RoomLogic.CanDiscard(room, player, player, to_select.Id) && selected.Count < 1 + player.UsedTimes(JungongCard.ClassName);
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasFlag(Name);
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            int count = 1 + player.UsedTimes(JungongCard.ClassName);
            if (cards.Count == count || (cards.Count == 0 && player.Hp >= count))
            {
                WrappedCard jg = new WrappedCard(JungongCard.ClassName) { Skill = Name };
                jg.AddSubCards(cards);
                return jg;
            }
            return null;
        }
    }

    public class JungongCard : SkillCard
    {
        public static string ClassName = "JungongCard";
        public JungongCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            WrappedCard slash = new WrappedCard(Slash.ClassName)
            {
                DistanceLimited = false
            };
            return Slash.Instance.TargetFilter(room, targets, to_select, Self, slash);
        }

        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            Player player = use.From;
            room.NotifySkillInvoked(player, "jungong");
            List<int> ids = new List<int>(use.Card.SubCards);
            if (ids.Count > 0)
            {
                room.ThrowCard(ref ids,
                    new CardMoveReason(MoveReason.S_REASON_THROW, player.Name, "jungong", string.Empty)
                    { General = RoomLogic.GetGeneralSkin(room, player, "jungong", use.Card.SkillPosition) },
                    player, null, "jungong");
            }
            else
            {
                room.BroadcastSkillInvoke("jungong", player, use.Card.SkillPosition);
                room.LoseHp(player, player.UsedTimes(ClassName) + 1);
            }
            if (player.Alive)
                return new WrappedCard(Slash.ClassName) { Skill = "_jungong", DistanceLimited = false };
            else
                return null;
        }
    }

    public class Dengli : TriggerSkill
    {
        public Dengli() : base("dengli")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.TargetConfirmed };
            skill_type = SkillType.Attack;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room))
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in use.To)
                    if (player.Hp == p.Hp) targets.Add(p);

                if (targets.Count > 0)
                    return new TriggerStruct(Name, player, targets);
            }
            else if (triggerEvent == TriggerEvent.TargetConfirmed && data is CardUseStruct _use && _use.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room) && player.Hp == _use.From.Hp)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player ask_who, TriggerStruct info)
        {
            room.DrawCards(ask_who, 1, Name);
            return false;
        }
    }

    public class JibingVS : ViewAsSkill
    {
        public JibingVS() : base("jibing")
        {
            attached_lord_skill = true;
            expand_pile = Name;
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return selected.Count == 0 && player.GetPile(Name).Contains(to_select.Id);
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return player.GetPile(Name).Count > 0 && Slash.IsAvailable(room, player);
        }
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
        {
            return (MatchSlash(respond) || MatchJink(respond)) && player.GetPile(Name).Count > 0;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1)
            {
                if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_PLAY)
                {
                    WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = Name };
                    slash.AddSubCards(cards);
                    slash = RoomLogic.ParseUseCard(room, slash);
                    return slash;
                }
                else
                {
                    string pattern = room.GetRoomState().GetCurrentCardUsePattern();
                    WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = Name };
                    slash.AddSubCards(cards);
                    slash = RoomLogic.ParseUseCard(room, slash);

                    if (Engine.MatchExpPattern(room, pattern, player, slash)) return slash;

                    WrappedCard jink = new WrappedCard(Jink.ClassName) { Skill = Name };
                    jink.AddSubCards(cards);
                    jink = RoomLogic.ParseUseCard(room, jink);
                    if (Engine.MatchExpPattern(room, pattern, player, jink)) return jink;
                }
            }

            return null;
        }
    }

    public class Jibing : TriggerSkill
    {
        public Jibing() : base("jibing")
        {
            view_as_skill = new JibingVS();
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.EventLoseSkill };
            skill_type = SkillType.Wizzard;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name)
                room.ClearOnePrivatePile(player, Name);
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Draw && player.GetPile(Name).Count < Zishou.GetAliveKingdoms(room))
                return new TriggerStruct(Name, player);
            

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
            List<int> ids = room.GetNCards(2);
            room.AddToPile(player, Name, ids, true);
            return true;
        }
    }

    public class Wangjing : TriggerSkill
    {
        public Wangjing() : base("wangjing")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.CardResponded };
            skill_type = SkillType.Replenish;
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName)
                && use.Card.GetSkillName() == "jibing" && base.Triggerable(player, room))
            {
                int max = 0;
                foreach (Player p in room.GetAlivePlayers())
                    if (p.Hp > max) max = p.Hp;
                List<Player> targets = new List<Player>();
                foreach (Player p in use.To)
                    if (p.Hp == max) targets.Add(p);

                if (targets.Count > 0)
                    return new TriggerStruct(Name, player, targets);
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Who != null && resp.Card != null
                && (resp.Card.Name.Contains(Slash.ClassName) || resp.Card.Name == Jink.ClassName) && resp.Card.GetSkillName() == "jibing"
                && base.Triggerable(player, room) && resp.Who.Alive)
            {
                int max = 0;
                foreach (Player p in room.GetAlivePlayers())
                    if (p.Hp > max) max = p.Hp;

                if (resp.Who.Hp == max) return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            room.DrawCards(ask_who, 1, Name);
            return false;
        }
    }

    public class Mouchuan : PhaseChangeSkill
    {
        public Mouchuan() : base("mouchuan")
        {
            frequency = Frequency.Wake;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Start && player.GetMark(Name) == 0 && base.Triggerable(player, room) && player.GetPile("jibing").Count >= Zishou.GetAliveKingdoms(room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            room.SetPlayerMark(player, Name, 1);
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.LoseMaxHp(player);
            if (player.Alive)
                room.HandleAcquireDetachSkills(player, "binghuo", true);

            return false;
        }
    }

    public class Binghuo : TriggerSkill
    {
        public Binghuo() : base("binghuo")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded, TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName) && use.Card.GetSkillName() == "jibing")
                player.SetFlags(Name);
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Card != null && resp.Card.GetSkillName() == "jibing")
                player.SetFlags(Name);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p.HasFlag(Name)) triggers.Add(new TriggerStruct(Name, p));
            }
            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetAlivePlayers(), Name, "@binghuo", true, true, info.SkillPosition);
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

                if (!judge.IsGood() && target.Alive)
                    room.Damage(new DamageStruct(Name, zhangjiao, target, 1, DamageStruct.DamageNature.Thunder));
            }

            return false;
        }
    }

    public class Shidi : TriggerSkill
    {
        public Shidi() : base("shidi")
        {
            frequency = Frequency.Compulsory;
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.TargetConfirmed };
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            CardUseStruct use = (CardUseStruct)data;
            if (triggerEvent == TriggerEvent.TargetChosen && use.Card != null && use.From.Phase != PlayerPhase.NotActive
                && use.Card.Name.Contains(Slash.ClassName) && WrappedCard.IsBlack(use.Card.Suit) && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player, use.To);
            }
            else if (triggerEvent == TriggerEvent.TargetConfirmed && use.Card != null && use.Card.Name.Contains(Slash.ClassName) && WrappedCard.IsRed(use.Card.Suit)
                && player.Phase == PlayerPhase.NotActive && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player, new List<Player> { use.From });
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            CardUseStruct use = (CardUseStruct)data;
            FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
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
                            effect.Effect2 = 0;
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
                        effect.Effect2 = 0;
                        break;
                    }
                }
            }

            data = use;

            return false;
        }
    }

    public class ShidiDistance : DistanceSkill
    {
        public ShidiDistance() : base("#shidi") { }
        public override int GetCorrect(Room room, Player from, Player to, WrappedCard card = null)
        {
            int count = 0;
            if (from.Phase != PlayerPhase.NotActive && RoomLogic.PlayerHasSkill(room, from, "shidi")) count--;
            if (to.Phase == PlayerPhase.NotActive && RoomLogic.PlayerHasSkill(room, to, "shidi")) count++;
            return count;
        }
    }

    public class Yishi : TriggerSkill
    {
        public Yishi() : base("yishi")
        {
            events.Add(TriggerEvent.DamageCaused);
            skill_type = SkillType.Wizzard;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DamageStruct damage && damage.To != null && player != damage.To)
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            DamageStruct damage = (DamageStruct)data;
            room.SetTag("zhiman_data", data);  // for AI
            bool invoke = room.AskForSkillInvoke(player, Name, damage.To, info.SkillPosition);
            room.RemoveTag("zhiman_data");
            if (invoke)
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                Player to = damage.To;
                if (to.HasEquip() && RoomLogic.CanGetCard(room, player, to, "e"))
                {
                    int card_id = room.AskForCardChosen(player, to, "e", Name, false, HandlingMethod.MethodGet);

                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_EXTRACTION, player.Name, to.Name, Name, string.Empty);
                    room.ObtainCard(player, room.GetCard(card_id), reason);
                }

                LogMessage log = new LogMessage
                {
                    Type = "#ReduceDamage",
                    From = to.Name,
                    Arg = Name,
                    Arg2 = (--damage.Damage).ToString()
                };
                room.SendLog(log);

                if (damage.Damage < 1)
                    return true;

                data = damage;
            }
            return false;
        }
    }

    public class Qishe : OneCardViewAsSkill
    {
        public Qishe() : base("qishe")
        {
            response_or_use = true;
        }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            return Engine.GetFunctionCard(to_select.Name) is EquipCard && !RoomLogic.IsCardLimited(room, player, to_select, HandlingMethod.MethodUse);
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => Analeptic.IsAnalepticAvailable(room, player);
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

    public class QisheMax : MaxCardsSkill
    {
        public QisheMax() : base("#qishe") { }
        public override int GetExtra(Room room, Player target) => RoomLogic.PlayerHasShownSkill(room, target, "qishe") ? target.GetEquips().Count : 0;
    }

    public class Wuyuan : OneCardViewAsSkill
    {
        public Wuyuan() : base("wuyuan")
        {
            filter_pattern = "Slash";
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(WuyuanCard.ClassName) && !player.IsKongcheng();
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard wy = new WrappedCard(WuyuanCard.ClassName) { Skill = Name };
            wy.AddSubCard(card);
            return wy;
        }
    }

    public class Lueying : TriggerSkill
    {
        public Lueying() : base("lueying")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.CardFinished, TriggerEvent.CardUsedAnnounced };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Attack;
            view_as_skill = new LueyingVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && use.Card.Name == Dismantlement.ClassName && use.Card.GetSkillName() == Name)
            {
                player.AddMark("zhui_mark", -2);
                room.DrawCards(player, 1, Name);
                if (player.GetMark("zhui_mark") > 0)
                    room.SetPlayerStringMark(player, "zhui_mark", player.GetMark("zhui_mark").ToString());
                else
                    room.RemovePlayerStringMark(player, "zhui_mark");
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room))
            {
                if (triggerEvent == TriggerEvent.TargetChosen || (triggerEvent == TriggerEvent.CardFinished && player.GetMark("zhui_mark") >= 2))
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.TargetChosen)
            {
                room.SendCompulsoryTriggerLog(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                player.AddMark("zhui_mark");
                room.SetPlayerStringMark(player, "zhui_mark", player.GetMark("zhui_mark").ToString());
            }
            else
            {
                room.AskForUseCard(player, RespondType.Skill, "@@lueying", "@lueying", null, -1, HandlingMethod.MethodUse, false, info.SkillPosition);
            }
            return false;
        }
    }

    public class LueyingVS : ViewAsSkill
    {
        public LueyingVS() : base("lueying")
        {
            response_pattern = "@@lueying";
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => false;
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
                return cards[0];
            else
                return null;
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player Self)
        {
            List<WrappedCard> all_cards = new List<WrappedCard>();
            WrappedCard slash = new WrappedCard(Dismantlement.ClassName)
            {
                Skill = "lueying"
            };
            all_cards.Add(slash);
            return all_cards;
        }
    }

    public class Yingwu : TriggerSkill
    {
        public Yingwu() : base("yingwu")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.CardFinished, TriggerEvent.CardUsedAnnounced };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Attack;
            view_as_skill = new YingwuVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && use.Card.Name == Slash.ClassName && use.Card.GetSkillName() == Name)
            {
                player.AddMark("zhui_mark", -2);
                room.DrawCards(player, 1, Name);
                if (player.GetMark("zhui_mark") > 0)
                    room.SetPlayerStringMark(player, "zhui_mark", player.GetMark("zhui_mark").ToString());
                else
                    room.RemovePlayerStringMark(player, "zhui_mark");
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && Engine.GetFunctionCard(use.Card.Name).IsNDTrick() && base.Triggerable(player, room))
            {
                if (triggerEvent == TriggerEvent.TargetChosen || (triggerEvent == TriggerEvent.CardFinished && player.GetMark("zhui_mark") >= 2))
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.TargetChosen)
            {
                room.SendCompulsoryTriggerLog(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                player.AddMark("zhui_mark");
                room.SetPlayerStringMark(player, "zhui_mark", player.GetMark("zhui_mark").ToString());
            }
            else
            {
                room.AskForUseCard(player, RespondType.Skill, "@@yingwu", "@yingwu", null, -1, HandlingMethod.MethodUse, false, info.SkillPosition);
            }
            return false;
        }
    }

    public class YingwuVS : ViewAsSkill
    {
        public YingwuVS() : base("yingwu")
        {
            response_pattern = "@@yingwu";
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => false;
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
                return cards[0];
            else
                return null;
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player Self)
        {
            List<WrappedCard> all_cards = new List<WrappedCard>();
            WrappedCard slash = new WrappedCard(Slash.ClassName)
            {
                Skill = "yingwu"
            };
            all_cards.Add(slash);
            return all_cards;
        }
    }

    public class LijianSp : ViewAsSkill
    {
        public LijianSp() : base("lijian_sp")
        {
            skill_type = SkillType.Wizzard;
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => room.GetAlivePlayers().Count > 2 && !player.IsNude() && RoomLogic.CanDiscard(room, player, player, "he") && !player.HasUsed(LijianSpCard.ClassName);
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => RoomLogic.CanDiscard(room, player, player, to_select.Id);
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
            {
                WrappedCard lijian_card = new WrappedCard(LijianSpCard.ClassName);
                lijian_card.AddSubCards(cards);
                lijian_card.Skill = Name;
                lijian_card.ShowSkill = Name;
                return lijian_card;
            }

            return null;
        }
    }

    public class LijianSpCard : SkillCard
    {
        public static string ClassName = "LijianSpCard";
        public LijianSpCard() : base(ClassName)
        { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count <= card.SubCards.Count && to_select != Self;
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card) => targets.Count - 1 == card.SubCards.Count;
        public override void Use(Room room, CardUseStruct card_use)
        {
            List<Player> targets = card_use.To;
            for (int i = 0; i < targets.Count;i++)
            {
                Player from = targets[i];
                if (from.Alive)
                {
                    Player to = null;
                    int count = 1;
                    while ((to == null || !to.Alive) && count < targets.Count)
                    {
                        if (i + count < targets.Count)
                            to = targets[i + count];
                        else
                            to = targets[i + count - targets.Count];

                        count++;
                    }
                    if (to != null && to.Alive)
                    {
                        WrappedCard duel = new WrappedCard(Duel.ClassName) { Skill = "_lijian_sp" };
                        if (RoomLogic.IsProhibited(room, from, to, duel) == null)
                            room.UseCard(new CardUseStruct(duel, from, to));
                    }
                    else
                        break;
                }
            }
        }
    }

    public class BiyueSp : TriggerSkill
    {
        public BiyueSp() : base("biyue_sp")
        {
            skill_type = SkillType.Replenish;
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.DamageDone, TriggerEvent.EventPhaseChanging };
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.DamageDone && data is DamageStruct damage && room.Current != null)
            {
                List<string> targets = room.Current.ContainsTag(Name) ? (List<string>)room.Current.GetTag(Name) : new List<string>();
                if (!targets.Contains(damage.To.Name))
                {
                    targets.Add(damage.To.Name);
                    room.Current.SetTag(Name, targets);
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                player.RemoveTag(Name);
                
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish && player.ContainsTag(Name))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, null, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.GetTag(Name) is List<string> targets)
                room.DrawCards(player, Math.Min(5, targets.Count), Name);

            return false;
        }
    }

    public class WuyuanCard : SkillCard
    {
        public static string ClassName = "WuyuanCard";
        public WuyuanCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0], player = card_use.From;

            ResultStruct result = card_use.From.Result;
            result.Assist += card_use.Card.SubCards.Count;
            card_use.From.Result = result;

            WrappedCard slash = room.GetCard(card_use.Card.GetEffectiveId());
            bool red = WrappedCard.IsRed(slash.Suit);
            string card_name = slash.Name;

            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "wuyuan", null);
            room.ObtainCard(target, card_use.Card, reason, false);

            if (player.Alive && player.IsWounded())
            {
                RecoverStruct recover = new RecoverStruct
                {
                    Recover = 1,
                    Who = player
                };
                room.Recover(player, recover, true);
            }
            if (player.Alive)
                room.DrawCards(player, 1, "wuyuan");

            if (target.Alive)
            {
                int count = 1;
                if (card_name != Slash.ClassName) count++;
                room.DrawCards(target, new DrawCardStruct(count, player, "wuyuan"));
            }
            if (red && target.Alive && target.IsWounded())
            {
                RecoverStruct recover = new RecoverStruct
                {
                    Recover = 1,
                    Who = player
                };
                room.Recover(target, recover, true);
            }
        }
    }

    public class Huaizi : MaxCardsSkill
    {
        public Huaizi() : base("huaizi")
        {
        }
        public override int GetFixed(Room room, Player target) => RoomLogic.PlayerHasShownSkill(room, target, this) ? target.MaxHp : -1;
    }

    public class YingjianVS : ViewAsSkill
    {
        public YingjianVS() : base("yingjian")
        {
            response_pattern = "@@yingjian";
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return false;
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return false;
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player Self)
        {
            if (cards.Count == 0)
                return new List<WrappedCard> { new WrappedCard(Slash.ClassName) { Skill = "yingjian", DistanceLimited = false } };

            return new List<WrappedCard>();
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
                return cards[0];

            return null;
        }
    }

    public class Yizan : TriggerSkill
    {
        public Yizan() : base("yizan")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Alter;
            view_as_skill = new YizanVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && use.Card.Skill == Name)
            {
                player.AddMark(Name);
                if (player.Phase != PlayerPhase.NotActive) player.AddMark("yizan_draw");
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Card.Skill == Name)
            {
                player.AddMark(Name);
                if (player.Phase != PlayerPhase.NotActive) player.AddMark("yizan_draw");
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                player.SetMark("yizan_draw", 0);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class YizanVS : ViewAsSkill
    {
        public YizanVS() : base("yizan")
        {
            response_or_use = true;
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            CardUseReason reason = room.GetRoomState().GetCurrentCardUseReason();
            if ((reason == CardUseReason.CARD_USE_REASON_PLAY || reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE) && RoomLogic.IsCardLimited(room, player, to_select, HandlingMethod.MethodUse))
                return false;
            else if (reason == CardUseReason.CARD_USE_REASON_RESPONSE && RoomLogic.IsCardLimited(room, player, to_select, HandlingMethod.MethodResponse))
                return false;
            else if (selected.Count >= 2)
                return false;

            if (player.GetMark("longyuan") == 0)
            {
                if (selected.Count == 0)
                    return true;
                else
                    return Engine.GetFunctionCard(selected[0].Name).TypeID == CardType.TypeBasic || Engine.GetFunctionCard(to_select.Name).TypeID == CardType.TypeBasic;
            }
            else
                return selected.Count == 0 && Engine.GetFunctionCard(to_select.Name).TypeID == CardType.TypeBasic;
        }

        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern) => MatchBasic(respond);

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player Self)
        {
            List<WrappedCard> all_cards = new List<WrappedCard>();
            if (cards.Count == (Self.GetMark("longyuan") > 0 ? 1 : 2))
            {
                CardUseReason reason = room.GetRoomState().GetCurrentCardUseReason();
                if (reason == CardUseReason.CARD_USE_REASON_PLAY)
                {
                    List<string> names = GetGuhuoCards(room, "b");
                    foreach (string name in names)
                    {
                        if (name == Jink.ClassName) continue;
                        WrappedCard card = new WrappedCard(name);
                        card.AddSubCards(cards);
                        all_cards.Add(card);
                    }
                }
                else
                {
                    string pattern = room.GetRoomState().GetCurrentCardUsePattern(Self);
                    WrappedCard slash = new WrappedCard(Slash.ClassName);
                    slash.AddSubCards(cards);
                    WrappedCard fslash = new WrappedCard(FireSlash.ClassName);
                    fslash.AddSubCards(cards);
                    WrappedCard tslash = new WrappedCard(ThunderSlash.ClassName);
                    tslash.AddSubCards(cards);
                    WrappedCard jink = new WrappedCard(Jink.ClassName);
                    jink.AddSubCards(cards);
                    WrappedCard peach = new WrappedCard(Peach.ClassName);
                    peach.AddSubCards(cards);
                    WrappedCard ana = new WrappedCard(Analeptic.ClassName);
                    ana.AddSubCards(cards);

                    if (Engine.MatchExpPattern(room, pattern, Self, slash))
                        all_cards.Add(slash);
                    if (Engine.MatchExpPattern(room, pattern, Self, fslash))
                        all_cards.Add(fslash);
                    if (Engine.MatchExpPattern(room, pattern, Self, tslash))
                        all_cards.Add(tslash);
                    if (Engine.MatchExpPattern(room, pattern, Self, jink))
                        all_cards.Add(jink);
                    if (Engine.MatchExpPattern(room, pattern, Self, peach))
                        all_cards.Add(peach);
                    if (Engine.MatchExpPattern(room, pattern, Self, ana))
                        all_cards.Add(ana);
                }
            }

            return all_cards;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count != 1) return null;
            if (cards[0].IsVirtualCard())
            {
                WrappedCard card = RoomLogic.ParseUseCard(room, cards[0]);
                card.Skill = Name;
                return card;
            }

            return null;
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => true;
    }

    public class Longyuan : TriggerSkill
    {
        public Longyuan() : base("longyuan")
        {
            frequency = Frequency.Wake;
            events.Add(TriggerEvent.EventPhaseChanging);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p.GetMark(Name) == 0 && p.GetMark("yizan") >= 3)
                        triggers.Add(new TriggerStruct(Name, p));
            }
            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            room.DoSuperLightbox(ask_who, info.SkillPosition, Name);
            room.SetPlayerMark(ask_who, Name, 1);
            room.SetPlayerMark(ask_who, "yizan_description_index", 1);
            room.RefreshSkill(ask_who);

            room.DrawCards(ask_who, 2, Name);
            if (ask_who.Alive && ask_who.IsWounded()) room.Recover(ask_who);

            return false;
        }
    }

    public class Qingren : TriggerSkill
    {
        public Qingren() : base("qingren")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish && player.GetMark("yizan_draw") > 0)
                return new TriggerStruct(Name, player);
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
            room.DrawCards(player, player.GetMark("yizan_draw"), Name);
            return false;
        }
    }

    public class Zhiyi : TriggerSkill
    {
        public Zhiyi() : base("zhiyi")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.EventPhaseChanging, TriggerEvent.CardUsed, TriggerEvent.CardResponded };
            frequency = Frequency.Compulsory;
            view_as_skill = new ZhiyiVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (p.ContainsTag(Name)) p.RemoveTag(Name);
            }
            else if (base.Triggerable(player, room) && (triggerEvent == TriggerEvent.CardUsed || triggerEvent == TriggerEvent.CardResponded))
            {
                WrappedCard card = triggerEvent == TriggerEvent.CardUsed ? ((CardUseStruct)data).Card : ((CardResponseStruct)data).Card;
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                if (fcard is BasicCard)
                {
                    List<string> cards = new List<string>();
                    if (player.ContainsTag(Name))
                        cards = (List<string>)player.GetTag(Name);
                    if (!cards.Contains(card.Name)) cards.Add(card.Name);

                    player.SetTag(Name, cards);
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                {
                    if (p.ContainsTag(Name) && p.GetTag(Name) is List<string>)
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            WrappedCard card = room.AskForUseCard(ask_who, RespondType.Skill, "@@zhiyi", "@zhiyi", null, -1, HandlingMethod.MethodUse, false, info.SkillPosition);
            if (card == null)
                room.DrawCards(ask_who, 1, Name);

            return false;
        }
    }

    public class ZhiyiVS : ViewAsSkill
    {
        public ZhiyiVS() : base("zhiyi")
        {
            response_pattern = "@@zhiyi";
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return false;
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
                return cards[0];

            return null;
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return false;
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            List<string> record = (List<string>)player.GetTag(Name);
            foreach (string card_name in record)
            {
                WrappedCard card = new WrappedCard(card_name);
                card.Skill = "_zhiyi";
                result.Add(card);
            }
            return result;
        }
    }

    public class Duoduan : TriggerSkill
    {
        public Duoduan() : base("duoduan")
        {
            events.Add(TriggerEvent.TargetConfirmed);
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is CardUseStruct use && use.From != null && use.From != player && !player.HasFlag(Name))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                room.SetTag(Name, data);
                int index = 0;
                for (int i = 0; i < use.EffectCount.Count; i++)
                {
                    CardBasicEffect effect = use.EffectCount[i];
                    if (effect.To == player)
                    {
                        index++;
                        if (index == info.Times)
                        {
                            player.SetTag(Name, i);
                            break;
                        }
                    }
                }

                List<int> ids = room.AskForExchange(player, Name, 1, 0, "@duoduan:" + use.From.Name, string.Empty, "..", info.SkillPosition);

                player.RemoveTag(Name);
                room.RemoveTag(Name);
                if (ids.Count == 1)
                {
                    player.SetFlags(Name);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.NotifySkillInvoked(player, Name);

                    WrappedCard card = room.GetCard(ids[0]);
                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_RECAST, use.From.Name)
                    {
                        SkillName = Name
                    };
                    room.MoveCardTo(card, null, Place.PlaceTable, reason, true);
                    LogMessage log = new LogMessage("#Card_Recast")
                    {
                        From = use.From.Name,
                        Card_str = RoomLogic.CardToString(room, card)
                    };
                    room.SendLog(log);

                    List<int> table_cardids = room.GetCardIdsOnTable(room.GetSubCards(card));
                    if (table_cardids.Count > 0)
                    {
                        CardsMoveStruct move = new CardsMoveStruct(table_cardids, use.From, null, Place.PlaceTable, Place.DiscardPile, reason);
                        room.MoveCardsAtomic(new List<CardsMoveStruct>() { move }, true);
                    }
                    room.DrawCards(use.From, 1, "recast");

                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, use.From.Name);
                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && use.From.Alive)
            {
                bool draw = true;
                if (!use.From.IsNude() && RoomLogic.CanDiscard(room, use.From, use.From, "he"))
                    draw = !room.AskForDiscard(use.From, Name, 1, 1, true, true, string.Format("@duoduan-discard:{0}::{1}", player.Name, use.Card.Name));

                if (draw)
                {
                    room.DrawCards(use.From, new DrawCardStruct(2, player, Name));

                    int index = 0;
                    for (int i = 0; i < use.EffectCount.Count; i++)
                    {
                        CardBasicEffect effect = use.EffectCount[i];
                        if (effect.To == player)
                        {
                            index++;
                            if (index == info.Times)
                            {
                                effect.Nullified = true;
                                use.EffectCount[i] = effect;
                                data = use;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "#NoJink",
                        From = player.Name
                    };
                    room.SendLog(log);

                    int index = 0;
                    for (int i = 0; i < use.EffectCount.Count; i++)
                    {
                        CardBasicEffect effect = use.EffectCount[i];
                        if (effect.To == player)
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
            }

            return false;
        }
    }

    public class Gongshun : TriggerSkill
    {
        public Gongshun() : base("gongshun")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.TurnStart, TriggerEvent.Death };
            skill_type = SkillType.Wizzard;
            view_as_skill = new GongshunVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct _move)
            {
                if (_move.From != null && _move.From_places.Contains(Place.PlaceHand) && _move.From.ContainsTag(Name) && _move.From.GetTag(Name) is List<int> ids)
                {
                    List<int> remove = ids.FindAll(t => _move.Card_ids.Contains(t));
                    foreach (int id in remove)
                        RoomLogic.RemovePlayerCardLimitation(_move.From, Name, "use,response,discard", id.ToString());

                    ids.RemoveAll(t => _move.Card_ids.Contains(t));
                    if (ids.Count == 0)
                        _move.From.RemoveTag(Name);
                    else
                        _move.From.SetTag(Name, ids);
                }
                else if (_move.To != null && _move.To_place == Place.PlaceHand)
                {
                    if (_move.To.ContainsTag("gongshun_from") && _move.To.GetTag("gongshun_from") is KeyValuePair<string, string> invalid)
                    {
                        List<int> results = _move.To.ContainsTag(Name) ? (List<int>)_move.To.GetTag(Name) : new List<int>();
                        foreach (int id in _move.Card_ids)
                        {
                            if (Engine.GetRealCard(id).Name.Contains(invalid.Value))
                            {
                                RoomLogic.SetPlayerCardLimitation(_move.To, Name, "use,response,discard", id.ToString());
                                results.Add(id);
                            }
                        }
                        if (results.Count > 0)
                            _move.To.SetTag(Name, results);
                    }
                    else if (_move.To.ContainsTag("gongshun_to") && _move.To.GetTag("gongshun_to") is KeyValuePair<string, string> _invalid)
                    {
                        List<int> results = _move.To.ContainsTag(Name) ? (List<int>)_move.To.GetTag(Name) : new List<int>();
                        foreach (int id in _move.Card_ids)
                        {
                            if (Engine.GetRealCard(id).Name.Contains(_invalid.Value))
                            {
                                RoomLogic.SetPlayerCardLimitation(_move.To, Name, "use,response,discard", id.ToString());
                                results.Add(id);
                            }
                        }
                        if (results.Count > 0)
                            _move.To.SetTag(Name, results);
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.TurnStart || triggerEvent == TriggerEvent.Death)
            {
                if (player.ContainsTag("gongshun_to") && player.GetTag("gongshun_to") is string target_name)
                {
                    room.RemovePlayerStringMark(player, Name);
                    player.RemoveTag("gongshun_to");

                    if (player.ContainsTag(Name) && player.GetTag(Name) is List<int> ids)
                    {
                        foreach (int id in ids)
                            RoomLogic.RemovePlayerCardLimitation(player, Name, "use,response,discard", id.ToString());
                    }


                    Player target = room.FindPlayer(target_name);
                    if (target != null)
                    {
                        room.RemovePlayerStringMark(target, Name);
                        target.RemoveTag("gongshun_from");
                        if (target.ContainsTag(Name) && target.GetTag(Name) is List<int> _ids)
                        {
                            foreach (int id in _ids)
                                RoomLogic.RemovePlayerCardLimitation(target, Name, "use,response,discard", id.ToString());
                        }
                    }
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.AskForUseCard(player, RespondType.Skill, "@@gongshun", "@gongshun", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
            return info;
        }
    }

    public class GongshunVS : ViewAsSkill
    {
        public GongshunVS() : base("gongshun") { response_pattern = "@@gongshun"; }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return selected.Count <= 1 && RoomLogic.CanDiscard(room, player, player, to_select.Id);
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 2)
            {
                WrappedCard card = new WrappedCard(GongshunCard.ClassName) { Skill = Name };
                card.AddSubCards(cards);
                return card;
            }
            return null;
        }
    }

    public class GongshunCard : SkillCard
    {
        public static string ClassName = "GongshunCard";
        public GongshunCard() : base(ClassName)
        { will_throw = true; }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && to_select != Self && !to_select.ContainsTag("gongshun_from");

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            Player target = card_use.To[0];

            List<string> cards = ViewAsSkill.GetGuhuoCards(room, "bt");
            cards.RemoveAll(t => t.Contains(Slash.ClassName) && t != Slash.ClassName);
            string choice = room.AskForChoice(player, "gongshun", string.Join("+", cards), new List<string> { "@to-player:" + player.Name }, target, card_use.Card.SkillPosition);
            player.SetTag("gongshun_to", new KeyValuePair<string, string>(target.Name, choice));
            target.SetTag("gongshun_from", new KeyValuePair<string, string>(player.Name, choice));

            room.SetPlayerStringMark(player, "gongshun", choice);
            room.SetPlayerStringMark(target, "gongshun", choice);
        }
    }

    public class Jimeng : TriggerSkill
    {
        public Jimeng() : base("jimeng")
        {
            events.Add(TriggerEvent.EventPhaseStart);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Play)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (RoomLogic.CanGetCard(room, player, p, "he"))
                    targets.Add(p);
            }
            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@jimeng", true, true, info.SkillPosition);
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
            if (room.GetTag(Name) is Player target)
            {
                room.RemoveTag(Name);
                int id = room.AskForCardChosen(player, target, "he", Name, false, HandlingMethod.MethodGet);
                room.ObtainCard(player, room.GetCard(id), new CardMoveReason(MoveReason.S_REASON_EXTRACTION, player.Name, target.Name, Name, string.Empty), false);

                if (player.Alive && target.Alive)
                {
                    int count = Math.Min(player.GetCardCount(true), player.Hp);
                    List<int> give;
                    if (count == player.GetCardCount(true))
                    {
                        give = player.GetCards("he");
                    }
                    else
                        give = room.AskForExchange(player, Name, count, count, string.Format("@jimeng-give:{0}::{1}", target.Name, count), string.Empty, "..", info.SkillPosition);

                    ResultStruct result = player.Result;
                    result.Assist += give.Count;
                    player.Result = result;

                    room.ObtainCard(target, ref give, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty), false);
                }
            }

            return false;
        }
    }

    public class Shuaiyan : TriggerSkill
    {
        public Shuaiyan() : base("shuaiyan")
        {
            events.Add(TriggerEvent.EventPhaseStart);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Discard && player.HandcardNum > 1)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (!p.IsNude()) targets.Add(p);
            }
            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@shuaiyan", true, true, info.SkillPosition);
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
            room.ShowAllCards(player, null, Name, info.SkillPosition);
            if (room.GetTag(Name) is Player target)
            {
                List<int> give = room.AskForExchange(target, Name, 1, 1, "@shuaiyan:" + player.Name, string.Empty, "..", info.SkillPosition);

                ResultStruct result = target.Result;
                result.Assist += 1;
                target.Result = result;

                room.ObtainCard(player, ref give, new CardMoveReason(MoveReason.S_REASON_GIVE, target.Name, player.Name, Name, string.Empty), false);
            }

            return false;
        }
    }

    public class Xuewei : TriggerSkill
    {
        public Xuewei() : base("xuewei")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.TurnStart };
            skill_type = SkillType.Defense;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.TurnStart && player.ContainsTag(Name) && player.GetTag(Name) is string target_name)
            {
                Player target = room.FindPlayer(target_name, true);
                player.RemoveTag(Name);

                if (target.ContainsTag("xuewei_from") && target.GetTag("xuewei_from") is List<string> froms)
                {
                    froms.Remove(player.Name);
                    if (froms.Count == 0)
                        target.RemoveTag("xuewei_from");
                    else
                        target.SetTag("xuewei_from", froms);
                }

                List<string> arg = new List<string>
                {
                    target.Name,
                    "@xuewei",
                    "0"
                };
                room.DoNotify(room.GetClient(player), CommandType.S_COMMAND_SET_MARK, arg);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Start)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@xuewei-target", true, false, info.SkillPosition);
            if (target != null)
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name, new List<Player> { player });
                room.NotifySkillInvoked(player, Name);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                room.SetTag(Name, target);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.ContainsTag(Name) && room.GetTag(Name) is Player target)
            {
                room.RemoveTag(Name);

                List<string> arg = new List<string>
                {
                    target.Name,
                    "@xuewei",
                    "1"
                };
                room.DoNotify(room.GetClient(player), CommandType.S_COMMAND_SET_MARK, arg);

                if (target.ContainsTag("xuewei_from") && target.GetTag("xuewei_from") is List<string> froms)
                {
                    if (!froms.Contains(player.Name))
                        froms.Add(player.Name);

                    target.SetTag("xuewei_from", froms);
                }
                else
                    target.SetTag("xuewei_from", new List<string> { player.Name });
            }

            return false;
        }
    }

    public class XueweiDamage : TriggerSkill
    {
        public XueweiDamage() : base("#xuewei")
        {
            frequency = Frequency.Compulsory;
            events.Add(TriggerEvent.DamageInflicted);
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (player.ContainsTag("xuewei_from") && player.GetTag("xuewei_from") is List<string> froms)
            {
                List<string> names = new List<string>(froms);
                foreach (string player_name in names)
                {
                    Player p = room.FindPlayer(player_name);
                    if (p == null)
                        froms.Remove(player_name);
                }

                if (froms.Count == 0)
                    player.RemoveTag("xuewei_from");
                else
                    player.SetTag("xuewei_from", froms);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.ContainsTag("xuewei_from") && player.GetTag("xuewei_from") is List<string> froms)
            {
                List<string> names = new List<string>(froms);
                foreach (string player_name in names)
                {
                    Player p = room.FindPlayer(player_name);
                    if (p != null) triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
            room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
            room.SendCompulsoryTriggerLog(ask_who, Name, true);

            if (player.ContainsTag("xuewei_from") && player.GetTag("xuewei_from") is List<string> froms)
            {
                froms.Remove(ask_who.Name);
                if (froms.Count == 0)
                    player.RemoveTag("xuewei_from");
                else
                    player.SetTag("xuewei_from", froms);
            }

            List<string> arg = new List<string>
            {
                    player.Name,
                    "@xuewei",
                    "0"
            };
            room.DoNotify(room.GetClient(ask_who), CommandType.S_COMMAND_SET_MARK, arg);

            if (data is DamageStruct damage)
            {
                DamageStruct _damage = new DamageStruct(Name, damage.From, ask_who, damage.Damage, damage.Nature);
                room.Damage(_damage);

                if (ask_who.Alive && damage.From != null && damage.From.Alive)
                {
                    DamageStruct damage2 = new DamageStruct(Name, ask_who, damage.From, damage.Damage, damage.Nature);
                    room.Damage(damage2);
                }
            }

            return true;
        }
    }

    public class Liechi : TriggerSkill
    {
        public Liechi() : base("liechi")
        {
            events.Add(TriggerEvent.Dying);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Attack;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DyingStruct dying && dying.Damage.From != null && dying.Damage.From != player
                && dying.Damage.From.Alive && !dying.Damage.From.IsNude())
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            if (data is DyingStruct dying)
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, dying.Damage.From.Name);
                room.AskForDiscard(dying.Damage.From, Name, 1, 1, false, true, "@liechi:" + player.Name, false, null);
            }
            return false;
        }
    }

    public class Shameng : ViewAsSkill
    {
        public Shameng() : base("shameng") { skill_type = SkillType.Replenish; }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (selected.Count < 2 && room.GetCardPlace(to_select.Id) == Place.PlaceHand)
            {
                if (selected.Count == 0)
                    return true;
                else if (selected.Count == 1)
                    return WrappedCard.IsBlack(selected[0].Suit) == WrappedCard.IsBlack(to_select.Suit);
            }
            return false;
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(ShamengCard.ClassName);

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 2)
            {
                WrappedCard sm = new WrappedCard(ShamengCard.ClassName) { Skill = Name };
                sm.AddSubCards(cards);
                return sm;
            }
            return null;
        }
    }

    public class ShamengCard : SkillCard
    {
        public static string ClassName = "ShamengCard";
        public ShamengCard() : base(ClassName)
        {
            will_throw = true;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && Self != to_select;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0], player = card_use.From;
            room.DrawCards(target, new DrawCardStruct(2, player, "shameng"));
            if (player.Alive)
                room.DrawCards(player, 3, "shameng");
        }
    }

    public class ShengxiClassic : TriggerSkill
    {
        public ShengxiClassic() : base("shengxi_classic")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageDone, TriggerEvent.EventPhaseEnd, TriggerEvent.EventPhaseStart };
            frequency = Frequency.Frequent;
            skill_type = SkillType.Replenish;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.DamageDone && data is DamageStruct damage && damage.From != null && !damage.From.HasFlag("ShengxiDamageInPlayPhase")
                && damage.From.Phase <= PlayerPhase.Finish)
                damage.From.SetFlags("ShengxiDamageInPlayPhase");
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room)
                && player.Phase == PlayerPhase.Finish && !player.HasFlag("ShengxiDamageInPlayPhase"))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, null, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.DrawCards(player, 2, Name);

            return false;
        }
    }

    public class Jianyu : TriggerSkill
    {
        public Jianyu() : base("jianyu")
        {
            events = new List<TriggerEvent> { TriggerEvent.TurnStart, TriggerEvent.TargetChoosing, TriggerEvent.Death, TriggerEvent.EventLoseSkill };
            view_as_skill = new JianyuVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.TurnStart)
            {
                ClearTargets(room, player);
                player.SetMark(Name, 0);
            }
            else if (triggerEvent == TriggerEvent.Death)
                ClearTargets(room, player);
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name)
                ClearTargets(room, player);
        }

        private void ClearTargets(Room room, Player player)
        {
            if (player.ContainsTag(Name) && player.GetTag(Name) is List<string> targets)
            {
                player.RemoveTag(Name);
                foreach (string target_name in targets)
                {
                    Player target = room.FindPlayer(target_name);
                    if (target != null)
                        room.RemovePlayerStringMark(target, Name);
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.TargetChoosing && data is CardUseStruct use && player.Phase == PlayerPhase.Play)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (!(fcard is SkillCard))
                {
                    foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    {
                        if (p.ContainsTag(Name) && p.GetTag(Name) is List<string> targets && targets.Contains(player.Name))
                        {
                            foreach (Player victim in use.To)
                            {
                                if (victim != player && targets.Contains(victim.Name))
                                {
                                    triggers.Add(new TriggerStruct(Name, p));
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && ask_who.ContainsTag(Name) && ask_who.GetTag(Name) is List<string> targets && targets.Contains(player.Name))
            {
                Player target = null;
                foreach (Player victim in use.To)
                {
                    if (victim != player && targets.Contains(victim.Name))
                    {
                        target = victim;
                        break;
                    }
                }

                target.SetFlags(Name);
                bool invoke = room.AskForSkillInvoke(ask_who, Name, target, info.SkillPosition);
                target.SetFlags("-jianyu");
                if (invoke)
                {
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, target.Name);
                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && ask_who.ContainsTag(Name) && ask_who.GetTag(Name) is List<string> targets && targets.Contains(player.Name))
            {
                Player target = null;
                foreach (Player victim in use.To)
                {
                    if (victim != player && targets.Contains(victim.Name))
                    {
                        target = victim;
                        break;
                    }
                }
                room.DrawCards(target, new DrawCardStruct(1, ask_who, Name));
            }
            return false;
        }
    }

    public class JianyuVS : ZeroCardViewAsSkill
    {
        public JianyuVS() : base("jianyu") { }
        public override bool IsEnabledAtPlay(Room room, Player player) => player.GetMark(Name) == 0;

        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(JianyuCard.ClassName) { Skill = Name, Mute = true };
    }

    public class JianyuCard : SkillCard
    {
        public static string ClassName = "JianyuCard";
        public JianyuCard() : base(ClassName)
        {}
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 || targets.Count == 1 && !targets.Contains(to_select);

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card) => targets.Count == 2;
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "jianyu", card_use.Card.SkillPosition);
            room.BroadcastSkillInvoke("jianyu", "male", 1, gsk.General, gsk.SkinId);
            List<string> targets = new List<string>();
            foreach (Player p in card_use.To)
            {
                room.SetPlayerStringMark(p, "jianyu", string.Empty);
                targets.Add(p.Name);
            }
            player.SetTag("jianyu", targets);
            player.AddMark("jianyu");
        }
    }

    public class CunsiClassic : ZeroCardViewAsSkill
    {
        public CunsiClassic() : base("cunsi_classic")
        {
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => player.FaceUp;
        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(CunsiCCard.ClassName) { Skill = Name };
    }

    public class CunsiCCard : SkillCard
    {
        public static string ClassName = "CunsiCCard";
        public CunsiCCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            room.TurnOver(player);
            target.AddMark("cunsi_classic");
            room.SetPlayerStringMark(target, "cunsi_classic", target.GetMark("cunsi_classic").ToString());
            List<int> get = new List<int>();
            foreach (int id in room.DrawPile)
            {
                WrappedCard card = room.GetCard(id);
                if (card.Name.Contains(Slash.ClassName))
                {
                    get.Add(id);
                    break;
                }
            }

            if (get.Count > 0)
                room.ObtainCard(player, ref get, new CardMoveReason(MoveReason.S_REASON_GOTCARD, target.Name, "cunsi_classic", string.Empty));
        }
    }

    public class CunsiEffect : TriggerSkill
    {
        public CunsiEffect() : base("#cunsi_classic")
        {
            events.Add(TriggerEvent.CardUsedAnnounced);
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName) && player.Alive && player.GetMark("cunsi_classic") > 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                LogMessage log = new LogMessage
                {
                    Type = "#cunsi-add",
                    From = player.Name,
                    Arg =  player.GetMark("cunsi_classic").ToString(),
                    Arg2 = use.Card.Name
                };
                room.SendLog(log);

                use.ExDamage += player.GetMark("cunsi_classic");
                data = use;
                player.SetMark("cunsi_classic", 0);
                room.RemovePlayerStringMark(player, "cunsi_classic");
            }

            return false;
        }
    }

    public class GuixiuClassic : TriggerSkill
    {
        public GuixiuClassic() : base("guixiu_classic")
        {
            frequency = Frequency.Compulsory;
            events = new List<TriggerEvent> { TriggerEvent.Damaged, TriggerEvent.TurnedOver };
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && base.Triggerable(player, room) && !player.FaceUp)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.TurnedOver && base.Triggerable(player, room) && player.FaceUp)
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            if (triggerEvent == TriggerEvent.Damaged)
                room.TurnOver(player);
            else
                room.DrawCards(player, 1, Name);

            return false;
        }
    }

    public class Xiangzhen : TriggerSkill
    {
        public Xiangzhen() : base("xiangzhen")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardFinished, TriggerEvent.Damage };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && damage.Card != null && damage.Card.Name == SavageAssault.ClassName)
            {
                damage.Card.SetFlags(Name);
                if (damage.From != null && damage.From.Alive) damage.From.SetFlags(string.Format("{0}_{1}", Name, RoomLogic.CardToString(room, damage.Card)));
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && use.Card.Name == SavageAssault.ClassName && use.Card.HasFlag(Name))
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    triggers.Add(new TriggerStruct(Name, p));

            }
            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            room.DrawCards(ask_who, 1, Name);
            if (data is CardUseStruct use)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.HasFlag(string.Format("{0}_{1}", Name, RoomLogic.CardToString(room, use.Card))))
                    {
                        room.DrawCards(p, new DrawCardStruct(1, ask_who, Name));
                    }
                }
            }

            return false;
        }
    }

    public class XiangzhenClear : TriggerSkill
    {
        public XiangzhenClear() : base("#xiangzhen")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardFinished };
        }
        public override int Priority => 2;
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is CardUseStruct use && use.Card.Name == SavageAssault.ClassName)
            {
                string str = RoomLogic.CardToString(room, use.Card);
                foreach (Player p in room.GetAlivePlayers())
                {
                    p.SetFlags(string.Format("-{0}_{1}", Name, str));
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class Fangzong : TriggerSkill
    {
        public Fangzong() : base("fangzong")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Finish && base.Triggerable(player, room) && player.HandcardNum < room.AliveCount())
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            int count = room.AliveCount() - player.HandcardNum;
            room.DrawCards(player, count, Name);
            return false;
        }
    }

    public class FangzongPro : ProhibitSkill
    {
        public FangzongPro() : base("#fangzong") { }
        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if ((card.Name.Contains(Slash.ClassName) || card.Name == FireAttack.ClassName || card.Name == Duel.ClassName || card.Name == Drowning.ClassName || card.Name == BurningCamps.ClassName
                || card.Name == ArcheryAttack.ClassName || card.Name == SavageAssault.ClassName) && from != to && RoomLogic.InMyAttackRange(room, from, to, card)
                && (RoomLogic.PlayerHasShownSkill(room, from, Name) && from.Phase == PlayerPhase.Play || (!to.HasFlag("xizhan") && RoomLogic.PlayerHasShownSkill(room, to, Name)))) return true;

            return false;
        }
    }

    public class Xizhan : TriggerSkill
    {
        public Xizhan() : base("xizhan")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.CardsMoveOneTime };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.To_place == Place.DiscardPile
                && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && move.Reason.SkillName == Name)
                move.From.SetTag(Name, room.GetCard(move.Card_ids[0]).Suit);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.Start)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p != player) triggers.Add(new TriggerStruct(Name, p));
            }
                
            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForDiscard(ask_who, Name, 1, 1, true, true, "@xizhan", true, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                if (ask_who.Alive && ask_who.GetTag(Name) is WrappedCard.CardSuit suit)
                {
                    ask_who.SetFlags(Name);
                    ask_who.RemoveTag(Name);
                    switch (suit)
                    {
                        case WrappedCard.CardSuit.Club:
                            WrappedCard chain = new WrappedCard(IronChain.ClassName) { Skill = "_xizhan" };
                            if (RoomLogic.IsProhibited(room, ask_who, player, chain) == null)
                                room.UseCard(new CardUseStruct(chain, ask_who, player));
                            break;
                        case WrappedCard.CardSuit.Spade when player.Alive:
                            WrappedCard ana = new WrappedCard(Analeptic.ClassName) { Skill = "_xizhan" };
                            if (RoomLogic.IsProhibited(room, player, player, ana) == null)
                                room.UseCard(new CardUseStruct(ana, player, player));
                            break;
                        case WrappedCard.CardSuit.Heart:
                            WrappedCard ex = new WrappedCard(ExNihilo.ClassName) { Skill = "_xizhan" };
                            if (RoomLogic.IsProhibited(room, player, player, ex) == null)
                                room.UseCard(new CardUseStruct(ex, ask_who, ask_who));
                            break;
                        case WrappedCard.CardSuit.Diamond:
                            WrappedCard slash = new WrappedCard(FireSlash.ClassName) { Skill = "_xizhan", DistanceLimited = false };
                            if (RoomLogic.IsProhibited(room, ask_who, player, slash) == null)
                                room.UseCard(new CardUseStruct(slash, ask_who, player) { Reason = CardUseReason.CARD_USE_REASON_RESPONSE_USE });
                            break;
                    }
                }
            }
            else
                room.LoseHp(ask_who);

            return false;
        }
    }

    public class Mingxuan : TriggerSkill
    {
        public Mingxuan() : base("mingxuan")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Wizzard;
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Play && base.Triggerable(player, room) && !player.IsKongcheng())
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (p.GetMark(Name) == 0)
                    targets.Add(p);

            List<Player> players = new List<Player>();
            List<int> ids = new List<int>();
            if (targets.Count > 0)
            {
                List<WrappedCard.CardSuit> suits = new List<WrappedCard.CardSuit>();
                foreach (int id in player.GetCards("h"))
                {
                    WrappedCard card = room.GetCard(id);
                    if (!suits.Contains(card.Suit))
                        suits.Add(card.Suit);
                }

                int count = Math.Min(targets.Count, suits.Count);
                while (ids.Count < count)
                {
                    List<string> patterns = new List<string>();
                    foreach (WrappedCard.CardSuit suit in suits)
                        patterns.Add(string.Format(".|{0}|.|hand", WrappedCard.GetSuitString(suit)));
                    List<int> result = room.AskForExchange(player, Name, 1, 1, "@mingxuan:::" + (ids.Count + 1).ToString(), string.Empty, string.Join("#", patterns), info.SkillPosition);
                    suits.Remove(room.GetCard(result[0]).Suit);
                    ids.AddRange(result);
                }
            }
            else
            {
                ids = room.AskForExchange(player, Name, 1, 1, "@mingxuan-one", string.Empty, ".", info.SkillPosition);
                targets = room.GetOtherPlayers(player);
            }
            if (ids.Count > 0)
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.SendCompulsoryTriggerLog(player, Name);

                Shuffle.shuffle(ref targets);
                for (int i = 0; i < ids.Count; i++)
                    players.Add(targets[i]);
            }

            List<CardsMoveStruct> moves = new List<CardsMoveStruct>();
            int index = 0;
            foreach (Player target in players)
            {
                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty);
                CardsMoveStruct move = new CardsMoveStruct(new List<int> { ids[index] }, target, Place.PlaceHand, reason);
                moves.Add(move);
                index++;
            }
            room.MoveCardsAtomic(moves, false);

            room.SortByActionOrder(ref players);
            foreach (Player p in players)
            {
                bool slash = false;
                if (p.Alive && player.Alive)
                    slash = room.AskForUseSlashTo(p, player, "@mingxuan-slash:" + player.Name, null) != null;

                if (slash)
                {
                    p.SetMark(Name, 1);
                }
                else if (player.Alive)
                {
                    if (p.Alive && !p.IsNude())
                    {
                        List<int> give = room.AskForExchange(p, Name, 1, 1, "@mingxuan-give:" + player.Name, string.Empty, "..", null);
                        if (give.Count > 0)
                            room.ObtainCard(player, ref give, new CardMoveReason(MoveReason.S_REASON_GIVE, p.Name, player.Name, Name, string.Empty), false);
                    }
                    if (player.Alive) room.DrawCards(player, 1, Name);
                }
            }
            return false;
        }
    }

    public class Xianchou : TriggerSkill
    {
        public Xianchou() : base("xianchou")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged, TriggerEvent.DamageComplete, TriggerEvent.CardFinished };
            skill_type = SkillType.Wizzard;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.DamageComplete && data is DamageStruct damage && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName) && damage.Card.GetSkillName() == Name)
            {
                int index = (int)room.GetTag("xianchou_count");
                string mark = "xianchou_" + index.ToString();
                room.SetTag(mark, true);
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct damage && damage.From != null && damage.From != player && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetOtherPlayers(player))
                    if (!p.IsNude() && p != damage.From)
                        targets.Add(p);

                if (targets.Count > 0)
                {
                    damage.From.SetFlags(Name);
                    Player target = room.AskForPlayerChosen(player, targets, Name, "@xianchou:" + damage.From.Name, true, true, info.SkillPosition);
                    damage.From.SetFlags("-xianchou");
                    if (target != null)
                    {
                        room.SetTag(Name, target);
                        room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                        return info;
                    }
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage && room.GetTag(Name) is Player target)
            {
                room.RemoveTag(Name);
                bool invoke = room.AskForDiscard(target, Name, 1, 1, true, true, string.Format("@xianchou-slash:{0}:{1}", player.Name, damage.From.Name));
                if (invoke)
                {
                    if (target.Alive && damage.From.Alive)
                    {
                        WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_xianchou", DistanceLimited = false };
                        if (RoomLogic.IsProhibited(room, target, damage.From, slash) == null)
                        {
                            int index = room.ContainsTag("xianchou_count") ? (int)room.GetTag("xianchou_count") : 0;
                            index++;
                            room.SetTag("xianchou_count", index);
                            room.UseCard(new CardUseStruct(slash, target, damage.From) { Reason = CardUseReason.CARD_USE_REASON_RESPONSE_USE });
                            string mark = "xianchou_" + index.ToString();
                            bool succe = room.ContainsTag(mark);
                            room.RemoveTag(mark);
                            if (succe && target.Alive) room.DrawCards(target, new DrawCardStruct(2, player, Name));
                            if (succe && player.Alive && player.IsWounded()) room.Recover(player);
                        }
                    }
                }
            }

            return false;
        }
    }

    public class LiegongMobile : TriggerSkill
    {
        public LiegongMobile() : base("liegong_mobile")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.TargetConfirmed, TriggerEvent.CardUsed, TriggerEvent.CardResponded };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            int suit = -1;
            if ((triggerEvent == TriggerEvent.TargetConfirmed || triggerEvent == TriggerEvent.CardUsed) && data is CardUseStruct use
                && !Engine.IsSkillCard(use.Card.Name) && base.Triggerable(player, room))
            {
                suit = (int)use.Card.Suit;
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use && resp.Card != null
                && !Engine.IsSkillCard(resp.Card.Name) && base.Triggerable(player, room))
            {
                suit = (int)resp.Card.Suit;
            }

            if (suit >= 0 && suit < 4)
            {
                List<int> suits = player.ContainsTag(Name) ? (List<int>)player.GetTag(Name) : new List<int>();
                if (!suits.Contains(suit))
                {
                    suits.Add(suit);
                    player.SetTag(Name, suits);
                    StringBuilder strs = new StringBuilder();
                    foreach (int id in suits)
                        strs.Append(WrappedCard.GetSuitIcon((WrappedCard.CardSuit)id));

                    room.SetPlayerStringMark(player, Name, strs.ToString());
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && base.Triggerable(player, room) && use.Card.Name.Contains(Slash.ClassName) && use.To.Count == 1
                && player.ContainsTag(Name) && player.GetTag(Name) is List<int> suits && suits.Count > 0)
                return new TriggerStruct(Name, player, use.To);
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
            if (player.GetTag(Name) is List<int> suits && data is CardUseStruct use)
            {
                player.RemoveTag(Name);
                room.RemovePlayerStringMark(player, Name);

                int count = suits.Count - 1;
                if (count > 0)
                {
                    List<int> card_ids = room.GetNCards(count);
                    int add = 0;
                    foreach (int id in card_ids)
                    {
                        WrappedCard card = room.GetCard(id);
                        room.MoveCardTo(card, player, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_TURNOVER, player.Name, Name, null), false);
                        if (suits.Contains((int)card.Suit))
                            add++;
                    }

                    if (add > 0)
                    {
                        LogMessage log = new LogMessage
                        {
                            Type = "#damage-add",
                            From = player.Name,
                            Arg = use.Card.Name,
                            Arg2 = add.ToString()
                        };
                        room.SendLog(log);

                        use.ExDamage += count;
                    }

                    room.MoveCards(new List<CardsMoveStruct>{ new CardsMoveStruct(card_ids, null, Place.DiscardPile, new CardMoveReason(MoveReason.S_REASON_NATURAL_ENTER, null, Name, null)) }, true);
                }

                StringBuilder strs = new StringBuilder();
                List<string> suits_str = new List<string> { "spade", "heart", "club", "diamond", "no_suit", "no_suit_black", "no_suit_red" };
                foreach (int id in suits)
                {
                    strs.Append(WrappedCard.GetSuitIcon((WrappedCard.CardSuit)id));
                    suits_str.Remove(WrappedCard.GetSuitString((WrappedCard.CardSuit)id));
                }
                string pattern = string.Format("Jink|{0}", string.Join(",", suits_str));

                LogMessage log2 = new LogMessage
                {
                    Type = "$NoJinkSuit",
                    From = target.Name,
                    Card_str = RoomLogic.CardToString(room, use.Card),
                    Arg = strs.ToString()
                };
                room.SendLog(log2);

                int index = 0;
                for (int i = 0; i < use.EffectCount.Count; i++)
                {
                    CardBasicEffect effect = use.EffectCount[i];
                    if (effect.To == target)
                    {
                        index++;
                        if (index == info.Times)
                        {
                            effect.RespondPattern = pattern;
                            break;
                        }
                    }
                }
                data = use;
            }
            return false;
        }
    }

    public class LiegongMobileTar : TargetModSkill
    {
        public LiegongMobileTar() : base("#liegong_mobile-tar")
        {
        }

        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern)
        {
            if (from != null && RoomLogic.PlayerHasSkill(room, from, "liegong_mobile") && to != null)
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

    public class YanyuMobile : TriggerSkill
    {
        public YanyuMobile() : base("yanyu_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseEnd, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Replenish;
            view_as_skill = new YanyuMobileVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.GetMark(Name) > 0)
                player.SetMark(Name, 0);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseEnd && player.Phase == PlayerPhase.Play && player.GetMark(Name) > 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@yanyu_jx:::" + (player.GetMark(Name) * 3).ToString() , true, true, info.SkillPosition);
            if (target != null)
            {
                room.SetTag(Name, target);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is Player target)
            {
                room.RemoveTag(Name);
                int count = 3 * player.GetMark(Name);
                room.DrawCards(target, new DrawCardStruct(count, player, Name));
            }
            return false;
        }
    }

    public class YanyuMobileCard : SkillCard
    {
        public static string ClassName = "YanyuMobileCard";
        public YanyuMobileCard() : base(ClassName)
        {
            will_throw = true;
            target_fixed = true;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            card_use.From.AddMark("yanyu_jx");
            room.DrawCards(card_use.From, 1, "yanyu_jx");
        }
    }

    public class YanyuMobileVS : OneCardViewAsSkill
    {
        public YanyuMobileVS() : base("yanyu_jx")
        {
        }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player) => room.GetCardPlace(to_select.Id) == Place.PlaceHand
            && RoomLogic.CanDiscard(room, player, player, to_select.Id) && to_select.Name.Contains(Slash.ClassName);
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.IsKongcheng() && player.UsedTimes(YanyuMobileCard.ClassName) < 2;
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard yy = new WrappedCard(YanyuMobileCard.ClassName)
            {
                Skill = Name
            };
            yy.AddSubCard(card);
            return yy;
        }
    }

    public class QiaoshiMobile : TriggerSkill
    {
        public QiaoshiMobile() : base("qiaoshi_jx")
        {
            events.Add(TriggerEvent.Damaged);
            skill_type = SkillType.Recover;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DamageStruct damage && damage.From != null && damage.From != player && damage.From.Alive && !player.HasFlag(Name) && base.Triggerable(player, room) && player.IsWounded())
                return new TriggerStruct(Name, damage.From, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                int count = Math.Min(damage.Damage, player.GetLostHp());
                if (room.AskForSkillInvoke(ask_who, Name, string.Format("@qiaoshi_jx:{0}::{1}", player.Name, count)))
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    room.NotifySkillInvoked(player, Name);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    player.SetFlags(Name);
                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                int count = Math.Min(damage.Damage, player.GetLostHp());
                RecoverStruct recover = new RecoverStruct();
                recover.Recover = count;
                recover.Who = ask_who;
                room.Recover(player, recover, true);

                if (ask_who.Alive)
                    room.DrawCards(ask_who, 2, Name);
            }

            return false;
        }
    }

    //lifeng
    public class TunchuJX : DrawCardsSkill
    {
        public TunchuJX() : base("tunchu_jx")
        {
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Draw && player.GetPile("commissariat").Count == 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, null, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                player.SetTag(Name, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override int GetDrawNum(Room room, Player player, int n)
        {
            player.SetFlags(Name);
            return n + 2;
        }
    }

    public class TunchuJxAdd : TriggerSkill
    {
        public TunchuJxAdd() : base("#tunchu_jx-add")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventLoseSkill, TriggerEvent.AfterDrawNCards };
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == "tunchu_jx")
                room.ClearOnePrivatePile(player, "commissariat");
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.AfterDrawNCards && player != null && player.Alive && player.HasFlag("tunchu_jx"))
            {
                if (player.IsKongcheng())
                {
                    player.SetFlags("-tunchu_jx");
                    return new TriggerStruct();
                }
                TriggerStruct trigger = new TriggerStruct(Name, player)
                {
                    SkillPosition = (string)player.GetTag("tunchu_jx")
                };
                return trigger;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            player.SetFlags("-tunchu_jx");
            player.RemoveTag("tunchu_jx");

            List<int> ids = room.AskForExchange(player, "tunchu", player.HandcardNum, 0, "@tunchu_jx", string.Empty, ".|.|.|hand", info.SkillPosition);
            if (ids.Count > 0) room.AddToPile(player, "commissariat", ids);

            return false;
        }
    }


    public class TunchuProhibitJX : ProhibitSkill
    {
        public TunchuProhibitJX() : base("#tunchu_jx-prohibit")
        {
        }
        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if (from != null && from.GetPile("commissariat").Count > 0 && card != null && card.Name.Contains("Slash"))
            {
                CardUseReason reason = room.GetRoomState().GetCurrentCardUseReason();
                return reason == CardUseReason.CARD_USE_REASON_PLAY || reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE;
            }

            return false;
        }
    }

    public class ShuliangJX : TriggerSkill
    {
        public ShuliangJX() : base("shuliang_jx")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Replenish;
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (player.Alive && player.Phase == PlayerPhase.Finish && player.HandcardNum < player.Hp)
            {
                List<Player> lifengs = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in lifengs)
                {
                    if (p.GetPile("commissariat").Count > 0)
                    {
                        TriggerStruct trigger = new TriggerStruct(Name, p);
                        skill_list.Add(trigger);
                    }
                }
            }
            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player lifeng, TriggerStruct info)
        {
            if (player.Alive && player.Phase == PlayerPhase.Finish && player.HandcardNum < player.Hp && lifeng.GetPile("commissariat").Count > 0)
            {
                List<int> ids = room.AskForExchange(lifeng, Name, 1, 0, "@shuliang:" + player.Name, "commissariat", string.Empty, info.SkillPosition);
                if (ids.Count > 0)
                {
                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_REMOVE_FROM_PILE, string.Empty, Name, Name);
                    room.ThrowCard(ref ids, reason, null);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, lifeng.Name, player.Name);
                    room.BroadcastSkillInvoke(Name, lifeng, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Alive)
                room.DrawCards(player, new DrawCardStruct(2, ask_who, Name));
            return false;
        }
    }

    public class RendeJx : TriggerSkill
    {
        public RendeJx() : base("rende_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.EventAcquireSkill, TriggerEvent.EventPhaseStart, TriggerEvent.EventLoseSkill, TriggerEvent.CardUsed, TriggerEvent.CardResponded };
            view_as_skill = new RendeJxVS();
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
            {
                if (!room.Skills.Contains("rende_virtual"))
                    room.Skills.Add("rende_virtual");
                    room.HandleAcquireDetachSkills(player, "rende_virtual", true, false);
            }
            else if (triggerEvent == TriggerEvent.EventAcquireSkill && data is InfoStruct info && info.Info == Name)
            {
                if (!room.Skills.Contains("rende_virtual"))
                    room.Skills.Add("rende_virtual");
                room.HandleAcquireDetachSkills(player, "rende_virtual", true, false);
            }
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name)
            {
                room.RemovePlayerStringMark(player, Name);
                room.HandleAcquireDetachSkills(player, "-rende_virtual", true, false);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play)
            {
                int count = Math.Min(8 - player.GetMark(Name), 2);
                if (count > 0)
                {
                    player.AddMark(Name, count);
                    room.SetPlayerStringMark(player, Name, player.GetMark(Name).ToString());
                }
            }
            else if (player.Alive && ((triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && use.Card.GetSkillName() == Name && !Engine.IsSkillCard(use.Card.Name))
                || (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Card.GetSkillName() == Name)))
            {
                player.SetFlags(Name);
                player.AddMark(Name, -2);
                int count = player.GetMark(Name);
                if (count > 0)
                    room.SetPlayerStringMark(player, Name, count.ToString());
                else
                    room.RemovePlayerStringMark(player, Name);
            }
        }
    }

    public class RendeJxVS : ViewAsSkill
    {
        public RendeJxVS() : base("rende_jx")
        {
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.IsNude();
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => true;
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
            {
                WrappedCard rd = new WrappedCard(RendeJxCard.ClassName) { Skill = Name };
                rd.AddSubCards(cards);
                return rd;
            }
            return null;
        }
    }

    public class RendeJxVirtual : ViewAsSkill
    {
        public RendeJxVirtual() : base("rende_virtual")
        {
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasFlag("rende_jx") && player.GetMark("rende_jx") >= 2;
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
            => room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE && MatchBasic(respond) && !player.HasFlag("rende_jx") && player.GetMark("rende_jx") >= 2;
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => false;
        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> all_cards = new List<WrappedCard>();
            string pattern = room.GetRoomState().GetCurrentCardUsePattern(player);
            List<string> names = GetGuhuoCards(room, "b");
            if (pattern == ".")
            {
                foreach (string name in names)
                {
                    if (name == Jink.ClassName) continue;
                    WrappedCard card = new WrappedCard(name)
                    {
                        Skill = "rende_jx"
                    };
                    all_cards.Add(card);
                }
            }
            else
            {
                foreach (string name in names)
                {
                    WrappedCard card = new WrappedCard(name)
                    {
                        Skill = "rende_jx"
                    };
                    if (Engine.MatchExpPattern(room, pattern, player, card))
                        all_cards.Add(card);
                }
            }
            return all_cards;
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1) return cards[0];
            return null;
        }
    }

    public class RendeJxCard : SkillCard
    {
        public static string ClassName = "RendeJxCard";
        public RendeJxCard() : base(ClassName)
        {
            will_throw = false;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && to_select != Self && !to_select.HasFlag("rende_" + Self.Name);
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0];
            Player player = card_use.From;
            List<int> ids = new List<int>(card_use.Card.SubCards);
            ResultStruct result = player.Result;
            result.Assist += ids.Count;
            player.Result = result;

            target.SetFlags("rende_" + player.Name);
            target.SetMark("rende_" + player.Name, 1);
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "rende_jx", null);
            room.ObtainCard(target, ref ids, reason, false);
            
            int count = Math.Min(8 - player.GetMark("rende_jx"), ids.Count);
            if (count > 0)
            {
                player.AddMark("rende_jx", count);
                room.SetPlayerStringMark(player, "rende_jx", player.GetMark("rende_jx").ToString());
            }
        }
    }

    public class  ZhangwuJx : ZeroCardViewAsSkill
    {
        public ZhangwuJx() : base("zhangwu_jx")
        {
            frequency = Frequency.Limited;
            limit_mark = "@zhangwu";
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            if (player.GetMark(limit_mark) > 0 && room.Round > 1)
            {
                foreach (Player p in room.GetOtherPlayers(player))
                    if (p.GetMark(string.Format("rende_{0}", player.Name)) > 0 && !p.IsNude())
                        return true;
            }
            return false;
        }
        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(ZhangwuJxCard.ClassName) { Skill = Name };
    }
    public class ZhangwuJxCard : SkillCard
    {
        public static string ClassName = "ZhangwuJxCard";
        public ZhangwuJxCard() : base(ClassName) { target_fixed = true; }
        public override void OnUse(Room room, CardUseStruct card_use)
        {
            room.SetPlayerMark(card_use.From, "@zhangwu", 0);
            room.BroadcastSkillInvoke("zhangwu_jx", card_use.From, card_use.Card.SkillPosition);
            room.DoSuperLightbox(card_use.From, card_use.Card.SkillPosition, "zhangwu_jx");

            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(card_use.From))
                if (p.GetMark(string.Format("rende_{0}", card_use.From.Name)) > 0 && !p.IsNude())
                    targets.Add(p);

            card_use.To = targets;
            room.SortByActionOrder(ref card_use);
            base.OnUse(room, card_use);
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            base.Use(room, card_use);
            Player player = card_use.From;
            if (player.Alive && player.IsWounded())
            {
                int count = Math.Min(3, player.GetLostHp());
                room.Recover(player, count);
            }
            if (player.Alive) room.HandleAcquireDetachSkills(player, "-rende_jx", false);
        }
        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            Player from = effect.From;
            if (from.Alive && !effect.To.IsNude())
            {
                int count = Math.Min(effect.To.GetCardCount(true), room.Round - 1);
                count = Math.Min(3, count);
                List<int> ids = room.AskForExchange(effect.To, "zhangwu_jx", count, count, string.Format("@zhangwu_jx:{0}::{1}", from.Name, count), string.Empty, "..", string.Empty);
                if (ids.Count > 0)
                    room.ObtainCard(from, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, effect.To.Name, "zhangwu_jx", string.Empty), false);
            }
        }
    }

    public class Yingjian : TriggerSkill
    {
        public Yingjian() : base("yingjian")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Attack;
            view_as_skill = new YingjianVS();
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Start && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.AskForUseCard(player, RespondType.Skill, "@@yingjian", "@yingjian", null, -1, HandlingMethod.MethodUse, false, info.SkillPosition);
            return new TriggerStruct();
        }
    }

    public class Shixin : TriggerSkill
    {
        public Shixin() : base("shixin")
        {
            events.Add(TriggerEvent.DamageDefined);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Defense;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DamageStruct damage && damage.Nature == DamageStruct.DamageNature.Fire && base.Triggerable(player, room))
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

            return true;
        }
    }

    public class Fenyin : TriggerSkill
    {
        public Fenyin() : base("fenyin")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded };
            skill_type = SkillType.Replenish;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase != PlayerPhase.NotActive)
            {
                WrappedCard card = null;
                if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use)
                    card = use.Card;
                else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use)
                    card = resp.Card;

                if (card != null)
                {
                    FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                    if (!(fcard is SkillCard) && !(fcard is ImperialOrder))
                    {
                        int suit = player.GetMark(Name);
                        if (player.Alive && suit > 0 && ((suit == 1 && card.Suit != WrappedCard.CardSuit.NoSuit) || (suit != 2 && WrappedCard.IsBlack(card.Suit))
                            || (suit != 3 && WrappedCard.IsRed(card.Suit))))
                            return new TriggerStruct(Name, player);
                    }
                }
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
            if (player.Alive) room.DrawCards(player, 1, Name);
            return false;
        }
    }
    public class FenyinRecord : TriggerSkill
    {
        public FenyinRecord() : base("#fenyin")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded, TriggerEvent.EventPhaseChanging };
        }
        public override int Priority => 2;

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetMark("fenyin") > 0)
            {
                player.SetMark("fenyin", 0);
                room.RemovePlayerStringMark(player, "fenyin");
            }
            else if ((triggerEvent == TriggerEvent.CardUsed || triggerEvent == TriggerEvent.CardResponded) && player == room.Current && base.Triggerable(player, room))
            {
                WrappedCard card = null;
                if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use)
                    card = use.Card;
                else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use)
                    card = resp.Card;

                if (card != null)
                {
                    FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                    if (!(fcard is SkillCard) && !(fcard is ImperialOrder))
                    {
                        if (card.Suit == WrappedCard.CardSuit.NoSuit)
                        {
                            player.SetMark("fenyin", 1);
                            room.SetPlayerStringMark(player, "fenyin", "no_suit");
                        }
                        else if (WrappedCard.IsBlack(card.Suit))
                        {
                            player.SetMark("fenyin", 2);
                            room.SetPlayerStringMark(player, "fenyin", "black");
                        }
                        else
                        {
                            player.SetMark("fenyin", 3);
                            room.SetPlayerStringMark(player, "fenyin", "red");
                        }
                    }
                }
            }
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class Fubi : TriggerSkill
    {
        public Fubi() : base("fubi")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.Death, TriggerEvent.EventLoseSkill, TriggerEvent.EventPhaseChanging };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.ContainsTag("fubi_from"))
            {
                player.SetMark(Name, 0);
                player.SetMark("fubi_extra", 0);
            }
            else if (((triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name) || triggerEvent == TriggerEvent.Death)
                && player.ContainsTag(Name) && player.GetTag(Name) is string target_name)
            {
                player.RemoveTag(Name);
                Player target = room.FindPlayer(target_name);
                if (target != null && target.ContainsTag("fubi_from") && target.GetTag("fubi_from") is List<string> froms)
                {
                    froms.Remove(player.Name);
                    if (froms.Count == 0)
                    {
                        target.RemoveTag("fubi_from");
                        room.RemovePlayerStringMark(target, Name);
                    }
                    else
                        target.SetTag("fubi_from", froms);
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room)) return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@fubi", true, true, info.SkillPosition);
            if (target != null)
            {
                room.SetTag(Name, target);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = (Player)room.GetTag(Name);
            room.RemoveTag(Name);

            player.SetTag(Name, target.Name);
            room.SetPlayerStringMark(target, Name, string.Empty);
            List<string> froms = new List<string>();
            if (target.ContainsTag("fubi_from")) froms = (List<string>)target.GetTag("fubi_from");
            froms.Add(player.Name);
            target.SetTag("fubi_from", froms);
            return false;
        }
    }

    public class FubiEffect : TriggerSkill
    {
        public FubiEffect() : base("#fubi-effect")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            frequency = Frequency.Compulsory;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.ContainsTag("fubi_from") && player.Phase == PlayerPhase.Start && player.GetTag("fubi_from") is List<string> froms)
            {
                foreach (string from_name in froms)
                {
                    Player p = room.FindPlayer(from_name);
                    if (p != null && RoomLogic.PlayerHasSkill(room, p, "fubi") && p.ContainsTag("fubi") && p.GetTag("fubi") is string target && target == player.Name)
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }
            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            string choice = room.AskForChoice(ask_who, "fubi", "max+extra+cancel", new List<string> { "@to-player:" + player.Name }, player, info.SkillPosition);
            LogMessage log = new LogMessage
            {
                From = ask_who.Name
            };
            log.AddTo(player);
            switch (choice)
            {
                case "max":
                    player.AddMark("fubi");
                    log.Type = "#fubi-max";
                    room.SendLog(log);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    break;
                case "extra":
                    player.AddMark("fubi_extra");
                    log.Type = "#fubi-extra";
                    room.SendLog(log);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    break;
            }

            return false;
        }
    }

    public class FubiMax : MaxCardsSkill
    {
        public FubiMax() : base("#fubi") { }
        public override int GetExtra(Room room, Player target) => target.GetMark("fubi") * 3;
    }

    public class FubiExta : TargetModSkill
    {
        public FubiExta() : base("#fubi-extra") {}
        public override int GetResidueNum(Room room, Player from, WrappedCard card) => from.GetMark("fubi_extra");
    }

    public class Zuici : TriggerSkill
    {
        public Zuici() : base("zuici")
        {
            events.Add(TriggerEvent.AskForPeaches);
            skill_type = SkillType.Recover;
            view_as_skill = new ZuiciVS();
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player ask_who)
        {
            if (data is DyingStruct dying && dying.Who == target && target.Hp <= 0 && base.Triggerable(target, room))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!target.EquipIsBaned(i) && target.GetEquip(i) >= 0)
                        return new TriggerStruct(Name, target);
                }
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<string> choices = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                if (!player.EquipIsBaned(i) && player.GetEquip(i) >= 0)
                {
                    switch (i)
                    {
                        case 0:
                            choices.Add("Weapon");
                            break;
                        case 1:
                            choices.Add("Armor");
                            break;
                        case 2:
                            choices.Add("DefensiveHorse");
                            break;
                        case 3:
                            choices.Add("OffensiveHorse");
                            break;
                        case 4:
                            choices.Add("Treasure");
                            break;
                    }
                }
            }
            choices.Add("cancel");
            string choice = room.AskForChoice(player, Name, string.Join("+", choices), new List<string> { "@zuici" }, null, info.SkillPosition);
            if (choice != "cancel")
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.NotifySkillInvoked(player, Name);
                player.SetTag(Name, choice);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player pangtong, ref object data, Player ask_who, TriggerStruct info)
        {
            string choice = (string)pangtong.GetTag(Name);
            pangtong.RemoveTag(Name);

            ZuiciCard.Effect(room, pangtong, choice);
            return false;
        }
    }

    public class ZuiciVS : ZeroCardViewAsSkill
    {
        public ZuiciVS() : base("zuici") { }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            if (player.IsWounded())
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!player.EquipIsBaned(i) && player.GetEquip(i) >= 0)
                        return true;
                }
            }
            return false;
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(ZuiciCard.ClassName) { Skill = Name };
        }
    }

    public class ZuiciCard : SkillCard
    {
        public static string ClassName = "ZuiciCard";
        public ZuiciCard() :base(ClassName)
        {
            target_fixed = true;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            List<string> choices = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                if (!player.EquipIsBaned(i) && player.GetEquip(i) >= 0)
                {
                    switch (i)
                    {
                        case 0:
                            choices.Add("Weapon");
                            break;
                        case 1:
                            choices.Add("Armor");
                            break;
                        case 2:
                            choices.Add("DefensiveHorse");
                            break;
                        case 3:
                            choices.Add("OffensiveHorse");
                            break;
                        case 4:
                            choices.Add("Treasure");
                            break;
                    }
                }
            }
            string choice = room.AskForChoice(player, "zuici", string.Join("+", choices), new List<string> { "@zuici" }, null, card_use.Card.SkillPosition);
            Effect(room, player, choice);
        }

        public static void Effect(Room room, Player pangtong, string choice)
        {
            int index = -1;
            switch (choice)
            {
                case "Weapon":
                    index = 0;
                    break;
                case "Armor":
                    index = 1;
                    break;
                case "DefensiveHorse":
                    index = 2;
                    break;
                case "OffensiveHorse":
                    index = 3;
                    break;
                case "Treasure":
                    index = 4;
                    break;
            }
            room.AbolisheEquip(pangtong, index, "zuici");
            if (pangtong.Alive && pangtong.IsWounded())
                room.Recover(pangtong, Math.Min(2, pangtong.GetLostHp()));

            if (pangtong.Alive && RoomLogic.PlayerHasSkill(room, pangtong, "fubi"))
            {
                Player old = null;
                List<Player> targets = room.GetOtherPlayers(pangtong);
                if (pangtong.ContainsTag("fubi") && pangtong.GetTag("fubi") is string target_name)
                {
                    old = room.FindPlayer(target_name);
                    if (old != null)
                    {
                        targets.Remove(old);
                        if (old.ContainsTag("fubi_from") && old.GetTag("fubi_from") is List<string> froms)
                        {
                            froms.Remove(pangtong.Name);
                            if (froms.Count == 0)
                            {
                                old.RemoveTag("fubi_from");
                                room.RemovePlayerStringMark(old, "fubi");
                            }
                            else
                                old.SetTag("fubi_from", froms);
                        }
                    }
                }

                Player target = room.AskForPlayerChosen(pangtong, targets, "fubi", "@fubi", true, true);
                if (target != null)
                {
                    room.BroadcastSkillInvoke("fubi", pangtong);

                    pangtong.SetTag("fubi", target.Name);
                    room.SetPlayerStringMark(target, "fubi", string.Empty);
                    List<string> froms = new List<string>();
                    if (target.ContainsTag("fubi_from")) froms = (List<string>)target.GetTag("fubi_from");
                    froms.Add(pangtong.Name);
                    target.SetTag("fubi_from", froms);
                }
            }
        }
    }

    public class Qinzheng : TriggerSkill
    {
        public Qinzheng() : base("qinzheng")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (!(fcard is SkillCard))
                    player.AddMark(Name);
            }
            else if (triggerEvent == TriggerEvent.CardResponded)
                player.AddMark(Name);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            bool judge = false;
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && base.Triggerable(player, room))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (!(fcard is SkillCard))
                    judge = true;
            }
            else if (triggerEvent == TriggerEvent.CardResponded && base.Triggerable(player, room))
            {
                judge = true;
            }

            if (judge)
            {
                int three = player.GetMark(Name) % 3;
                int five = player.GetMark(Name) % 5;
                int eight = player.GetMark(Name) % 8;
                if (three == 0 || five == 0 || eight == 0)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            int three = player.GetMark(Name) % 3;
            int five = player.GetMark(Name) % 5;
            int eight = player.GetMark(Name) % 8;

            //slash jink
            if (three == 0)
            {
                GetCard(room, player, Jink.ClassName, Slash.ClassName);
            }
            //peach ana
            if (five == 0)
            {
                GetCard(room, player, Peach.ClassName, Analeptic.ClassName);
            }
            //ex duel
            if (eight == 0)
            {
                GetCard(room, player, ExNihilo.ClassName, Duel.ClassName);
            }
            return false;
        }

        private void GetCard(Room room, Player player, string pattern1, string pattern2)
        {
            List<int> ids = new List<int>();
            foreach (int id in room.DrawPile)
            {
                WrappedCard card = room.GetCard(id);
                if (card.Name == pattern1 || card.Name.Contains(pattern2))
                {
                    ids.Add(id);
                    break;
                }
            }
            if (ids.Count > 0)
            {
                room.MoveCardTo(room.GetCard(ids[0]), player, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_TURNOVER, player.Name, Name, null), false);
                System.Threading.Thread.Sleep(200);

                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name, Name, string.Empty);
                room.ObtainCard(player, ref ids, reason, true);
            }
            else
            {
                foreach (int id in room.DiscardPile)
                {
                    WrappedCard card = room.GetCard(id);
                    if (card.Name == pattern1 || card.Name.Contains(pattern2))
                    {
                        ids.Add(id);
                        break;
                    }
                }

                if (ids.Count > 0)
                {
                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name, Name, string.Empty);
                    room.ObtainCard(player, ref ids, reason, true);
                }
            }
        }
    }

    public class Heji : TriggerSkill
    {
        public Heji() : base("heji")
        {
            skill_type = SkillType.Attack;
            events = new List<TriggerEvent> { TriggerEvent.CardFinished, TriggerEvent.CardUsedAnnounced };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            //if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && use.Pattern == "Slash|.|.|hand#Duel|.|.|hand:heji")
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && use.Pattern == "Slash#Duel:heji")
            {
                room.ShowSkill(player, Name, string.Empty);
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player);

                if (!use.Card.IsVirtualCard())
                {
                    List<int> get = new List<int>();
                    foreach (int id in room.DrawPile)
                    {
                        WrappedCard card = room.GetCard(id);
                        if (WrappedCard.IsRed(card.Suit))
                        {
                            get.Add(id);
                            break;
                        }
                    }

                    if (get.Count > 0)
                        room.ObtainCard(player, ref get, new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, Name, string.Empty));
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && use.To.Count == 1 && use.To[0].Alive)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash && WrappedCard.IsRed(use.Card.Suit) || fcard is Duel)
                {
                    foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                        if (!p.IsKongcheng() && p != use.To[0]) triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && ask_who.Alive && use.To[0].Alive)
            {
                ask_who.SetFlags("slashTargetFix");
                use.To[0].SetFlags("SlashAssignee");
                ask_who.SetFlags("duelTargetFix");
                use.To[0].SetFlags("DuelAssignee");

                WrappedCard used = room.AskForUseCard(ask_who, RespondType.NTTrickSlash, "Slash#Duel:heji", "@heji:" + use.To[0].Name, null, -1, HandlingMethod.MethodUse, false);
                //WrappedCard used = room.AskForUseCard(ask_who, "Slash|.|.|hand#Duel|.|.|hand:heji", "@heji:" + use.To[0].Name, null, -1, HandlingMethod.MethodUse, false);
                if (used == null)
                {
                    ask_who.SetFlags("-slashTargetFix");
                    use.To[0].SetFlags("-SlashAssignee");
                    ask_who.SetFlags("-duelTargetFix");
                    use.To[0].SetFlags("-DuelAssignee");
                }
            }

            return new TriggerStruct();
        }
    }

    public class HejiTag : TargetModSkill
    {
        public HejiTag() : base("#heji", false) { }
        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern)
        {
            if (reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE && to.HasFlag("SlashAssignee")
                //&& (room.GetRoomState().GetCurrentResponseSkill() == "heji" || pattern == "Slash|.|.|hand#Duel|.|.|hand:heji"))
                && (room.GetRoomState().GetCurrentResponseSkill() == "heji" || pattern == "Slash#Duel:heji"))
                return true;

            return false;
        }
    }

    public class Jianyi : TriggerSkill
    {
        public Jianyi() : base("jianyi")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To_place == Place.DiscardPile
                && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && move.From != null)
            {
                List<int> ids = room.ContainsTag(Name) ? (List<int>)room.GetTag(Name) : new List<int>();
                foreach (int id in move.Card_ids)
                {
                    FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(id).Name);
                    if (fcard is EquipCard && !ids.Contains(id))
                        ids.Add(id);
                }
                if (ids.Count > 0) room.SetTag(Name, ids);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && room.ContainsTag(Name))
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p != player) triggers.Add(new TriggerStruct(Name, p));
            }
            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is List<int> cards)
            {
                List<int> ids = new List<int>();
                foreach (int id in cards)
                    if (room.GetCardPlace(id) == Place.DiscardPile)
                        ids.Add(id);

                if (ids.Count > 0)
                {
                    List<int> result = room.NotifyChooseCards(ask_who, ids, Name, 1, 0, "@jianyi", null, info.SkillPosition);
                    if (result.Count > 0)
                    {
                        ask_who.SetMark(Name, result[0]);
                        room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                        room.NotifySkillInvoked(ask_who, Name);
                        return info;
                    }
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List< int> ids = new List<int> { ask_who.GetMark(Name) };
            room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, ask_who.Name, Name, string.Empty));
            return false;
        }
    }

    public class JianyiClear : TriggerSkill
    {
        public JianyiClear() : base("#jianyi")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
        }

        public override int Priority => 0;

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                room.RemoveTag("jianyi");
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class ShangyiCCard : SkillCard
    {
        public static string ClassName = "ShangyiCCard";
        public ShangyiCCard() : base(ClassName) { will_throw = true; }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && !to_select.IsKongcheng() && to_select != Self;
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            if (!card_use.From.IsKongcheng())
                room.ShowAllCards(card_use.From, card_use.To[0], "shangyi_classic", card_use.Card.SkillPosition);
            base.Use(room, card_use);
        }
        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            if (!effect.To.IsKongcheng())
            {
                List<int> blacks = new List<int>();
                foreach (int card_id in effect.To.GetCards("h"))
                {
                    if (RoomLogic.CanGetCard(room, effect.From, effect.To, card_id))
                        blacks.Add(card_id);
                }
                effect.To.SetFlags("shangyi_target");
                int to_discard = room.DoGongxin(effect.From, effect.To, effect.To.GetCards("h"), blacks, "shangyi_classic", "@shangyi_classic:" + effect.To.Name, effect.Card.SkillPosition);
                effect.To.SetFlags("-shangyi_target");

                if (to_discard == -1) return;

                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_EXTRACTION, effect.From.Name, effect.To.Name, "shangyi_classic", null);
                List<int> ints = new List<int> { to_discard };
                room.ObtainCard(effect.From, ref ints, reason, false);
            }
        }
    }
    public class ShangyiClassic : OneCardViewAsSkill
    {
        public ShangyiClassic() : base("shangyi_classic")
        {
            skill_type = SkillType.Attack;
            filter_pattern = "..!";
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(ShangyiCCard.ClassName) && !player.IsKongcheng();
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard c = new WrappedCard(ShangyiCCard.ClassName)
            {
                Skill = Name,
                ShowSkill = Name
            };
            c.AddSubCard(card);
            return c;
        }
    }
    public class DiaoduClassic : TriggerSkill
    {
        public DiaoduClassic() : base("diaodu_classic")
        {
            view_as_skill = new DiaoduClassicVS();
            events.Add(TriggerEvent.EventPhaseStart);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return base.Triggerable(player, room) && player.Phase == PlayerPhase.Start ? new TriggerStruct(Name, player) : new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.AskForUseCard(player, RespondType.Skill, "@@diaodu_classic", "@diaodu_classic", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
            return new TriggerStruct();
        }
    }
    public class DiaoduClassicVS : ZeroCardViewAsSkill
    {
        public DiaoduClassicVS() : base("diaodu_classic")
        {
            response_pattern = "@@diaodu_classic";
        }

        public override WrappedCard ViewAs(Room room, Player player) => new WrappedCard(DiaoduCard.ClassName) { Skill = Name };
    }

    public class DiaoduCard : SkillCard
    {
        public static string ClassName = "DiaoduCard";
        public DiaoduCard() : base(ClassName) { }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (targets.Count == 0)
                return true;
            else if (targets.Count == 1 && to_select != targets[0])
                return room.CheckStageCardMove(targets[0], to_select, StageArea.Equip);
            return false;
        }
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card) => targets.Count == 2;
        public override void Use(Room room, CardUseStruct card_use)
        {
            int card_id = room.AskforMoveStageCard(card_use.From, "diaodu_classic", card_use.To[0], card_use.To[1], StageArea.Equip, false, card_use.Card.SkillPosition);
            Player from = card_use.To[0].GetCards("e").Contains(card_id) ? card_use.To[0] : card_use.To[1];
            Player to = from == card_use.To[0] ? card_use.To[1] : card_use.To[0];
            Place place = room.GetCardPlace(card_id);

            ResultStruct result = card_use.From.Result;
            result.Assist++;
            card_use.From.Result = result;

            room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, from.Name, to.Name);
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_TRANSFER, card_use.From.Name, "diaodu_classic", null)
            {
                Card = room.GetCard(card_id)
            };
            room.MoveCardTo(room.GetCard(card_id), from, to, Place.PlaceEquip, reason);
        }
    }

    public class DiancaiClassic : TriggerSkill
    {
        public DiancaiClassic() : base("diancai_classic")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseStart, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                foreach (Player p in room.GetAlivePlayers())
                    p.SetMark(Name, 0);
            }
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.From.Phase == PlayerPhase.NotActive && move.From_places.Contains(Place.PlaceHand))
                move.From.AddMark(Name, move.Card_ids.Count);
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish)
            {
                List<Player> players = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in players)
                    if (p != player && p.GetMark(Name) > 0) triggers.Add(new TriggerStruct(Name, p));
            }
            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = room.AskForPlayersChosen(ask_who, room.GetAlivePlayers(), Name, 0, ask_who.GetMark(Name), "@diancai_classic:::" + ask_who.GetMark(Name).ToString(),
                true, info.SkillPosition);

            if (targets.Count > 0)
            {
                room.SetTag(Name, targets);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is List<Player> targets)
            {
                room.RemoveTag(Name);
                foreach (Player p in targets)
                    if (p.Alive) room.DrawCards(p, new DrawCardStruct(1, ask_who, Name));
            }

            return false;
        }
    }

    public class Yanji : TriggerSkill
    {
        public Yanji() : base("yanji")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.CardUsed, TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsed && player != null && player.Alive && player.Phase == PlayerPhase.Play && !player.HasFlag(Name) && data is CardUseStruct use
                && !Engine.IsSkillCard(use.Card.Name))
            {
                if (player.HasFlag("yanji_number"))
                {
                    int number = player.GetMark("yanji_number");
                    int count = player.GetMark("yanji_count");
                    if (use.Card.Number > number)
                    {
                        number = use.Card.Number;
                        count++;
                        if (count >= 3)
                        {
                            player.SetFlags(Name);
                            LogMessage log = new LogMessage
                            {
                                Type = "#yanji_success",
                                From = player.Name,
                            };
                            room.SendLog(log);
                        }
                        else
                        {
                            player.SetMark("yanji_number", number);
                            player.SetMark("yanji_count", count);
                        }
                    }
                    else
                    {
                        player.SetMark("yanji_number", 0);
                        player.SetMark("yanji_count", 0);
                    }
                }
                else if (player.HasFlag("yanji_suit"))
                {
                    int suit = player.GetMark("yanji_suit");
                    int count = player.GetMark("yanji_count");
                    if (count > 0)
                    {
                        if ((int)use.Card.Suit == suit)
                        {
                            player.SetFlags(Name);
                            LogMessage log = new LogMessage
                            {
                                Type = "#yanji_success",
                                From = player.Name,
                            };
                            room.SendLog(log);
                        }
                        else
                            player.SetMark("yanji_suit", (int)use.Card.Suit);
                    }
                    else
                    {
                        player.SetMark("yanji_suit", (int)use.Card.Suit);
                        player.SetMark("yanji_count", 1);
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.From.Alive && move.From.Phase == PlayerPhase.Discard
                && move.From.HasFlag("yanji_discard") && move.From_places.Contains(Place.PlaceHand) && move.Reason.Reason == MoveReason.S_REASON_RULEDISCARD && !move.From.HasFlag(Name))
            {
                bool check = true;
                List<WrappedCard.CardSuit> suits = new List<WrappedCard.CardSuit>();
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    if (move.From_places[i] == Place.PlaceHand)
                    {
                        WrappedCard card = room.GetCard(move.Card_ids[i]);
                        if (!suits.Contains(card.Suit))
                            suits.Add(card.Suit);
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                }
                if (check && suits.Count < 2) check = false;
                if (check)
                {
                    move.From.SetFlags(Name);
                    LogMessage log = new LogMessage
                    {
                        Type = "#yanji_success",
                        From = move.From.Name,
                    };
                    room.SendLog(log);
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Discard && player.Alive && player.HasFlag(Name))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging)
                return info;
            else if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                string choice = room.AskForChoice(player, Name, "number+suit+discard+cancel", null, null, info.SkillPosition);
                if (choice != "cancel")
                {
                    player.SetTag(Name, choice);
                    room.NotifySkillInvoked(player, Name);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                    return info;
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging)
            {
                List<string> choices = new List<string> { "draw" };
                if (player.IsWounded()) choices.Add("recover");
                string choice = room.AskForChoice(player, Name, string.Join("+", choices), null, null, info.SkillPosition);

                room.NotifySkillInvoked(player, Name);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);

                if (choice == "draw")
                    room.DrawCards(player, 2, Name);
                else
                    room.Recover(player, 2);
            }
            else if (player.GetTag(Name) is string choice)
            {
                player.RemoveTag(Name);
                LogMessage log = new LogMessage
                {
                    From = player.Name
                };
                switch (choice)
                {
                    case "number":
                        log.Type = "#yanji_number";
                        player.SetFlags("yanji_number");
                        player.SetMark("yanji_number", 0);
                        player.SetMark("yanji_count", 0);
                        break;
                    case "suit":
                        log.Type = "#yanji_suit";
                        player.SetFlags("yanji_suit");
                        player.SetMark("yanji_count", 0);
                        break;
                    case "discard":
                        log.Type = "#yanji_discard";
                        player.SetFlags("yanji_discard");
                        break;
                }
                room.SendLog(log);
            }

            return false;
        }
    }
}