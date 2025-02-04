﻿using CommonClass;
using CommonClass.Game;
using CommonClassLibrary;
using SanguoshaServer.Game;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static CommonClass.Game.CardUseStruct;
using static CommonClass.Game.Player;
using static SanguoshaServer.Package.FunctionCard;

namespace SanguoshaServer.Package
{
    public class ClassicSpecial : GeneralPackage
    {
        public ClassicSpecial() : base("ClassicSpecial")
        {
            skills = new List<Skill>
            {
                new Shefu(),
                new ShefuClear(),
                new ShefuInvalid(),
                new Benyu(),
                new Mashu("guanyu_sp"),
                new Nuzhan(),
                new NuzhanTM(),
                new Danji(),
                new Yuanhu(),
                new Juezhu(),
                new Bifa(),
                new Songci(),
                new Xianfu(),
                new Chouce(),
                new Chenqing(),
                new Moshi(),
                new Shanjia(),
                new ShanjiaTar(),
                new Qizhi(),
                new Jinqu(),
                new Gushe(),
                new Jici(),
                new Kangkai(),
                new XiaoguoJX(),
                new Zhenwei(),
                new Kunfen(),
                new Fengliang(),
                new Weikui(),
                new WeikuiDistance(),
                new Lizhan(),
                new Gongao(),
                new Juyi(),
                new Weizhong(),
                new Junbing(),
                new Quji(),
                new Tuifeng(),
                new TuifengGet(),
                new TuifengTar(),
                new Zhenlue(),
                new ZhenluePro(),
                new Jianshu(),
                new Yongdi(),
                new Lingren(),
                new Fujian(),
                new Juesi(),
                new Mashu("pangde_sp"),
                new Qingzhong(),
                new QingzhongExchange(),
                new Weijing(),
                new Xingzhao(),
                new XingzhaoVH(),
                new Tuogu(),
                new Shanzhuan(),
                new JixianZL(),
                new Zengou(),
                new Changji(),
                new Yuanzhi(),
                new Liejie(),
                new KanpoDZ(),
                new Genzhan(),
                new GenzhanTar(),
                new WangxiJx(),

                new Mizhao(),
                new Tianming(),
                new YongsiJX(),
                new YongsiMax(),
                new WeidiJX(),
                new WeidiRemove(),
                new Lihun(),
                new Chongzhen(),
                new Jieyuan(),
                new Fenxin(),
                new Zongkui(),
                new Guqu(),
                new Baijia(),
                new Canshi(),
                new Bingzhao(),
                new Qiaomeng(),
                new Yicong(),
                new YicongDis(),
                new Jiqiao(),
                new Linglong(),
                new LinglongVH(),
                new LinglongTar(),
                new LinglongMax(),
                new LinglongFix(),
                new Zhuiji(),
                new ZhuijiDistance(),
                new Shichou(),
                new Fuqi(),
                new Jiaozi(),
                new Moukui(),
                new MoukuiDis(),
                new Yishe(),
                new Bushi(),
                new Midao(),
                new Rangshang(),
                new Hanyong(),
                new Xionghuo(),
                new XionghuoTri(),
                new XionghuoMax(),
                new XionghuoPro(),
                new Shajue(),
                new Yisuan(),
                new Langxi(),
                new Luanzhan(),
                new Falu(),
                new FaluClear(),
                new Zhenyi(),
                new Dianhua(),
                new Biluan(),
                new BiluanDistance(),
                new Lixia(),
                new LixiaDistance(),
                new HuojiSM(),
                new LianhuanSM(),
                new YeyanSM(),
                new Jianjie(),
                new JianjieMove(),
                new Chenghao(),
                new Yinshi(),
                new Lueming(),
                new Tunjun(),
                new Xingluan(),
                new Sidao(),
                new SidaoRecord(),
                new Tanbei(),
                new TanbeiPro(),
                new TanbeiTar(),
                new Wenji(),
                new WenjiEffect(),
                new Tunjiang(),
                new Zhidao(),
                new ZhidaoPro(),
                new JiliYbh(),
                new Lianji(),
                new Moucheng(),
                new Jingong(),
                new Zhoufu(),
                new ZhoufuEffect(),
                new Yingbing(),
                new Lianzhu(),
                new Xiahui(),
                new XiahuiMax(),
                new Neifa(),
                new NeifaTar(),
                new NeifaPro(),
                new ZhenduJX(),
                new QiluanJX(),
                new QiluanJXClear(),
                new BeizhanClassic(),
                new BeizhanCProhibit(),
                new GangzhiClassic(),
                new Mubing(),
                new Zhiqu(),
                new ZhiquSecond(),
                new Diaoling(),
                new Liushi(),
                new LiushiMax(),
                new LiushiTar(),
                new Zhanwan(),
                new Wangong(),
                new WangongTar(),
                new Fengzi(),
                new Jizhan(),
                new Fusong(),
                new Zhuangshu(),
                new Chuiti(),
                new ChuitiClear(),
                new ZhouxuanZH(),
                new ZhouxuanZhEffect(),
                new Juguan(),
                new JuguanDraw(),
                new FengjiSP(),
                new FengjiTar(),
                new Huamu(),
                new HuamuRecord(),
                new Qianmeng(),
                new Liangyuan(),
                new Jisi(),

                new Shenxian(),
                new Qiangwu(),
                new QiangwuTar(),
                new Xueji(),
                new Huxiao(),
                new HuxiaoTar(),
                new Wuji(),
                new Liangzhu(),
                new Fanxiang(),
                new Fengpo(),
                new Mashu("mayunlu"),
                new Zhengnan(),
                new Xiefang(),
                new Wuniang(),
                new Xushen(),
                new Zhennan(),
                new Yuhua(),
                new YuhuaMax(),
                new Qirang(),
                new Fanghun(),
                new FanghunDetach(),
                new Fuhan(),
                new Zishu(),
                new Yingyuan(),
                new Ziyuan(),
                new Jujia(),
                new JujiaMax(),
                new ZhuhaiJX(),
                new ZhuhaiJXTag(),
                new Qianxin(),
                new Jianyan(),
                new Qianya(),
                new Shuimeng(),
                new Fuman(),
                new FumanEffect(),
                new Bingzheng(),
                new Sheyan(),
                new Baobian(),
                new Dianhu(),
                new Jianji(),
                new Yuxu(),
                new YuxuDiscard(),
                new Shijian(),
                new Youlong(),
                new Luanfeng(),
                new Xiuhao(),
                new Sujian(),
                new Juanxia(),
                new JuanxiaEffect(),
                new Dingcuo(),
                new Qiongshou(),
                new QiongshouMax(),
                new Fenrui(),
                new Xiaosi(),
                new XiaosiTag(),
                new Chenglie(),
                new ChenglieEffect(),
                new ChenglieTar(),
                new Mashu("macheng"),

                new Hongyuan(),
                new Huanshi(),
                new Mingzhe(),
                new Aocai(),
                new Duwu(),
                new Hongde(),
                new Dingpan(),
                new Xingwu(),
                new XingwuClear(),
                new Luoyan(),
                new Meibu(),
                new Mumu(),
                new MumuTar(),
                new Zhixi(),
                new Lianpian(),
                new LianpianRecord(),
                new Yinbing(),
                new YinbingDamage(),
                new Juedi(),
                new CanshiSH(),
                new CanshiDiscard(),
                new Chouhai(),
                new Guiming(),
                new Xiashu(),
                new Kuanshi(),
                new KuanshiIm(),
                new Qizhou(),
                new QizhouVH(),
                new Mashu("heqi"),
                new Yingzi("heqi", false),
                new YingziMax("heqi"),
                new Shanxi(),
                new Bizheng(),
                new Yidian(),
                new Weiyi(),
                new Jinzhi(),
                new DuanbingJX(),
                new FenxunJX(),
                new FenxunJXEffect(),
                new Lanjiang(),
                new Aichen(),
                new Luochong(),
                new Qingliang(),
                new Qiaoli(),
                new QiaoliEffect(),
            };

            skill_cards = new List<FunctionCard>
            {
                new ShefuCard(),
                //new BenyuCard(),
                new BifaCard(),
                new SongciCard(),
                new QiangwuCard(),
                new XuejiCard(),
                new AocaiCard(),
                new DuwuCard(),
                new MizhaoCard(),
                new WeidiJXCard(),
                new LihunCard(),
                new FanghunCard(),
                new DingpanCard(),
                new GusheCard(),
                new WeikuiCard(),
                new ZiyuanCard(),
                new XionghuoCard(),
                new QujiCard(),
                new JianshuCard(),
                new ZhenyiCard(),
                new JianyanCard(),
                new QianyaCard(),
                new FumanCard(),
                new JuesiCard(),
                new YeyanSMCard(),
                new JianjieCard(),
                new LuemingCard(),
                new TunjunCard(),
                new SidaoCard(),
                new TanbeiCard(),
                new WeijingCard(),
                new ShanxiCard(),
                new LianjiCard(),
                new JianjiCard(),
                new ZhoufuCard(),
                new LianzhuCard(),
                new LiushiCard(),
                new YoulongCard(),
                new JinzhiCard(),
                new FenxunJXCard(),
                new XingwuCard(),
                new SujianCard(),
                new ChuitiCard(),
                new YuanhuCard(),
                new AichenCard(),
                new XiaosiCard(),
                new ChenglieCard(),
            };

            related_skills = new Dictionary<string, List<string>>
            {
                { "shefu", new List<string>{ "#shefu-clear", "#shefu-invalid"} },
                { "nuzhan", new List<string>{ "#nuzhan" } },
                { "qiangwu", new List<string>{ "#qiangwu-tar" } },
                { "huxiao", new List<string>{ "#huxiao-tar" } },
                { "yongsi_jx", new List<string>{ "#yongsi-max" } },
                { "weidi_jx", new List<string>{ "#weidi-remove" } },
                { "shanjia", new List<string>{ "#shanjia" } },
                { "fanghun", new List<string>{ "#fanghun-clear" } },
                { "yuhua", new List<string>{ "#yuhua-max" } },
                { "linglong", new List<string>{ "#linglong-max", "#linglong-tar", "#linglongvh", "#linglong-fix" } },
                { "xingwu", new List<string>{ "#xingwu-clear" } },
                { "yicong", new List<string>{ "#yicong" } },
                { "weikui", new List<string>{ "#weikui-dis" } },
                //{ "meibu", new List<string>{ "#meibu-dis" } },
                { "mumu", new List<string>{ "#mumu" } },
                { "moukui", new List<string>{ "#moukui" } },
                { "jujia", new List<string>{ "#jujia-max" } },
                { "xionghuo", new List<string>{ "#xionghuo", "#xionghuo-max", "#xionghuo-prohibit" } },
                { "tuifeng", new List<string>{ "#tuifeng", "#tuifeng-tar" } },
                { "falu", new List<string>{ "#falu" } },
                { "zhuhai_jx", new List<string>{ "#zhuhai_jx" } },
                { "biluan", new List<string>{ "#biluan" } },
                { "lixia", new List<string>{ "#lixia" } },
                { "lianpian", new List<string>{ "#lianpian" } },
                { "yinbing", new List<string>{ "#yinbing" } },
                { "jianjie", new List<string>{ "#jianjie" } },
                { "canshi_sh", new List<string>{ "#canshi-discard" } },
                { "kuanshi", new List<string>{ "#kuanshi" } },
                { "sidao", new List<string>{ "#sidao" } },
                { "tanbei", new List<string>{ "#tanbei-target", "#tanbei-prohibit" } },
                { "qingzhong", new List<string>{ "#qingzhong" } },
                { "qizhou", new List<string>{ "#qizhou" } },
                { "zhidao", new List<string>{ "#zhidao" } },
                { "xingzhao", new List<string>{ "#xingzhao" } },
                { "zhoufu", new List<string>{ "#zhoufu" } },
                { "xiahui", new List<string>{ "#xiahui-max" } },
                { "wenji", new List<string>{ "#wenji" } },
                { "zhenlue", new List<string>{ "#zhenlue" } },
                { "yuxu", new List<string>{ "#yuxu" } },
                { "neifa", new List<string>{ "#neifa-tar", "#neifa-pro" } },
                { "qiluan_jx", new List<string>{ "#qiluan_jx" } },
                { "zhiqu", new List<string>{ "#zhiqu" } },
                { "liushi", new List<string>{ "#liushi", "#liushi-max" } },
                { "fenxun_jx", new List<string>{ "#fenxun_jx" } },
                { "wangong", new List<string>{ "#wangong" } },
                { "juanxia", new List<string>{ "#juanxia" } },
                { "chuiti", new List<string>{ "#chuiti" } },
                { "zhouxuan_zh", new List<string>{ "#zhouxuan_zh" } },
                { "juguan", new List<string>{ "#juguan" } },
                { "fengji_sp", new List<string>{ "#fengji_sp" } },
                { "zhuiji", new List<string>{ "#zhuiji" } },
                { "fuman", new List<string>{ "#fuman" } },
                { "huamu", new List<string>{ "#huamu" } },
                { "genzhan", new List<string>{ "#genzhan" } },
                { "qiongshou", new List<string>{ "#qiongshou" } },
                { "qiaoli", new List<string>{ "#qiaoli" } },
                { "beizhan_classic", new List<string>{ "#beizhan-c-prohibit" } },
                { "xiaosi", new List<string>{ "#xiaosi-tar" } },
                { "chenglie", new List<string>{ "#chenglie-effect", "#chenglie-tar" } },
            };
        }
    }

    public class Shefu : TriggerSkill
    {
        public Shefu() : base("shefu")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.EventPhaseStart, TriggerEvent.JinkEffect, TriggerEvent.NullificationEffect };
            view_as_skill = new ShefuVS();
            skill_type = SkillType.Wizzard;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == Player.PlayerPhase.Finish && base.Triggerable(player, room)
                && !player.IsKongcheng() && ShefuVS.GuhuoCards(room, player).Count > 0)
            {
                triggers.Add(new TriggerStruct(Name, player));
            }
            else if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && use.Card != null && use.To.Count > 0 && use.IsHandcard)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is SkillCard) return triggers;

                List<Player> chengyus = RoomLogic.FindPlayersBySkillName(room, Name);
                string card_name = fcard.Name;
                if (fcard is Slash) card_name = Slash.ClassName;
                foreach (Player p in chengyus)
                {
                    if (p != player && p.Phase == Player.PlayerPhase.NotActive && p.ContainsTag(string.Format("shefu_{0}", card_name))
                        && p.GetTag(string.Format("shefu_{0}", card_name)) is int id && p.GetPile("ambush").Contains(id))
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }
            else if (triggerEvent == TriggerEvent.JinkEffect && data is CardResponseStruct resp && resp.Handcard)
            {
                List<Player> chengyus = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in chengyus)
                {
                    if (p != player && p.Phase == Player.PlayerPhase.NotActive && p.ContainsTag("shefu_Jink")
                        && p.GetTag("shefu_Jink") is int id && p.GetPile("ambush").Contains(id))
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }
            else if (triggerEvent == TriggerEvent.NullificationEffect && data is CardUseStruct nulli_use && nulli_use.IsHandcard)
            {
                List<Player> chengyus = RoomLogic.FindPlayersBySkillName(room, Name);
                string str = string.Format("shefu_{0}", nulli_use.Card.Name);
                foreach (Player p in chengyus)
                {
                    if (p != player && p.Phase == Player.PlayerPhase.NotActive && p.ContainsTag(str)
                        && p.GetTag(str) is int id && p.GetPile("ambush").Contains(id))
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player p, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
                room.AskForUseCard(player, RespondType.Skill, "@@shefu", "@shefu", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
            else
            {
                string card_name = string.Empty;
                if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use)
                {
                    if (use.To.Count == 0) return new TriggerStruct();
                    FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                    card_name = fcard.Name;
                    if (fcard is Slash) card_name = Slash.ClassName;
                }
                else if (triggerEvent == TriggerEvent.JinkEffect)
                    card_name = Jink.ClassName;
                else if (triggerEvent == TriggerEvent.NullificationEffect && data is CardUseStruct nulli_use)
                    card_name = nulli_use.Card.Name;

                string key = string.Format("shefu_{0}", card_name);
                if (p.ContainsTag(key) && p.GetTag(key) is int id && p.GetPile("ambush").Contains(id))
                {
                    room.SetTag("shefu_data", data);
                    List<int> ids = room.AskForExchange(p, Name, 1, 0, string.Format("@shefu-cancel:::{0}", card_name),
                        "ambush", string.Format("{0}|.|.|ambush", id.ToString()), info.SkillPosition);
                    room.RemoveTag("shefu_data");
                    if (ids.Count == 1)
                    {
                        p.RemoveTag(key);
                        GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, p, Name, info.SkillPosition);
                        CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_REMOVE_FROM_PILE, p.Name, string.Empty, Name, string.Empty)
                        {
                            General = gsk
                        };
                        room.MoveCardTo(room.GetCard(id), p, null, Place.DiscardPile, string.Empty, reason, true);

                        room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                        return info;
                    }
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player == room.Current) player.SetFlags(Name);
            if (data is CardUseStruct use)
            {
                LogMessage log = new LogMessage
                {
                    Type = "#ShefuEffect",
                    From = ask_who.Name,
                    To = new List<string> { player.Name },
                    Arg = Name,
                    Arg2 = use.Card.Name
                };
                room.SendLog(log);

                if (use.To.Count > 0)
                {
                    List<Player> targets = new List<Player>(use.To);
                    foreach (Player p in targets)
                        room.CancelTarget(ref use, p);

                    data = use;
                }
                else if (triggerEvent == TriggerEvent.NullificationEffect)
                    return true;
            }
            else
            {
                LogMessage log = new LogMessage
                {
                    Type = "#ShefuEffect",
                    From = ask_who.Name,
                    To = new List<string> { player.Name },
                    Arg = Name,
                    Arg2 = Jink.ClassName
                };
                room.SendLog(log);
                return true;
            }

            return false;
        }
    }

    public class ShefuClear : DetachEffectSkill
    {
        public ShefuClear() : base("shefu", "ambush") { }
    }

    public class ShefuVS : ViewAsSkill
    {
        public ShefuVS() : base("shefu")
        {
            response_pattern = "@@shefu";
        }

        public override GuhuoType GetGuhuoType() => GuhuoType.PopUpBox;

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => selected.Count == 0;
        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            foreach (string name in GuhuoCards(room, player))
            {
                FunctionCard fcard = Engine.GetFunctionCard(name);
                if (fcard is Slash && name != Slash.ClassName) continue;
                if (player.ContainsTag(string.Format("shefu_{0}", name))) continue;

                WrappedCard card = new WrappedCard(name);
                card.AddSubCards(cards);
                result.Add(card);
            }

            return result;
        }

        public static List<string> GuhuoCards(Room room, Player player)
        {
            List<string> guhuos = GetGuhuoCards(room, "btd");
            List<string> result = new List<string>();
            foreach (string name in guhuos)
            {
                FunctionCard fcard = Engine.GetFunctionCard(name);
                if (fcard is Slash && name != Slash.ClassName) continue;
                if (fcard is Nullification && name != Nullification.ClassName) continue;
                if (player.ContainsTag(string.Format("shefu_{0}", name))) continue;

                result.Add(name);
            }

            return result;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].SubCards.Count == 1)
            {
                WrappedCard shefu = new WrappedCard(ShefuCard.ClassName) { Skill = Name, UserString = cards[0].Name };
                shefu.AddSubCards(cards);
                return shefu;
            }

            return null;
        }
    }

    public class ShefuInvalid : InvalidSkill
    {
        public ShefuInvalid() : base("#shefu-invalid") { }

        public override bool Invalid(Room room, Player player, string skill)
        {
            Skill s = Engine.GetSkill(skill);
            if (s == null || s.SkillFrequency == Frequency.Compulsory || s.Attached_lord_skill) return false;
            if (player.HasEquip(skill)) return false;
            return player.HasFlag("shefu");
        }
    }

    public class ShefuCard : SkillCard
    {
        public static string ClassName = "ShefuCard";
        public ShefuCard() : base(ClassName)
        {
            target_fixed = true;
            will_throw = false;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, card_use.From, "shefu", card_use.Card.SkillPosition);
            room.BroadcastSkillInvoke("shefu", "male", 1, gsk.General, gsk.SkinId);

            int id = card_use.Card.GetEffectiveId();
            string card_name = card_use.Card.UserString;
            room.AddToPile(card_use.From, "ambush", id, false);
            card_use.From.SetTag(string.Format("shefu_{0}", card_name), id);

            LogMessage log = new LogMessage
            {
                Type = "$ShefuRecord",
                From = card_use.From.Name,
                Card_str = id.ToString(),
                Arg = card_name
            };
            room.SendLog(log, card_use.From);
        }
    }
    public class Benyu : MasochismSkill
    {
        public Benyu() : base("benyu")
        {
            //view_as_skill = new BenyuVS();
            skill_type = SkillType.Defense;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DamageStruct damage && damage.From != null && damage.From.Alive)
            {
                if (damage.From.HandcardNum > player.HandcardNum && player.HandcardNum < 5)
                    return new TriggerStruct(Name, player);
                else if (player.GetCardCount(true) > damage.From.HandcardNum)
                {
                    int count = 0;
                    foreach (int id in player.GetCards("he"))
                        if (RoomLogic.CanDiscard(room, player, player, id)) count++;
                    if (count > damage.From.HandcardNum)
                        return new TriggerStruct(Name, player);
                }
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                bool invoke = false;
                if (damage.From.HandcardNum > player.HandcardNum && player.HandcardNum < 5)
                {
                    if (room.AskForSkillInvoke(player, Name, "@benyu-draw", info.SkillPosition))
                    {
                        room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                        player.SetTag("benyu_type", true);
                        invoke = true;
                    }
                }
                else if (player.GetCardCount(true) > damage.From.HandcardNum)
                {
                    int count = 0;
                    foreach (int id in player.GetCards("he"))
                        if (RoomLogic.CanDiscard(room, player, player, id)) count++;
                    if (count > damage.From.HandcardNum)
                    {
                        room.SetTag(Name, data);
                        invoke = room.AskForDiscard(player, Name, damage.From.HandcardNum + 1, damage.From.HandcardNum + 1, true, true, string.Format("@benyu::{0}:{1}", damage.From.Name, damage.From.HandcardNum + 1), true, info.SkillPosition);
                        room.RemoveTag(Name);

                        if (invoke)
                        {
                            room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                            player.SetTag("benyu_type", false);
                        }
                    }
                }
                if (invoke) return info;
            }

            return new TriggerStruct();
        }
        public override void OnDamaged(Room room, Player target, DamageStruct damage, TriggerStruct info)
        {
            bool type = (bool)target.GetTag("benyu_type");
            target.RemoveTag("benyu_type");
            if (type)
            {
                int count = Math.Min(5 - target.HandcardNum, damage.From.HandcardNum - target.HandcardNum);
                if (count > 0)
                    room.DrawCards(target, count, Name);
            }
            else if (damage.From.Alive)
                room.Damage(new DamageStruct(Name, target, damage.From));
        }
    }

    //sp关羽
    public class Danji : PhaseChangeSkill
    {
        public Danji() : base("danji")
        {
            frequency = Frequency.Wake;
            skill_type = SkillType.Attack;
        }
        public override bool Triggerable(Player player, Room room)
        {
            foreach (Player p in room.GetAlivePlayers())
                if (p.GetRoleEnum() == PlayerRole.Lord && p.General1.Contains("liubei")) return false;

            return base.Triggerable(player, room) && player.Phase == PlayerPhase.Start
                    && player.HandcardNum > player.Hp && player.GetMark(Name) == 0;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SetPlayerMark(player, Name, 1);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            return info;
        }
        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            room.LoseMaxHp(player);
            List<string> skills = new List<string>();
            if (info.SkillPosition == "head")
            {
                skills.Add("mashu_guanyu_sp");
                skills.Add("nuzhan");
            }
            else
            {
                skills.Add("mashu_guanyu_sp!");
                skills.Add("nuzhan!");
            }
            room.HandleAcquireDetachSkills(player, skills);

            return false;
        }
    }

    public class Nuzhan : TriggerSkill
    {
        public Nuzhan() : base("nuzhan")
        {
            events.Add(TriggerEvent.ConfirmDamage);
            frequency = Frequency.Compulsory;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DamageStruct damage && damage.Card != null && !damage.Chain && !damage.Transfer && damage.ByUser)
            {
                FunctionCard fcard = Engine.GetFunctionCard(damage.Card.Name);
                if (fcard is Slash && damage.Card.IsVirtualCard() && damage.Card.SubCards.Count == 1)
                {
                    if (Engine.GetFunctionCard(room.GetCard(damage.Card.GetEffectiveId()).Name) is EquipCard)
                        return new TriggerStruct(Name, player);
                }
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
            room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
            DamageStruct damage = (DamageStruct)data;
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

            return false;
        }
    }

    public class NuzhanTM : TargetModSkill
    {
        public NuzhanTM() : base("#nuzhan")
        {
        }

        public override int GetResidueNum(Room room, Player from, WrappedCard card)
        {
            if (RoomLogic.PlayerHasSkill(room, from, "nuzhan") && Engine.MatchExpPattern(room, pattern, from, card)
           && card.IsVirtualCard() && card.SubCards.Count == 1)
            {
                if (Engine.GetFunctionCard(room.GetCard(card.GetEffectiveId()).Name) is TrickCard)
                    return 999;
            }

            return 0;
        }
        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ModType type, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            if (type == ModType.History)
                index = 1;
            else
                index = -1;
        }
    }


    public class YuanhuViewAsSkill : OneCardViewAsSkill
    {
        public YuanhuViewAsSkill() : base("yuanhu")
        {
            filter_pattern = "EquipCard";
            response_pattern = "@@yuanhu";
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard first = new WrappedCard(YuanhuCard.ClassName) { Skill = Name, Mute = true };
            first.AddSubCard(card);
            return first;
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(YuanhuCard.ClassName);
    }

    public class YuanhuCard : SkillCard
    {
        public static string ClassName = "YuanhuCard";
        public YuanhuCard() : base(ClassName)
        {
            will_throw = false;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (targets.Count > 0) return false;

            WrappedCard ecard = room.GetCard(card.SubCards[0]);
            EquipCard equip = (EquipCard)Engine.GetFunctionCard(ecard.Name);
            int equip_index = (int)equip.EquipLocation();
            return to_select.GetEquip(equip_index) < 0 && RoomLogic.CanPutEquip(to_select, ecard);
        }
        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            ResultStruct result = effect.From.Result;
            result.Assist += 2;
            effect.From.Result = result;

            WrappedCard ecard = room.GetCard(effect.Card.SubCards[0]);
            FunctionCard fcard = Engine.GetFunctionCard(ecard.Name);
            
            room.MoveCardTo(ecard, effect.From, effect.To, Place.PlaceEquip,
                new CardMoveReason(MoveReason.S_REASON_PUT, effect.From.Name, effect.Card.Skill, null));

            LogMessage log = new LogMessage
            {
                Type = "$ZhijianEquip",
                From = effect.To.Name,
                Card_str = ecard.Id.ToString()
            };
            room.SendLog(log);

            if (fcard != null && effect.From.Alive)
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, effect.From, "yuanhu", effect.Card.SkillPosition);
                if (fcard is Weapon && effect.To.Alive)
                {
                    room.BroadcastSkillInvoke("yuanhu", "male", 1, gsk.General, gsk.SkinId);
                    List<Player> targets = new List<Player>();
                    foreach (Player p in room.GetAlivePlayers())
                    {
                        if (RoomLogic.DistanceTo(room, effect.To, p) == 1 && RoomLogic.CanDiscard(room, effect.From, p, "hej"))
                            targets.Add(p);
                    }
                    if (targets.Count > 0)
                    {
                        Player to_dismantle = room.AskForPlayerChosen(effect.From, targets, "yuanhu", "@huyuan-discard:" + effect.To.Name, true, false, effect.Card.SkillPosition);
                        if (to_dismantle != null)
                        {
                            int card_id = room.AskForCardChosen(effect.From, to_dismantle, "hej", "yuanhu", false, FunctionCard.HandlingMethod.MethodDiscard);
                            room.ThrowCard(card_id, to_dismantle, effect.From);
                        }
                    }
                }
                else if (fcard is Armor)
                {
                    room.BroadcastSkillInvoke("yuanhu", "male", 2, gsk.General, gsk.SkinId);
                    room.DrawCards(effect.To, new DrawCardStruct(1, effect.From, "yuanhu"));
                }
                else if (fcard is Horse && effect.To.IsWounded())
                {
                    room.BroadcastSkillInvoke("yuanhu", "male", 3, gsk.General, gsk.SkinId);
                    RecoverStruct recover = new RecoverStruct
                    {
                        Recover = 1,
                        Who = effect.From
                    };
                    room.Recover(effect.To, recover, true);
                }

                if (effect.From.Alive && effect.To.Alive && (effect.To.Hp <= effect.From.Hp || effect.To.HandcardNum <= effect.From.HandcardNum))
                    room.DrawCards(effect.From, 1, "yuanhu");
            }
        }
    }

    public class Yuanhu : PhaseChangeSkill
    {
        public Yuanhu() : base("yuanhu")
        {
            view_as_skill = new YuanhuViewAsSkill();
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish && !player.IsNude()
                ? new TriggerStruct(Name, player)
                : new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            player.RemoveTag("huyuan_equip");
            player.RemoveTag("huyuan_target");
            WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@yuanhu", "@huyuan-equip", null, -1, HandlingMethod.MethodNone, true, info.SkillPosition);
            return new TriggerStruct();
        }
        public override bool OnPhaseChange(Room room, Player caohong, TriggerStruct info) => false;
    }

    public class Juezhu : TriggerSkill
    {
        public Juezhu() : base("juezhu")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.Death };
            skill_type = SkillType.Defense;
            limit_mark = "@juezhu";
            frequency = Frequency.Limited;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Death && player.ContainsTag(Name) && player.GetTag(Name) is KeyValuePair<string, int> keys && keys.Value > 1)
            {
                player.RemoveTag(Name);
                Player target = room.FindPlayer(keys.Key);
                if (target != null && target.EquipIsBaned(keys.Value)) room.RecoverEquip(target, keys.Value);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Start && base.Triggerable(player, room) && player.GetMark(limit_mark) > 0)
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetAlivePlayers())
                if (!p.ContainsTag(Name)) targets.Add(p);

            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@juezhu-tareget", true, true, info.SkillPosition);
                if (target != null)
                {
                    room.SetTag(Name, target);
                    room.RemovePlayerMark(player, limit_mark);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.DoSuperLightbox(player, info.SkillPosition, Name);
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
                int index = -1;
                List<string> choices = new List<string>();
                if (!player.EquipIsBaned(2))
                    choices.Add("DefensiveHorse");
                if (!player.EquipIsBaned(3))
                    choices.Add("OffensiveHorse");
                if (choices.Count > 0)
                {
                    string choice = room.AskForChoice(player, Name, string.Join("+", choices), new List<string> { "@juezhu-bolish" }, null, info.SkillPosition);
                    if (choice == "DefensiveHorse")
                    {
                        room.AbolisheEquip(player, 2, Name);
                        index = 2;
                    }
                    else
                    {
                        room.AbolisheEquip(player, 3, Name);
                        index = 3;
                    }
                }
                if (target.Alive)
                {
                    KeyValuePair<string, int> keys = new KeyValuePair<string, int>(player.Name, index);
                    target.SetTag(Name, keys);
                    room.AbolishJudgingArea(target, Name);
                    room.HandleAcquireDetachSkills(target, "feiying", true);
                }
            }

            return false;
        }
    }

    //陈琳
    public class BifaCard : SkillCard
    {
        public static string ClassName = "BifaCard";
        public BifaCard() : base(ClassName)
        {
            will_throw = false;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select.GetPile("bifa").Count == 0 && to_select != Self;
        }
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            return targets.Count == 1 && card.SubCards.Count == 1;
        }
        public override void OnUse(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0];
            card_use.From.SetTag("bifa_target", target.Name);
            card_use.From.SetMark("bifa", card_use.Card.GetEffectiveId());
        }
    }
    public class BifaViewAsSkill : OneCardViewAsSkill
    {
        public BifaViewAsSkill() : base("bifa")
        {
            filter_pattern = ".";
            response_pattern = "@@bifa";
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard bf = new WrappedCard(BifaCard.ClassName) { Skill = Name };
            bf.AddSubCard(card);
            return bf;
        }
    }

    public class Bifa : TriggerSkill
    {
        public Bifa() : base("bifa")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            view_as_skill = new BifaViewAsSkill();
            skill_type = SkillType.Attack;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (player.Phase == Player.PlayerPhase.RoundStart && player.GetPile("bifa").Count > 0)
            {
                int card_id = player.GetPile("bifa")[0];
                Player chenlin = room.FindPlayer(player.GetTag(string.Format("BifaSource{0}", card_id)).ToString());
                player.RemoveTag(string.Format("BifaSource{0}", card_id));
                List<int> ids = new List<int>
                {
                    card_id
                };

                LogMessage log = new LogMessage
                {
                    Type = "$BifaView",
                    From = player.Name,
                    Card_str = card_id.ToString(),
                    Arg = Name
                };
                room.SendLog(log, player);

                room.FillAG(Name, ids, player);
                FunctionCard cd = Engine.GetFunctionCard(room.GetCard(card_id).Name);
                string pattern = string.Empty;
                if (cd is BasicCard)
                    pattern = "BasicCard";
                else if (cd is TrickCard)
                    pattern = "TrickCard";
                else if (cd is EquipCard)
                    pattern = "EquipCard";
                pattern += "|.|.|hand";
                List<int> to_give = new List<int>();
                if (!player.IsKongcheng() && chenlin != null && chenlin.Alive)
                {
                    to_give = room.AskForExchange(player, Name, 1, 0, "@bifa-give:" + chenlin.Name, string.Empty, pattern, string.Empty);
                    if (to_give.Count == 1)
                    {
                        CardMoveReason reasonG = new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, chenlin.Name, Name, string.Empty);
                        room.ObtainCard(chenlin, ref to_give, reasonG, false);
                        CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_EXCHANGE_FROM_PILE, player.Name, Name, string.Empty);
                        List<int> card_ids = new List<int> { card_id };
                        room.ObtainCard(player, ref card_ids, reason, false);
                    }
                }

                room.ClearAG(player);
                if (to_give.Count == 0)
                {
                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_REMOVE_FROM_PILE, string.Empty, Name, string.Empty);
                    List<int> dis = player.GetPile("bifa");
                    room.ThrowCard(ref dis, reason, null);
                    room.LoseHp(player);
                }
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@bifa", "@bifa-remove", null, -1, HandlingMethod.MethodNone, true, info.SkillPosition);
            if (card != null)
            {
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.ContainsTag("bifa_target"))
            {
                Player target = room.FindPlayer(player.GetTag("bifa_target").ToString());
                player.RemoveTag("bifa_target");
                if (target != null && target.Alive)
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                    int id = player.GetMark(Name);
                    target.SetTag(string.Format("BifaSource{0}", id), player.Name);
                    room.AddToPile(target, Name, id, false);
                }
            }

            return false;
        }
    }

    public class SongciCard : SkillCard
    {
        public static string ClassName = "SongciCard";
        public SongciCard() : base(ClassName)
        {
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select.GetMark(string.Format("songci_{0}", Self.Name)) == 0;
        }
        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            int handcard_num = effect.To.HandcardNum;
            int hp = effect.To.Hp;
            room.SetPlayerMark(effect.To, "@songci", 1);
            effect.To.SetMark(string.Format("songci_{0}", effect.From.Name), 1);
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, effect.From, "songci", effect.Card.SkillPosition);
            if (handcard_num > hp)
            {
                room.BroadcastSkillInvoke("songci", "male", 2, gsk.General, gsk.SkinId);
                room.AskForDiscard(effect.To, "songci", 2, 2, false, true);
            }
            else
            {
                room.BroadcastSkillInvoke("songci", "male", 1, gsk.General, gsk.SkinId);
                room.DrawCards(effect.To, new DrawCardStruct(2, effect.From, "songci"));
            }
        }
    }

    public class Songci : TriggerSkill
    {
        public Songci() : base("songci")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            view_as_skill = new SongciVS();
            skill_type = SkillType.Wizzard;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (base.Triggerable(player, room) && player.Phase == Player.PlayerPhase.Finish)
            {
                bool all = true;
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.GetMark(string.Format("songci_{0}", player.Name)) == 0)
                    {
                        all = false;
                        break;
                    }
                }
                if (all)
                {
                    room.SendCompulsoryTriggerLog(player, Name);
                    room.DrawCards(player, 1, Name);
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class SongciVS : ZeroCardViewAsSkill
    {
        public SongciVS() : base("songci")
        {
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            foreach (Player sib in room.GetAlivePlayers())
                if (sib.GetMark("songci_" + player.Name) == 0 && sib.HandcardNum != sib.Hp)
                    return true;
            return false;
        }
        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard c = new WrappedCard(SongciCard.ClassName) { Skill = Name, Mute = true };
            return c;
        }
    }


    public class Xianfu : TriggerSkill
    {
        public Xianfu() : base("xianfu")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.Damaged, TriggerEvent.HpRecover };
            skill_type = SkillType.Wizzard;
            frequency = Frequency.Compulsory;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                triggers.Add(new TriggerStruct(Name, player));
            else if (triggerEvent == TriggerEvent.Damaged && player.Alive && player.ContainsTag(Name))
            {
                List<string> xizhicai = (List<string>)player.GetTag(Name);
                foreach (string name in xizhicai)
                {
                    Player p = room.FindPlayer(name);
                    if (p != null) triggers.Add(new TriggerStruct(Name, p));
                }
            }
            else if (triggerEvent == TriggerEvent.HpRecover && player.ContainsTag(Name))
            {
                List<string> xizhicai = (List<string>)player.GetTag(Name);
                foreach (string name in xizhicai)
                {
                    Player p = room.FindPlayer(name);
                    if (p != null && p.IsWounded()) triggers.Add(new TriggerStruct(Name, p));
                }
            }
            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Random ra = new Random();
            if (triggerEvent == TriggerEvent.GameStart)
            {
                Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@xianfu-target", false, false, info.SkillPosition);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name, new List<Player> { player });
                List<string> froms = target.ContainsTag(Name) ? (List<string>)target.GetTag(Name) : new List<string>();
                if (!froms.Contains(player.Name))
                    froms.Add(player.Name);
                target.SetTag(Name, froms);

                List<string> arg = new List<string>
                {
                    target.Name,
                    "@fu",
                    "1"
                };
                room.DoNotify(room.GetClient(player), CommandType.S_COMMAND_SET_MARK, arg);

                room.NotifySkillInvoked(player, Name);
                GeneralSkin general = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                int result = ra.Next(1, 3);
                room.BroadcastSkillInvoke(Name, "male", result, general.General, general.SkinId);
            }
            else if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct damage && ask_who.Alive)
            {
                if (player.GetMark("@fu") == 0)
                    room.SetPlayerMark(player, "@fu", 1);

                room.NotifySkillInvoked(ask_who, Name);
                GeneralSkin general = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                int result = ra.Next(3, 5);
                room.BroadcastSkillInvoke(Name, "male", result, general.General, general.SkinId);

                room.Damage(new DamageStruct(Name, null, ask_who, damage.Damage));
            }
            else if (triggerEvent == TriggerEvent.HpRecover && data is RecoverStruct recover && ask_who.IsWounded())
            {
                room.NotifySkillInvoked(ask_who, Name);
                GeneralSkin general = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                int result = ra.Next(5, 7);
                room.BroadcastSkillInvoke(Name, "male", result, general.General, general.SkinId);

                RecoverStruct _recover = new RecoverStruct
                {
                    Recover = recover.Recover,
                    Who = player
                };
                room.Recover(ask_who, _recover, true);
            }
            return false;
        }
    }

    public class Chouce : TriggerSkill
    {
        public Chouce() : base("chouce")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged };
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
            if (room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            JudgeStruct judge = new JudgeStruct
            {
                Good = true,
                PlayAnimation = false,
                Who = player,
                Reason = Name
            };
            room.Judge(ref judge);

            if (WrappedCard.IsBlack(judge.JudgeSuit))
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetAlivePlayers())
                    if (RoomLogic.CanDiscard(room, player, p, "hej"))
                        targets.Add(p);

                if (targets.Count > 0)
                {
                    player.SetFlags(Name);
                    Player target = room.AskForPlayerChosen(player, targets, Name, "@chouce-discard", false, true, info.SkillPosition);
                    player.SetFlags("-chouce");

                    int id = room.AskForCardChosen(player, target, "hej", Name, false, HandlingMethod.MethodDiscard);
                    room.ThrowCard(id, room.GetCardPlace(id) != Place.PlaceDelayedTrick ? target : null, player != target ? player : null);
                }
            }
            else
            {
                Player target = room.AskForPlayerChosen(player, room.GetAlivePlayers(), Name, "@chouce-draw", false, true, info.SkillPosition);
                DrawCardStruct draw = new DrawCardStruct(1, player, Name);
                if (target.ContainsTag("xianfu") && target.GetTag("xianfu") is List<string> names && names.Contains(player.Name))
                {
                    if (target.GetMark("@fu") == 0)
                        room.SetPlayerMark(target, "@fu", 1);
                    draw.Draw = 2;
                }

                room.DrawCards(target, draw);
            }

            return false;
        }
    }

    public class Chenqing : TriggerSkill
    {
        public Chenqing() : base("chenqing")
        {
            skill_type = SkillType.Recover;
            events = new List<TriggerEvent> { TriggerEvent.Dying };
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.Alive && player.HasFlag("Global_Dying"))
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (room.Round > p.GetMark(Name)) triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player dyer, ref object data, Player player, TriggerStruct info)
        {
            if (data is DyingStruct dying && room.Round > player.GetMark(Name))
            {
                List<Player> targets = room.GetOtherPlayers(player);
                targets.Remove(dyer);
                if (targets.Count > 0)
                {
                    room.SetTag(Name, data);
                    Player target = room.AskForPlayerChosen(player, targets, Name, "@chenqing:" + dying.Who.Name, true, true, info.SkillPosition);
                    room.RemoveTag(Name);
                    if (target != null)
                    {
                        player.SetTag(Name, target.Name);
                        room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                        return info;
                    }
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player dyer, ref object data, Player player, TriggerStruct info)
        {
            player.SetMark(Name, room.Round);
            if (data is DyingStruct dying)
            {
                Player target = room.FindPlayer((string)player.GetTag(Name));
                player.RemoveTag(Name);

                room.DrawCards(target, new DrawCardStruct(4, player, Name));
                List<int> ids = room.AskForExchange(target, Name, 4, 4, "@chenqing-discard:" + dying.Who.Name, string.Empty, "..!", string.Empty);
                bool heal = false;
                if (ids.Count == 4)
                {
                    heal = true;
                    for (int i = 0; i < ids.Count; i++)
                    {
                        WrappedCard.CardSuit suit = room.GetCard(ids[i]).Suit;
                        for (int j = i + 1; j < ids.Count; j++)
                        {
                            if (suit == room.GetCard(ids[j]).Suit)
                            {
                                heal = false;
                                break;
                            }
                        }

                        if (!heal) break;
                    }
                }
                if (ids.Count > 0)
                    room.ThrowCard(ref ids, target);

                if (heal)
                {
                    WrappedCard peach = new WrappedCard(Peach.ClassName) { Skill = "_chenqing" };
                    if (RoomLogic.IsProhibited(room, target, dying.Who, peach) == null)
                    {
                        Thread.Sleep(700);
                        room.UseCard(new CardUseStruct(peach, target, dying.Who));
                    }
                }
            }

            return false;
        }
    }

    public class Moshi : TriggerSkill
    {
        public Moshi() : base("moshi")
        {
            skill_type = SkillType.Alter;
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.CardUsedAnnounced, TriggerEvent.EventPhaseChanging, TriggerEvent.CardResponded };
            view_as_skill = new MoshiVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && player.Phase == PlayerPhase.Play && data is CardUseStruct use
                && (!player.ContainsTag(Name) || ((List<string>)player.GetTag(Name)).Count < 2))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if ((fcard is BasicCard || fcard is TrickCard) && !(fcard is DelayedTrick))
                {
                    List<string> cards = player.ContainsTag(Name) ? (List<string>)player.GetTag(Name) : new List<string>();
                    cards.Add(use.Card.Name);
                    player.SetTag(Name, cards);
                }
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use && player.Phase == PlayerPhase.Play
                && (!player.ContainsTag(Name) || ((List<string>)player.GetTag(Name)).Count < 2))
            {
                FunctionCard fcard = Engine.GetFunctionCard(resp.Card.Name);
                if (fcard is BasicCard)
                {
                    List<string> cards = player.ContainsTag(Name) ? (List<string>)player.GetTag(Name) : new List<string>();
                    cards.Add(resp.Card.Name);
                    player.SetTag(Name, cards);
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.ContainsTag(Name))
                player.RemoveTag(Name);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish
                && player.ContainsTag(Name) && !player.IsKongcheng())
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.GetTag(Name) is List<string> cards)
            {
                while (cards.Count > 0 && !player.IsKongcheng())
                {
                    string card_name = cards[0];
                    room.AskForUseCard(player, RespondType.Skill, "@@moshi", string.Format("@moshi:::{0}", card_name), null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
                    cards.RemoveAt(0);
                }
            }

            player.RemoveTag(Name);
            
            return false;
        }
    }

    public class MoshiVS : ViewAsSkill
    {
        public MoshiVS() : base("moshi")
        {
            response_pattern = "@@moshi";
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return false;
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return selected.Count == 0 && room.GetCardPlace(to_select.Id) == Place.PlaceHand
                && !RoomLogic.IsCardLimited(room, player, to_select, FunctionCard.HandlingMethod.MethodUse, true);
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            if (cards.Count == 1 && player.GetTag(Name) is List<string> strs)
            {
                string card_name = strs[0];
                WrappedCard card = new WrappedCard(card_name) { Skill = Name };
                card.AddSubCards(cards);
                result.Add(card);
            }

            return result;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
                return cards[0];

            return null;
        }
    }

    public class ShanjiaVS : ViewAsSkill
    {
        public ShanjiaVS() : base("shanjia")
        {
            response_pattern = "@@shanjia";
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
                return new List<WrappedCard> { new WrappedCard(Slash.ClassName) { Skill = "_shanjia" } };

            return new List<WrappedCard>();
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
                return cards[0];

            return null;
        }
    }

    public class Shanjia : TriggerSkill
    {
        public Shanjia() : base("shanjia")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseStart, TriggerEvent.EventLoseSkill, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Replenish;
            view_as_skill = new ShanjiaVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && ((move.From_places.Contains(Place.PlaceEquip) && move.To_place != Place.PlaceHand)
                || (move.From_places.Contains(Place.PlaceHand) && move.To_place != Place.PlaceEquip)) && move.From.GetMark(Name) < 3)
            {
                int count = move.From.GetMark(Name);
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    Place place = move.From_places[i];
                    if (place == Place.PlaceEquip)
                        count++;
                    else if (place == Place.PlaceHand)
                    {
                        WrappedCard card = room.GetCard(move.Card_ids[i]);
                        FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                        if (fcard is EquipCard) count++;
                    }
                }

                count = Math.Min(3, count);
                if (count > move.From.GetMark(Name))
                {
                    move.From.SetMark(Name, count);
                    if (base.Triggerable(move.From, room)) room.SetPlayerStringMark(move.From, "shanjia_losed", count.ToString());
                }
            }
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name)
            {
                room.RemovePlayerStringMark(player, "shanjia_losed");
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.Alive)
            {
                player.SetFlags("-shanjia_slash");
                player.SetFlags("-shanjia_distance");
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Play && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player);
            }

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
            room.DrawCards(player, 3, Name);
            int count = Math.Max(0, 3 - player.GetMark(Name));
            int hand = 0;

            List<int> ids = new List<int>(), all = new List<int>();
            if (count > 0)
            {
                foreach (int id in player.GetCards("he"))
                {
                    if (RoomLogic.CanDiscard(room, player, player, id))
                    {
                        all.Add(id);
                        if (room.GetCardPlace(id) == Place.PlaceHand) hand++;
                    }
                }

                if (all.Count <= count)
                {
                    ids = all;
                    if (hand < player.HandcardNum)
                        room.ShowAllCards(player, null);
                }
                else
                    ids = room.AskForExchange(player, Name, count, count, "@shanjia-discard:::" + count.ToString(), string.Empty, "..!", info.SkillPosition);

                if (ids.Count > 0)
                    room.ThrowCard(ref ids, player);
            }

            if (player.Alive)
            {
                bool basic_check = true;
                bool trick_check = true;
                foreach (int id in ids)
                {
                    WrappedCard card = room.GetCard(id);
                    FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                    if (fcard is BasicCard)
                    {
                        basic_check = false;
                    }
                    else if (fcard is TrickCard)
                    {
                        trick_check = false;
                    }
                }
                if (basic_check)
                    player.SetFlags("shanjia_slash");
                if (trick_check)
                    player.SetFlags("shanjia_distance");

                if (basic_check && trick_check)
                    room.AskForUseCard(player, RespondType.Skill, "@@shanjia", "@shanjia-slash", null, -1, HandlingMethod.MethodUse, false, info.SkillPosition);
            }

            return false;
        }
    }

    public class ShanjiaTar : TargetModSkill
    {
        public ShanjiaTar() : base("#shanjia", false) { pattern = "."; }
        public override int GetResidueNum(Room room, Player from, WrappedCard card) => card != null && card.Name.Contains(Slash.ClassName) && from.HasFlag("shanjia_slash") ? 1 : 0;
        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern) => from.HasFlag("shanjia_distance");
    }

    public class Qizhi : TriggerSkill
    {
        public Qizhi() : base("qizhi")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetMark(Name) > 0)
            {
                room.RemovePlayerStringMark(player, Name);
                player.SetMark(Name, 0);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && base.Triggerable(player, room) && player.Phase != PlayerPhase.NotActive)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is BasicCard || fcard is TrickCard)
                {
                    foreach (Player p in room.GetAlivePlayers())
                        if (!use.To.Contains(p) && !p.IsNude() && RoomLogic.CanDiscard(room, player, p, "he"))
                            return new TriggerStruct(Name, player);
                }
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetAlivePlayers())
                    if (!use.To.Contains(p) && !p.IsNude())
                        targets.Add(p);

                if (targets.Count > 0)
                {
                    Player target = room.AskForPlayerChosen(player, targets, Name, "@qizhi", true, true, info.SkillPosition);
                    if (target != null)
                    {
                        player.SetTag(Name, target.Name);
                        room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                        return info;
                    }
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.FindPlayer(player.GetTag(Name).ToString());
            player.RemoveTag(Name);
            int id = -1;
            if (player == target)
                id = room.AskForExchange(player, Name, 1, 1, "@qizhi-discard", string.Empty, "..!", info.SkillPosition)[0];
            else
                id = room.AskForCardChosen(player, target, "he", Name, false, FunctionCard.HandlingMethod.MethodDiscard);
            room.ThrowCard(id, target, player != target ? player : null);

            if (target.Alive)
                room.DrawCards(target, new DrawCardStruct(1, player, Name));

            if (player.Alive)
            {
                player.AddMark(Name);
                room.SetPlayerStringMark(player, Name, player.GetMark(Name).ToString());
            }

            return false;
        }
    }

    public class Jinqu : PhaseChangeSkill
    {
        public Jinqu() : base("jinqu") { }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return player.Phase == PlayerPhase.Finish && base.Triggerable(player, room) ? new TriggerStruct(Name, player) : new TriggerStruct();
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

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            room.DrawCards(player, 2, Name);
            int count = player.HandcardNum - player.GetMark("qizhi");
            if (count > 0)
                room.AskForDiscard(player, Name, count, count, false, false, string.Format("@jinqu-discard:::{0}", player.GetMark("qizhi")), false, info.SkillPosition);

            return false;
        }
    }

    public class Gushe : TriggerSkill
    {
        public Gushe() : base("gushe")
        {
            skill_type = SkillType.Attack;
            view_as_skill = new GusheVS();
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                player.SetMark(Name, 0);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class GusheVS : ZeroCardViewAsSkill
    {
        public GusheVS() : base("gushe")
        {
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.IsKongcheng() && player.GetMark(Name) + player.GetMark("@she") < 7;
        }
        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(GusheCard.ClassName) { Skill = Name };
        }
    }

    public class GusheCard : SkillCard
    {
        public static string ClassName = "GusheCard";
        public GusheCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count < 3 && to_select != Self && RoomLogic.CanBePindianBy(room, to_select, Self);
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            return targets.Count > 0 && targets.Count <= 3;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            PindianStruct pd = room.PindianSelect(player, card_use.To, "gushe", null);

            for (int i = 0; i < card_use.To.Count; i++)
            {
                room.Pindian(ref pd, i);
                Player target = pd.Tos[i];
                List<Player> loser = new List<Player>();

                if (pd.From_number > pd.To_numbers[i])
                    loser.Add(target);
                else if (pd.From_number == pd.To_numbers[i])
                {
                    loser.Add(player);
                    loser.Add(target);
                }
                else
                    loser.Add(player);

                if (!loser.Contains(player)) player.AddMark("gushe");
                foreach (Player p in loser)
                {
                    if (p.Alive)
                    {
                        if (p == player)
                        {
                            room.AddPlayerMark(player, "@she");
                            if (player.GetMark("@she") >= 7)
                            {
                                room.DoAnimate(AnimateType.S_ANIMATE_ABUSE);
                                Thread.Sleep(4500);

                                for (int x = 0; x < 5; x++)
                                {
                                    room.SetEmotion(player, "lightning2");
                                    Thread.Sleep(250);
                                }
                                Thread.Sleep(1000);

                                player.Hp = 0;
                                room.BroadcastProperty(player, "Hp");
                                room.KillPlayer(player, new DamageStruct());
                            }
                        }

                        if (p.Alive)
                        {
                            string prompt = "@gushe:" + player.Name;
                            if (player == p) prompt = "@gushe-self";
                            if (!player.Alive)
                                prompt = "@gushe-force";
                            bool discard = false;
                            if (!p.IsNude())
                                discard = room.AskForDiscard(p, "gushe", 1, 1, player.Alive, true, prompt, false, card_use.Card.SkillPosition);

                            if (!discard && player.Alive)
                                room.DrawCards(player, new DrawCardStruct(1, p, "gushe"));
                        }
                    }
                }
            }

            //激词的获得点数最大的卡牌要放在这里
            if (player.HasFlag("jici") && player.Alive)
            {
                player.SetFlags("-jici");
                int max_id = -1, max_number = 0;
                if (pd.From_card.Number > max_number)
                {
                    max_number = pd.From_card.Number;
                    max_id = pd.From_card.Id;
                }
                foreach (WrappedCard card in pd.To_cards)
                {
                    if (card.Number > max_number)
                    {
                        max_number = card.Number;
                        max_id = card.Id;
                    }
                }

                //匹配是否唯一最大
                bool same = false;
                if (pd.From_card.Number == max_number && pd.From_card.Id != max_id)
                {
                    same = true;
                }
                foreach (WrappedCard card in pd.To_cards)
                {
                    if (card.Number == max_number && card.Id != max_id)
                    {
                        same = true;
                        break;
                    }
                }

                if (!same && max_id > -1  && room.GetCardPlace(max_id) == Place.DiscardPile)
                    room.ObtainCard(player, room.GetCard(max_id), new CardMoveReason(MoveReason.S_REASON_RECYCLE, player.Name, "jici", string.Empty));
            }
        }
    }

    public class Jici : TriggerSkill
    {
        public Jici() : base("jici")
        {
            events = new List<TriggerEvent> { TriggerEvent.PindianVerifying, TriggerEvent.Pindian, TriggerEvent.Death };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.PindianVerifying && data is PindianStruct pindian
                && pindian.Reason == "gushe" && base.Triggerable(player, room) && pindian.From_number <= player.GetMark("@she"))
            {
                return new TriggerStruct(Name, player);
            }
            else if (player != null && RoomLogic.PlayerHasSkill(room, player, Name) && data is DeathStruct death && death.Damage.From != null && death.Damage.From.Alive)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player sunce, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            if (triggerEvent == TriggerEvent.Death && data is DeathStruct death)
            {
                Player target = death.Damage.From;
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                int count = 7 - player.GetMark("@she");
                if (count > 0 && !target.IsNude())
                    room.AskForDiscard(target, Name, count, count, false, true, string.Format("@jici-discard:{0}::{1}", player.Name, count));
                if (target.Alive) room.LoseHp(target);
            }
            else
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);

                PindianStruct pindian = (PindianStruct)data;
                int count = player.GetMark("@she");
                pindian.From_number = Math.Min(13, pindian.From_number + count);
                data = pindian;
                LogMessage log = new LogMessage
                {
                    From = player.Name,
                    Type = "#gushe-verify",
                    Arg = pindian.From_number.ToString()
                };
                room.SendLog(log);

                player.SetFlags(Name);
            }

            return false;
        }
    }

    public class Kangkai : TriggerSkill
    {
        public Kangkai() : base("kangkai")
        {
            events.Add(TriggerEvent.TargetConfirmed);
            skill_type = SkillType.Defense;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName))
            {
                List<Player> caoans = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in caoans)
                    if (p == player || RoomLogic.DistanceTo(room, p, player) == 1)
                        triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Alive && ask_who.Alive && (ask_who == player || RoomLogic.DistanceTo(room, ask_who, player) == 1))
            {
                if (room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition))
                {
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.DrawCards(ask_who, 1, Name);
            if (player.Alive && player != ask_who)
            {
                room.SetTag(Name, data);
                player.SetFlags(Name);
                List<int> ids = room.AskForExchange(ask_who, Name, 1, 1, "@kangkai-give:" + player.Name, string.Empty, "..", info.SkillPosition);
                player.SetFlags("-kangkai");
                room.RemoveTag(Name);
                room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, ask_who.Name, player.Name, Name, string.Empty));
                if (ids.Count == 1 && player.Alive)
                {
                    WrappedCard card = room.GetCard(ids[0]);
                    FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                    if (fcard is EquipCard && fcard.IsAvailable(room, player, card))
                        room.AskForUseCard(player, RespondType.None, ids[0].ToString(), "@kangkai-use", null);
                }

                ResultStruct result = ask_who.Result;
                result.Assist++;
                ask_who.Result = result;
            }
            
            return false;
        }
    }

    public class XiaoguoJX : TriggerSkill
    {
        public XiaoguoJX() : base("xiaoguo_jx")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Attack;
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (player != null && player.Phase == PlayerPhase.Finish)
            {
                List<Player> yuejins = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player yuejin in yuejins)
                {
                    if (player != yuejin && RoomLogic.CanDiscard(room, yuejin, yuejin, "h"))
                        skill_list.Add(new TriggerStruct(Name, yuejin));
                }
            }
            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> ints = new List<int>(room.AskForExchange(ask_who, Name, 1, 0, "@xiaoguo:" + player.Name, null, "BasicCard!", info.SkillPosition));
            if (ints.Count == 1)
            {
                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_DISMANTLE, ask_who.Name, ask_who.Name, Name, null)
                {
                    General = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition)
                };
                room.ThrowCard(ref ints, reason, ask_who, null, Name);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SetTag(Name, ask_who);
            WrappedCard card = room.AskForCard(player, Name, RespondType.None, ".Equip", "@xiaoguo_jx-discard:" + ask_who.Name, null);
            room.RemoveTag(Name);
            if (card == null)
                room.Damage(new DamageStruct(Name, ask_who, player));
            else if (ask_who.Alive)
                room.DrawCards(ask_who, 1, Name);

            return false;
        }
    }

    public class Zhenwei : TriggerSkill
    {
        public Zhenwei() : base("zhenwei")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetConfirming, TriggerEvent.EventPhaseStart };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.NotActive)
            {
                foreach (Player p in room.GetAllPlayers(true))
                {
                    if (p.ContainsTag(Name) && p.Alive && p.GetTag(Name) is List<int> ids)
                    {
                        p.RemoveTag(Name);
                        List<int> get = new List<int>();
                        foreach (int id in ids)
                            if (room.GetCardPlace(id) == Place.DiscardPile)
                                get.Add(id);

                        room.ObtainCard(p, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, p.Name, Name, string.Empty));
                    }
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.TargetConfirming && data is CardUseStruct use && use.To.Contains(player) && use.To.Count == 1)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash || (fcard is TrickCard && WrappedCard.IsBlack(use.Card.Suit)))
                {
                    foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                        if (p != player && p != use.From && p.Hp >= player.Hp && !p.IsNude())
                            triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && use.To.Contains(player) && use.To.Count == 1 && player.Alive && ask_who.Hp > player.Hp && !ask_who.IsNude())
            {
                List<CardUseStruct> datas = room.ContainsTag(Name) ? (List<CardUseStruct>)room.GetTag(Name) : new List<CardUseStruct>();
                datas.Add(use);
                room.SetTag(Name, datas);
                bool invoke = room.AskForDiscard(ask_who, Name, 1, 1, true, true, string.Format("@zhenwei:{0}:{1}:{2}", use.From.Name, player.Name, use.Card.Name), true, info.SkillPosition);
                datas.RemoveAt(datas.Count - 1);
                room.SetTag(Name, datas);

                if (invoke)
                {
                    ResultStruct result = ask_who.Result;
                    result.Assist++;
                    ask_who.Result = result;

                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && use.To.Contains(player) && player.Alive && ask_who.Alive)
            {
                List<string> choices = new List<string> { "nullfy" };
                bool transfer = true;
                if (RoomLogic.IsProhibited(room, use.From, ask_who, use.Card) != null
                    || (use.Card.Name == FireAttack.ClassName && ask_who.IsKongcheng())
                    || (use.Card.Name == IronChain.ClassName && !RoomLogic.CanBeChainedBy(room, ask_who, use.From))
                    || (use.Card.Name == Dismantlement.ClassName && !RoomLogic.CanDiscard(room, use.From, ask_who, "hej"))
                    || (use.Card.Name == Snatch.ClassName && !RoomLogic.CanGetCard(room, use.From, ask_who, "hej"))
                    || (Engine.GetFunctionCard(use.Card.Name) is DelayedTrick && RoomLogic.PlayerContainsTrick(room, ask_who, use.Card.Name))
                    || (use.Card.Name == Collateral.ClassName && !ask_who.GetWeapon()))
                    transfer = false;
                if (transfer) choices.Add("transfer");
                string choice = room.AskForChoice(ask_who, Name, string.Join("+", choices), new List<string> { "@zhenwei-card:::" + use.Card.Name }, data, info.SkillPosition);

                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (choice == "transfer")
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "#zhenwei",
                        From = ask_who.Name,
                        To = new List<string> { player.Name },
                        Arg = use.Card.Name
                    };
                    room.SendLog(log);

                    room.DrawCards(ask_who, 1, Name);
                    if (ask_who.Alive)
                    {
                        if (use.To.Contains(ask_who) && use.To.IndexOf(ask_who) > use.To.IndexOf(player))
                        {
                            use.To.Insert(use.To.IndexOf(ask_who), ask_who);
                            use.EffectCount.Insert(use.To.IndexOf(ask_who), fcard.FillCardBasicEffct(room, ask_who));

                            int index = 0, count = use.EffectCount.Count;
                            for (index = 0; index < count; index++)
                            {
                                if (use.EffectCount[index].To == player && !use.EffectCount[index].Triggered)
                                    break;
                            }
                            use.To.RemoveAt(index);
                            use.EffectCount.RemoveAt(index);
                        }
                        else
                        {
                            int index = 0, count = use.EffectCount.Count;
                            for (index = 0; index < count; index++)
                            {
                                if (use.EffectCount[index].To == player && !use.EffectCount[index].Triggered)
                                    break;
                            }
                            use.To.RemoveAt(index);
                            use.EffectCount.RemoveAt(index);

                            use.To.Add(ask_who);
                            use.EffectCount.Add(fcard.FillCardBasicEffct(room, ask_who));
                            room.SortByActionOrder(ref use);
                        }
                        if (fcard is Slash)
                            room.SlashSettlementFinished(player, use.Card);

                        data = use;
                        return true;
                    }
                }
                else
                {
                    if (use.From.Alive)
                    {
                        List<int> ids = use.From.ContainsTag(Name) ? (List<int>)use.From.GetTag(Name) : new List<int>();
                        ids.AddRange(use.Card.SubCards);
                        use.From.SetTag(Name, ids);
                    }

                    room.CancelTarget(ref use, player); // Room::cancelTarget(use, player);
                    data = use;
                    return true;
                }
            }
            return false;
        }
    }

    public class Kunfen : TriggerSkill
    {
        public Kunfen() : base("kunfen")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Masochism;
            frequency = Frequency.Compulsory;
        }

        public override bool Triggerable(Player target, Room room)
        {
            return target.Phase == PlayerPhase.Finish && base.Triggerable(target, room);
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            bool invoke = player.GetMark("fengliang") == 0 || room.AskForSkillInvoke(player, Name, null, info.SkillPosition);
            if (invoke)
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct(); 
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.LoseHp(player);
            if (player.Alive) room.DrawCards(player, 2, Name);
            return false;
        }
    }

    public class Fengliang : TriggerSkill
    {
        public Fengliang() : base("fengliang")
        {
            events.Add(TriggerEvent.AskForPeaches);
            frequency = Frequency.Wake;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DyingStruct dying && dying.Who == player && base.Triggerable(player, room) && player.GetMark(Name) == 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            room.SetPlayerMark(player, Name, 1);
            room.SendCompulsoryTriggerLog(player, Name);

            room.SetPlayerMark(player, "kunfen_description_index", 1);
            room.RefreshSkill(player);

            room.LoseMaxHp(player);
            RecoverStruct recover = new RecoverStruct
            {
                Who = player,
                Recover = Math.Min(2, player.MaxHp) - player.Hp
            };
            room.Recover(player, recover, true);

            room.HandleAcquireDetachSkills(player, "tiaoxin_jx", true);

            return false;
        }
    }
    
    public class Weikui : ZeroCardViewAsSkill
    {
        public Weikui() : base("weikui")
        {
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(WeikuiCard.ClassName);
        }
        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(WeikuiCard.ClassName) { Skill = Name };
        }
    }

    public class WeikuiCard : SkillCard
    {
        public static string ClassName = "WeikuiCard";
        public WeikuiCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self && !to_select.IsKongcheng();
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            room.LoseHp(player);

            if (player.Alive && target.Alive && !target.IsKongcheng())
            {
                List<int> ids = target.GetCards("h");
                bool jink = false;
                foreach (int id in ids)
                {
                    if (room.GetCard(id).Name == Jink.ClassName)
                    {
                        jink = true;
                        break;
                    }
                }

                if (!jink)
                {
                    List<int> discard = new List<int>();
                    foreach (int id in ids)
                        if (RoomLogic.CanDiscard(room, player, target, id)) discard.Add(id);

                    target.SetFlags("gongxin_target");
                    int result = room.DoGongxin(player, target, target.GetCards("h"), discard, "weikui", "@weikui:" + target.Name, card_use.Card.SkillPosition);
                    target.SetFlags("-gongxin_target");

                    if (result != -1)
                        room.ThrowCard(result, target, player);
                }
                else
                {
                    room.ShowAllCards(target, player, "weikui");
                    player.SetFlags("WeikuiInvoker");
                    target.SetFlags("WeikuiTarget");

                    WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_weikui" };
                    if (RoomLogic.IsProhibited(room, player, target, slash) == null)
                        room.UseCard(new CardUseStruct(slash, player, target), false);
                }
            }
        }
    }

    public class WeikuiDistance : DistanceSkill
    {
        public WeikuiDistance() : base("#weikui-dis")
        {
        }
        public override int GetFixed(Room room, Player from, Player to)
        {
            if (from.HasFlag("WeikuiInvoker") && to.HasFlag("WeikuiTarget"))
                return 1;
            else
                return 0;
        }
    }
    public class Lizhan : PhaseChangeSkill
    {
        public Lizhan() : base("lizhan")
        {
            skill_type = SkillType.Replenish;
        }

        public override bool Triggerable(Player target, Room room)
        {
            return base.Triggerable(target, room) && target.Phase == PlayerPhase.Finish;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> to_choose = new List<Player>();
            foreach (Player p in room.GetAlivePlayers())
                if (p.IsWounded()) to_choose.Add(p);

            if (to_choose.Count > 0)
            {
                List<Player> choosees = room.AskForPlayersChosen(player, to_choose, Name, 0, to_choose.Count, "@lizhan", true, info.SkillPosition);
                if (choosees.Count > 0)
                {
                    room.SortByActionOrder(ref choosees);
                    room.SetTag("tuxi_invoke" + player.Name, choosees);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            string str = "tuxi_invoke" + player.Name;
            List<Player> targets = room.ContainsTag(str) ? (List<Player>)room.GetTag(str) : new List<Player>();
            room.RemoveTag(str);

            foreach (Player p in targets)
                if (p.Alive) room.DrawCards(p, new DrawCardStruct(1, player, Name));

            return false;
        }
    }



    public class Gongao : TriggerSkill
    {
        public Gongao() : base("gongao")
        {
            events.Add(TriggerEvent.Dying);
            frequency = Frequency.Compulsory;
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            List<Player> caopis = RoomLogic.FindPlayersBySkillName(room, Name);
            foreach (Player caopi in caopis)
                if (caopi != player && caopi.GetMark(string.Format("{0}_{1}", Name, player.Name)) == 0)
                    triggers.Add(new TriggerStruct(Name, caopi));

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player dying, ref object data, Player player, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.SendCompulsoryTriggerLog(player, Name);
            player.SetMark(string.Format("{0}_{1}", Name, dying.Name), 1);
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
            }

            return false;
        }
    }
    public class Juyi : PhaseChangeSkill
    {
        public Juyi() : base("juyi")
        {
            frequency = Frequency.Wake;
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Start && base.Triggerable(player, room) && player.GetMark(Name) == 0 && player.MaxHp > room.AliveCount())
            {
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

            room.DrawCards(player, player.MaxHp, Name);

            if (player.Alive)
                room.HandleAcquireDetachSkills(player, "benghuai|weizhong", true);

            return false;
        }
    }

    public class Weizhong : TriggerSkill
    {
        public Weizhong() : base("weizhong")
        {
            events.Add(TriggerEvent.MaxHpChanged);
            frequency = Frequency.Compulsory;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DrawCards(player, 2, Name);
            return false;
        }
    }

    public class Junbing : TriggerSkill
    {
        public Junbing() : base("junbing")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            view_as_skill = new JunbingVS();
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.Phase == PlayerPhase.Finish && player.Alive && player.HandcardNum < player.Hp)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    triggers.Add(new TriggerStruct(Name, player, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            string prompt = string.Empty;
            if (player != ask_who) prompt = "@junbing:" + player.Name;
            if (room.AskForSkillInvoke(ask_who, Name, string.IsNullOrEmpty(prompt) ? null : prompt, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.DrawCards(ask_who, new DrawCardStruct(1, player, Name));
            List<int> ids = ask_who.GetCards("h");
            if (ids.Count > 0 && player.Alive && player != ask_who)
            {
                room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, ask_who.Name, player.Name, Name, string.Empty), false);
                int count = ids.Count;

                if (count > 0 && ask_who.Alive && player.Alive && !player.IsNude())
                {
                    player.SetMark(Name, count);
                    WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@junbing", string.Format("@junbing-give:{0}::{1}", ask_who.Name, count),
                        null, -1, HandlingMethod.MethodNone, true, info.SkillPosition);
                    player.SetMark(Name, 0);
                    if (card != null)
                    {
                        List<int> give = new List<int>(card.SubCards);
                        room.ObtainCard(ask_who, ref give, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, ask_who.Name, Name, string.Empty), false);
                    }
                }
            }

            return false;
        }
    }

    public class JunbingVS :ViewAsSkill
    {
        public JunbingVS() : base("junbing") { response_pattern = "@@junbing"; }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => selected.Count < player.GetMark(Name);
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == player.GetMark(Name))
            {
                WrappedCard card = new WrappedCard(DummyCard.ClassName);
                card.AddSubCards(cards);
                return card;
            }
            return null;
        }
    }

    public class Quji : ViewAsSkill
    {
        public Quji() : base("quji")
        {
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return selected.Count < player.GetLostHp() && RoomLogic.CanDiscard(room, player, player, to_select.Id);
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return player.IsWounded() && !player.IsNude() && !player.HasUsed(QujiCard.ClassName);
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == player.GetLostHp())
            {
                WrappedCard qj = new WrappedCard(QujiCard.ClassName) { Skill = Name };
                qj.AddSubCards(cards);
                return qj;
            }

            return null;
        }
    }

    public class QujiCard : SkillCard
    {
        public static string ClassName = "QujiCard";
        public QujiCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count < Self.GetLostHp() && to_select.IsWounded();
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;

            bool black = false;
            foreach (int id in card_use.Card.SubCards)
            {
                if (WrappedCard.IsBlack(room.GetCard(id).Suit))
                {
                    black = true;
                    break;
                }
            }

            foreach (Player p in card_use.To)
            {
                RecoverStruct recover = new RecoverStruct
                {
                    Recover = 1,
                    Who = player
                };
                room.Recover(p, recover, true);
            }

            foreach (Player p in card_use.To)
                if (p.Alive && p.IsWounded())
                    room.DrawCards(p, new DrawCardStruct(1, player, "quji"));

            if (player.Alive && black)
                room.LoseHp(player);
        }
    }

    public class Tuifeng : TriggerSkill
    {
        public Tuifeng() : base("tuifeng")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Masochism;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetMark(Name) > 0)
                player.SetMark(Name, 0);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && base.Triggerable(player, room) && !player.IsNude() && data is DamageStruct damage)
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
            List<int> ids = room.AskForExchange(player, Name, 1, 0, "@tuifeng", string.Empty, "..", info.SkillPosition);
            if (ids.Count > 0)
            {
                room.NotifySkillInvoked(player, Name);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                room.AddToPile(player, Name, ids);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            return false;
        }
    }

    public class TuifengGet : PhaseChangeSkill
    {
        public TuifengGet() : base("#tuifeng") { frequency = Frequency.Compulsory; }

        public override bool Triggerable(Player target, Room room)
        {
            return base.Triggerable(target, room) && target.Phase == PlayerPhase.Start && target.GetPile("tuifeng").Count > 0;
        }
        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "tuifeng", info.SkillPosition);
            room.BroadcastSkillInvoke("tuifeng", "male", 2, gsk.General, gsk.SkinId);

            List<int> ids = player.GetPile("tuifeng");
            int count = ids.Count;
            player.SetMark("tuifeng", count);

            List<CardsMoveStruct> moves = new List<CardsMoveStruct>();
            CardsMoveStruct move1 = new CardsMoveStruct(ids, null, Place.DiscardPile, new CardMoveReason(MoveReason.S_REASON_NATURAL_ENTER, player.Name, "tuifeng", string.Empty));
            moves.Add(move1);
            room.MoveCardsAtomic(moves, true);

            if (player.Alive)
                room.DrawCards(player, 2 * count, "tuifeng");

            return false;
        }
    }

    public class TuifengTar : TargetModSkill
    {
        public TuifengTar() : base("#tuifeng-tar", false) { }

        public override int GetResidueNum(Room room, Player from, WrappedCard card)
        {
            return from.GetMark("tuifeng");
        }
    }

    public class Zhenlue : TriggerSkill
    {
        public Zhenlue() : base("zhenlue")
        {
            frequency = Frequency.Compulsory;
            events = new List<TriggerEvent> { TriggerEvent.CardUsed };
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && Engine.GetFunctionCard(use.Card.Name).IsNDTrick() && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                room.SendCompulsoryTriggerLog(ask_who, Name);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                use.Cancelable = false;
                data = use;
            }
            return false;
        }
    }

    public class ZhenluePro : ProhibitSkill
    {
        public ZhenluePro() : base("#zhenlue") { }

        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if (card != null && to != null && RoomLogic.PlayerHasShownSkill(room, to, this))
            {
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                if (fcard is DelayedTrick) return true;
            }

            return false;
        }
    }

    public class Jianshu : TriggerSkill
    {
        public Jianshu() : base("jianshu")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            view_as_skill = new JianshuVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is PhaseChangeStruct change && change.From == PlayerPhase.Play)
                player.SetMark(Name, 0);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class JianshuVS : OneCardViewAsSkill
    {
        public JianshuVS() : base("jianshu")
        {
            filter_pattern = ".|black|.|hand";
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => player.GetMark(Name) >= player.UsedTimes(JianshuCard.ClassName);
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard js = new WrappedCard(JianshuCard.ClassName);
            js.AddSubCard(card);
            return js;
        }
    }

    public class JianshuCard : SkillCard
    {
        public static string ClassName = "JianshuCard";
        public JianshuCard() : base(ClassName) { will_throw = false; }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (to_select == Self || targets.Count >= 2) return false;
            if (targets.Count == 1) return RoomLogic.CanBePindianBy(room, to_select, targets[0]);
            return true;
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            return targets.Count == 2;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            room.NotifySkillInvoked(player, "jianshu");
            room.BroadcastSkillInvoke("jianshu", card_use.From, card_use.Card.SkillPosition);
            List<Player> targets = new List<Player>(card_use.To);
            room.SortByActionOrder(ref targets);

            LogMessage log = new LogMessage("#UseCard")
            {
                From = player.Name,
                To = new List<string>(),
                Card_str = RoomLogic.CardToString(room, card_use.Card)
            };
            log.SetTos(targets);

            RoomThread thread = room.RoomThread;
            object data = card_use;
            thread.Trigger(TriggerEvent.PreCardUsed, room, player, ref data);

            room.SendLog(log);

            room.RoomThread.Trigger(TriggerEvent.CardUsedAnnounced, room, player, ref data);
            room.RoomThread.Trigger(TriggerEvent.CardTargetAnnounced, room, player, ref data);

            room.RoomThread.Trigger(TriggerEvent.CardUsed, room, player, ref data);
            room.RoomThread.Trigger(TriggerEvent.CardFinished, room, player, ref data);
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            Player from = card_use.To[0], to = card_use.To[1];
            List<int> ids = new List<int>(card_use.Card.SubCards);
            room.ObtainCard(from, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, from.Name, "jianshu", string.Empty), false);

            bool dead = false;
            if (!from.IsKongcheng() && RoomLogic.CanBePindianBy(room, to, from))
            {
                PindianStruct pd = room.PindianSelect(from, to, "jianshu");
                room.Pindian(ref pd);
                if (pd.From_number > pd.To_numbers[0])
                {
                    if (from.Alive && !from.IsNude())
                    {
                        List<int> discard = room.ForceToDiscard(from, from.GetCards("he"), 1, true);
                        if (discard.Count > 0)
                            room.ThrowCard(ref discard, from);
                    }
                    if (to.Alive)
                    {
                        room.LoseHp(to);
                        if (!to.Alive) dead = true;
                    }
                }
                else if (pd.To_numbers[0] > pd.From_number)
                {
                    if (to.Alive && !to.IsNude())
                    {
                        List<int> discard = room.ForceToDiscard(to, to.GetCards("he"), 1, true);
                        if (discard.Count > 0)
                            room.ThrowCard(ref discard, to);
                    }
                    if (from.Alive)
                    {
                        room.LoseHp(from);
                        if (!from.Alive) dead = true;
                    }
                }
                else
                {
                    if (from.Alive)
                    {
                        room.LoseHp(from);
                        if (!from.Alive) dead = true;
                    }
                    if (to.Alive)
                    {
                        room.LoseHp(to);
                        if (!to.Alive) dead = true;
                    }
                }
            }
            if (player.Alive && dead)
                player.AddMark("jianshu");
        }
    }

    public class Yongdi : TriggerSkill
    {
        public Yongdi() : base("yongdi")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Recover;
            frequency = Frequency.Limited;
            limit_mark = "@yongdi";
        }
        
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.RoundStart && player.GetMark(limit_mark) > 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (p.IsMale()) targets.Add(p);

            Player target = room.AskForPlayerChosen(player, targets, Name, "@yongdi-give", true, true, info.SkillPosition);
            if (target != null)
            {
                room.SetPlayerMark(player, limit_mark, 0);
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.DoSuperLightbox(player, info.SkillPosition, Name);

                room.SetTag(Name, target);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = (Player)room.GetTag(Name);
            room.RemoveTag(Name);
            if (target.Alive)
            {
                target.MaxHp++;
                room.BroadcastProperty(target, "MaxHp");

                LogMessage log = new LogMessage
                {
                    Type = "$GainMaxHp",
                    From = target.Name,
                    Arg = "1"
                };
                room.SendLog(log);

                room.RoomThread.Trigger(TriggerEvent.MaxHpChanged, room, target);

                if (target.Alive && target.IsWounded())
                {
                    RecoverStruct recover = new RecoverStruct
                    {
                        Who = player,
                        Recover = 1
                    };
                    room.Recover(target, recover, true);
                }

                if (target.Alive && target.GetRoleEnum() != PlayerRole.Lord)
                {
                    foreach (string skill_name in Engine.GetGeneralSkills(target.General1, room.Setting.GameMode, true))
                    {
                        Skill s = Engine.GetSkill(skill_name);
                        if (s.LordSkill)
                        {
                            room.AddPlayerSkill(target, skill_name);
                            if (s != null && s.SkillFrequency == Frequency.Limited && !string.IsNullOrEmpty(s.LimitMark))
                                room.SetPlayerMark(target, s.LimitMark, 1);

                            object _data = new InfoStruct() { Info = skill_name, Head = true };
                            room.RoomThread.Trigger(TriggerEvent.EventAcquireSkill, room, target, ref _data);
                        }
                    }
                }
            }

            return false;
        }
    }

    public class Lingren : TriggerSkill
    {
        public Lingren() : base("lingren")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.EventPhaseStart, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Wizzard;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.RoundStart && player.GetMark(Name) > 0)
            {
                player.SetMark(Name, 0);
                room.HandleAcquireDetachSkills(player, "-jianxiong_jx|-xingshang", true);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.HasFlag(Name))
                player.SetFlags("-lingren");
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && player.Phase == PlayerPhase.Play && base.Triggerable(player, room) && !player.HasFlag(Name))
            {
                if (use.Card.Name.Contains(Slash.ClassName) || use.Card.Name == FireAttack.ClassName || use.Card.Name == Duel.ClassName
                    || use.Card.Name == SavageAssault.ClassName || use.Card.Name == ArcheryAttack.ClassName)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                Player target = null;
                room.SetTag(Name, data);
                if (use.To.Count == 1)
                {
                    if (room.AskForSkillInvoke(player, Name, use.To[0], info.SkillPosition))
                        target = use.To[0];
                }
                else
                {
                    target = room.AskForPlayerChosen(player, use.To, Name, "@lingren", true, true, info.SkillPosition);
                }
                room.RemoveTag(Name);

                if (target != null)
                {
                    player.SetFlags(Name);
                    room.SetTag(Name, target);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && room.GetTag(Name) is Player target)
            {
                int correct = 0;
                if (target.IsKongcheng())
                {
                    correct = 3;
                }
                else
                {
                    bool basic = false, equip = false, trick = false;
                    foreach (int id in target.GetCards("h"))
                    {
                        FunctionCard card = Engine.GetFunctionCard(room.GetCard(id).Name);
                        switch (card.TypeID)
                        {
                            case CardType.TypeBasic:
                                basic = true;
                                break;
                            case CardType.TypeEquip:
                                equip = true;
                                break;
                            case CardType.TypeTrick:
                                trick = true;
                                break;
                        }
                    }

                    player.SetFlags("lingren_basic");
                    string basic_choice = room.AskForChoice(player, Name, "has+nohas", new List<string> { "@lingren-basic:" + target.Name }, target, info.SkillPosition);
                    player.SetFlags("-lingren_basic");

                    if ((basic_choice == "has" && basic) || (basic_choice != "has" && !basic))
                        correct++;

                    player.SetFlags("lingren_equip");
                    string equip_choice = room.AskForChoice(player, Name, "has+nohas", new List<string> { "@lingren-equip:" + target.Name }, target, info.SkillPosition);
                    player.SetFlags("-lingren_equip");

                    if ((equip_choice == "has" && equip) || (equip_choice != "has" && !equip))
                        correct++;

                    player.SetFlags("lingren_trick");
                    string trick_choice = room.AskForChoice(player, Name, "has+nohas", new List<string> { "@lingren-trick:" + target.Name }, target, info.SkillPosition);
                    player.SetFlags("-lingren_trick");

                    if ((trick_choice == "has" && trick) || (trick_choice != "has" && !trick))
                        correct++;

                    LogMessage log = new LogMessage
                    {
                        Type = "#lingren-result",
                        From = player.Name,
                        To = new List<string> { target.Name },
                        Arg = Name,
                        Arg2 = correct.ToString()
                    };

                    room.SendLog(log);
                }

                if (correct > 0)
                {
                    foreach (CardBasicEffect effect in use.EffectCount)
                        if (effect.To == target) effect.Effect1++;
                }
                if (correct > 1)
                    room.DrawCards(player, 2, Name);
                if (correct > 2 && player.Alive)
                {
                    player.SetMark(Name, 1);
                    room.HandleAcquireDetachSkills(player, "jianxiong_jx|xingshang", true);
                }
            }

            return false;
        }
    }

    public class Fujian : TriggerSkill
    {
        public Fujian() : base("fujian")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Wizzard;
        }

        public override bool Triggerable(Player target, Room room)
        {
            if (base.Triggerable(target, room) && target.Phase == PlayerPhase.Finish)
                foreach (Player p in room.GetOtherPlayers(target))
                    if (!p.IsKongcheng()) return true;

            return false;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            int min = 1000;
            foreach (Player p in room.GetAlivePlayers())
                if (p.HandcardNum < min) min = p.HandcardNum;

            if (min > 0)
            {
                List<Player> targets = room.GetOtherPlayers(player);
                Shuffle.shuffle(ref targets);
                Player target = targets[0];

                List<int> ids = target.GetCards("h"), views = new List<int>(); ;
                Shuffle.shuffle(ref ids);
                for (int i = 0; i < Math.Min(min, ids.Count); i++)
                    views.Add(ids[i]);

                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                room.DoGongxin(player, target, views, new List<int>(), Name, "@to-player:" + target.Name, info.SkillPosition);
            }

            return false;
        }
    }

    public class Juesi : OneCardViewAsSkill
    {
        public Juesi() : base("juesi") { skill_type = SkillType.Attack; filter_pattern = "Slash!"; }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard js = new WrappedCard(JuesiCard.ClassName) { Skill = Name };
            js.AddSubCard(card);
            return js;
        }
    }

    public class JuesiCard : SkillCard
    {
        public static string ClassName = "JuesiCard";
        public JuesiCard() : base(ClassName) { }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self && RoomLogic.InMyAttackRange(room, Self, to_select, card) && RoomLogic.CanDiscard(room, to_select, to_select, "he");
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            List<int> ids = target.GetCards("he");
            if (ids.Count > 1)
                ids = room.AskForExchange(target, "juesi", 1, 1, "@juesi:" + player.Name, string.Empty, "..!", string.Empty);
            
            if (ids.Count > 0)
            {
                bool slash = room.GetCard(ids[0]).Name.Contains(Slash.ClassName);
                room.ThrowCard(ref ids, target);

                if (!slash && player.Alive && target.Alive && player.Hp <= target.Hp)
                {
                    WrappedCard duel = new WrappedCard(Duel.ClassName) { Skill = "_juesi" };
                    if (RoomLogic.IsProhibited(room, player, target, duel) == null)
                        room.UseCard(new CardUseStruct(duel, player, target));
                }
            }
        }
    }

    public class Qingzhong : TriggerSkill
    {
        public Qingzhong() : base("qingzhong")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Replenish;
        }
        public override bool Triggerable(Player target, Room room)
        {
            return base.Triggerable(target, room) && target.Phase == PlayerPhase.Play;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, null, info.SkillPosition))
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            player.SetTag(Name, info.SkillPosition);
            player.SetFlags(Name);
            room.DrawCards(player, 2, Name);
            return false;
        }
    }
    public class QingzhongExchange : TriggerSkill
    {
        public QingzhongExchange() : base("#qingzhong")
        {
            events.Add(TriggerEvent.EventPhaseEnd);
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Play && player.HasFlag("qingzhong") && player.GetTag("qingzhong") is string position)
            {
                if (!player.IsKongcheng())
                {
                    TriggerStruct trigger = new TriggerStruct(Name, player)
                    {
                        SkillPosition = position
                    };
                    return trigger;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            player.SetFlags("-qingzhong");
            player.RemoveTag("qingzhong");
            int less = 100000;
            foreach (Player p in room.GetAlivePlayers())
                if (p.HandcardNum < less) less = p.HandcardNum;

            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (p.HandcardNum == less) targets.Add(p);

            if (targets.Count > 0)
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "qingzhong", info.SkillPosition);
                room.BroadcastSkillInvoke("qingzhong", "male", 2, gsk.General, gsk.SkinId);

                bool option = player.HandcardNum == less;
                Player target = room.AskForPlayerChosen(player, targets, "qingzhong", "@qingzhong", option, true, info.SkillPosition);
                if (target != null)
                {
                    CardsMoveStruct move1 = new CardsMoveStruct(player.GetCards("h"), target, Place.PlaceHand,
                        new CardMoveReason(MoveReason.S_REASON_SWAP, player.Name, target.Name, "qingzhong", null));
                    CardsMoveStruct move2 = new CardsMoveStruct(target.GetCards("h"), player, Place.PlaceHand,
                        new CardMoveReason(MoveReason.S_REASON_SWAP, target.Name, player.Name, "qingzhong", null));
                    List<CardsMoveStruct> exchangeMove = new List<CardsMoveStruct> { move1, move2 };
                    room.MoveCards(exchangeMove, false);
                }
            }

            return false;
        }
    }

    public class Weijing : ZeroCardViewAsSkill
    {
        public Weijing() : base("weijing") { }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return player.GetMark(Name) < room.Round && Slash.IsAvailable(room, player);
        }

        public override bool IsEnabledAtResponse(Room room, Player player, FunctionCard.RespondType respond, string pattern)
        {
            if (player.GetMark(Name) >= room.Round || room.GetRoomState().GetCurrentCardUseReason() != CardUseReason.CARD_USE_REASON_RESPONSE_USE) return false;
            return MatchSlash(respond) || MatchJink(respond);
        }
        public override WrappedCard ViewAs(Room room, Player player)
        {
            if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_PLAY)
                return new WrappedCard(WeijingCard.ClassName) { UserString = Slash.ClassName };
            else
            {
                string pattern = room.GetRoomState().GetCurrentCardUsePattern(player);
                WrappedCard slash = new WrappedCard(Slash.ClassName);
                WrappedCard jink = new WrappedCard(Jink.ClassName);
                if (Engine.MatchExpPattern(room, pattern, player, slash))
                    return new WrappedCard(WeijingCard.ClassName) { UserString = Slash.ClassName };
                else if (Engine.MatchExpPattern(room, pattern, player, jink))
                    return new WrappedCard(WeijingCard.ClassName) { UserString = Jink.ClassName };
            }

            return null;
        }
    }

    public class WeijingCard : SkillCard
    {
        public static string ClassName = "WeijingCard";
        public WeijingCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            WrappedCard real = new WrappedCard(card.UserString);
            FunctionCard fcard = Engine.GetFunctionCard(real.Name);
            return fcard.TargetFilter(room, targets, to_select, Self, real);
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            WrappedCard real = new WrappedCard(card.UserString);
            FunctionCard fcard = Engine.GetFunctionCard(real.Name);
            return fcard.TargetsFeasible(room, targets, Self, real);
        }

        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            WrappedCard real = new WrappedCard(use.Card.UserString) { Skill = "weijing", ShowSkill = "weijing" };
            use.From.SetMark("weijing", room.Round);
            return real;
        }

        public override WrappedCard ValidateInResponse(Room room, Player player, WrappedCard card)
        {
            WrappedCard real = new WrappedCard(card.UserString) { Skill = "weijing", ShowSkill = "weijing" };
            player.SetMark("weijing", room.Round);
            return real;
        }
    }

    public class Xingzhao : TriggerSkill
    {
        public Xingzhao() : base("xingzhao")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.EventPhaseChanging, TriggerEvent.DamageCaused };
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && base.Triggerable(player, room))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is EquipCard)
                {
                    int count = 0;
                    foreach (Player p in room.GetAlivePlayers())
                        if (p.IsWounded()) count++;

                    if (count >= 2)
                        return new TriggerStruct(Name, player);
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.Discard && base.Triggerable(player, room))
            {
                int count = 0;
                foreach (Player p in room.GetAlivePlayers())
                    if (p.IsWounded()) count++;

                if (count >= 3)
                    return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.DamageCaused && base.Triggerable(player, room))
            {
                int count = 0;
                foreach (Player p in room.GetAlivePlayers())
                    if (p.IsWounded()) count++;

                if (count >= 4 || count == 0)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            if (triggerEvent == TriggerEvent.CardUsed)
                room.DrawCards(player, 1, Name);
            else if (triggerEvent == TriggerEvent.DamageCaused && data is DamageStruct damage)
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
            else
                room.SkipPhase(player, PlayerPhase.Discard, true);

            return false;
        }
    }

    public class XingzhaoVH : ViewHasSkill
    {
        public XingzhaoVH() : base("#xingzhao") { viewhas_skills = new List<string> { "xunxun" }; }
        public override bool ViewHas(Room room, Player player, string skill_name)
        {
            if (RoomLogic.PlayerHasSkill(room, player, "xingzhao"))
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (p.IsWounded()) return true;
            }

            return false;
        }
    }

    public class Tuogu : TriggerSkill
    {
        public Tuogu() : base("tuogu")
        {
            events = new List<TriggerEvent> { TriggerEvent.Death, TriggerEvent.EventLoseSkill };
            //frequency = Frequency.Limited;
            //limit_mark = "@tuogu";
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name
                && player.ContainsTag(Name) && player.GetTag(Name) is string a_skill)
            {
                player.RemoveTag(Name);
                room.RemovePlayerStringMark(player, Name);
                room.HandleAcquireDetachSkills(player, "-" + a_skill, true);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.Death)
            {
                List<string> skills = Engine.GetGeneralSkills(player.General1, room.Setting.GameMode);
                skills.Remove("huashen");
                skills.Remove("xinsheng");
                List<string> checks = new List<string>(skills);
                foreach (string skill in checks)
                {
                    Skill _skill = Engine.GetSkill(skill);
                    if (_skill.LordSkill || _skill.SkillFrequency == Frequency.Limited || _skill.SkillFrequency == Frequency.Wake)
                        skills.Remove(skill);
                }

                if (skills.Count > 0)
                {
                    List<Player> css = RoomLogic.FindPlayersBySkillName(room, Name);
                    foreach (Player p in css)
                    {
                        //if (p != player && p.GetMark(limit_mark) > 0)
                        if (p != player) triggers.Add(new TriggerStruct(Name, p));
                    }
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition))
                return info;

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            room.NotifySkillInvoked(ask_who, Name);
            //room.DoSuperLightbox(ask_who, info.SkillPosition, Name);
            //room.RemovePlayerMark(ask_who, limit_mark);

            if (ask_who.ContainsTag(Name) && ask_who.GetTag(Name) is string a_skill)
            {
                ask_who.RemoveTag(Name);
                room.RemovePlayerStringMark(ask_who, Name);
                room.HandleAcquireDetachSkills(ask_who, "-" + a_skill, true);
            }

            if (ask_who.Alive)
            {
                List<string> skills = Engine.GetGeneralSkills(player.General1, room.Setting.GameMode);
                skills.Remove("huashen");
                skills.Remove("xinsheng");
                List<string> checks = new List<string>(skills);
                foreach (string skill in checks)
                {
                    Skill _skill = Engine.GetSkill(skill);
                    if (_skill.LordSkill || _skill.SkillFrequency == Frequency.Limited || _skill.SkillFrequency == Frequency.Wake)
                        skills.Remove(skill);
                }

                string choice = room.AskForSkill(player, Name, string.Join("+", skills), "@tuogu-from:" + ask_who.Name, 1, 1, false, info.SkillPosition);
                ask_who.SetTag(Name, choice);
                room.SetPlayerStringMark(ask_who, Name, choice);
                room.HandleAcquireDetachSkills(ask_who, choice, true);
            }

            return false;
        }
    }

    public class Shanzhuan : TriggerSkill
    {
        public Shanzhuan() : base("shanzhuan")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.EventPhaseStart, TriggerEvent.DamageDone };
            skill_type = SkillType.Attack;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.DamageDone && data is DamageStruct damage && damage.From != null && !damage.From.HasFlag(Name) && damage.From.Phase != PlayerPhase.NotActive)
                damage.From.SetFlags(Name);
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish && !player.HasFlag(Name) && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.Damage && base.Triggerable(player, room) && data is DamageStruct damage && damage.To.Alive && player != damage.To
                && damage.To.JudgingArea.Count == 0 && !damage.To.IsNude() && player.JudgingAreaAvailable)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            bool invoke = false;
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
            if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage)
            {
                if (room.AskForSkillInvoke(player, Name, damage.To, info.SkillPosition))
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, damage.To.Name);
                    room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                    invoke = true;
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                if (room.AskForSkillInvoke(player, Name, "@shanzhuan", info.SkillPosition))
                {
                    invoke = true;
                    room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                }
            }

            if (invoke) return info;

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
                room.DrawCards(player, 1, Name);
            else if (data is DamageStruct damage)
            {
                Player target = damage.To;
                int id = room.AskForCardChosen(player, target, "he", Name, false, HandlingMethod.MethodNone, null);
                WrappedCard card = room.GetCard(id);
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                if (!(fcard is DelayedTrick) || fcard is Lightning)
                {
                    WrappedCard trick = new WrappedCard(WrappedCard.IsBlack(RoomLogic.GetCardSuit(room, card)) ? SupplyShortage.ClassName : Indulgence.ClassName);
                    trick.AddSubCard(card);
                    trick = RoomLogic.ParseUseCard(room, trick);
                    //将卡牌转化为延时锦囊就相当于改写了该牌的牌名，必须对其重写以保证此延时锦囊将来可以正确生效
                    RoomCard wrapped = room.GetCard(trick.GetEffectiveId());
                    wrapped.TakeOver(trick);
                    card = wrapped.GetUsedCard();
                }

                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_TRANSFER, player.Name, target.Name, Name, string.Empty)
                {
                    Card = card
                };
                room.MoveCardTo(card, null, target, Place.PlaceDelayedTrick, reason, true);
            }

            return false;
        }
    }

    public class JixianZL : TriggerSkill
    {
        public JixianZL() : base("jixian_zl")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseEnd, TriggerEvent.DamageDone };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.DamageDone && data is DamageStruct damage && damage.Card != null && damage.Card.GetSkillName() == Name)
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (p.HasFlag(Name)) p.SetFlags("-jixian_zl");
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseEnd && base.Triggerable(player, room) && player.Phase == PlayerPhase.Draw)
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            WrappedCard slash = new WrappedCard(Slash.ClassName) { DistanceLimited = false };
            int count = Engine.GetGeneral(player.General1, room.Setting.GameMode).Skills.Count;
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (RoomLogic.IsProhibited(room, player, p, slash) == null && (p.GetArmor()
                    || p.GetLostHp() == 0 || Engine.GetGeneral(p.General1, room.Setting.GameMode).Skills.Count > count))
                    targets.Add(p);
            }

            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@jixian_zl", true, true, info.SkillPosition);
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

                WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_jixian_zl", DistanceLimited = false };
                int count = Engine.GetGeneral(player.General1, room.Setting.GameMode).Skills.Count;

                int draw = 0;
                if (target.HasEquip()) draw++;
                if (target.GetLostHp() == 0) draw++;
                if (Engine.GetGeneral(target.General1, room.Setting.GameMode).Skills.Count > count) draw++;

                player.SetFlags(Name);
                room.UseCard(new CardUseStruct(slash, player, target));

                if (player.Alive) room.DrawCards(player, draw, Name);
                if (player.Alive && player.HasFlag(Name)) room.LoseHp(player);
            }

            return false;
        }
    }

    public class Zengou : TriggerSkill
    {
        public Zengou() : base("zengou")
        {
            events = new List<TriggerEvent> { TriggerEvent.JinkEffect };
            skill_type = SkillType.Wizzard;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.JinkEffect && data is CardResponseStruct resp)
            {
                List<Player> chengyus = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in chengyus)
                {
                    if (p != player && RoomLogic.InMyAttackRange(room, p, player) && (p.Hp > 0 || !p.IsNude()))
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player p, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(p, Name, string.Format("@zengou:{0}", player.Name), info.SkillPosition))
            {
                List<int> ids = new List<int>();
                if (!p.IsNude())
                    ids = room.AskForExchange(p, Name, 1, p.Hp > 0 ? 0 : 1, string.Format("@zengou-discard:{0}", player.Name), string.Empty, "^BasicCard!", info.SkillPosition);

                room.BroadcastSkillInvoke(Name, p, info.SkillPosition);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, p.Name, player.Name);
                if (ids.Count == 0)
                    room.LoseHp(p);
                else
                    room.ThrowCard(ids[0], p, null, Name);

                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {

            LogMessage log = new LogMessage
            {
                Type = "#ShefuEffect",
                From = ask_who.Name,
                To = new List<string> { player.Name },
                Arg = Name,
                Arg2 = Jink.ClassName
            };
            room.SendLog(log);

            if (ask_who.Alive && data is CardResponseStruct resp)
            {
                List<int> ids = new List<int>();
                foreach (int id in resp.Card.SubCards)
                {
                    if (room.GetCardPlace(id) == Place.PlaceTable || room.GetCardPlace(id) == Place.DiscardPile)
                        ids.Add(id);
                }
                if (ids.Count > 0)
                    room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, ask_who.Name, Name, string.Empty));
            }

            return true;
        }
    }

    public class Changji : TriggerSkill
    {
        public Changji() : base("changji")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.Damaged, TriggerEvent.EventPhaseStart };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Damage)
                player.SetFlags("changji_damage");
            else if (triggerEvent == TriggerEvent.Damaged)
                player.SetFlags("changji_damaged");
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player != null && player.Alive && player.Phase == PlayerPhase.Finish)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p.HasFlag("changji_damage") || (p != player && p.HasFlag("changji_damaged")))
                        triggers.Add(new TriggerStruct(Name, p));
            }
            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (ask_who.HasFlag("changji_damage") && room.AskForSkillInvoke(ask_who, Name, "@changji-draw:" + player.Name, info.SkillPosition))
            {
                ask_who.SetFlags("changji_draw");
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }
            else if (ask_who.HasFlag("changji_damaged") && player != ask_who && !player.IsNude() && RoomLogic.CanDiscard(room, player, player, "he")
                && room.AskForSkillInvoke(ask_who, Name, "@changji-discard:" + player.Name, info.SkillPosition))
            {
                ask_who.SetFlags("changji_discard");
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (ask_who.HasFlag("changji_draw"))
            {
                room.DrawCards(player, new DrawCardStruct(2, ask_who, Name));
                if (ask_who.Alive && ask_who.HasFlag("changji_damaged") && player.Alive && player != ask_who && !player.IsNude() && RoomLogic.CanDiscard(room, player, player, "he")
                    && room.AskForSkillInvoke(ask_who, Name, "@changji-discard:" + player.Name, info.SkillPosition))
                {
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    room.AskForDiscard(player, Name, 2, 2, false, true, "@changji-from:" + ask_who.Name, false);
                }
            }
            else
            {
                room.AskForDiscard(player, Name, 2, 2, false, true, "@changji-from:" + ask_who.Name, false);
                if (ask_who.Alive && ask_who.HasFlag("changji_damage") && room.AskForSkillInvoke(ask_who, Name, "@changji-draw:" + player.Name, info.SkillPosition))
                {
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    room.DrawCards(player, new DrawCardStruct(2, ask_who, Name));
                }
            }

            return false;
        }
    }

    public class Yuanzhi : TriggerSkill
    {
        public Yuanzhi() : base("yuanzhi")
        {
            events = new List<TriggerEvent> { TriggerEvent.RoundStart, TriggerEvent.EventPhaseStart, TriggerEvent.Damage, TriggerEvent.EventPhaseChanging };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.RoundStart)
            {
                foreach (Player p in room.GetAlivePlayers())
                    p.SetMark(Name, 0);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                player.RemoveTag(Name);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if  (triggerEvent == TriggerEvent.EventPhaseStart && player != null && player.Alive && player.Phase == PlayerPhase.Start)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p != player && !p.IsKongcheng() && p.GetMark(Name) == 0)
                        triggers.Add(new TriggerStruct(Name, p));
            }
            else if (triggerEvent == TriggerEvent.Damage && player != null && player.ContainsTag(Name) && player.GetTag(Name) is List<string> froms)
            {
                foreach (string from_name in froms)
                {
                    Player from = room.FindPlayer(from_name);
                    if (from != null && player.HandcardNum >= from.HandcardNum)
                        triggers.Add(new TriggerStruct(Name, from));
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition))
            {
                ask_who.AddMark(Name);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                return info;
            }
            else if (triggerEvent == TriggerEvent.Damage && room.AskForSkillInvoke(ask_who, Name, data, info.SkillPosition))
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                List<int> ids = ask_who.GetCards("h");
                room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, ask_who.Name, player.Name, Name, string.Empty), false);
                if (ask_who.Alive && player.Alive)
                {
                    List<string> froms = player.ContainsTag(Name) ? (List<string>)player.GetTag(Name) : new List<string>();
                    froms.Add(ask_who.Name);
                    player.SetTag(Name, froms);
                }
            }
            else
                room.DrawCards(ask_who, 2, Name);

            return false;
        }
    }

    public class Liejie : TriggerSkill
    {
        public Liejie() : base("liejie")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged, TriggerEvent.CardsMoveOneTime };
            skill_type = SkillType.Masochism;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To_place == Place.DiscardPile && move.Reason.Reason == MoveReason.S_REASON_THROW
                && move.Reason.SkillName == Name && move.From != null && move.From.Alive)
            {
                int count = 0;
                foreach (int id in move.Card_ids)
                    if (WrappedCard.IsRed(room.GetCard(id).Suit))
                        count++;

                List<int> ids = move.From.ContainsTag(Name) ? (List<int>)move.From.GetTag(Name) : new List<int>();
                ids.Add(move.Card_ids.Count);
                ids.Add(count);
                move.From.SetTag(Name, ids);
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && base.Triggerable(player, room) && !player.IsNude())
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForDiscard(player, Name, 3, 1, true, true, "@liejie", true, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage && player.Alive && player.GetTag(Name) is List<int> ids && ids.Count >= 2)
            {
                int draw = ids[0];
                ids.RemoveAt(0);
                int count = ids[0];
                ids.RemoveAt(0);

                if (ids.Count == 0)
                    player.RemoveTag(Name);
                else
                    player.SetTag(Name, ids);

                room.DrawCards(player, draw, Name);
                if (damage.From != null && damage.From.Alive && count > 0 && !damage.From.IsNude() && RoomLogic.CanDiscard(room, player, damage.From, "he") && room.AskForSkillInvoke(player, Name, damage.From, info.SkillPosition))
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, damage.From.Name);
                    List<int> cards = room.AskForCardsChosen(player, damage.From, "he", Name, 1, count, false, HandlingMethod.MethodDiscard);
                    room.ThrowCard(ref cards, damage.From, player);
                }
            }
            return false;
        }
    }

    public class KanpoDZ : TriggerSkill
    {
        public KanpoDZ() : base("kanpo_dz")
        {
            events.Add(TriggerEvent.Damage);
            view_as_skill = new KanpoDZVS();
            skill_type = SkillType.Attack;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DamageStruct damage && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName) && !damage.Chain
                && !damage.Transfer && damage.To.Alive && !damage.To.IsKongcheng())
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage && room.AskForSkillInvoke(player, Name, damage.To, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, damage.To.Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                Player target = damage.To;
                List<int> ids = new List<int>();
                foreach (int id in target.GetCards("h"))
                    if (room.GetCard(id).Suit == damage.Card.Suit)
                        ids.Add(id);

                target.SetFlags("gongxin_target");
                int result = room.DoGongxin(player, target, target.GetCards("h"), ids, Name,
                    string.Format("@kanpo_dz:{0}::{1}", target.Name, WrappedCard.GetSuitString(damage.Card.Suit)), info.SkillPosition);
                target.SetFlags("-gongxin_target");

                if (result != -1)
                    room.ObtainCard(player, room.GetCard(result), new CardMoveReason(MoveReason.S_REASON_EXTRACTION, player.Name, target.Name, Name, string.Empty));
            }

            return false;
        }
    }

    public class KanpoDZVS : OneCardViewAsSkill
    {
        public KanpoDZVS() : base("kanpo_dz")
        {
            response_or_use = true;
            filter_pattern = ".";
        }

        public override bool IsEnabledAtPlay(Room room, Player player)=> Slash.IsAvailable(room, player) && player.UsedTimes("ViewAsSkill_kanpo_dzCard") < 1;
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
            => MatchSlash(respond) && room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE && player.UsedTimes("ViewAsSkill_kanpo_dzCard") < 1;

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = Name };
            slash.AddSubCard(card);
            return slash;
        }
    }

    public class Genzhan : TriggerSkill
    {
        public Genzhan() : base("genzhan")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.CardsMoveOneTime, TriggerEvent.CardUsed, TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change)
            {
                if (change.To == PlayerPhase.NotActive)
                {
                    player.SetMark(Name, 0);
                    room.RemovePlayerStringMark(player, Name);
                }
                if (change.From == PlayerPhase.Play)
                {
                    foreach (Player p in room.GetOtherPlayers(player))
                        p.SetFlags("-genzhan");
                }
            }
            else if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName))
                player.SetFlags("genzhan_slash");
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> result = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To_place == Place.DiscardPile && 
                (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && room.Current != null && room.Current.Phase == PlayerPhase.Play)
            {
                List<int> ids = new List<int>();
                foreach (int id in move.Card_ids)
                    if (room.GetCard(id).Name.Contains(Slash.ClassName) && room.GetCardPlace(id) == Place.DiscardPile) ids.Add(id);

                if (ids.Count > 0)
                {
                    List<Player> caozhi = RoomLogic.FindPlayersBySkillName(room, Name);
                    foreach (Player p in caozhi)
                        if (p != room.Current && !p.HasFlag(Name)) result.Add(new TriggerStruct(Name, p));
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish && !player.HasFlag("genzhan_slash"))
            {
                List<Player> caozhi = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in caozhi)
                    if (p != player) result.Add(new TriggerStruct(Name, p));
            }

            return result;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move)
            {
                List<int> ids = new List<int>();
                foreach (int id in move.Card_ids)
                    if (room.GetCard(id).Name.Contains(Slash.ClassName) && room.GetCardPlace(id) == Place.DiscardPile) ids.Add(id);

                if (ids.Count > 0)
                {
                    AskForMoveCardsStruct ly = room.AskForMoveCards(ask_who, new List<int>(), ids, false, Name, ids.Count, ids.Count, true, true, new List<int>(), info.SkillPosition);
                    if (ly.Success && ly.Bottom.Count > 0)
                    {
                        ask_who.SetFlags(Name);
                        ask_who.SetTag(Name, ly.Bottom);
                        room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                        room.NotifySkillInvoked(ask_who, Name);
                        return info;
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.NotifySkillInvoked(ask_who, Name);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime)
            {
                List<int> ids = (List<int>)ask_who.GetTag(Name);
                ask_who.RemoveTag(Name);
                room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, ask_who.Name, Name, string.Empty));
            }
            else
            {
                ask_who.AddMark(Name);
                room.SetPlayerStringMark(ask_who, Name, ask_who.GetMark(Name).ToString());
            }
            return false;
        }
    }

    public class GenzhanTar : TargetModSkill
    {
        public GenzhanTar() : base("#genzhan", false) { }
        public override int GetResidueNum(Room room, Player from, WrappedCard card) => from.GetMark("genzhan");
    }
    public class Tianming : TriggerSkill
    {
        public Tianming() : base("tianming")
        {
            events.Add(TriggerEvent.TargetConfirmed);
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is CardUseStruct use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash)
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
            room.AskForDiscard(player, Name, 2, 2, false, true, "@tianming", false, info.SkillPosition);
            room.DrawCards(player, 2, Name);

            int hp = 0;
            foreach (Player p in room.GetAlivePlayers())
                if (p.Hp > hp)
                    hp = p.Hp;

            List<Player> players = new List<Player>();
            foreach (Player p in room.GetAlivePlayers())
                if (p.Hp == hp) players.Add(p);

            if (players.Count == 1 && players[0] != player && room.AskForSkillInvoke(players[0], Name, "@tianming-disacard"))
            {
                room.AskForDiscard(players[0], Name, 2, 2, false, true, "@tianming", false, info.SkillPosition);
                room.DrawCards(players[0], 2, Name);
            }

            return false;
        }
    }

    public class WangxiJx : TriggerSkill
    {
        public WangxiJx() : base("wangxi_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.Damaged };
            skill_type = SkillType.Replenish;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DamageStruct damage)
            {
                Player target = null;
                if (triggerEvent == TriggerEvent.Damage)
                    target = damage.To;
                else
                    target = damage.From;
                if (target != null && target.Alive && target != player && !target.HasFlag("Global_DFDebut"))
                {

                    TriggerStruct trigger = new TriggerStruct(Name, player)
                    {
                        Times = damage.Damage
                    };
                    return trigger;
                }
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            DamageStruct damage = (DamageStruct)data;
            Player target = null;
            if (triggerEvent == TriggerEvent.Damage)
                target = damage.To;
            else
                target = damage.From;
            if (room.AskForSkillInvoke(player, Name, target, info.SkillPosition))
            {
                room.DoAnimate(CommonClassLibrary.AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", (triggerEvent == TriggerEvent.Damage) ? 2 : 1, gsk.General, gsk.SkinId);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            DamageStruct damage = (DamageStruct)data;
            Player target = null;
            if (triggerEvent == TriggerEvent.Damage)
                target = damage.To;
            else
                target = damage.From;

            room.DrawCards(player, 2, Name);
            if (player.Alive && !player.IsNude() && target.Alive)
            {
                List<int> ids = room.AskForExchange(player, Name, 1, 1, string.Format("@wangxi_jx:{0}", target.Name), string.Empty, "..", info.SkillPosition);
                room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty), false);
            }
            return false;
        }
    }

    public class Mizhao : ZeroCardViewAsSkill
    {
        public Mizhao() : base("mizhao")
        {
            skill_type = SkillType.Wizzard;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.IsKongcheng() && !player.HasUsed(MizhaoCard.ClassName);
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard card = new WrappedCard(MizhaoCard.ClassName)
            {
                Skill = Name,
                ShowSkill = Name
            };
            card.AddSubCards(player.GetCards("h"));
            return card;
        }
    }

    public class MizhaoCard : SkillCard
    {
        public static string ClassName = "MizhaoCard";
        public MizhaoCard() : base(ClassName) { will_throw = false; }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (to_select == Self || targets.Count >= 2) return false; ;
            if (targets.Count == 1) return RoomLogic.CanBePindianBy(room, to_select, targets[0]);
            return true;
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            return targets.Count == 2;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;

            ResultStruct result = card_use.From.Result;
            result.Assist += card_use.Card.SubCards.Count;
            card_use.From.Result = result;

            List<Player> targets = new List<Player>(card_use.To);
            room.SortByActionOrder(ref targets);
            
            LogMessage log = new LogMessage("#UseCard")
            {
                From = player.Name,
                To = new List<string>(),
                Card_str = RoomLogic.CardToString(room, card_use.Card)
            };
            log.SetTos(targets);

            RoomThread thread = room.RoomThread;
            object data = card_use;
            thread.Trigger(TriggerEvent.PreCardUsed, room, player, ref data);

            room.SendLog(log);

            room.RoomThread.Trigger(TriggerEvent.CardUsedAnnounced, room, player, ref data);
            room.RoomThread.Trigger(TriggerEvent.CardTargetAnnounced, room, player, ref data);

            room.RoomThread.Trigger(TriggerEvent.CardUsed, room, player, ref data);
            room.RoomThread.Trigger(TriggerEvent.CardFinished, room, player, ref data);
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            Player from = card_use.To[0], to = card_use.To[1];
            List<int> ids = new List<int>(card_use.Card.SubCards);
            room.ObtainCard(from, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, from.Name, "mizhao", string.Empty), false);

            if (!from.IsKongcheng() && RoomLogic.CanBePindianBy(room, to, from))
            {
                PindianStruct pd = room.PindianSelect(from, to, "mizhao");
                room.Pindian(ref pd);
                WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_mizhao" };
                if (pd.From_number > pd.To_numbers[0])
                {
                    if (RoomLogic.IsProhibited(room, from, to, slash) == null)
                        room.UseCard(new CardUseStruct(slash, from, to));
                }
                else if (pd.To_numbers[0] > pd.From_number)
                {
                    if (RoomLogic.IsProhibited(room, to, from, slash) == null)
                        room.UseCard(new CardUseStruct(slash, to, from));
                }
            }
        }
    }


    public class YongsiJX : TriggerSkill
    {
        public YongsiJX() : base("yongsi_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.EventPhaseChanging, TriggerEvent.EventPhaseStart };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && damage.From != null && damage.From.Alive && damage.From.Phase != PlayerPhase.NotActive)
                damage.From.AddMark(Name, damage.Damage);
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetMark(Name) > 0)
                player.SetMark(Name, 0);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Draw && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Discard && base.Triggerable(player, room))
            {
                if ((player.GetMark(Name) == 0 && player.HandcardNum < player.Hp) || player.GetMark(Name) > 1)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Draw)
            {
                room.DrawCards(player, Fuli.GetKingdoms(room), Name);
                return true;
            }
            else
            {
                if (player.GetMark(Name) == 0 && player.HandcardNum < player.Hp)
                    room.DrawCards(player, player.Hp - player.HandcardNum, Name);
            }

            return false;
        }
    }

    public class YongsiMax : MaxCardsSkill
    {
        public YongsiMax() : base("#yongsi-max") { }

        public override int GetFixed(Room room, Player target)
        {
            if (RoomLogic.PlayerHasShownSkill(room, target, "yongsi_jx") && target.GetMark("yongsi_jx") > 1)
                return target.GetLostHp();

            return -1;
        }
    }

    public class WeidiJXCard : SkillCard
    {
        public static string ClassName = "WeidiJXCard";
        public WeidiJXCard() : base(ClassName)
        {
            will_throw = false;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && !to_select.HasFlag("weidi_jx") && to_select != Self && to_select.Kingdom == "qun";
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            card_use.From.SetTag("lirang_target", card_use.To[0].Name);
        }
    }
    public class WeidiViewAsSkill : OneCardViewAsSkill
    {
        public WeidiViewAsSkill() : base("weidi_jx")
        {
            expand_pile = "#weidi_jx";
            response_pattern = "@@weidi_jx";
        }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            return player.GetPile(expand_pile).Contains(to_select.Id);
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard Lirang_card = new WrappedCard(WeidiJXCard.ClassName);
            Lirang_card.AddSubCard(card);
            return Lirang_card;
        }
    }

    public class WeidiJX : TriggerSkill
    {
        public WeidiJX() : base("weidi_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseEnd, TriggerEvent.CardsMoveOneTime };
            skill_type = SkillType.Replenish;
            view_as_skill = new WeidiViewAsSkill();
            lord_skill = true;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.From.Phase == PlayerPhase.Discard
                && move.From == room.Current && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD
                && move.To_place == Place.DiscardPile && base.Triggerable(move.From, room))
            {
                List<int> guzhengToGet = move.From.ContainsTag("WeidiToGet") ? (List<int>)move.From.GetTag("WeidiToGet") : new List<int>();
                foreach (int card_id in move.Card_ids)
                {
                    if (!guzhengToGet.Contains(card_id))
                        guzhengToGet.Add(card_id);
                }

                move.From.SetTag("WeidiToGet", guzhengToGet);
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseEnd && player.Phase == PlayerPhase.Discard && base.Triggerable(player, room))
            {
                List<int> cardsToGet = player.ContainsTag("WeidiToGet") ? (List<int>)player.GetTag("WeidiToGet") : new List<int>();
                foreach (int id in cardsToGet)
                    if (room.GetCardPlace(id) == Place.DiscardPile)
                        return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> cardsToGet = player.ContainsTag("WeidiToGet") ? (List<int>)player.GetTag("WeidiToGet") : new List<int>();
            List<int> cards = new List<int>();
            foreach (int id in cardsToGet)
                if (room.GetCardPlace(id) == Place.DiscardPile)
                    cards.Add(id);

            List<CardsMoveStruct> lirangs = new List<CardsMoveStruct>();
            while (cards.Count > 0)
            {
                player.PileChange("#" + Name, cards);
                WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@weidi_jx", "@weidi-distribute", null, -1, HandlingMethod.MethodNone, true, info.SkillPosition);
                player.PileChange("#" + Name, cards, false);

                if (card != null && card.SubCards.Count > 0)
                {
                    Player target = room.FindPlayer((string)player.GetTag("lirang_target"), true);
                    target.SetFlags(Name);
                    player.RemoveTag("lirang_target");
                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_PREVIEWGIVE, player.Name, target.Name, Name, null);
                    CardsMoveStruct moves = new CardsMoveStruct(card.SubCards, target, Place.PlaceHand, reason);
                    lirangs.Add(moves);
                    foreach (int id in card.SubCards)
                        cards.Remove(id);
                }
                else
                    cards.Clear();
            }

            foreach (Player p in room.GetAlivePlayers())
                p.SetFlags("-weidi_jx");

            if (lirangs.Count > 0)
            {
                room.SetTag(Name, lirangs);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            else
                return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player p, ref object data, Player player, TriggerStruct info)
        {
            List<CardsMoveStruct> lirangs = (List<CardsMoveStruct>)room.GetTag(Name);
            player.RemoveTag(Name);
            List<CardsMoveStruct> moves = new List<CardsMoveStruct>();
            List<Player> targets = new List<Player>();
            foreach (CardsMoveStruct move_struct in lirangs)
            {
                List<int> ids = move_struct.Card_ids;
                for (int i = 0; i < ids.Count; i++)
                {
                    int card_id = ids[i];
                    if (room.GetCardPlace(card_id) != Place.DiscardPile)
                        move_struct.Card_ids.Remove(card_id);
                }
                if (move_struct.Card_ids.Count > 0)
                {
                    moves.Add(move_struct);
                    Player target = room.FindPlayer(move_struct.To);
                    if (!targets.Contains(target))
                        targets.Add(target);
                }
            }

            if (moves.Count > 0)
            {
                LogMessage l = new LogMessage
                {
                    Type = "#ChoosePlayerWithSkill",
                    From = player.Name,
                    Arg = Name
                };
                l.SetTos(targets);
                room.SendLog(l);

                room.MoveCardsAtomic(moves, true);
            }

            return false;
        }
    }
    public class WeidiRemove : TriggerSkill
    {
        public WeidiRemove() : base("#weidi-remove")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseEnd };
        }
        public override int Priority => 0;
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (player != null && player.Phase == PlayerPhase.Discard && player.ContainsTag("WeidiToGet"))
                player.RemoveTag("WeidiToGet");
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return new TriggerStruct();
        }
    }

    public class LihunVS : OneCardViewAsSkill
    {
        public LihunVS() : base("lihun")
        {
            filter_pattern = "..!";
            skill_type = SkillType.Wizzard;
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return room.GetAlivePlayers().Count > 2
                && RoomLogic.CanDiscard(room, player, player, "he") && !player.HasUsed(LihunCard.ClassName);
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard lijian_card = new WrappedCard(LihunCard.ClassName)
            {
                Skill = Name,
                ShowSkill = Name,
                Mute = true
            };
            lijian_card.AddSubCard(card);
            return lijian_card;
        }
    }

    public class LihunCard : SkillCard
    {
        public static string ClassName = "LihunCard";
        public LihunCard() : base(ClassName)
        {
            will_throw = true;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self && to_select.IsMale() && !to_select.IsKongcheng();
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];

            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "lihun", card_use.Card.SkillPosition);
            room.BroadcastSkillInvoke("lihun", "male", 1, gsk.General, gsk.SkinId);

            room.TurnOver(player);
            List<int> ids = target.GetCards("h");
            room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_EXTRACTION, player.Name, target.Name, "lihun", string.Empty), false);

            player.SetTag("lihun", target.Name);
            player.SetTag("lihun_position", card_use.Card.SkillPosition);
        }
    }

    public class Lihun : TriggerSkill
    {
        public Lihun() : base("lihun")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseEnd };
            skill_type = SkillType.Wizzard;
            view_as_skill = new LihunVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (player.Phase == PlayerPhase.Play && player.ContainsTag(Name))
            {
                Player target = room.FindPlayer(player.GetTag(Name).ToString(), true);
                player.RemoveTag(Name);
                if (player.Alive && !player.IsNude() && target.Alive && target.Hp > 0)
                {
                    List<int> ids = new List<int>();
                    if (player.GetCardCount(true) < target.Hp)
                        ids = player.GetCards("he");
                    else
                        ids = room.AskForExchange(player, Name, target.Hp, target.Hp, string.Format("@lihun:{0}::{1}", target.Name, target.Hp),
                        string.Empty, "..", player.GetTag("lihun_position").ToString());

                    room.NotifySkillInvoked(player, Name);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, player.GetTag("lihun_position").ToString());
                    room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);

                    room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty), false);
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class Chongzhen : TriggerSkill
    {
        public Chongzhen() : base("chongzhen")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.CardResponded };
            skill_type = SkillType.Attack;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName)
                && use.Card.Skill == "longdan_jx" && base.Triggerable(player, room))
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in use.To)
                    if (!p.IsKongcheng() && RoomLogic.CanGetCard(room, player, p, "h")) targets.Add(p);

                if (targets.Count > 0)
                    return new TriggerStruct(Name, player, targets);
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Who != null && resp.Card != null
                && (resp.Card.Name.Contains(Slash.ClassName) || resp.Card.Name == Jink.ClassName) && resp.Card.Skill == "longdan_jx"
                && base.Triggerable(player, room) && resp.Who.Alive && !resp.Who.IsKongcheng() && RoomLogic.CanGetCard(room, player, resp.Who, "h"))
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player ask_who, TriggerStruct info)
        {
            Player player = null;
            if (triggerEvent == TriggerEvent.TargetChosen)
                player = target;
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp)
                player = resp.Who;

            if (player.Alive && ask_who.Alive && !player.IsKongcheng() && RoomLogic.CanGetCard(room, ask_who, player, "h"))
            {
                player.SetFlags(Name);
                bool invoke = room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition);
                player.SetFlags("-chongzhen");

                if (invoke)
                {
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player target, ref object data, Player ask_who, TriggerStruct info)
        {
            Player player = null;
            if (triggerEvent == TriggerEvent.TargetChosen)
                player = target;
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp)
                player = resp.Who;

            int id = room.AskForCardChosen(ask_who, player, "h", Name, false, FunctionCard.HandlingMethod.MethodGet);
            room.ObtainCard(ask_who, room.GetCard(id), new CardMoveReason(MoveReason.S_REASON_EXTRACTION, ask_who.Name, player.Name, Name, string.Empty), false);

            return false;
        }
    }

    public class Jieyuan : TriggerSkill
    {
        public Jieyuan() : base("jieyuan")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageCaused, TriggerEvent.DamageInflicted };
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DamageStruct damage && damage.From != null && damage.From != damage.To && !player.IsKongcheng())
            {
                if ((triggerEvent == TriggerEvent.DamageCaused && (damage.To.Hp >= player.Hp || player.GetMark(PlayerRole.Rebel.ToString()) > 0))
                    || (triggerEvent == TriggerEvent.DamageInflicted && (damage.From.Hp >= player.Hp || player.GetMark(PlayerRole.Loyalist.ToString()) > 0)))
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (!player.IsKongcheng() && data is DamageStruct damage)
            {
                List<int> ids = new List<int>();
                if (triggerEvent == TriggerEvent.DamageCaused)
                {
                    string prompt = string.Format("@jieyuan-add:{0}", damage.To.Name);
                    string pattern = ".black!";
                    if (player.GetMark(PlayerRole.Renegade.ToString()) > 0)
                    {
                        pattern = "..!";
                        prompt = string.Format("@jieyuan-add1:{0}", damage.To.Name);
                    }
                    ids = room.AskForExchange(player, Name, 1, 0, prompt, string.Empty, pattern, info.SkillPosition);
                }
                else
                {
                    string prompt = string.Format("@jieyuan-reduce:{0}", damage.From.Name);
                    string pattern = ".red!";
                    if (player.GetMark(PlayerRole.Renegade.ToString()) > 0)
                    {
                        prompt = string.Format("@jieyuan-reduce1:{0}", damage.From.Name);
                        pattern = "..!";
                    }
                    ids = room.AskForExchange(player, Name, 1, 0, prompt, string.Empty, pattern, info.SkillPosition);
                }

                if (ids.Count == 1)
                {
                    room.ThrowCard(ids[0], player, null, Name);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", triggerEvent == TriggerEvent.DamageCaused ? 2 : 1, gsk.General, gsk.SkinId);
                    room.NotifySkillInvoked(player, Name);

                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            DamageStruct damage = (DamageStruct)data;
            if (triggerEvent == TriggerEvent.DamageCaused)
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
            else
            {
                LogMessage log = new LogMessage
                {
                    Type = "#ReduceDamage",
                    From = player.Name,
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

    public class Fenxin : TriggerSkill
    {
        public Fenxin() : base("fenxin")
        {
            events.Add(TriggerEvent.Death);
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            List<Player> caopis = RoomLogic.FindPlayersBySkillName(room, Name);
            foreach (Player caopi in caopis)
                if (caopi != player)
                    triggers.Add(new TriggerStruct(Name, caopi));

            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player caopi, TriggerStruct info)
        {
            if (caopi.GetMark(player.GetRoleEnum().ToString()) == 0)
            {
                room.BroadcastSkillInvoke(Name, caopi, Name);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player caopi, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(caopi, Name);

            LogMessage log = new LogMessage
            {
                From = caopi.Name
            };
            switch (player.GetRoleEnum())
            {
                case PlayerRole.Rebel:
                    log.Type = "#fenxin-add";
                    break;
                case PlayerRole.Loyalist:
                    log.Type = "#fenxin-reduce";
                    break;
                case PlayerRole.Renegade:
                    log.Type = "#fenxin-pattern";
                    break;
            }
            room.SendLog(log);

            caopi.AddMark(player.GetRoleEnum().ToString());

            return false;
        }
    }

    public class Zongkui : TriggerSkill
    {
        public Zongkui() : base("zongkui")
        {
            events = new List<TriggerEvent> { TriggerEvent.RoundStart, TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Wizzard;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.RoundStart && base.Triggerable(player, room))
            {
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.GetMark("@kui") == 0)
                    {
                        triggers.Add(new TriggerStruct(Name, player));
                        break;
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.RoundStart)
            {
                List<Player> himiko = RoomLogic.FindPlayersBySkillName(room, Name);
                if (himiko.Count > 0)
                {
                    int hp = 100;
                    List<Player> targets = new List<Player>();
                    foreach (Player p in room.GetAlivePlayers())
                        if (p.Hp < hp)
                            hp = p.Hp;

                    foreach (Player p in room.GetAlivePlayers())
                        if (p.Hp == hp && !RoomLogic.PlayerHasSkill(room, p, Name) && p.GetMark("@kui") == 0)
                            targets.Add(p);

                    if (targets.Count > 0)
                        foreach (Player p in himiko)
                            triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                foreach (Player p in room.GetOtherPlayers(ask_who))
                    if (p.GetMark("@kui") == 0)
                        targets.Add(p);
            }
            else
            {
                int hp = 100;
                foreach (Player p in room.GetAlivePlayers())
                    if (p.Hp < hp)
                        hp = p.Hp;

                foreach (Player p in room.GetAlivePlayers())
                    if (p.Hp == hp && !RoomLogic.PlayerHasSkill(room, p, Name) && p.GetMark("@kui") == 0)
                        targets.Add(p);
            }

            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(ask_who, targets, Name, "@zongkui", triggerEvent == TriggerEvent.EventPhaseStart, true, info.SkillPosition);
                if (target != null)
                {
                    ask_who.SetTag(Name, target.Name);
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.FindPlayer(ask_who.GetTag(Name).ToString());
            ask_who.RemoveTag(Name);
            room.SetPlayerMark(target, "@kui", 1);

            return false;
        }
    }

    public class Guqu : TriggerSkill
    {
        public Guqu() : base("guqu")
        {
            events.Add(TriggerEvent.Damaged);
            skill_type = SkillType.Wizzard;
            frequency = Frequency.Compulsory;
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.Alive && player.GetMark("@kui") > 0)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                {
                    triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            int count = 1;

            if (ask_who.ContainsTag("bingzhao") && ask_who.GetTag("bingzhao") is string kingdom && kingdom == player.Kingdom && room.AskForSkillInvoke(player, "bingzhao", "@bingzhao:" + ask_who.Name))
                count++;

            room.DrawCards(ask_who, count, Name);
            return false;
        }
    }

    public class Baijia : TriggerSkill
    {
        public Baijia() : base("baijia")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.CardsMoveOneTime };
            frequency = Frequency.Wake;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.Reason.Reason == MoveReason.S_REASON_DRAW
                && move.Reason.SkillName == "guqu" && move.To.GetMark(Name) == 0)
            {
                move.To.AddMark("baijia_got", move.Card_ids.Count);
                room.SetPlayerStringMark(move.To, "guqu", move.To.GetMark("baijia_got").ToString());
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Start && base.Triggerable(player, room)
                && player.GetMark(Name) == 0 && player.GetMark("baijia_got") >= 7)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SetPlayerMark(player, Name, 1);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            room.RemovePlayerStringMark(player, "guqu");
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

                foreach (Player p in room.GetOtherPlayers(player))
                    if (p.GetMark("gui") == 0)
                        room.SetPlayerMark(p, "@kui", 1);

                room.HandleAcquireDetachSkills(player, "-guqu", false);
                room.HandleAcquireDetachSkills(player, "canshi", true);
            }

            return false;
        }
    }

    public class Canshi : TriggerSkill
    {
        public Canshi() : base("canshi")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetConfirming, TriggerEvent.CardTargetAnnounced };
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetConfirming && data is CardUseStruct use && use.From != null && base.Triggerable(player, room)
                && use.To.Count == 1 && use.From.GetMark("@kui") > 0)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is BasicCard || fcard.IsNDTrick())
                    return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct _use && base.Triggerable(player, room) && _use.Card.ExtraTarget)
            {
                FunctionCard fcard = Engine.GetFunctionCard(_use.Card.Name);
                if (fcard is BasicCard || (fcard.IsNDTrick() && _use.Card.Name != Collateral.ClassName && !_use.Card.Name.Contains(Nullification.ClassName)))
                    foreach (Player p in room.GetOtherPlayers(player))
                        if (p.GetMark("@kui") > 0 && !_use.To.Contains(p))
                            return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            CardUseStruct use = (CardUseStruct)data;
            if (triggerEvent == TriggerEvent.TargetConfirming)
            {
                room.SetTag(Name, data);
                bool invoke = room.AskForSkillInvoke(ask_who, Name, string.Format("@canshi-cancel:{0}::{1}", use.From.Name, use.Card.Name), info.SkillPosition);
                room.RemoveTag(Name);
                if (invoke)
                {
                    room.SetPlayerMark(use.From, "@kui", 0);
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    return info;
                }
            }
            else if (triggerEvent == TriggerEvent.CardTargetAnnounced)
            {
                List<Player> targets = new List<Player>();
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if ((fcard is Peach && !p.IsWounded())
                        || (fcard is IronChain && !p.Chained && !RoomLogic.CanBeChainedBy(room, player, p))
                        || (fcard is FireAttack && p.IsKongcheng())
                        || (fcard is Snatch && !Snatch.Instance.TargetFilter(room, new List<Player>(), p, player, use.Card))
                        || (fcard is Dismantlement && (!RoomLogic.CanDiscard(room, player, p, "hej") || p.IsAllNude()))) continue;

                    if (p.GetMark("@kui") > 0 && !use.To.Contains(p) && RoomLogic.IsProhibited(room, player, p, use.Card) == null)
                        targets.Add(p);
                }

                room.SetTag("extra_target_skill", data);                   //for AI
                List<Player> players = room.AskForPlayersChosen(player, targets, Name, 0, targets.Count, "@canshi-extra:::" + use.Card.Name, true, info.SkillPosition);
                room.RemoveTag("extra_target_skill");
                if (players.Count > 0)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    List<string> names = new List<string>();
                    foreach (Player p in players)
                    {
                        room.SetPlayerMark(p, "@kui", 0);
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, p.Name);
                        names.Add(p.Name);
                    }
                    LogMessage log = new LogMessage
                    {
                        Type = "$extra_target",
                        From = player.Name,
                        Card_str = RoomLogic.CardToString(room, use.Card),
                        Arg = Name
                    };
                    log.SetTos(players);
                    room.SendLog(log);

                    player.SetTag("extra_targets", names);
                    return info;
                }
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            CardUseStruct use = (CardUseStruct)data;
            if (triggerEvent == TriggerEvent.TargetConfirming)
            {
                room.CancelTarget(ref use, player); // Room::cancelTarget(use, player);
                data = use;
                return true;
            }
            else
            {
                List<string> names = (List<string>)player.GetTag("extra_targets");
                player.RemoveTag("extra_targets");
                List<Player> targets = new List<Player>();
                foreach (string name in names)
                    targets.Add(room.FindPlayer(name));

                if (targets.Count > 0)
                {
                    use.To.AddRange(targets);
                    room.SortByActionOrder(ref use);
                    data = use;
                }
            }

            return false;
        }
    }

    public class Bingzhao : TriggerSkill
    {
        public Bingzhao() : base("bingzhao")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart };
            lord_skill = true;
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name, true);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);

            List<string> kingdoms = new List<string>();
            foreach (Player p in room.GetAlivePlayers())
                if (!kingdoms.Contains(p.Kingdom))
                    kingdoms.Add(p.Kingdom);

            string choice = room.AskForChoice(player, Name, string.Join("+", kingdoms), null, null, info.SkillPosition);
            room.SetPlayerStringMark(player, Name, choice);
            player.SetTag(Name, choice);
            foreach (Player p in room.GetAlivePlayers())
                if (p.Kingdom == choice)
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, p.Name);

            return false;
        }
    }
    

    public class Qiaomeng : TriggerSkill
    {
        public Qiaomeng() : base("qiaomeng")
        {
            events.Add(TriggerEvent.Damage);
            frequency = Frequency.Frequent;
            skill_type = SkillType.Attack;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player panfeng, ref object data, Player ask_who)
        {
            if (base.Triggerable(panfeng, room) && data is DamageStruct damage && damage.Card != null && !damage.To.IsAllNude())
            {
                Player target = damage.To;
                FunctionCard fcard = Engine.GetFunctionCard(damage.Card.Name);
                if (fcard is Slash && RoomLogic.CanDiscard(room, panfeng, target, "hej") && !target.HasFlag("Global_DFDebut"))
                    return new TriggerStruct(Name, panfeng);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player panfeng, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage && room.AskForSkillInvoke(panfeng, Name, damage.To, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, panfeng.Name, damage.To.Name);
                room.BroadcastSkillInvoke(Name, panfeng, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player panfeng, ref object data, Player ask_who, TriggerStruct info)
        {
            DamageStruct damage = (DamageStruct)data;
            Player target = damage.To;

            int card_id = room.AskForCardChosen(panfeng, target, "hej", Name, false, HandlingMethod.MethodDiscard);
            List<int> ids = new List<int> { card_id };
            room.ThrowCard(ref ids, target, panfeng);
            if (ids.Count == 1)
            {
                card_id = ids[0];
                if (panfeng.Alive && room.GetCardPlace(card_id) == Place.DiscardPile && Engine.GetFunctionCard(room.GetCard(card_id).Name) is Horse)
                    room.ObtainCard(panfeng, card_id);
            }

            return false;
        }
    }

    public class Yicong : TriggerSkill
    {
        public Yicong() : base("yicong")
        {
            events.Add(TriggerEvent.HpChanged);
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && ((player.GetMark(Name) == 0 && player.Hp <= 2) || (player.Hp > 2 && player.GetMark(Name) > 0)))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
            if (player.Hp > 2)
            {
                player.SetMark(Name, 0);
                room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
            }
            else
            {
                player.SetMark(Name, 1);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
            }

            return false;
        }
    }

    public class YicongDis : DistanceSkill
    {
        public YicongDis() : base("#yicong")
        {
        }

        public override int GetCorrect(Room room, Player from, Player to, WrappedCard card = null)
        {
            int count = 0;
            if (RoomLogic.PlayerHasShownSkill(room, from, this))
                count--;

            if (RoomLogic.PlayerHasShownSkill(room, to, this) && to.Hp <= 2)
                count++;

            return count;
        }
    }

    public class Jiqiao : TriggerSkill
    {
        public Jiqiao() : base("jiqiao")
        {
            events.Add(TriggerEvent.EventPhaseStart);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Play && !player.IsNude())
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> ids = room.AskForExchange(player, Name, 200, 0, "@jiqiao", string.Empty, ".Equip!", info.SkillPosition);
            if (ids.Count > 0)
            {
                room.ThrowCard(ref ids, player, null, Name);
                if (ids.Count > 0)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    player.SetMark(Name, ids.Count);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            int count = player.GetMark(Name) * 2;
            player.SetMark(Name, 0);

            List<int> card_ids = room.GetNCards(count);
            List<int> gets = new List<int>(), drops = new List<int>();

            foreach (int id in card_ids)
            {
                if (Engine.GetFunctionCard(room.GetCard(id).Name).TypeID != CardType.TypeEquip)
                    gets.Add(id);
                else
                    drops.Add(id);
                room.MoveCardTo(room.GetCard(id), player, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_TURNOVER, player.Name, Name, null), false);
                Thread.Sleep(400);
            }
            room.MoveCards(new List<CardsMoveStruct>{
                new CardsMoveStruct(gets, player, Place.PlaceHand, new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name, Name, null)) },
                true);
            room.MoveCards(new List<CardsMoveStruct>{
                new CardsMoveStruct(drops, null, Place.DiscardPile, new CardMoveReason(MoveReason.S_REASON_NATURAL_ENTER, null, Name, null)) },
                true);

            return false;
        }
    }

    public class Linglong : TriggerSkill
    {
        public Linglong() : base("linglong")
        {
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Defense;
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
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

            return false;
        }
    }

    public class LinglongVH : ViewHasSkill
    {
        public LinglongVH() : base("#linglongvh")
        {
            viewhas_armors.Add(EightDiagram.ClassName);
        }
        public override bool ViewHas(Room room, Player player, string skill_name)
        {
            if (player.Alive && RoomLogic.PlayerHasSkill(room, player, "linglong") && !player.GetArmor())
                return true;
            return false;
        }
    }

    public class LinglongTar : TargetModSkill
    {
        public LinglongTar() : base("#linglong-tar")
        {
            pattern = "Slash#TrickCard";
            skill_type = SkillType.Wizzard;
        }
        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern)
        {
            return Engine.GetFunctionCard(card.Name).TypeID == CardType.TypeTrick && RoomLogic.PlayerHasSkill(room, from, "linglong") && !from.GetTreasure();
        }

        public override int GetResidueNum(Room room, Player from, WrappedCard card)
        {
            return Engine.GetFunctionCard(card.Name) is Slash && !from.GetWeapon() && RoomLogic.PlayerHasSkill(room, from, "linglong") ? 1 : 0;
        }
    }

    public class LinglongMax : MaxCardsSkill
    {
        public LinglongMax() : base("#linglong-max") { }

        public override int GetExtra(Room room, Player target)
        {
            return RoomLogic.PlayerHasSkill(room, target, "linglong") && !target.GetDefensiveHorse() && !target.GetOffensiveHorse() ? 1 : 0;
        }
    }

    public class LinglongFix : FixCardSkill
    {
        public LinglongFix() : base("#linglong-fix") { }

        public override bool IsCardFixed(Room room, Player from, Player to, string flags, HandlingMethod method)
        {
            if (to != null && from != null && from != to && (flags == "t" || flags == "a")
                && method == HandlingMethod.MethodDiscard && RoomLogic.PlayerHasSkill(room, to, "linglong") && !to.GetTreasure())
                return true;

            return false;
        }
    }

    public class Zhuiji : TriggerSkill
    {
        public Zhuiji() : base("zhuiji")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen };
            skill_type = SkillType.Attack;
            frequency = Frequency.Compulsory;
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
                        if (RoomLogic.DistanceTo(room, player, p) == 1 && (p.HasEquip() || (!p.IsKongcheng() && RoomLogic.CanDiscard(room, p, p, "h"))))
                            targets.Add(p);                            
                    }

                    if (targets.Count > 0)
                        return new TriggerStruct(Name, player, targets);
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player skill_target, ref object data, Player machao, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(machao, Name);
            room.BroadcastSkillInvoke(Name, machao, info.SkillPosition);
            room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, machao.Name, skill_target.Name);

            bool recast = false;
            string prompt = skill_target.HasEquip() ? "@zhuiji:" + machao.Name : "@zhuiji-discard:" + machao.Name;
            if (!room.AskForDiscard(skill_target, Name, 1, 1, skill_target.HasEquip(), true, prompt, false))
                recast = true;

            if (recast && skill_target.HasEquip())
            {
                List<int> ids = skill_target.GetEquips();
                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_RECAST, skill_target.Name, Name, string.Empty);
                CardsMoveStruct move = new CardsMoveStruct(ids, skill_target, Place.PlaceTable, reason)
                {
                    To_pile_name = string.Empty,
                    From = skill_target.Name
                };
                List<CardsMoveStruct> moves = new List<CardsMoveStruct> { move };
                room.MoveCardsAtomic(moves, true);
                room.BroadcastSkillInvoke("@recast", skill_target.IsMale() ? "male" : "female", -1);

                int count = ids.Count;
                List<int> table_cardids = room.GetCardIdsOnTable(ids);
                if (table_cardids.Count > 0)
                {
                    CardsMoveStruct move2 = new CardsMoveStruct(table_cardids, skill_target, null, Place.PlaceTable, Place.DiscardPile, reason);
                    room.MoveCardsAtomic(new List<CardsMoveStruct>() { move2 }, true);
                }

                if (skill_target.Alive)
                    room.DrawCards(skill_target, count, "recast");
            }

            return false;
        }
    }

    public class ZhuijiDistance : DistanceSkill
    {
        public ZhuijiDistance() : base("#zhuiji") { }

        public override int GetFixed(Room room, Player from, Player to)
        {
            if (from != to && from != null && to != null && RoomLogic.PlayerHasShownSkill(room, from, this) && to.Hp <= from.Hp)
                return 1;

            return 0;
        }
    }

    public class Shichou : TriggerSkill
    {
        public Shichou() : base("shichou")
        {
            events.Add(TriggerEvent.CardTargetAnnounced);
            skill_type = SkillType.Attack;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is CardUseStruct use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash && use.Card.ExtraTarget)
                {
                    List<Player> selected = new List<Player>(use.To);
                    foreach (Player p in room.GetOtherPlayers(player))
                        if (!use.To.Contains(p) && fcard.ExtratargetFilter(room, selected, p, player, use.Card))
                            return new TriggerStruct(Name, player);
                }
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            CardUseStruct use = (CardUseStruct)data;
            List<Player> targets = new List<Player>();
            List<Player> selected = new List<Player>(use.To);
            FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
            foreach (Player p in room.GetOtherPlayers(player))
                if (!use.To.Contains(p) && fcard.ExtratargetFilter(room, selected, p, player, use.Card))
                    targets.Add(p);

            if (targets.Count > 0)
            {
                room.SetTag("extra_target_skill", data);                   //for AI
                List<Player> players = room.AskForPlayersChosen(player, targets, Name, 0, player.GetLostHp() + 1,
                    string.Format("@extra_targets1:::{0}:{1}", use.Card.Name, player.GetLostHp() + 1), true, info.SkillPosition);
                room.RemoveTag("extra_target_skill");
                if (players.Count > 0)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    List<string> names = new List<string>();
                    foreach (Player p in players)
                    {
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, p.Name);
                        names.Add(p.Name);
                    }
                    LogMessage log = new LogMessage
                    {
                        Type = "$extra_target",
                        From = player.Name,
                        Card_str = RoomLogic.CardToString(room, use.Card),
                        Arg = Name
                    };
                    log.SetTos(players);
                    room.SendLog(log);

                    player.SetTag("extra_targets", names);
                    return info;
                }
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<string> names = (List<string>)player.GetTag("extra_targets");
            player.RemoveTag("extra_targets");
            List<Player> targets = new List<Player>();
            foreach (string name in names)
                targets.Add(room.FindPlayer(name));

            if (targets.Count > 0 && data is CardUseStruct use)
            {
                use.To.AddRange(targets);
                room.SortByActionOrder(ref use);
                data = use;
            }

            return false;
        }
    }

    public class Fuqi : TriggerSkill
    {
        public Fuqi() : base("fuqi")
        {
            frequency = Frequency.Compulsory;
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.TrickCardCanceling };
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && base.Triggerable(player, room))
            {
                if (use.Card.Name.Contains(Slash.ClassName))
                {
                    foreach (Player p in use.To)
                        if (p != player && RoomLogic.DistanceTo(room, p, player, null, true) == 1)
                            return new TriggerStruct(Name, player);

                }
                if (Engine.GetFunctionCard(use.Card.Name).IsNDTrick())
                    foreach (Player p in room.GetOtherPlayers(player))
                        if (RoomLogic.DistanceTo(room, p, player, null, true) == 1)
                            return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.TrickCardCanceling && data is CardEffectStruct effect && base.Triggerable(effect.From, room)
                && player != effect.From && RoomLogic.DistanceTo(room, player, effect.From, null, true) == 1)
            {
                return new TriggerStruct(Name, effect.From);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use)
            {
                List<Player> targets = new List<Player>();
                if (use.Card.Name.Contains(Slash.ClassName) || use.Card.Name == Duel.ClassName || use.Card.Name == Collateral.ClassName
                    || use.Card.Name == ArcheryAttack.ClassName || use.Card.Name == SavageAssault.ClassName)
                {
                    for (int i = 0; i < use.EffectCount.Count; i++)
                    {
                        CardBasicEffect effect = use.EffectCount[i];
                        if (RoomLogic.DistanceTo(room, effect.To, player) == 1)
                        {
                            effect.Effect2 = 0;
                            if (!targets.Contains(effect.To))
                                targets.Add(effect.To);
                        }
                    }
                }

                if (Engine.GetFunctionCard(use.Card.Name).IsNDTrick())
                    foreach (Player p in room.GetOtherPlayers(player))
                        if (RoomLogic.DistanceTo(room, p, player, null, true) == 1 && !targets.Contains(p))
                            targets.Add(p);

                if (targets.Count > 0)
                {
                    room.SortByActionOrder(ref targets);
                    foreach (Player p in targets)
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, p.Name);

                    room.SendCompulsoryTriggerLog(ask_who, Name);
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);

                    LogMessage log = new LogMessage
                    {
                        Type = "$NoRespond2",
                        From = player.Name,
                        Card_str = RoomLogic.CardToString(room, use.Card)
                    };
                    log.SetTos(targets);
                    room.SendLog(log);
                }
            }
            else if (triggerEvent == TriggerEvent.TrickCardCanceling)
                return true;

            return false;
        }
    }

    public class Jiaozi : TriggerSkill
    {
        public Jiaozi() : base("jiaozi")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageCaused, TriggerEvent.DamageInflicted };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Attack;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room))
            {
                bool check = true;
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.HandcardNum >= player.HandcardNum)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
            DamageStruct damage = (DamageStruct)data;
            if (triggerEvent == TriggerEvent.DamageCaused)
            {
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
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
            else
            {
                room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                LogMessage log = new LogMessage
                {
                    Type = "#AddDamaged",
                    From = player.Name,
                    Arg = Name,
                    Arg2 = (++damage.Damage).ToString()
                };
                room.SendLog(log);

                data = damage;
            }

            return false;
        }
    }

    public class Moukui : TriggerSkill
    {
        public Moukui() : base("moukui")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.CardFinished };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName) && use.From.ContainsTag(Name) && use.From.GetTag(Name) is Dictionary<string, List<string>> discard_list)
            {
                string str = RoomLogic.CardToString(room, use.Card);
                discard_list.Remove(str);
                if (discard_list.Keys.Count == 0)
                    use.From.RemoveTag(Name);
                else
                    use.From.SetTag(Name, discard_list);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room))
                return new TriggerStruct(Name, player, use.To);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<string> choices = new List<string> { "draw", "cancel" };
            if (RoomLogic.CanDiscard(room, ask_who, player, "he")) choices.Insert(1, "discard");
            player.SetFlags("moukui_target");
            string choice = room.AskForChoice(ask_who, Name, string.Join("+", choices), new List<string> { "@to-player:" + player.Name }, data, info.SkillPosition);
            player.SetFlags("-moukui_target");
            if (choice != "cancel")
            {
                ask_who.SetTag(Name, choice);
                room.NotifySkillInvoked(ask_who, Name);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                string choice = ask_who.GetTag(Name).ToString();
                ask_who.RemoveTag(Name);
                int count = 0;
                while (ask_who.Alive && choice != "cancel" && count < 2)
                {
                    count++;
                    List<string> choices = new List<string> { "cancel" };
                    if (choice == "draw")
                    {
                        room.DrawCards(ask_who, 1, Name);
                        if (player.Alive && ask_who.Alive && RoomLogic.CanDiscard(room, ask_who, player, "he")) choices.Insert(0, "discard");
                    }
                    else
                    {
                        int card_id = room.AskForCardChosen(ask_who, player, "he", Name, false, HandlingMethod.MethodDiscard);
                        room.ThrowCard(card_id, player, ask_who);
                        choices.Insert(0, "draw");
                    }

                    if (ask_who.Alive && count < 2 && choices.Count > 1)
                    {
                        player.SetFlags("moukui_target");
                        choice = room.AskForChoice(ask_who, Name, string.Join("+", choices), new List<string> { "@to-player:" + player.Name }, data, info.SkillPosition);
                        player.SetFlags("-moukui_target");
                    }
                    else
                        break;
                }


                if (count >= 2 && ask_who.Alive && player.Alive)
                {
                    Dictionary<string, List<string>> discard_list = ask_who.ContainsTag(Name) ? (Dictionary<string, List<string>>)ask_who.GetTag(Name) : new Dictionary<string, List<string>>();
                    string str = RoomLogic.CardToString(room, use.Card);
                    if (!discard_list.ContainsKey(str))
                        discard_list[str] = new List<string> { player.Name };
                    else
                        discard_list[str].Add(player.Name);

                    ask_who.SetTag(Name, discard_list);
                }
            }

            return false;
        }
    }

    public class MoukuiDis : TriggerSkill
    {
        public MoukuiDis() : base("#moukui")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardEffectResult, TriggerEvent.SlashMissed };
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.SlashMissed && data is SlashEffectStruct effect && player.Alive && effect.To.Alive && !player.IsNude() && RoomLogic.CanDiscard(room, effect.To, player, "he")
                && player.ContainsTag("moukui") && player.GetTag("moukui") is Dictionary<string, List<string>> discard_list)
            {
                string str = RoomLogic.CardToString(room, effect.Slash);
                if (discard_list.ContainsKey(str) && discard_list[str].Contains(effect.To.Name))
                    return new TriggerStruct(Name, effect.To);
            }
            else if (triggerEvent == TriggerEvent.CardEffectResult && data is CardEffectStruct _effect && _effect.Card.Name.Contains(Slash.ClassName) && !_effect.Effected && player.Alive && _effect.From.Alive
                && !_effect.From.IsNude() && RoomLogic.CanDiscard(room, player, _effect.From, "he") && _effect.From.ContainsTag("moukui") && _effect.From.GetTag("moukui") is Dictionary<string, List<string>> _discard_list)
            {
                string str = RoomLogic.CardToString(room, _effect.Card);
                if (_discard_list.ContainsKey(str) && _discard_list[str].Contains(player.Name))
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = null;
            WrappedCard card = null;

            if (triggerEvent == TriggerEvent.SlashMissed && data is SlashEffectStruct effect)
            {
                target = player;
                card = effect.Slash;
            }
            else if (data is CardEffectStruct _effect)
            {
                target = _effect.From;
                card = _effect.Card;
            }

            if (target.GetTag("moukui") is Dictionary<string, List<string>> discard_list )
            {
                string str = RoomLogic.CardToString(room, card);
                discard_list[str].Remove(ask_who.Name);
                if (discard_list[str].Count == 0) discard_list.Remove(str);
                target.SetTag("moukui", discard_list);

                if (RoomLogic.CanDiscard(room, ask_who, target, "he"))
                {
                    int id = room.AskForCardChosen(ask_who, target, "he", "moukui", false, HandlingMethod.MethodDiscard);
                    room.ThrowCard(id, target, ask_who);
                }
            }

            return false;
        }
    }

    public class Yishe : TriggerSkill
    {
        public Yishe() : base("yishe")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.CardsMoveOneTime, TriggerEvent.EventLoseSkill };
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null
                && move.From.Alive && move.From_pile_names.Contains("rice") && move.From.GetPile("rice").Count == 0 && move.From.IsWounded())
            {
                RecoverStruct recover = new RecoverStruct
                {
                    Recover = 1,
                    Who = move.From
                };
                room.Recover(move.From, recover, true);
            }
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name)
            {
                room.ClearOnePrivatePile(player, "rice");
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish && player.GetPile("rice").Count == 0)
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
            if (player.Alive)
            {
                List<int> ids = room.AskForExchange(player, Name, 2, 2, "@yishe", string.Empty, "..", info.SkillPosition);
                room.AddToPile(player, "rice", ids);
            }

            return false;
        }
    }

    public class Bushi : TriggerSkill
    {
        public Bushi() : base("bushi")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.Damaged };
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct _damage && base.Triggerable(player, room) && player.GetPile("rice").Count > 0)
            {
                TriggerStruct trigger = new TriggerStruct(Name, player)
                {
                    Times = _damage.Damage
                };
                return trigger;
            }
            else if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && damage.To.Alive && base.Triggerable(player, room) && player.GetPile("rice").Count > 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> ids = new List<int>();
            if (triggerEvent == TriggerEvent.Damaged && player.GetPile("rice").Count > 0)
                ids = room.AskForExchange(player, Name, 1, 0, "@bushi", "rice", string.Empty, info.SkillPosition);
            else if (data is DamageStruct damage && player.GetPile("rice").Count > 0 && damage.To.Alive)
            {
                room.SetTag(Name, player);
                AskForMoveCardsStruct move = room.AskForMoveCards(damage.To, player.GetPile("rice"), new List<int>(), false, Name, 1, 1, true, false, null, null);
                room.RemoveTag(Name);
                if (move.Success && move.Bottom.Count == 1)
                    ids = move.Bottom;
            }

            if (ids.Count == 1)
            {
                room.SetTag(Name, ids);
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> ids = (List<int>)room.GetTag(Name);
            room.RemoveTag(Name);
            if (triggerEvent == TriggerEvent.Damaged)
                room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_EXCHANGE_FROM_PILE, player.Name, Name, string.Empty));
            else if (data is DamageStruct damage)
                room.ObtainCard(damage.To, ref ids, new CardMoveReason(MoveReason.S_REASON_EXCHANGE_FROM_PILE, damage.To.Name, Name, string.Empty));

            return false;
        }
    }

    public class Midao : TriggerSkill
    {
        public Midao() : base("midao")
        {
            events.Add(TriggerEvent.AskForRetrial);
            skill_type = SkillType.Wizzard;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.GetPile("rice").Count > 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            JudgeStruct judge = (JudgeStruct)data;

            List<string> prompt_list = new List<string> { "@midao", judge.Who.Name, string.Empty, Name, judge.Reason };
            string prompt = string.Join(":", prompt_list);

            room.SetTag(Name, data);
            List<int> ids = room.AskForExchange(player, Name, 1, 0, prompt, "rice", string.Empty, info.SkillPosition);
            room.RemoveTag(Name);
            if (ids.Count == 1)
            {
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.Retrial(room.GetCard(ids[0]), player, ref judge, Name, false, info.SkillPosition);
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
            return false;
        }
    }

    public class Rangshang : TriggerSkill
    {
        public Rangshang() : base("rangshang")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.Damaged };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Masochism;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && base.Triggerable(player, room) && data is DamageStruct damage && damage.Nature == DamageStruct.DamageNature.Fire)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish && player.GetMark("@flame") > 0 && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name, true);
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
            if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct damage)
            {
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                room.AddPlayerMark(ask_who, "@flame", damage.Damage);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                room.LoseHp(ask_who, ask_who.GetMark("@flame"));

                if (ask_who.Alive && ask_who.GetMark("@flame") > 2)
                {
                    room.LoseMaxHp(ask_who, 2);
                    if (ask_who.Alive)
                        room.DrawCards(ask_who, 2, Name);
                }
            }

            return false;
        }
    }

    public class Hanyong : TriggerSkill
    {
        public Hanyong() : base("hanyong")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed };
            skill_type = SkillType.Attack;
        }


        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && base.Triggerable(player, room) && data is CardUseStruct use
                && (use.Card.Name == ArcheryAttack.ClassName || use.Card.Name == SavageAssault.ClassName
                || (use.Card.Name == Slash.ClassName && use.Card.Suit == WrappedCard.CardSuit.Spade)) && player.IsWounded())
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player skill_target, ref object data, Player player, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                room.SetTag(Name, data);
                bool invoke = room.AskForSkillInvoke(player, Name, "@hanyong:::" + use.Card.Name, info.SkillPosition);
                room.RemoveTag(Name);
                if (invoke)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player skill_target, ref object data, Player machao, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                LogMessage log = new LogMessage
                {
                    Type = "#hanyong",
                    From = machao.Name,
                    Arg = use.Card.Name,
                };
                room.SendLog(log);

                use.ExDamage++;
                data = use;
            }

            if (machao.Hp > room.Round)
                room.AddPlayerMark(machao, "@flame");

            return false;
        }
    }

    public class Xionghuo : ZeroCardViewAsSkill
    {
        public Xionghuo() : base("xionghuo")
        {
            skill_type = SkillType.Attack;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return player.GetMark(Name) > 0;
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(XionghuoCard.ClassName) { Skill = Name };
        }
    }

    public class XionghuoCard : SkillCard
    {
        public static string ClassName = "XionghuoCard";
        public XionghuoCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self && to_select.GetMark("xionghuo") == 0;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            player.RemoveMark("xionghuo");
            int count = player.GetMark("xionghuo");
            if (count > 0)
                room.SetPlayerStringMark(player, "cruel", player.GetMark("xionghuo").ToString());
            else
                room.RemovePlayerStringMark(player, "cruel");

            target.AddMark("xionghuo");
            room.SetPlayerStringMark(target, "cruel", target.GetMark("xionghuo").ToString());

            List<string> names =  target.ContainsTag("xionghuo") ? (List<string>)target.GetTag("xionghuo") : new List<string>();
            names.Add(player.Name);
            target.SetTag("xionghuo", names);
        }
    }

    public class XionghuoTri : TriggerSkill
    {
        public XionghuoTri() : base("#xionghuo")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.DamageCaused, TriggerEvent.EventPhaseStart, TriggerEvent.EventPhaseChanging };
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.ContainsTag("xionghuo_slash"))
                player.RemoveTag("xionghuo_slash");
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                triggers.Add(new TriggerStruct(Name, player));
            else if (triggerEvent == TriggerEvent.DamageCaused && base.Triggerable(player, room) && data is DamageStruct damage && damage.To.GetMark("xionghuo") > 0
                && damage.To.ContainsTag("xionghuo") && damage.To.GetTag("xionghuo") is List<string> xurongs && xurongs.Contains(player.Name))
            {
                triggers.Add(new TriggerStruct(Name, player));
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.Play && player.GetMark("xionghuo") > 0
                && player.ContainsTag("xionghuo") && player.GetTag("xionghuo") is List<string> names)
            {
                foreach (string str in names)
                {
                    Player p = room.FindPlayer(str);
                    if (base.Triggerable(p, room)) triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, "xionghuo");
            switch (triggerEvent)
            {
                case TriggerEvent.GameStart:
                    player.SetMark("xionghuo", 3);
                    room.SetPlayerStringMark(player, "cruel", player.GetMark("xionghuo").ToString());
                    break;
                case TriggerEvent.EventPhaseStart when player.Alive && ask_who.Alive:
                    {
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                        room.BroadcastSkillInvoke("xionghuo", ask_who, info.SkillPosition);

                        player.RemoveMark("xionghuo");
                        int count = player.GetMark("xionghuo");
                        if (count > 0)
                            room.SetPlayerStringMark(player, "cruel", player.GetMark("xionghuo").ToString());
                        else
                            room.RemovePlayerStringMark(player, "cruel");

                        List<int> ids = new List<int> { 0, 1, 2 };
                        Shuffle.shuffle(ref ids);
                        switch (ids[0])
                        {
                            case 0:
                                room.Damage(new DamageStruct("xionghuo", ask_who, player, 1, DamageStruct.DamageNature.Fire));
                                if (player.Alive)
                                {
                                    List<string> names = player.ContainsTag("xionghuo_slash") ? (List<string>)player.GetTag("xionghuo_slash") : new List<string>();
                                    names.Add(ask_who.Name);
                                    player.SetTag("xionghuo_slash", names);
                                }
                                break;
                            case 1:
                                room.LoseHp(player);
                                if (player.Alive) player.SetFlags("xionghuo");
                                break;
                            case 2:
                                List<int> get = new List<int>(), eq = new List<int>(), hands = new List<int>();
                                foreach (int id in player.GetEquips())
                                    if (RoomLogic.CanGetCard(room, ask_who, player, id)) eq.Add(id);
                                foreach (int id in player.GetCards("h"))
                                    if (RoomLogic.CanGetCard(room, ask_who, player, id)) hands.Add(id);
                                if (eq.Count > 0)
                                {
                                    Shuffle.shuffle(ref eq);
                                    get.Add(eq[0]);
                                }
                                if (hands.Count > 0)
                                {
                                    Shuffle.shuffle(ref hands);
                                    get.Add(hands[0]);
                                }
                                if (get.Count > 0)
                                    room.ObtainCard(ask_who, ref get, new CardMoveReason(MoveReason.S_REASON_EXTRACTION, ask_who.Name, player.Name, Name, string.Empty), false);
                                break;
                        }

                        break;
                    }

                case TriggerEvent.DamageCaused when data is DamageStruct damage:
                    {
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, damage.To.Name);
                        room.BroadcastSkillInvoke("xionghuo", ask_who, info.SkillPosition);
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
                        break;
                    }
            }

            return false;
        }
    }
    public class XionghuoMax : MaxCardsSkill
    {
        public XionghuoMax() : base("#xionghuo-max")
        { }

        public override int GetExtra(Room room, Player target)
        {
            return target.HasFlag("xionghuo") ? -1 : 0;
        }
    }
    public class XionghuoPro : ProhibitSkill
    {
        public XionghuoPro() : base("#xionghuo-prohibit")
        {
        }

        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if (from != null && to != null && card.Name.Contains(Slash.ClassName)
                && from.ContainsTag("xionghuo_slash") && from.GetTag("xionghuo_slash") is List<string> names && names.Contains(to.Name))
                return true;

            return false;
        }
    }

    public class Shajue : TriggerSkill
    {
        public Shajue() : base("shajue")
        {
            events.Add(TriggerEvent.Dying);
            skill_type = SkillType.Attack;
            frequency = Frequency.Compulsory;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.Hp < 0)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                {
                    if (p != player)
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);

            ask_who.AddMark("xionghuo");
            room.SetPlayerStringMark(ask_who, "cruel", ask_who.GetMark("xionghuo").ToString());

            if (data is DyingStruct dying && dying.Damage.Card != null)
            {
                List<int> ids = new List<int>();
                foreach (int id in dying.Damage.Card.SubCards)
                    if (room.GetCardPlace(id) == Place.DiscardPile || room.GetCardPlace(id) == Place.PlaceTable)
                        ids.Add(id);

                if (ids.Count > 0)
                    room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, ask_who.Name, Name, string.Empty));
            }

            return false;
        }
    }

    public class Shenxian : TriggerSkill
    {
        public Shenxian() : base("shenxian")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime };
            skill_type = SkillType.Replenish;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.From_places.Contains(Place.PlaceHand)
                && move.To_place == Place.PlaceTable && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD)
            {
                bool basic = false;
                foreach (int id in move.Card_ids)
                {
                    if (Engine.GetFunctionCard(room.GetCard(id).Name) is BasicCard)
                    {
                        basic = true;
                        break;
                    }
                }
                if (basic)
                {
                    List<Player> xincai = RoomLogic.FindPlayersBySkillName(room, Name);
                    foreach (Player p in xincai)
                        if (move.From != p && p.Phase == PlayerPhase.NotActive && !p.HasFlag(Name))
                            triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
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
            ask_who.SetFlags(Name);
            room.DrawCards(ask_who, 1, Name);
            return false;
        }
    }

    public class Yisuan : TriggerSkill
    {
        public Yisuan() : base("yisuan")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Masochism;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.HasFlag(Name))
                player.SetFlags("-yisuan");
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To_place == Place.DiscardPile && move.Reason.Reason == MoveReason.S_REASON_USE
                && move.Reason.Card != null && move.Reason.Card.SubCards.Count > 0)
            {
                Player target = room.FindPlayer(move.Reason.PlayerId);
                WrappedCard card = move.Reason.Card;
                List<int> ids = room.GetSubCards(card);
                if (card != null && Engine.GetFunctionCard(card.Name) is TrickCard && base.Triggerable(target, room) && target.Phase == PlayerPhase.Play && !target.HasFlag(Name)
                    && ids.SequenceEqual(card.SubCards) && ids.SequenceEqual(move.Card_ids))
                {
                    bool check = true;
                    foreach (int id in card.SubCards)
                    {
                        if (room.GetCardPlace(id) != Place.DiscardPile)
                        {
                            check = false;
                            break;
                        }
                    }

                    if (check) return new TriggerStruct(Name, target);
                }
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardsMoveOneTimeStruct move)
            {
                WrappedCard card = move.Reason.Card;
                if (card.SubCards.Count > 0 && ask_who.Alive)
                {
                    room.SetTag(Name, card);
                    bool invoke = room.AskForSkillInvoke(ask_who, Name, "@yisuan:::" + card.Name, info.SkillPosition);
                    room.RemoveTag(Name);
                    if (invoke)
                    {
                        room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                        room.LoseMaxHp(ask_who);
                        return info;
                    }
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (ask_who.Alive && data is CardsMoveOneTimeStruct move)
            {
                List<int> ids = new List<int>(move.Reason.Card.SubCards);
                room.RemoveSubCards(move.Reason.Card);

                if (ids.Count > 0)
                {
                    ask_who.SetFlags(Name);
                    room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, ask_who.Name, Name, string.Empty));
                }
            }

            return false;
        }
    }

    public class Langxi : PhaseChangeSkill
    {
        public Langxi() : base("langxi") { skill_type = SkillType.Attack; }
        public override bool CanPreShow() => false;
        public override bool Triggerable(Player target, Room room)
        {
            return base.Triggerable(target, room) && target.Phase == PlayerPhase.Start;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (p.Hp <= player.Hp) targets.Add(p);
            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@langxi", true, true, info.SkillPosition);
                if (target != null)
                {
                    player.SetTag(Name, target.Name);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            Player target = room.FindPlayer(player.GetTag(Name).ToString());
            player.RemoveTag(Name);
            List<int> ids = new List<int> { 0, 0, 1, 1, 1, 2 };
            Shuffle.shuffle(ref ids);
            int result = ids[0];
            if (result > 0)
                room.Damage(new DamageStruct(Name, player, target, result));

            return false;
        }
    }

    public class Luanzhan : TriggerSkill
    {
        public Luanzhan() : base("luanzhan")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardTargetAnnounced, TriggerEvent.TargetChosen, TriggerEvent.Damage, TriggerEvent.Damaged,
                TriggerEvent.GameStart, TriggerEvent.EventLoseSkill, TriggerEvent.EventAcquireSkill };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                room.SetPlayerStringMark(player, Name, "0");
            else if (triggerEvent == TriggerEvent.EventAcquireSkill && data is InfoStruct info && info.Info == Name)
            {
                player.SetMark(Name, 0);
                room.SetPlayerStringMark(player, Name, "0");
            }
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name)
                room.RemovePlayerStringMark(player, Name);
            else if ((triggerEvent == TriggerEvent.Damage || triggerEvent == TriggerEvent.Damaged) && base.Triggerable(player, room))
            {
                player.AddMark(Name);
                if (player.StringMarks.ContainsKey(Name))
                    room.SetPlayerStringMark(player, Name, player.GetMark(Name).ToString());
            }
            else if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && player.GetMark(Name) > 0 && use.Card.Name != Collateral.ClassName
                && use.To.Count < player.GetMark(Name))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash || (fcard is TrickCard && WrappedCard.IsBlack(use.Card.Suit) && !(fcard is DelayedTrick) && !(fcard is Nullification)))
                {
                    int count = player.GetMark(Name) / 2;
                    player.SetMark(Name, count);
                    if (player.StringMarks.ContainsKey(Name))
                        room.SetPlayerStringMark(player, Name, count.ToString());
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use && use.Card.ExtraTarget
                && base.Triggerable(player, room) && player.GetMark(Name) > 0 && use.Card.Name != Collateral.ClassName)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash || (fcard is TrickCard && WrappedCard.IsBlack(use.Card.Suit) && !(fcard is DelayedTrick) && !(fcard is Nullification)))
                {
                    return new TriggerStruct(Name, player);
                }
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                List<Player> targets = new List<Player>();
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                foreach (Player p in room.GetAlivePlayers())
                {
                    if ((fcard is IronChain && !p.Chained && !RoomLogic.CanBeChainedBy(room, player, p))
                        || ((fcard is SavageAssault || fcard is ArcheryAttack) && p == player)
                        || (fcard is Slash && !Slash.Instance.TargetFilter(room, new List<Player>(), p, player, use.Card))
                        || (fcard is FireAttack && p.IsKongcheng()) || (fcard is Snatch && !Snatch.Instance.TargetFilter(room, new List<Player>(), p, player, use.Card))
                        || (fcard is Dismantlement && (!RoomLogic.CanDiscard(room, player, p, "hej") || p == player || p.IsAllNude()))) continue;

                    if (!use.To.Contains(p) && RoomLogic.IsProhibited(room, player, p, use.Card) == null)
                        targets.Add(p);
                }

                room.SetTag("extra_target_skill", data);                   //for AI
                List<Player> players = room.AskForPlayersChosen(player, targets, Name, 0, player.GetMark(Name),
                    string.Format("@extra_targets1:::{0}:{1}", use.Card.Name, player.GetMark(Name)), true, info.SkillPosition);
                room.RemoveTag("extra_target_skill");
                if (players.Count > 0)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    List<string> names = new List<string>();
                    foreach (Player p in players)
                    {
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, p.Name);
                        names.Add(p.Name);
                    }
                    LogMessage log = new LogMessage
                    {
                        Type = "$extra_target",
                        From = player.Name,
                        Card_str = RoomLogic.CardToString(room, use.Card),
                        Arg = Name
                    };
                    log.SetTos(players);
                    room.SendLog(log);

                    player.SetTag("extra_targets", names);
                    return info;
                }
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                List<string> names = (List<string>)player.GetTag("extra_targets");
                player.RemoveTag("extra_targets");
                List<Player> targets = new List<Player>();
                foreach (string name in names)
                    targets.Add(room.FindPlayer(name));

                if (targets.Count > 0)
                {
                    use.To.AddRange(targets);
                    room.SortByActionOrder(ref use);
                    data = use;
                }
            }

            return false;
        }
    }

    public class Falu : TriggerSkill
    {
        public Falu() : base("falu")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.GameStart };
        }

        public static Dictionary<int, string> suits = new Dictionary<int, string>
        {
            { 0, "@zhiwei" },
            { 1, "@houtu" },
            { 2, "@yuqing" },
            { 3, "@gouchen" },
        };
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && base.Triggerable(move.From, room) &&
                (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && move.To_place == Place.PlaceTable)
            {
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    int card_id = move.Card_ids[i];
                    if (room.GetCardPlace(card_id) == Place.PlaceTable && (move.From_places[i] == Place.PlaceHand || move.From_places[i] == Place.PlaceEquip))
                        room.GetCard(card_id).SetFlags(Name);
                }
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && base.Triggerable(move.From, room)
                && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && move.To_place == Place.DiscardPile)
            {
                foreach (int id in move.Card_ids)
                {
                    WrappedCard card = room.GetCard(id);
                    if (!card.HasFlag(Name)) continue;
                    string mark = suits[(int)card.Suit];
                    if (move.From.GetMark(mark) == 0)
                        return new TriggerStruct(Name, move.From);
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            if (triggerEvent == TriggerEvent.GameStart)
            {
                foreach (string mark in suits.Values)
                {
                    room.AddPlayerMark(player, mark);
                }
            }
            else if (data is CardsMoveOneTimeStruct move)
            {
                foreach (int id in move.Card_ids)
                {
                    WrappedCard card = room.GetCard(id);
                    if (!card.HasFlag(Name)) continue;
                    string mark = suits[(int)card.Suit];
                    if (ask_who.GetMark(mark) == 0)
                        room.AddPlayerMark(ask_who, mark);
                }
            }

            return false;
        }
    }

    public class FaluClear : TriggerSkill
    {
        public FaluClear() : base("#falu")
        {
            events.Add(TriggerEvent.CardsMoveOneTime);
        }
        public override int Priority => -1;
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            CardsMoveOneTimeStruct move = (CardsMoveOneTimeStruct)data;
            if (move.From != null)
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    WrappedCard card = room.GetCard(move.Card_ids[i]);
                    if (move.From_places[i] == Place.PlaceTable && card.HasFlag("falu"))
                        card.SetFlags("-falu");
                }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return new TriggerStruct();
        }
    }

    public class Zhenyi : TriggerSkill
    {
        public Zhenyi() : base("zhenyi")
        {
            events = new List<TriggerEvent> { TriggerEvent.JudgeResult, TriggerEvent.DamageCaused, TriggerEvent.Damaged };
            view_as_skill = new ZhenyiVS();
            skill_type = SkillType.Alter;
        }
        public override bool CanPreShow() => true;
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.JudgeResult && data is JudgeStruct)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p.GetMark(Falu.suits[0]) > 0)
                        triggers.Add(new TriggerStruct(Name, p));
            }
            else if (triggerEvent == TriggerEvent.DamageCaused && base.Triggerable(player, room) && player.GetMark(Falu.suits[2]) > 0)
                triggers.Add(new TriggerStruct(Name, player));
            else if (triggerEvent == TriggerEvent.Damaged && base.Triggerable(player, room) && player.GetMark(Falu.suits[3]) > 0
                && data is DamageStruct damage && damage.Nature != DamageStruct.DamageNature.Normal)
                triggers.Add(new TriggerStruct(Name, player));

            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            object _data = data;
            string mark = string.Empty;
            Player target = null;
            switch (triggerEvent)
            {
                case TriggerEvent.JudgeResult when data is JudgeStruct judge:
                    _data = string.Format("@zhenyi-judge:{0}::{1}", player.Name, judge.Reason);
                    target = player;
                    mark = Falu.suits[0];
                    break;
                case TriggerEvent.DamageCaused when data is DamageStruct damage:
                    _data = target = damage.To;
                    mark = Falu.suits[2];
                    break;
                case TriggerEvent.Damaged:
                    mark = Falu.suits[3];
                    break;
            }

            room.SetTag(Name, data);
            bool invoke = room.AskForSkillInvoke(ask_who, Name, _data, info.SkillPosition);
            room.RemoveTag(Name);

            if (invoke)
            {
                room.SetPlayerMark(ask_who, mark, 0);
                if (target != null) room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, target.Name);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            switch (triggerEvent)
            {
                case TriggerEvent.JudgeResult when data is JudgeStruct judge:
                    {
                        LogMessage log = new LogMessage
                        {
                            Type = "#zhenyi",
                            From = ask_who.Name,
                            To = new List<string> { player.Name },
                            Arg = judge.Reason
                        };

                        string choic = room.AskForChoice(ask_who, Name, "spade+heart", new List<string> { string.Format("@zhenyi:{0}::{1}", player.Name, judge.Reason) }, data, info.SkillPosition);
                        if (choic == "spade")
                        {
                            judge.Card.SetSuit(WrappedCard.CardSuit.Spade);
                            log.Arg2 = "<color=black>♠</color>5";
                        }
                        else
                        {
                            judge.Card.SetSuit(WrappedCard.CardSuit.Heart);
                            log.Arg2 = "<color=red>♥</color>5";
                        }
                        judge.Card.SetNumber(5);
                        judge.Card.Modified = true;

                        room.UpdateJudgeResult(ref judge);
                        data = judge;

                        room.SendLog(log);
                    }
                    break;
                case TriggerEvent.DamageCaused when data is DamageStruct damage:
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
                    break;
                case TriggerEvent.Damaged:
                    {
                        int trick = -1;
                        int equip = -1;
                        int basic = -1;
                        List<int> ids = new List<int>();
                        foreach (int id in room.DrawPile)
                        {
                            WrappedCard card = room.GetCard(id);
                            FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                            if (trick == -1 && fcard is TrickCard)
                            {
                                trick = id;
                                ids.Add(trick);
                            }
                            if (equip == -1 && fcard is EquipCard)
                            {
                                equip = id;
                                ids.Add(equip);
                            }
                            if (basic == -1 && fcard is BasicCard)
                            {
                                basic = id;
                                ids.Add(basic);
                            }

                            if (ids.Count >= 3) break;
                        }
                        if (ids.Count > 0)
                            room.ObtainCard(ask_who, ref ids, new CardMoveReason(MoveReason.S_REASON_GOTCARD, ask_who.Name, Name, string.Empty), false);
                    }
                    break;
            }
            return false;
        }
    }

    public class ZhenyiVS : OneCardViewAsSkill
    {
        public ZhenyiVS() : base("zhenyi")
        {
            response_or_use = true;
        }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            return room.GetCardPlace(to_select.Id) == Place.PlaceHand || player.GetHandPile().Contains(to_select.Id);
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => false;
        public override bool IsEnabledAtResponse(Room room, Player player, FunctionCard.RespondType respond, string pattern)
        {
            if (MatchPeach(respond))
            {
                WrappedCard peach = new WrappedCard(Peach.ClassName);
                FunctionCard fcard = Peach.Instance;
                if (player.Phase == PlayerPhase.NotActive && player.GetMark(Falu.suits[1]) > 0
                    && room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE && fcard.IsAvailable(room, player, peach))
                {
                    return true;
                }
            }

            return false;
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            if (!RoomLogic.IsCardLimited(room, player, card, HandlingMethod.MethodUse))
            {
                WrappedCard zy = new WrappedCard(ZhenyiCard.ClassName);
                zy.AddSubCard(card);
                return zy;
            }

            return null;
        }
    }
    public class ZhenyiCard : SkillCard
    {
        public static string ClassName = "ZhenyiCard";
        public ZhenyiCard() : base(ClassName) { target_fixed = true; }
        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            Player player = use.From;
            room.SetPlayerMark(player, Falu.suits[1], 0);
            room.BroadcastSkillInvoke("zhenyi", player, use.Card.SkillPosition);
            room.NotifySkillInvoked(player, "zhenyi");
            WrappedCard wrapped = new WrappedCard(Peach.ClassName) { Skill = "_zhenyi" };
            wrapped.AddSubCard(use.Card);
            return wrapped;
        }
    }

    public class Dianhua : PhaseChangeSkill
    {
        public Dianhua() : base("dianhua")
        {
            skill_type = SkillType.Wizzard;
        }
        public override bool Triggerable(Player target, Room room)
        {
            if (base.Triggerable(target, room) && (target.Phase == PlayerPhase.Finish || target.Phase == PlayerPhase.Start))
            {
                foreach (string mark in Falu.suits.Values)
                    if (target.GetMark(mark) > 0) return true;
            }

            return false;
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
        public override bool OnPhaseChange(Room room, Player zhuge, TriggerStruct info)
        {
            List<int> guanxing = room.GetNCards(GetGuanxingNum(room, zhuge), false);
            LogMessage log = new LogMessage
            {
                Type = "$ViewDrawPile",
                From = zhuge.Name,
                Card_str = string.Join("+", JsonUntity.IntList2StringList(guanxing))
            };
            room.SendLog(log, zhuge);
            log.Type = "$ViewDrawPile2";
            log.Arg = guanxing.Count.ToString();
            log.Card_str = null;
            room.SendLog(log, new List<Player> { zhuge });

            AskForMoveCardsStruct result = room.AskForMoveCards(zhuge, guanxing, new List<int>(), true, Name, 0, 0, false, true, new List<int>(), info.SkillPosition);
            List<int> top_cards = result.Top;
            if (top_cards.Count > 0)
            {
                LogMessage log1 = new LogMessage
                {
                    Type = "$GuanxingTop",
                    From = zhuge.Name,
                    Card_str = string.Join("+", JsonUntity.IntList2StringList(top_cards))
                };
                room.SendLog(log1, zhuge);
            }
            room.ReturnToDrawPile(top_cards, false, zhuge);

            return false;
        }
        private int GetGuanxingNum(Room room, Player zhuge)
        {
            int count = 0;
            foreach (string mark in Falu.suits.Values)
                if (zhuge.GetMark(mark) > 0) count++;

            return count;
        }
    }

    public class Biluan : TriggerSkill
    {
        public Biluan() : base("biluan")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Defense;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player lidian, ref object data, Player ask_who)
        {
            if (base.Triggerable(lidian, room) && lidian.Phase == PlayerPhase.Finish && !lidian.IsNude())
                foreach (Player p in room.GetOtherPlayers(lidian))
                    if (RoomLogic.DistanceTo(room, p, lidian) == 1) return new TriggerStruct(Name, lidian);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player lidian, ref object data, Player ask_who, TriggerStruct info)
        {
            int count = Math.Min(4, room.GetAlivePlayers().Count);
            if (room.AskForDiscard(lidian, Name, 1, 1, true, true, "@biluan:::" + count.ToString(), true, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, lidian, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player lidian, ref object data, Player ask_who, TriggerStruct info)
        {
            int count = Math.Min(4, room.GetAlivePlayers().Count);
            lidian.AddMark(Name, count);
            int change = lidian.GetMark(Name) - lidian.GetMark("lixia");
            room.SetPlayerStringMark(lidian, "distance", change.ToString());
            return true;
        }
    }

    public class BiluanDistance : DistanceSkill
    {
        public BiluanDistance() : base("#biluan")
        {
        }
        public override int GetCorrect(Room room, Player from, Player to, WrappedCard card = null)
        {
            if (RoomLogic.PlayerHasSkill(room, to, "biluan"))
                return to.GetMark("biluan");

            return 0;
        }
    }

    public class Lixia : TriggerSkill
    {
        public Lixia() : base("lixia")
        {
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Wizzard;
            events.Add(TriggerEvent.EventPhaseStart);
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.Alive && player.Phase == PlayerPhase.Finish)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (player != p && !RoomLogic.InMyAttackRange(room, player, p)) triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);

            string choice = room.AskForChoice(ask_who, Name, "draw+letdraw", null, player, info.SkillPosition);
            if (choice == "draw")
                room.DrawCards(ask_who, 1, Name);
            else
                room.DrawCards(player, new DrawCardStruct(2, ask_who, Name));

            if (ask_who.Alive)
            {
                ask_who.AddMark(Name);
                int change = ask_who.GetMark("biluan") - ask_who.GetMark(Name);
                room.SetPlayerStringMark(ask_who, "distance", change.ToString());
            }

            return false;
        }
    }

    public class LixiaDistance : DistanceSkill
    {
        public LixiaDistance() : base("#lixia")
        {
        }
        public override int GetCorrect(Room room, Player from, Player to, WrappedCard card = null)
        {
            if (RoomLogic.PlayerHasSkill(room, to, "lixia"))
                return -to.GetMark("lixia");

            return 0;
        }
    }

    public class HuojiSM : OneCardViewAsSkill
    {
        public HuojiSM() : base("huoji_sm")
        {
            filter_pattern = ".|red|.|hand";
            response_or_use = true;
            skill_type = SkillType.Attack;
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => player.GetMark("@dragon") > 0 && player.UsedTimes("ViewAsSkill_huoji_smCard") < 3;
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard fire_attack = new WrappedCard(FireAttack.ClassName);
            fire_attack.AddSubCard(card);
            fire_attack.Skill = Name;
            fire_attack.ShowSkill = Name;
            fire_attack = RoomLogic.ParseUseCard(room, fire_attack);
            return fire_attack;
        }

        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            index = -2;
        }
    }

    public class LianhuanSM : OneCardViewAsSkill
    {
        public LianhuanSM() : base("lianhuan_sm")
        {
            filter_pattern = ".|club|.|hand";
            response_or_use = true;
            skill_type = SkillType.Alter;
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => player.GetMark("@phenix") > 0 && player.UsedTimes("ViewAsSkill_lianhuan_smCard") < 3;
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

        public override void GetEffectIndex(Room room, Player player, WrappedCard card, ref int index, ref string skill_name, ref string general_name, ref int skin_id)
        {
            index = -2;
        }
    }

    public class YeyanSM : ViewAsSkill
    {
        public YeyanSM() : base("yeyan_sm")
        {
            frequency = Frequency.Limited;
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => player.GetMark("@phenix") > 0 && player.GetMark("@dragon") > 0;

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (selected.Count > 3 || room.GetCardPlace(to_select.Id) != Place.PlaceHand || !RoomLogic.CanDiscard(room, player, player, to_select.Id))
                return false;

            if (selected.Count > 0)
            {
                List<WrappedCard.CardSuit> suits = new List<WrappedCard.CardSuit>();
                foreach (WrappedCard card in selected)
                    suits.Add(card.Suit);

                return !suits.Contains(to_select.Suit);
            }

            return true;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 0 || cards.Count == 4)
            {
                WrappedCard yy = new WrappedCard(YeyanSMCard.ClassName) { Skill = Name };
                yy.AddSubCards(cards);
                return yy;
            }

            return null;
        }
    }

    public class YeyanSMCard : SkillCard
    {
        public static string ClassName = "YeyanSMCard";
        public YeyanSMCard() : base(ClassName)
        {
            votes = true;
            will_throw = true;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (targets.Count >= 3) return false;
            if (card.SubCards.Count == 0)
                return !targets.Contains(to_select);
            else if (card.SubCards.Count == 4 && targets.Count == 2)
                return targets.Contains(to_select) || targets[0] == targets[1];

            return true;
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            if (targets.Count == 0) return false;
            if (card.SubCards.Count == 0)
                return targets.Count <= 3;
            else if (card.SubCards.Count == 4 && targets.Count > 1 && targets.Count <= 3)
            {
                for (int i = 0; i < targets.Count; i++)
                {
                    Player p1 = targets[i];
                    for (int x = i + 1; x < targets.Count; x++)
                    {
                        Player p2 = targets[x];
                        if (p2 == p1)
                            return true;
                    }
                }
            }

            return false;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            room.SetPlayerMark(card_use.From, "@phenix", 0);
            room.SetPlayerMark(card_use.From, "@dragon", 0);
            room.BroadcastSkillInvoke("yeyan", card_use.From, card_use.Card.SkillPosition);

            List<Player> targets = new List<Player>();
            for (int i = 0; i < card_use.To.Count; i++)
            {
                int count = 1;
                Player p1 = card_use.To[i];
                if (targets.Contains(p1)) continue;
                for (int x = i + 1; x < card_use.To.Count; x++)
                {
                    Player p2 = card_use.To[x];
                    if (p2 == p1)
                    {
                        count++;
                    }
                }

                p1.SetMark("yeyan_sm", count);
                targets.Add(p1);
            }

            card_use.To = targets;
            card_use.Card.Mute = true;
            base.OnUse(room, card_use);
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            if (card_use.Card.SubCards.Count > 0)
                room.LoseHp(card_use.From, 3);

            base.Use(room, card_use);
        }

        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            Player player = effect.From, target = effect.To;
            int count = target.GetMark("yeyan_sm");
            target.SetMark("yeyan_sm", 0);

            if (target.Alive)
                room.Damage(new DamageStruct("yeyan_sm", player, target, count, DamageStruct.DamageNature.Fire));
        }
    }

    public class JianjieVS : ZeroCardViewAsSkill
    {
        public JianjieVS() : base("jianjie")
        {
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(JianjieCard.ClassName) && room.Round > 1;
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern) => pattern.StartsWith("@@jianjie");
        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(JianjieCard.ClassName) { Skill = Name, Mute = true };
        }
    }

    public class Jianjie : TriggerSkill
    {
        public Jianjie() : base("jianjie")
        {
            skill_type = SkillType.Wizzard;
            events = new List<TriggerEvent> { TriggerEvent.EventLoseSkill, TriggerEvent.Death };
            view_as_skill = new JianjieVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.GetMark("@dragon") > 0 || p.GetMark("@phenix") > 0)
                    {
                        room.SetPlayerMark(p, "@dragon", 0);
                        room.SetPlayerMark(p, "@phenix", 0);
                        room.HandleAcquireDetachSkills(p, "-huoji_sm|-lianhuan_sm|-yeyan_sm", true);
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.Death && RoomLogic.PlayerHasSkill(room, player, Name))
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.GetMark("@dragon") > 0 || p.GetMark("@phenix") > 0)
                    {
                        room.SetPlayerMark(p, "@dragon", 0);
                        room.SetPlayerMark(p, "@phenix", 0);
                        room.HandleAcquireDetachSkills(p, "-huoji_sm|-lianhuan_sm|-yeyan_sm", true);
                    }
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class JianjieMove : TriggerSkill
    {
        public JianjieMove() : base("#jianjie")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.Death };
            frequency = Frequency.Compulsory;
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Start && player.GetMark(Name) == 0 && base.Triggerable(player, room))
                triggers.Add(new TriggerStruct(Name, player));
            else if (triggerEvent == TriggerEvent.Death && (player.GetMark("@dragon") > 0 || player.GetMark("@phenix") > 0))
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p != player) triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                if (room.AskForUseCard(player, RespondType.Skill, "@@jianjie!", "@jianjie-add", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition) == null)
                {
                    List<Player> targets = new List<Player>();
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.GetMark("@dragon") == 0 && p.GetMark("@phenix") == 0)
                            targets.Add(p);

                        if (targets.Count >= 2) break;
                    }

                    if (targets.Count == 2)
                    {
                        WrappedCard jj = new WrappedCard(JianjieCard.ClassName) { Skill = "jianjie", Mute = true };
                        room.UseCard(new CardUseStruct(jj, player, targets));
                    }
                }
            }
            else
            {
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, "jianjie", info.SkillPosition);
            Random ra = new Random();
            int index = ra.Next(1, 3);
            room.BroadcastSkillInvoke("jianjie", "male", index, gsk.General, gsk.SkinId);

            if (player.GetMark("@dragon") > 0)
            {
                Player target = room.AskForPlayerChosen(ask_who, room.GetOtherPlayers(player), "jianjie", "@jianjie-dragon:" + player.Name, false, true, info.SkillPosition);
                room.BroadcastSkillInvoke("jianjie", player, info.SkillPosition);
                room.SetPlayerMark(player, "@dragon", 0);
                room.SetPlayerMark(target, "@dragon", 1);
                string skill = "huoji_sm";
                if (target.GetMark("@phenix") > 0)
                {
                    Thread.Sleep(1000);
                    skill = "huoji_sm|yeyan_sm";
                    room.BroadcastSkillInvoke("jianjie", "male", 3, gsk.General, gsk.SkinId);
                }
                room.HandleAcquireDetachSkills(target, skill, true);
            }
            if (player.GetMark("@phenix") > 0)
            {
                Player target = room.AskForPlayerChosen(ask_who, room.GetOtherPlayers(player), "jianjie", "@jianjie-phenix:" + player.Name, false, true, info.SkillPosition);
                room.BroadcastSkillInvoke("jianjie", player, info.SkillPosition);
                room.SetPlayerMark(player, "@phenix", 0);
                room.SetPlayerMark(target, "@phenix", 1);
                string skill = "lianhuan_sm";
                if (target.GetMark("@dragon") > 0)
                {
                    Thread.Sleep(1000);
                    skill = "lianhuan_sm|yeyan_sm";
                    room.BroadcastSkillInvoke("jianjie", "male", 3, gsk.General, gsk.SkinId);
                }
                room.HandleAcquireDetachSkills(target, skill, true);
            }

            return false;
        }
    }

    public class JianjieCard : SkillCard
    {
        public static string ClassName = "JianjieCard";
        public JianjieCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (targets.Count > 1) return false;
            if (Self.Phase == PlayerPhase.Start)
                return to_select.GetMark("@dragon") == 0 && to_select.GetMark("@phenix") == 0 && to_select != Self;
            else
            {
                if (targets.Count == 0)
                    return to_select.GetMark("@dragon") > 0 || to_select.GetMark("@phenix") > 0;
                else
                    return (targets[0].GetMark("@dragon") > 0 && to_select.GetMark("@dragon") == 0)|| (targets[0].GetMark("@phenix") > 0 && to_select.GetMark("@phenix") == 0);
            }
        }
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card) => targets.Count == 2;
        public override void OnUse(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            List<Player> targets = new List<Player>(card_use.To);
            room.SortByActionOrder(ref targets);

            LogMessage log = new LogMessage("#UseCard")
            {
                From = player.Name,
                To = new List<string>(),
                Card_str = RoomLogic.CardToString(room, card_use.Card)
            };
            log.SetTos(targets);

            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "jianjie", card_use.Card.SkillPosition);
            Random ra = new Random();
            int index = ra.Next(1, 3);
            room.BroadcastSkillInvoke("jianjie", "male", index, gsk.General, gsk.SkinId);

            RoomThread thread = room.RoomThread;
            object data = card_use;
            thread.Trigger(TriggerEvent.PreCardUsed, room, player, ref data);

            room.RoomThread.Trigger(TriggerEvent.CardUsedAnnounced, room, player, ref data);
            room.RoomThread.Trigger(TriggerEvent.CardTargetAnnounced, room, player, ref data);

            room.RoomThread.Trigger(TriggerEvent.CardUsed, room, player, ref data);
            room.RoomThread.Trigger(TriggerEvent.CardFinished, room, player, ref data);
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            if (player.Phase == PlayerPhase.Start)
            {
                player.AddMark("#jianjie");
                for (int i = 0; i < 2; i++)
                {
                    Player target = card_use.To[i];
                    if (i == 0)
                    {
                        room.AddPlayerMark(target, "@dragon");
                        room.HandleAcquireDetachSkills(target, "huoji_sm", true);
                    }
                    else
                    {
                        room.AddPlayerMark(target, "@phenix");
                        room.HandleAcquireDetachSkills(target, "lianhuan_sm", true);
                    }
                }
            }
            else
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "jianjie", card_use.Card.SkillPosition);
                Player from = card_use.To[0], to = card_use.To[1];
                List<string> choices = new List<string>();
                if (from.GetMark("@dragon") > 0 && to.GetMark("@dragon") == 0) choices.Add("@dragon");
                if (from.GetMark("@phenix") > 0 && to.GetMark("@phenix") == 0) choices.Add("@phenix");
                string mark = room.AskForChoice(player, "jianjie", string.Join("+", choices), new List<string> { string.Format("@jianjie-from:{0}:{1}", from.Name, to.Name) }, null, card_use.Card.SkillPosition);
                if (mark == "@dragon")
                {
                    room.SetPlayerMark(from, "@dragon", 0);
                    room.SetPlayerMark(to, "@dragon", 1);
                    room.HandleAcquireDetachSkills(from, "-huoji_sm|-yeyan_sm", true);
                    string skill = to.GetMark("@phenix") > 0 ? "huoji_sm|yeyan_sm" : "huoji_sm";
                    if (to.GetMark("@phenix") > 0)
                    {
                        Thread.Sleep(1000);
                        skill = "huoji_sm|yeyan_sm";
                        room.BroadcastSkillInvoke(Name, "male", 3, gsk.General, gsk.SkinId);
                    }
                    room.HandleAcquireDetachSkills(to, skill, true);
                }
                else
                {
                    room.SetPlayerMark(from, "@phenix", 0);
                    room.SetPlayerMark(to, "@phenix", 1);
                    room.HandleAcquireDetachSkills(from, "-lianhuan_sm|-yeyan_sm", true);
                    string skill = "lianhuan_sm";
                    if (to.GetMark("@dragon") > 0)
                    {
                        Thread.Sleep(1000);
                        skill = "lianhuan_sm|yeyan_sm";
                        room.BroadcastSkillInvoke(Name, "male", 3, gsk.General, gsk.SkinId);
                    }
                    room.HandleAcquireDetachSkills(to, skill, true);
                }
            }
        }
    }

    public class Chenghao : TriggerSkill
    {
        public Chenghao() : base("chenghao")
        {
            skill_type = SkillType.Replenish;
            events.Add(TriggerEvent.Damaged);
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.Alive && data is DamageStruct damage && damage.Nature != DamageStruct.DamageNature.Normal && damage.ChainStarter && !damage.Chain)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    triggers.Add(new TriggerStruct(Name, p));
            }
            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player guojia, TriggerStruct info)
        {
            int count = 1;
            foreach (Player p in room.GetAlivePlayers())
                if (p.Chained) count++;

            List<int> yiji_cards = room.GetNCards(count);
            List<int> origin_yiji = new List<int>(yiji_cards);

            while (guojia.Alive && yiji_cards.Count > 0)
            {
                guojia.PileChange("#chenghao", yiji_cards);
                if (!room.AskForYiji(guojia, ref yiji_cards, Name, true, false, true, -1, room.GetOtherPlayers(guojia), null, null, "#chenghao", false, info.SkillPosition))
                    break;

                guojia.Piles["#chenghao"].Clear();
            }
            if (guojia.GetPile("#chenghao").Count > 0) guojia.Piles["#chenghao"].Clear();
            if (yiji_cards.Count > 0 && guojia.Alive)
            {
                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GOTBACK, guojia.Name);
                room.ObtainCard(guojia, ref yiji_cards, reason, false);
                yiji_cards.Clear();
            }

            if (yiji_cards.Count > 0)
                room.ReturnToDrawPile(yiji_cards, false);

            return false;
        }
    }
    public class Yinshi : TriggerSkill
    {
        public Yinshi() : base("yinshi")
        {
            events.Add(TriggerEvent.DamageDefined);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Defense;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DamageStruct damage && base.Triggerable(player, room) && player.GetMark("@dragon") == 0 && player.GetMark("@phenix") == 0
                && !player.EquipIsBaned(1) && !player.GetArmor()
                && (damage.Card != null && Engine.GetFunctionCard(damage.Card.Name).TypeID == CardType.TypeTrick || damage.Nature != DamageStruct.DamageNature.Normal))
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

    public class Lueming :ZeroCardViewAsSkill
    {
        public Lueming() : base("lueming")
        {
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(LuemingCard.ClassName) && player.HasEquip();
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(LuemingCard.ClassName) { Skill = Name };
        }
    }

    public class LuemingCard : SkillCard
    {
        public static string ClassName = "LuemingCard";
        public LuemingCard() : base(ClassName) { }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && Self != to_select && to_select.GetEquips().Count < Self.GetEquips().Count; 
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            player.AddMark("lueming");
            room.SetPlayerStringMark(player, "lueming", player.GetMark("lueming").ToString());
            string number = room.AskForChoice(target, "lueming", "A+2+3+4+5+6+7+8+9+10+J+Q+K", new List<string> { "@lueming-judge:" + player.Name }, null, card_use.Card.SkillPosition);

            JudgeStruct judge = new JudgeStruct
            {
                Good = true,
                Negative = false,
                PlayAnimation = false,
                Who = player,
                Reason = "lueming",
                Pattern = ".|.|" + number
            };
            target.SetFlags("lueming");
            room.Judge(ref judge);
            target.SetFlags("-lueming");

            if (player.Alive && target.Alive)
            {
                if (judge.IsGood())
                {
                    room.Damage(new DamageStruct("lueming", player, target, 2));
                }
                else if (!target.IsAllNude() && RoomLogic.CanGetCard(room, player, target, "hej"))
                {
                    List<int> ids = target.GetCards("hej");
                    Shuffle.shuffle(ref ids);
                    foreach (int card in ids)
                    {
                        if (RoomLogic.CanGetCard(room, player, target, card))
                        {
                            room.ObtainCard(player, ids[0], false);
                            break;
                        }
                    }
                }
            }
        }
    }

    public class Tunjun : ZeroCardViewAsSkill
    {
        public Tunjun() : base("tunjun") { limit_mark = "@tunjun"; frequency = Frequency.Limited; }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return player.GetMark(limit_mark) > 0 && player.GetMark("lueming") > 0;
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(TunjunCard.ClassName) { Mute = true };
        }
    }

    public class TunjunCard : SkillCard
    {
        public static string ClassName = "TunjunCard";
        public TunjunCard() : base(ClassName)
        {}

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (targets.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!to_select.EquipIsBaned(i) && to_select.GetEquip(i) == -1)
                        return true;
                }
            }

            return false;
        }
        public override void OnUse(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;

            room.SetPlayerMark(card_use.From, "@tunjun", 0);
            room.BroadcastSkillInvoke("tunjun", card_use.From, card_use.Card.SkillPosition);
            room.DoSuperLightbox(card_use.From, card_use.Card.SkillPosition, "tunjun");

            base.OnUse(room, card_use);
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            int count = player.GetMark("lueming");

            List<int> ids = new List<int>();
            foreach (int id in room.DrawPile)
            {
                WrappedCard card = room.GetCard(id);
                if (Engine.GetFunctionCard(card.Name).TypeID == CardType.TypeEquip)
                    ids.Add(id);
            }

            if (ids.Count > 0)
            {
                Shuffle.shuffle(ref ids);
                for (int i = 0; i < Math.Min(ids.Count, count); i++)
                {
                    WrappedCard card = room.GetCard(ids[i]);
                    FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                    EquipCard equip = (EquipCard)fcard;
                    int index = (int)equip.EquipLocation();
                    if (target.Alive && target.GetEquip(index) == -1 && fcard.IsAvailable(room, target, card))
                        room.UseCard(new CardUseStruct(card, target, new List<Player>(), false));
                }
            }
        }
    }

    public class Xingluan : TriggerSkill
    {
        public Xingluan() : base("xingluan")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.CardFinished };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.HasFlag(Name))
                player.SetFlags("-xingluan");
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && base.Triggerable(player, room) && !player.HasFlag(Name) && player.Phase == PlayerPhase.Play
                && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill && use.To.Count == 1)
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
            player.SetFlags(Name);
            bool draw = false;
            foreach (int id in room.DrawPile)
            {
                if (room.GetCard(id).Number == 6)
                {
                    draw = true;
                    room.ObtainCard(player, id, true);
                    break;
                }
            }
            if (!draw) room.DrawCards(player, 6, Name);

            return false;
        }
    }

    public class Sidao : TriggerSkill
    {
        public Sidao() : base("sidao")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardFinished, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Alter;
            view_as_skill = new SidaoVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.ContainsTag(Name))
            {
                player.RemoveTag(Name);
                player.SetFlags("-sidao");
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play
                && player.ContainsTag(Name) && player.GetTag(Name) is List<string> names && !player.HasFlag(Name) && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill)
            {
                foreach (Player p in use.To)
                    if (p != player && names.Contains(p.Name))
                        return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use && player.GetTag(Name) is List<string> names)
            {
                List<string> targets = new List<string>();
                foreach (Player p in use.To)
                    if (names.Contains(p.Name))
                        targets.Add(p.Name);

                player.SetTag("sidao_target", targets);
                room.AskForUseCard(player, RespondType.Skill, "@@sidao", "@sidao", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
                player.RemoveTag("sidao_target");
            }
            return new TriggerStruct();
        }
    }

    public class SidaoVS : OneCardViewAsSkill
    {
        public SidaoVS() : base("sidao")
        {
            response_pattern = "@@sidao";
            filter_pattern = ".";
            response_or_use = true;
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => false;
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard sd = new WrappedCard(SidaoCard.ClassName);
            sd.AddSubCard(card);
            return sd;
        }
    }

    public class SidaoCard : SkillCard
    {
        public static string ClassName = "SidaoCard";
        public SidaoCard() : base(ClassName)
        {
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (Self.GetTag("sidao_target") is List<string> names)
            {
                WrappedCard snatch = new WrappedCard(Snatch.ClassName);
                snatch.AddSubCard(card);
                return names.Contains(to_select.Name) && Snatch.Instance.TargetFilter(room, targets, to_select, Self, snatch);
            }
            return false;
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            WrappedCard snatch = new WrappedCard(Snatch.ClassName);
            snatch.AddSubCard(card);
            return Snatch.Instance.TargetsFeasible(room, targets, Self, snatch);
        }

        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            use.From.SetFlags("sidao");
            WrappedCard snatch = new WrappedCard(Snatch.ClassName) {Skill =  "sidao", ShowSkill = "sidao" };
            snatch.AddSubCard(use.Card);
            return snatch;
        }
    }

    public class SidaoRecord : TriggerSkill
    {
        public SidaoRecord() : base("#sidao")
        {
            events.Add(TriggerEvent.CardFinished);
        }
        public override int Priority => 2;

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is CardUseStruct use && player.Phase == PlayerPhase.Play && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill)
            {
                if (use.To.Count > 0)
                {
                    List<string> names = new List<string>();
                    foreach (Player p in use.To)
                        names.Add(p.Name);

                    player.SetTag("sidao", names);
                }
                else if (player.ContainsTag("sidao"))
                    player.RemoveTag("sidao");
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class TanbeiCard : SkillCard
    {
        public static string ClassName = "TanbeiCard";
        public TanbeiCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            bool infi = true;
            if (!target.IsAllNude() && RoomLogic.CanGetCard(room, player, target, "hej"))
                infi = room.AskForChoice(target, "tanbei", "got+infi", new List<string> { "@tanbei:" + player.Name }, player, card_use.Card.SkillPosition) == "infi";

            if (infi)
            {
                player.SetFlags("tanbei_" + target.Name);
                LogMessage log = new LogMessage("#infi-inturn")
                {
                    From = player.Name,
                    To = new List<string> { target.Name },
                    Arg = "tanbei"
                };
                room.SendLog(log);
            }
            else
            {
                List<int> ids = target.GetCards("hej");
                Shuffle.shuffle(ref ids);
                foreach (int card in ids)
                {
                    if (RoomLogic.CanGetCard(room, player, target, card))
                    {
                        room.ObtainCard(player, ids[0], false);
                        break;
                    }
                }

                player.SetFlags("tanbeipro_" + target.Name);

                LogMessage log = new LogMessage("#prohibi-inturn")
                {
                    From = player.Name,
                    To = new List<string> { target.Name },
                    Arg = "tanbei"
                };
                room.SendLog(log);
            }
        }
    }

    public class Tanbei : ZeroCardViewAsSkill
    {
        public Tanbei() : base("tanbei") { skill_type = SkillType.Attack; }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(TanbeiCard.ClassName);
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(TanbeiCard.ClassName) { Skill = Name };
        }
    }

    
    public class TanbeiTar : TargetModSkill
    {
        public TanbeiTar() : base("#tanbei-target", false)
        {
            pattern = ".";
        }

        public override bool CheckSpecificAssignee(Room room, Player from, Player to, WrappedCard card, string pattern)
        {
            if (to != null && from.HasFlag("tanbei_" + to.Name))
                return true;

            return false;
        }

        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern)
        {
            if (to != null && from.HasFlag("tanbei_" + to.Name))
                return true;

            return false;
        }
    }

    public class TanbeiPro : ProhibitSkill
    {
        public TanbeiPro() : base("#tanbei-prohibit") { }
        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if (from != null && to != null && Engine.GetFunctionCard(card.Name).TypeID != CardType.TypeSkill && from.HasFlag("tanbeipro_" + to.Name))
                return true;

            return false;
        }
    }

    public class Wenji : TriggerSkill
    {
        public Wenji() : base("wenji")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.EventPhaseChanging };
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.ContainsTag(Name))
                player.RemoveTag(Name);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Play && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (!p.IsNude()) targets.Add(p);
            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@wenji-ask", true, true, info.SkillPosition);
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

            List<int> ids = target.GetCards("he");
            if (ids.Count > 1)
                ids = room.AskForExchange(target, Name, 1, 1, "@wenji:" + player.Name, string.Empty, "..", string.Empty);
            string card_name;
            WrappedCard card = room.GetCard(ids[0]);
            FunctionCard fcard = Engine.GetFunctionCard(card.Name);
            switch (fcard)
            {
                case BasicCard _:
                    card_name = "BasicCard";
                    break;
                case TrickCard _:
                    card_name = "TrickCard";
                    break;
                default:
                    card_name = "EquipCard";
                    break;
            }

            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, target.Name, player.Name, Name, null);
            room.ObtainCard(player, ref ids, reason, true);
            if (!string.IsNullOrEmpty(card_name))
            {
                List<string> names = player.ContainsTag(Name) ? (List<string>)player.GetTag(Name) : new List<string>();
                names.Add(card_name);
                player.SetTag(Name, names);
            }
            return false;
        }
    }
    public class WenjiEffect : TriggerSkill
    {
        public WenjiEffect() : base("#wenji")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.TrickCardCanceling };
            frequency = Frequency.Compulsory;
        }


        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && use.To.Count > 0 && player.ContainsTag("wenji") && player.GetTag("wenji") is List<string> names)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (!(fcard is DelayedTrick) && !(fcard is SkillCard) && ((fcard is BasicCard && names.Contains("BasicCard")) || (fcard is TrickCard && names.Contains("TrickCard"))
                    || (fcard is EquipCard && names.Contains("EquipCard"))))
                {
                    return new TriggerStruct(Name, player);
                }
            }
            else if (triggerEvent == TriggerEvent.TrickCardCanceling && data is CardEffectStruct effect && player != effect.From && effect.From != null && effect.From.Alive
                && effect.From.ContainsTag("wenji") && effect.From.GetTag("wenji") is List<string> _names && _names.Contains(effect.Card.Name))
            {
                return new TriggerStruct(Name, effect.From);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct chose_use)
            {
                for (int i = 0; i < chose_use.EffectCount.Count; i++)
                {
                    CardBasicEffect effect = chose_use.EffectCount[i];
                    effect.Effect2 = 0;
                }
                data = chose_use;
                LogMessage log = new LogMessage
                {
                    Type = "$NoRespond",
                    From = player.Name,
                    Card_str = RoomLogic.CardToString(room, chose_use.Card)
                };
                room.SendLog(log);
            }
            else if (triggerEvent == TriggerEvent.TrickCardCanceling)
                return true;

            return false;
        }
    }

    public class Tunjiang : TriggerSkill
    {
        public Tunjiang() : base("tunjiang")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.CardTargetAnnounced };
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && player.Phase == PlayerPhase.Play && data is CardUseStruct use && use.To.Count > 0 && !player.HasFlag(Name))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (!(fcard is SkillCard))
                {
                    foreach (Player p in use.To)
                    {
                        if (p != player)
                        {
                            player.SetFlags(Name);
                            break;
                        }
                    }
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish && !player.HasFlag(Name))
            {
                bool check = true;
                foreach (PhaseStruct phase in player.PhasesState)
                {
                    if (phase.Phase == PlayerPhase.Play && phase.Skipped)
                    {
                        check = false;
                        break;
                    }
                }
                if (check) return new TriggerStruct(Name, player);
            }

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
            room.DrawCards(player, Fuli.GetKingdoms(room), Name);
            return false;
        }
    }

    public class Zhidao : TriggerSkill
    {
        public Zhidao() : base("zhidao")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.EventPhaseChanging };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Attack;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Damage && player.Phase == PlayerPhase.Play)
                player.AddMark(Name);
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.GetMark(Name) > 0)
                player.SetMark(Name, 0);

        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && player.GetMark(Name) == 1 && damage.To.Alive && !damage.To.IsAllNude()
                && base.Triggerable(player, room) && RoomLogic.CanGetCard(room, player, damage.To, "hej") && damage.To != player)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                Player target = damage.To;
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.SendCompulsoryTriggerLog(player, Name);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                List<int> ids = new List<int>();
                if (!target.IsKongcheng() && RoomLogic.CanGetCard(room, player, target, "h"))
                {
                    int id = room.AskForCardChosen(player, target, "h", Name, false, HandlingMethod.MethodGet);
                    ids.Add(id);
                }
                if (target.HasEquip() && RoomLogic.CanGetCard(room, player, target, "e"))
                {
                    int id = room.AskForCardChosen(player, target, "e", Name, false, HandlingMethod.MethodGet);
                    ids.Add(id);
                }
                if (target.JudgingArea.Count > 0 && RoomLogic.CanGetCard(room, player, target, "j"))
                {
                    int id = room.AskForCardChosen(player, target, "j", Name, false, HandlingMethod.MethodGet);
                    ids.Add(id);
                }
                if (ids.Count > 0)
                    room.ObtainCard(player, ref ids, new CardMoveReason(MoveReason.S_REASON_EXTRACTION, player.Name, target.Name, Name, string.Empty), false);

                if (player.Alive)
                    player.SetFlags(Name);
            }
            return false;
        }
    }

    public class ZhidaoPro : ProhibitSkill
    {
        public ZhidaoPro() : base("#zhidao") { }

        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if (from != null && Engine.GetFunctionCard(card.Name).TypeID != CardType.TypeSkill && from.HasFlag("zhidao"))
                return from != to;

            return false;
        }
    }

    public class JiliYbh : TriggerSkill
    {
        public JiliYbh() : base("jili_ybh")
        {
            events.Add(TriggerEvent.TargetConfirming);
            skill_type = SkillType.Wizzard;
            frequency = Frequency.Compulsory;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (data is CardUseStruct use && use.To.Contains(player) && player.Alive && use.Card.Name != Collateral.ClassName && WrappedCard.IsRed(use.Card.Suit))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is BasicCard || fcard.IsNDTrick())
                {
                    foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    {
                        if (p != use.From && !use.To.Contains(p) && RoomLogic.DistanceTo(room, player, p) == 1
                            && RoomLogic.IsProhibited(room, use.From, p, use.Card) == null)
                        {
                            if ((fcard is Peach && !p.IsWounded()) || (fcard is IronChain && !p.Chained && !RoomLogic.CanBeChainedBy(room, use.From, p))
                                || (fcard is FireAttack && p.IsKongcheng()) || (fcard is Snatch && !RoomLogic.CanGetCard(room, use.From, p, "hej"))
                                || (fcard is Dismantlement && !RoomLogic.CanDiscard(room, use.From, p, "hej"))) continue;

                            triggers.Add(new TriggerStruct(Name, p));
                        }
                    }
                }
            }
            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            if (data is CardUseStruct use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                use.To.Add(ask_who);
                use.EffectCount.Add(fcard.FillCardBasicEffct(room, ask_who));
                room.SortByActionOrder(ref use);
                data = use;

                LogMessage log = new LogMessage
                {
                    Type = "$jili_ybh",
                    From = ask_who.Name,
                    Card_str = RoomLogic.CardToString(room, use.Card),
                    Arg = Name
                };
                room.SendLog(log);
            }
            return false;
        }
    }    

    public class Lianji : TriggerSkill
    {
        public Lianji() : base("lianji")
        {
            skill_type = SkillType.Wizzard;
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.SwapPile };
            view_as_skill = new LianjiVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.SwapPile && room.ContainsTag("saber_change") && !room.ContainsTag("saber_changed"))
            {
                for (int i = 0; i < room.DrawPile.Count; i++)
                {
                    int card_id = room.DrawPile[i];
                    WrappedCard wrapped = room.GetCard(card_id);
                    if (wrapped.Name == QinggangSword.ClassName && Shuffle.random(1, 3))
                    {
                        int replace = -1;
                        foreach (int real in Engine.GetEngineCards())
                        {
                            WrappedCard real_card = Engine.GetRealCard(real);
                            if (real_card.Name == Saber.ClassName)
                            {
                                replace = real;
                                break;
                            }
                        }

                        room.ReplaceRoomCard(card_id, replace);
                        room.SetTag("saber_changed", true);
                    }
                }

                room.RemoveTag("saber_change");
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class LianjiVS : OneCardViewAsSkill
    {
        public LianjiVS() : base("lianji")
        {
            filter_pattern = ".!";
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(LianjiCard.ClassName) && !player.IsKongcheng();
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard lj = new WrappedCard(LianjiCard.ClassName) { Skill = Name };
            lj.AddSubCard(card);
            return lj;
        }
    }

    public class LianjiCard : SkillCard
    {
        public static string ClassName = "LianjiCard";
        public LianjiCard() : base(ClassName)
        {
            will_throw = true;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            room.SetTag("saber_change", true);
            Player player = card_use.From, target = card_use.To[0];
            player.AddMark("lianji");

            if (target.Alive)
            {
                for (int i = 0; i < room.DrawPile.Count; i++)
                {
                    int card_id = room.DrawPile[i];
                    WrappedCard wrapped = room.GetCard(card_id);
                    FunctionCard functionCard = Engine.GetFunctionCard(wrapped.Name);
                    if (functionCard is Weapon)
                    {
                        if (wrapped.Name == QinggangSword.ClassName)
                        {
                            int replace = -1;
                            foreach (int real in Engine.GetEngineCards())
                            {
                                WrappedCard real_card = Engine.GetRealCard(real);
                                if (real_card.Name == Saber.ClassName)
                                {
                                    replace = real;
                                    break;
                                }
                            }

                            room.ReplaceRoomCard(card_id, replace);
                            room.SetTag("saber_changed", true);
                            card_id = replace;
                        }
                        wrapped = room.GetCard(card_id);
                        functionCard = Engine.GetFunctionCard(wrapped.Name);
                        if (functionCard.IsAvailable(room, target, wrapped))
                            room.UseCard(new CardUseStruct(wrapped, target, new List<Player>()));
                        break;
                    }
                }
            }

            if (target.Alive && player.Alive)
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetOtherPlayers(target))
                {
                    if (RoomLogic.CanSlash(room, target, p, 0, false))
                        targets.Add(p);
                }

                bool slash = true;
                if (targets.Count > 0)
                {
                    Player victim = room.AskForPlayerChosen(player, targets, "lianji", "@lianji-victim:" + target.Name, false, false, card_use.Card.SkillPosition);
                    if (victim != null)
                    {
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, victim.Name);
                        LogMessage log = new LogMessage
                        {
                            Type = "#lianji-target",
                            From = player.Name,
                            To = new List<string> { victim.Name }
                        };
                        room.SendLog(log);

                        slash = room.AskForUseSlashTo(target, victim, string.Format("@lianji-slash:{0}:{1}", player.Name, victim), null) != null;
                    }
                }

                if (!slash && target.GetWeapon())
                {
                    WrappedCard card = room.GetCard(target.Weapon.Key);
                    player.SetFlags("lianji_weapon");
                    Player holder = room.AskForPlayerChosen(player, room.GetOtherPlayers(target), Name, string.Format("@lianji-weapon:{0}::{1}", target.Name, card.Name),
                        false, false, card_use.Card.SkillPosition);
                    player.SetFlags("-lianji_weapon");

                    room.ObtainCard(holder, card, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, holder.Name, "lianji", string.Empty));
                }
            }
        }
    }


    public class Moucheng : PhaseChangeSkill
    {
        public Moucheng() : base("moucheng")
        {
            frequency = Frequency.Wake;
            skill_type = SkillType.Recover;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Start && player.GetMark(Name) == 0 && base.Triggerable(player, room) && player.GetMark("lianji") >= 3)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player ask_who, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            room.DoSuperLightbox(ask_who, info.SkillPosition, Name);
            ask_who.SetMark(Name, 1);
            room.SendCompulsoryTriggerLog(ask_who, Name);

            room.HandleAcquireDetachSkills(ask_who, "-lianji", false);
            room.HandleAcquireDetachSkills(ask_who, "jingong", true);

            return false;
        }
    }

    public class Jingong : TriggerSkill
    {
        public Jingong() : base("jingong")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.Damage, TriggerEvent.CardUsedAnnounced };
            skill_type = SkillType.Alter;
            view_as_skill = new JingongVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.ContainsTag(Name))
                player.RemoveTag(Name);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class JingongVS : ViewAsSkill
    {
        public JingongVS() : base("jingong")
        {
            response_or_use = true;
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed("ViewAsSkill_jingongCard");
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (selected.Count == 0)
            {
                FunctionCard fcard = Engine.GetFunctionCard(to_select.Name);
                return !RoomLogic.IsCardLimited(room, player, to_select, HandlingMethod.MethodUse) && (fcard is Slash || fcard is EquipCard);
            }
            return false;
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            if (cards.Count == 1)
            {
                if (player.ContainsTag(Name) && player.GetTag(Name) is List<string> vcards)
                {
                    foreach (string card_name in vcards)
                    {
                        WrappedCard card = new WrappedCard(card_name) { Skill = Name };
                        card.AddSubCard(cards[0]);
                        result.Add(card);
                    }
                }
                else
                {
                    List<string> v_cards = GetGuhuoCards(room, "t");
                    v_cards.RemoveAll(t => t.Contains(Nullification.ClassName));
                    List<string> specials = new List<string> { HoneyTrap.ClassName, HiddenDagger.ClassName };
                    Shuffle.shuffle(ref v_cards);
                    Shuffle.shuffle(ref specials);

                    List<string> alls = new List<string> { specials[0] };
                    for (int i = 0; i < 2; i++)
                        alls.Add(v_cards[i]);
                    player.SetTag(Name, alls);
                    foreach (string card_name in alls)
                    {
                        WrappedCard card = new WrappedCard(card_name) { Skill = Name };
                        card.AddSubCard(cards[0]);
                        result.Add(card);
                    }
                }
            }

            return result;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
            {
                WrappedCard card = RoomLogic.ParseUseCard(room, cards[0]);
                return card;
            }

            return null;
        }
    }

    public class ZhoufuEffect : TriggerSkill
    {
        public ZhoufuEffect() : base("#zhoufu")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.StartJudge, TriggerEvent.CardsMoveOneTime };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.From_places.Contains(Place.PlaceSpecial)
                && move.From_pile_names.Contains("incantation") && move.From.Alive)
            {
                int id = -1;
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    if (move.From_places[i] == Place.PlaceSpecial)
                    {
                        id = move.Card_ids[i];
                        break;
                    }
                }

                foreach (Player p in room.GetOtherPlayers(move.From))
                {
                    if (p.ContainsTag("zhoufu") && p.GetTag("zhoufu") is Dictionary<int, int> draws && draws.ContainsKey(id))
                    {
                        draws.Remove(id);
                        if (draws.Count == 0)
                            p.RemoveTag("zhoufu");
                        else
                            p.SetTag("zhoufu", draws);

                        if (p.ContainsTag("zhoufu_lose") && p.GetTag("zhoufu_lose") is List<string> targets)
                        {
                            if (!targets.Contains(move.From.Name))
                                targets.Add(move.From.Name);
                            p.SetTag("zhoufu_lose", targets);
                        }
                        else
                            p.SetTag("zhoufu_lose", new List<string> { move.From.Name });

                        break;
                    }
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.ContainsTag("zhoufu_lose") && p.GetTag("zhoufu_lose") is List<string> targets)
                    {
                        bool add = false;
                        if (base.Triggerable(p, room))
                        {
                            foreach (string player_name in targets)
                            {
                                if (room.FindPlayer(player_name) != null)
                                {
                                    add = true;
                                    triggers.Add(new TriggerStruct(Name, p));
                                    break;
                                }
                            }
                        }
                        if (!add)
                            p.RemoveTag("zhoufu_lose");
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.StartJudge && player.GetPile("incantation").Count > 0)
            {
                triggers.Add(new TriggerStruct(Name, player));
            }
            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.StartJudge && data is JudgeStruct judge_struct)
            {
                List<int> ids = player.GetPile("incantation");
                judge_struct.Card = room.GetCard(ids[0]);

                LogMessage log = new LogMessage
                {
                    Type = "$InitialJudge",
                    From = judge_struct.Who.Name,
                    Card_str = ids[0].ToString()
                };
                room.SendLog(log);

                room.MoveCardTo(judge_struct.Card, null, judge_struct.Who, Place.PlaceJudge,
                    new CardMoveReason(MoveReason.S_REASON_JUDGE, judge_struct.Who.Name, null, null, judge_struct.Reason), true);

                Thread.Sleep(500);
                bool effected = judge_struct.Good == Engine.MatchExpPattern(room, judge_struct.Pattern, judge_struct.Who, judge_struct.Card);
                judge_struct.UpdateResult(effected);
                data = judge_struct;

                return true;
            }
            else
            {
                if (ask_who.ContainsTag("zhoufu_lose") && ask_who.GetTag("zhoufu_lose") is List<string> targets)
                {
                    ask_who.RemoveTag("zhoufu_lose");
                    List<Player> loser = new List<Player>();
                    foreach (string player_name in targets)
                    {
                        Player target = room.FindPlayer(player_name);
                        if (target != null)
                            loser.Add(target);
                    }

                    if (loser.Count > 0)
                    {
                        room.SortByActionOrder(ref loser);
                        foreach (Player p in loser)
                            if (p.Alive) room.LoseHp(p);
                    }
                }

                return false;
            }
        }
    }

    public class Zhoufu : OneCardViewAsSkill
    {
        public Zhoufu() : base("zhoufu")
        {
        }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            Place place = room.GetCardPlace(to_select.Id);
            return place == Place.PlaceHand || place == Place.PlaceEquip;
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(ZhoufuCard.ClassName) && !player.IsNude();
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard zf = new WrappedCard(ZhoufuCard.ClassName) { Skill = Name };
            zf.AddSubCard(card);
            return zf;
        }
    }

    public class ZhoufuCard : SkillCard
    {
        public static string ClassName = "ZhoufuCard";
        public ZhoufuCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self && to_select.GetPile("incantation").Count == 0;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Dictionary<int, int> draws = new Dictionary<int, int>();
            Player player = card_use.From, target = card_use.To[0];
            if (player.ContainsTag("zhoufu"))
                draws = (Dictionary<int, int>)player.GetTag("zhoufu");

            draws[card_use.Card.GetEffectiveId()] = 0;
            player.SetTag("zhoufu", draws);
            room.AddToPile(target, "incantation", card_use.Card.GetEffectiveId(), false, new List<Player> { card_use.From });
        }
    }

    public class Yingbing : TriggerSkill
    {
        public Yingbing() : base("yingbing")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded, TriggerEvent.CardsMoveOneTime };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Wizzard;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && player.GetPile("incantation").Count > 0)
            {
                int card_id = player.GetPile("incantation")[0];
                WrappedCard.CardSuit suit = room.GetCard(card_id).Suit;
                if (WrappedCard.IsBlack(use.Card.Suit) && WrappedCard.IsBlack(suit) || WrappedCard.IsRed(use.Card.Suit) && WrappedCard.IsRed(suit))
                {
                    foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    {
                        if (p.ContainsTag("zhoufu") && p.GetTag("zhoufu") is Dictionary<int, int> draws && draws.ContainsKey(card_id))
                            triggers.Add(new TriggerStruct(Name, p));
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use && player.GetPile("incantation").Count > 0)
            {
                int card_id = player.GetPile("incantation")[0];
                WrappedCard.CardSuit suit = room.GetCard(card_id).Suit;
                if (WrappedCard.IsBlack(resp.Card.Suit) && WrappedCard.IsBlack(suit) || WrappedCard.IsRed(resp.Card.Suit) && WrappedCard.IsRed(suit))
                {
                    foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    {
                        if (p.ContainsTag("zhoufu") && p.GetTag("zhoufu") is Dictionary<int, int> draws && draws.ContainsKey(card_id))
                            triggers.Add(new TriggerStruct(Name, p));
                    }
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (ask_who.ContainsTag("zhoufu") && ask_who.GetTag("zhoufu") is Dictionary<int, int> draws)
            {
                int card_id = player.GetPile("incantation")[0];
                draws[card_id]++;
                room.DrawCards(ask_who, 1, Name);
                ask_who.SetTag("zhoufu", draws);
                if (draws[card_id] > 1)
                {
                    List<int> ids = player.GetPile("incantation");
                    if (ids.Count > 0)
                    {
                        CardsMoveStruct move = new CardsMoveStruct(ids, ask_who, Place.PlaceHand, new CardMoveReason(MoveReason.S_REASON_GOTCARD, ask_who.Name, player.Name, Name, string.Empty));
                        room.MoveCardsAtomic(move, false);
                    }
                }
            }

            return false;
        }
    }

    public class Lianzhu : OneCardViewAsSkill
    {
        public Lianzhu() : base("lianzhu")
        {
            filter_pattern = "..";
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(LianzhuCard.ClassName) && !player.IsKongcheng();
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard zf = new WrappedCard(LianzhuCard.ClassName) { Skill = Name };
            zf.AddSubCard(card);
            return zf;
        }
    }

    public class LianzhuCard : SkillCard
    {
        public static string ClassName = "LianzhuCard";
        public LianzhuCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From, target = card_use.To[0];
            List<int> ids = new List<int>(card_use.Card.SubCards);
            bool black = WrappedCard.IsBlack(room.GetCard(ids[0]).Suit);

            room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "lianzhu", string.Empty));

            if (target.Alive && black)
            {
                string pattern = "@lianzhu:" + player.Name;
                if (!player.Alive)
                    pattern = "@lianzhu-discard:" + player.Name;
                if (!room.AskForDiscard(target, "lianzhu", 2, 2, player.Alive, true, pattern) && player.Alive)
                    room.DrawCards(player, 2, "lianzhu");
            }
            else if (!black)
                room.DrawCards(player, 1, "lianzhu");
        }
    }

    public class Xiahui : TriggerSkill
    {
        public Xiahui() : base("xiahui")
        {
            events = new List<TriggerEvent> { TriggerEvent.BeforeCardsMove, TriggerEvent.CardsMoveOneTime, TriggerEvent.PostHpReduced,
                TriggerEvent.EventPhaseStart, TriggerEvent.Death, TriggerEvent.EventLoseSkill };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Wizzard;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.BeforeCardsMove && data is CardsMoveOneTimeStruct move && move.To != null && base.Triggerable(move.From, room)
                && move.To != move.From && move.To.Alive && move.To_place == Place.PlaceHand)
            {
                List<int> blacks = new List<int>();
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    int id = move.Card_ids[i];
                    if ((move.From_places[i] == Place.PlaceHand || move.From_places[i] == Place.PlaceEquip) && WrappedCard.IsBlack(room.GetCard(id).Suit))
                        blacks.Add(id);
                }

                if (blacks.Count > 0)
                    move.To.SetTag(string.Format("{0}_{1}", Name, move.To.Name), blacks);
            }
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct _move && _move.From != null && _move.From_places.Contains(Place.PlaceHand)
                && _move.From.ContainsTag(Name) && _move.From.GetTag(Name) is List<int> ids)
            {
                List<int> remove = ids.FindAll(t => _move.Card_ids.Contains(t));
                if (remove.Count > 0)
                {
                    foreach (int id in remove)
                        RoomLogic.RemovePlayerCardLimitation(_move.From, Name, "use,response,discard", id.ToString());

                    ids.RemoveAll(t => _move.Card_ids.Contains(t));
                    if (ids.Count == 0)
                        _move.From.RemoveTag(Name);
                    else
                        _move.From.SetTag(Name, ids);

                    if (_move.From.Phase != PlayerPhase.NotActive) _move.From.SetFlags("xiahui_lose");
                }
            }
            else if (triggerEvent == TriggerEvent.PostHpReduced && player.ContainsTag(Name) && player.GetTag(Name) is List<int> remove)
            {
                player.RemoveTag(Name);
                RoomLogic.RemovePlayerCardLimitation(player, Name);
            }
            else if ((triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name)
                || (triggerEvent == TriggerEvent.Death && RoomLogic.PlayerHasSkill(room, player, Name)))
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    p.RemoveTag(Name);
                    RoomLogic.RemovePlayerCardLimitation(p, Name);
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && base.Triggerable(move.From, room) && move.To != null && move.To.Alive
                && move.To != move.From && move.To_place == Place.PlaceHand
                && move.To.ContainsTag(string.Format("{0}_{1}", Name, move.To.Name)) && move.To.GetTag(string.Format("{0}_{1}", Name, move.To.Name)) is List<int> ids)
            {
                foreach (int id in move.Card_ids)
                    if (ids.Contains(id))
                        return new TriggerStruct(Name, move.From);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.Finish && player.HasFlag("xiahui_lose") && player.ContainsTag(Name))
            {
                Player db = RoomLogic.FindPlayerBySkillName(room, Name);
                if (db != null)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To.GetTag(string.Format("{0}_{1}", Name, move.To.Name)) is List<int> ids)
            {
                move.To.RemoveTag(string.Format("{0}_{1}", Name, move.To.Name));
                //room.SendCompulsoryTriggerLog(ask_who, Name);
                //room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, move.To.Name);

                List<int> fix = move.Card_ids.FindAll(t => ids.Contains(t));
                move.To.SetTag(Name, fix);
                foreach (int id in fix)
                    RoomLogic.SetPlayerCardLimitation(move.To, Name, "use,response,discard", id.ToString());
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart)
                room.LoseHp(player);

            return false;
        }
    }

    public class XiahuiMax : MaxCardsSkill
    {
        public XiahuiMax() : base("#xiahui-max") { }

        public override bool Ingnore(Room room, Player player, int card_id) => RoomLogic.PlayerHasSkill(room, player, "xiahui") && WrappedCard.IsBlack(room.GetCard(card_id).Suit);
    }

    public class Neifa : TriggerSkill
    {
        public Neifa() : base("neifa")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.CardUsed, TriggerEvent.EventPhaseChanging, TriggerEvent.CardTargetAnnounced };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                if (player.GetMark(Name) > 0)
                    player.SetMark(Name, 0);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play)
            {
                return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.CardUsed && player.HasFlag("neifa_not_basic") && data is CardUseStruct use && Engine.GetFunctionCard(use.Card.Name) is EquipCard
                && player.Alive && player.GetMark(Name) > 0 && player.GetMark("neifa_draw") < 2)
            {
                return new TriggerStruct(Name, player);
            }
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct _use && player.HasFlag("neifa_not_basic")
                && Engine.GetFunctionCard(_use.Card.Name).IsNDTrick() && _use.Card.Name != Collateral.ClassName)
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if ((p.HasEquip() || p.JudgingArea.Count > 0) && RoomLogic.CanGetCard(room, player, p, "ej"))
                        targets.Add(p);
                }
                targets.Add(player);
                player.SetFlags("neifa_invoke");
                Player target = room.AskForPlayerChosen(player, targets, Name, "@neifa-choose", true, true, info.SkillPosition);
                player.SetFlags("-neifa_invoke");
                if (target != null)
                {
                    room.SetTag(Name, target);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }
            else if (triggerEvent == TriggerEvent.CardUsed)
            {
                return info;
            }
            else if (data is CardUseStruct use)
            {
                List<Player> targets = new List<Player>();
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (use.To.Contains(p))
                    {
                        if (use.To.Count > 1)
                            targets.Add(p);
                    }
                    else if (RoomLogic.IsProhibited(room, use.From, p, use.Card) == null)
                    {
                        if ((fcard is Slash && p == use.From) || (fcard is Peach && !p.IsWounded())
                            || (fcard is IronChain && !p.Chained && !RoomLogic.CanBeChainedBy(room, player, p))
                            || (fcard is FireAttack && p.IsKongcheng())
                            || (fcard is Snatch && !Snatch.Instance.TargetFilter(room, new List<Player>(), p, player, use.Card))
                            || (fcard is Dismantlement && (!RoomLogic.CanDiscard(room, player, p, "hej") || p == use.From || p.IsAllNude()))
                            || (fcard is Duel && p == use.From)
                            || ((fcard is ArcheryAttack || fcard is SavageAssault) && p == use.From)) continue;
                        targets.Add(p);
                    }
                }

                if (targets.Count > 0)
                {
                    room.SetTag(Name, data);
                    Player target = room.AskForPlayerChosen(player, targets, Name, string.Format("@neifa-trick:::{0}", use.Card.Name), true, true, info.SkillPosition);
                    room.RemoveTag(Name);
                    if (target != null)
                    {
                        room.SetTag(Name, target);
                        return info;
                    }
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
                bool draw = target == player;
                if (target == player && (player.HasEquip() || player.JudgingArea.Count > 0) && RoomLogic.CanGetCard(room, player, player, "ej"))
                {
                    string choice = room.AskForChoice(player, Name, "draw+get", null, null, info.SkillPosition);
                    draw = choice == "draw";
                }

                if (draw)
                    room.DrawCards(player, 2, Name);
                else
                {
                    int id = room.AskForCardChosen(player, target, "ej", Name, false, HandlingMethod.MethodGet);
                    room.ObtainCard(player, room.GetCard(id),
                        new CardMoveReason(room.GetCardPlace(id) == Place.PlaceEquip ? MoveReason.S_REASON_EXTRACTION : MoveReason.S_REASON_GOTCARD, player.Name, target.Name,
                        Name, string.Empty));
                }

                if (player.Alive && RoomLogic.CanDiscard(room, player, player, "he"))
                {
                    List<int> ids = room.AskForExchange(player, Name, 1, 1, "@neifa", string.Empty, "..!", info.SkillPosition);
                    if (ids.Count > 0)
                    {
                        FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(ids[0]).Name);
                        if (fcard is BasicCard)
                        {
                            player.SetFlags("neifa_basic");
                            int count = 0;
                            foreach (int id in player.GetCards("h"))
                            {
                                if (!(Engine.GetFunctionCard(room.GetCard(id).Name) is BasicCard))
                                    count++;
                            }
                            count = Math.Min(5, count);
                            player.SetMark(Name, count);
                        }
                        else
                        {
                            player.SetFlags("neifa_not_basic");
                            int count = 0;
                            foreach (int id in player.GetCards("h"))
                            {
                                if (Engine.GetFunctionCard(room.GetCard(id).Name) is BasicCard)
                                    count++;
                            }
                            count = Math.Min(5, count);
                            player.SetMark(Name, count);
                            player.SetMark("neifa_draw", 0);
                        }

                        room.ThrowCard(ref ids,
                            new CardMoveReason(MoveReason.S_REASON_THROW, player.Name, Name, string.Empty) { General = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition) },
                            player);
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.CardUsed)
            {
                player.AddMark("neifa_draw");
                room.DrawCards(player, player.GetMark(Name), Name);
            }
            else if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                Player target = (Player)room.GetTag(Name);
                room.RemoveTag(Name);
                if (!use.To.Contains(target))
                {
                    use.To.Add(target);
                    LogMessage log = new LogMessage
                    {
                        Type = "$extra_target",
                        From = player.Name,
                        To = new List<string> { target.Name },
                        Card_str = RoomLogic.CardToString(room, use.Card),
                        Arg = Name
                    };
                    room.SendLog(log);
                }
                else
                {
                    use.To.Remove(target);
                    LogMessage log = new LogMessage
                    {
                        Type = "$CancelTarget",
                        From = use.From.Name,
                        To = new List<string> { target.Name },
                        Arg = use.Card.Name
                    };
                    room.SendLog(log);
                    room.SetEmotion(target, "cancel");
                    Thread.Sleep(400);
                }

                room.SortByActionOrder(ref use);
                data = use;
            }

            return false;
        }
    }

    public class NeifaTar : TargetModSkill
    {
        public NeifaTar() : base("#neifa-tar", false)
        {
        }
        public override int GetExtraTargetNum(Room room, Player from, WrappedCard card)
        {
            if (card.Name.Contains(Slash.ClassName) && from.HasFlag("neifa_basic"))
                return 1;
            return 0;
        }
        public override int GetResidueNum(Room room, Player from, WrappedCard card)
        {
            int count = 0;
            if (from.HasFlag("neifa_basic") && card.Name.Contains(Slash.ClassName))
            {
                count = from.GetMark("neifa");
            }
            return count;
        }
    }

    public class NeifaPro : ProhibitSkill
    {
        public NeifaPro() : base("#neifa-pro")
        {
        }
        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if (from != null && card != null)
            {
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                bool basic = fcard is BasicCard;
                if ((from.HasFlag("neifa_basic") && !basic) || (from.HasFlag("neifa_not_basic") && basic))
                    return true;
            }

            return false;
        }
    }

    public class ZhenduJX : TriggerSkill
    {
        public ZhenduJX() : base("zhendu_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Attack;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (player != null && triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Play)
            {
                List<Player> hetaihous = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player hetaihou in hetaihous)
                {
                    if (RoomLogic.CanDiscard(room, hetaihou, hetaihou, "h"))
                        skill_list.Add(new TriggerStruct(Name, hetaihou));
                }
            }
            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player hetaihou, TriggerStruct info)
        {
            string prompt = "@zhendu-discard:" + player.Name;
            if (hetaihou == player) prompt = "@zhendu-self-discard";
            if (room.AskForDiscard(hetaihou, Name, 1, 1, true, false, prompt, true, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, hetaihou.Name, player.Name);
                room.BroadcastSkillInvoke(Name, hetaihou, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player hetaihou, TriggerStruct info)
        {
            WrappedCard analeptic = new WrappedCard(Analeptic.ClassName)
            {
                Skill = "_zhendu_jx"
            };
            room.UseCard(new CardUseStruct(analeptic, player, new List<Player>(), true), true, true);
            if (player.Alive && player != hetaihou)
                room.Damage(new DamageStruct(Name, hetaihou, player));

            return false;
        }
    }
    public class QiluanJX : TriggerSkill
    {
        public QiluanJX() : base("qiluan_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.Death, TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Death && data is DeathStruct death)
            {
                foreach (Player p in room.GetOtherPlayers(death.Who))
                {
                    if (death.Damage.From != null && p == death.Damage.From)
                        p.AddMark(Name, 3);
                    else
                        p.AddMark(Name);
                }
            }
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> skill_list = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.NotActive)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p.GetMark(Name) > 0) skill_list.Add(new TriggerStruct(Name, p));
            }

            return skill_list;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player hetaihou, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(hetaihou, Name, null, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, hetaihou, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.DrawCards(ask_who, ask_who.GetMark(Name), Name);
            return false;
        }
    }

    public class QiluanJXClear : TriggerSkill
    {
        public QiluanJXClear() : base("#qiluan_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
        }
        public override int Priority => 2;
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.NotActive)
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (p.GetMark("qiluan_jx") > 0) p.SetMark("qiluan_jx", 0);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class BeizhanClassic : PhaseChangeSkill
    {
        public BeizhanClassic() : base("beizhan_classic")
        {
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (player.GetMark(Name) > 0 && player.Phase == Player.PlayerPhase.Start)
            {
                player.SetMark(Name, 0);
                int max_cout = 0;
                foreach (Player p in room.GetAlivePlayers())
                    if (p.HandcardNum > max_cout)
                        max_cout = p.HandcardNum;

                if (player.HandcardNum == max_cout)
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "#beizhan",
                        From = player.Name,
                        Arg = Name
                    };
                    room.SendLog(log);

                    player.SetFlags(Name);
                }
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == Player.PlayerPhase.Finish)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player to = room.AskForPlayerChosen(player, room.GetAlivePlayers(), Name, "@beizhan_classic", true, true, info.SkillPosition);
            if (to != null)
            {
                room.SetTag("beizhan_target", to);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            Player to = (Player)room.GetTag("beizhan_target");
            room.RemoveTag("beizhan_target");
            if (to != null)
            {
                to.SetMark(Name, 1);
                if (to.HandcardNum < to.MaxHp && to.HandcardNum < 5)
                    room.DrawCards(to, new DrawCardStruct(Math.Min(5 - to.HandcardNum, to.MaxHp - to.HandcardNum), player, Name));
            }

            return false;
        }
    }

    public class BeizhanCProhibit : ProhibitSkill
    {
        public BeizhanCProhibit() : base("#beizhan-c-prohibit")
        {
        }
        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null)
        {
            if (from != null && from.HasFlag("beizhan_classic") && card != null)
            {
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                return !(fcard is SkillCard) && to != null && to != from;
            }
            return false;
        }
    }

    public class GangzhiClassic : TriggerSkill
    {
        public GangzhiClassic() : base("gangzhi_classic")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageForseen, TriggerEvent.Predamage };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.DamageForseen && data is DamageStruct damage && base.Triggerable(player, room) && damage.From != player)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.Predamage && base.Triggerable(player, room))
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name, true);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            if (data is DamageStruct damage)
            {
                if (triggerEvent == TriggerEvent.DamageForseen)
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "#gangzhi",
                        From = ask_who.Name,
                        Arg = Name,
                        Arg2 = damage.Damage.ToString()
                    };
                    room.SendLog(log);

                    room.LoseHp(ask_who, damage.Damage);
                }
                else
                {
                    room.LoseHp(damage.To, damage.Damage);
                }
                return true;
            }

            return false;
        }
    }

    public class Mubing : TriggerSkill
    {
        public Mubing() : base("mubing")
        {
            events.Add(TriggerEvent.EventPhaseStart);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Play)
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
            int num = 3;
            if (player.GetMark("diaoling") > 0) num++;
            List<int> card_ids = room.GetNCards(num);
            List<int> gets = new List<int>(), drops;

            foreach (int id in card_ids)
            {
                room.MoveCardTo(room.GetCard(id), player, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_TURNOVER, player.Name, Name, string.Empty), false);
                Thread.Sleep(200);
            }
            room.SetTag(Name, card_ids);
            List<int> discard = room.AskForExchange(player, Name, player.GetCardCount(true), 0, "@mubing-discard", string.Empty, "..!", info.SkillPosition);
            room.RemoveTag(Name);
            if (discard.Count > 0)
            {
                int number_count = 0;
                foreach (int id in discard)
                    number_count += room.GetCard(id).Number;
                room.SetTag("mubing_count", number_count);
                room.ThrowCard(ref discard,
                    new CardMoveReason(MoveReason.S_REASON_THROW, player.Name, Name, string.Empty) { General = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition) },
                    player);
                AskForMoveCardsStruct move = room.AskForMoveCards(player, card_ids, new List<int>(), false, Name, 1, card_ids.Count, true, false, new List<int>(), info.SkillPosition);
                room.RemoveTag("mubing_count");
                if (move.Success && move.Bottom.Count > 0)
                {
                    gets = move.Bottom;
                    drops = move.Top;
                }
                else
                    drops = card_ids;
            }
            else
                drops = card_ids;

            if (gets.Count > 0)
                room.MoveCards(new List<CardsMoveStruct>{
                new CardsMoveStruct(gets, player, Place.PlaceHand, new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name, Name, null)) }, true);
            if (drops.Count > 0)
                room.MoveCards(new List<CardsMoveStruct>{
                new CardsMoveStruct(drops, null, Place.DiscardPile, new CardMoveReason(MoveReason.S_REASON_NATURAL_ENTER, null, Name, null)) }, true);

            if (player.Alive && gets.Count > 0)
            {
                if (player.GetMark("diaoling") > 0)
                {
                    List<int> origin_yiji = new List<int>(gets);
                    while (player.Alive && gets.Count > 0)
                    {
                        if (!room.AskForYiji(player, ref gets, Name, false, false, true, -1, room.GetOtherPlayers(player), null, "@mubing-give", string.Empty, false, info.SkillPosition))
                            break;
                    }
                }
                else
                {
                    int count = player.GetMark("diaoling_count");
                    foreach (int id in gets)
                    {
                        FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(id).Name);
                        if (fcard is Slash || fcard is Weapon || fcard is Duel || fcard is FireAttack || fcard is SavageAssault || fcard is ArcheryAttack)
                            count++;
                    }
                    if (count > 0)
                    {
                        player.SetMark("diaoling_count", count);
                        room.SetPlayerStringMark(player, "diaoling", count.ToString());
                    }
                }
            }

            return false;
        }

        public override bool MoveFilter(Room room, int id, List<int> downs)
        {
            if (room.ContainsTag("mubing_count") && room.GetTag("mubing_count") is int count)
            {
                int all = 0;
                foreach (int down_id in downs)
                    all += room.GetCard(down_id).Number;

                if (id < 0)
                    return all <= count;
                else
                    return all + room.GetCard(id).Number <= count;
            }

            return false;
        }
    }

    public class Zhiqu : TriggerSkill
    {
        public Zhiqu() : base("zhiqu")
        {
            events.Add(TriggerEvent.DamageCaused);
            skill_type = SkillType.Wizzard;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DamageStruct damage && damage.To != null && player != damage.To)
            {
                string str = string.Format("{0}_{1}", Name, damage.To.Name);
                if (player.GetMark(str) == 0)
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            DamageStruct damage = (DamageStruct)data;
            room.SetTag("zhiqu_data", data);  // for AI
            bool invoke = room.AskForSkillInvoke(player, Name, damage.To, info.SkillPosition);
            room.RemoveTag("zhiqu_data");
            if (invoke)
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, damage.To.Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            player.SetTag(Name, info.SkillPosition);
            DamageStruct damage = (DamageStruct)data;
            Player to = damage.To;

            LogMessage log = new LogMessage
            {
                Type = "#damage-prevent",
                From = player.Name,
                To = new List<string> { to.Name },
                Arg = Name
            };
            room.SendLog(log);

            to.SetMark(Name, 1);
            to.SetTag("zhiqu_from", player.Name);
            string str = string.Format("{0}_{1}", Name, to.Name);
            player.SetMark(str, 1);
            return true;
        }
    }
    public class ZhiquSecond : TriggerSkill
    {
        public ZhiquSecond() : base("#zhiqu")
        {
            events.Add(TriggerEvent.DamageComplete);
            frequency = Frequency.Compulsory;
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            DamageStruct damage = (DamageStruct)data;
            if (damage.To == player && player.GetMark("zhiqu") > 0 && damage.To.ContainsTag("zhiqu_from") && damage.To.GetTag("zhiqu_from") is string from)
            {
                Player masu = room.FindPlayer(from);
                if (damage.From == masu && RoomLogic.PlayerHasShownSkill(room, masu, "zhiqu"))
                {
                    List<TriggerStruct> skill_list = new List<TriggerStruct>();
                    TriggerStruct trigger = new TriggerStruct(Name, masu)
                    {
                        SkillPosition = (string)masu.GetTag("zhiqu")
                    };
                    skill_list.Add(trigger);
                    return skill_list;
                }
            }
            return new List<TriggerStruct>();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player to, ref object data, Player player, TriggerStruct info)
        {
            to.RemoveTag("zhiqu_from");
            to.SetMark("zhiqu", 0);
            if (!to.IsNude())
            {
                List<int> ids = to.GetCards("he");
                int card_id;
                int min = 0;
                foreach (int id in ids)
                {
                    int number = room.GetCard(id).Number;
                    if (number > min) min = number;
                }
                ids.RemoveAll(t => room.GetCard(t).Number != min);
                if (ids.Count == 1)
                {
                    card_id = ids[0];
                }
                else
                {
                    List<int> give = room.AskForExchange(to, Name, 1, 1, "@zhiqu:" + player.Name, string.Empty, string.Join("#", ids), null);
                    card_id = give[0];
                }

                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, to.Name, player.Name, "zhiqu", string.Empty);
                room.ObtainCard(player, room.GetCard(card_id), reason);
            }

            return false;
        }
    }

    public class Diaoling : PhaseChangeSkill
    {
        public Diaoling() : base("diaoling")
        {
            frequency = Frequency.Wake;
            skill_type = SkillType.Recover;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Start && base.Triggerable(player, room) && player.GetMark(Name) == 0 && player.GetMark("diaoling_count") >= 6)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            room.SetPlayerMark(player, Name, 1);

            room.SetPlayerMark(player, "mubing_description_index", 1);
            room.RefreshSkill(player);

            room.SendCompulsoryTriggerLog(player, Name);
            room.RemovePlayerStringMark(player, Name);
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

            return false;
        }
    }

    public class Liushi : TriggerSkill
    {
        public Liushi() : base("liushi")
        {
            view_as_skill = new LiushiVS();
            events = new List<TriggerEvent> { TriggerEvent.Damaged };
            skill_type = SkillType.Attack;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is DamageStruct damage && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName) && damage.Card.GetSkillName() == Name && player.Alive
                && !damage.Transfer && !damage.Chain)
            {
                room.SetPlayerStringMark(player, Name, string.Empty);
                List<string> names = new List<string>();
                if (player.ContainsTag(Name)) names = (List<string>)player.GetTag(Name);

                if (!names.Contains(damage.From.Name)) names.Add(damage.From.Name);
                player.SetTag(Name, names);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class LiushiVS : ViewAsSkill
    {
        public LiushiVS() : base("liushi")
        {
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
            => selected.Count == 0 && to_select.Suit == WrappedCard.CardSuit.Heart;

        public override bool IsEnabledAtPlay(Room room, Player player) => !player.IsNude();
        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            if (cards.Count == 1)
            {
                foreach (WrappedCard card in GetGuhuo(room, player))
                {
                    card.AddSubCard(cards[0]);
                    result.Add(card);
                }
            }

            return result;
        }

        private List<WrappedCard> GetGuhuo(Room room, Player player)
        {
            WrappedCard wrapped1 = new WrappedCard(Slash.ClassName) { Skill = "_liushi" };
            wrapped1.DistanceLimited = false;
            WrappedCard wrapped2 = new WrappedCard(FireSlash.ClassName) { Skill = "_liushi" };
            wrapped2.DistanceLimited = false;
            WrappedCard wrapped3 = new WrappedCard(ThunderSlash.ClassName) { Skill = "_liushi" };
            wrapped3.DistanceLimited = false;
            List<WrappedCard> result = new List<WrappedCard> { wrapped1, wrapped2, wrapped3 };
            return result;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
            {
                WrappedCard hm = new WrappedCard(LiushiCard.ClassName)
                {
                    UserString = cards[0].Name
                };
                hm.AddSubCard(cards[0]);
                return hm;
            }

            return null;
        }
    }

    public class LiushiTar : TargetModSkill
    {
        public LiushiTar() : base("#liushi", false) { }
        public override int GetResidueNum(Room room, Player from, WrappedCard card) => card.GetSkillName() == "liushi" ? 999 : 0;
    }

    public class LiushiMax : MaxCardsSkill
    {
        public LiushiMax() : base("#liushi-max") { }

        public override int GetExtra(Room room, Player target) => target.ContainsTag("liushi") ? -1 : 0;
    }

    public class LiushiCard : SkillCard
    {
        public static string ClassName = "LiushiCard";
        public LiushiCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            WrappedCard wrapped = new WrappedCard(card.UserString) { Skill = "_liushi", DistanceLimited = false };
            FunctionCard fcard = Engine.GetFunctionCard(card.UserString);
            return fcard.TargetFilter(room, targets, to_select, Self, wrapped);
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            WrappedCard wrapped = new WrappedCard(card.UserString) { Skill = "_liushi", DistanceLimited = false };
            FunctionCard fcard = Engine.GetFunctionCard(card.UserString);
            return fcard.TargetsFeasible(room, targets, Self, wrapped);
        }

        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            Player player = use.From;
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_PUT, player.Name, "liushi", string.Empty);
            CardsMoveStruct move = new CardsMoveStruct(new List<int>(use.Card.SubCards), null, Place.DrawPile, reason)
            {
                To_pile_name = string.Empty,
                From = player.Name
            };
            List<CardsMoveStruct> moves = new List<CardsMoveStruct> { move };
            room.MoveCardsAtomic(moves, true);

            room.BroadcastSkillInvoke("liushi", player, use.Card.SkillPosition);
            room.NotifySkillInvoked(player, "liushi");
            Thread.Sleep(500);
            WrappedCard wrapped = new WrappedCard(use.Card.UserString) { Skill = "_liushi", DistanceLimited = false };
            return wrapped;
        }
    }

    public class Zhanwan : TriggerSkill
    {
        public Zhanwan() : base("zhanwan")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseEnd };
            skill_type = SkillType.Replenish;
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.From.Phase == PlayerPhase.Discard
                && move.Reason.Reason == MoveReason.S_REASON_RULEDISCARD && move.From_places.Contains(Place.PlaceHand)
                && move.From.ContainsTag("liushi") && move.From.GetTag("liushi") is List<string> names)
            {
                move.From.RemoveTag("liushi");
                room.RemovePlayerStringMark(move.From, "liushi");
                int count = move.Card_ids.Count;
                foreach (string name in names)
                {
                    Player p = room.FindPlayer(name);
                    if (p != null)
                        p.AddMark(Name, count);
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseEnd && player.Phase == PlayerPhase.Discard)
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (p.GetMark(Name) > 0)
                        triggers.Add(new TriggerStruct(Name, p));
            }
            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            room.DrawCards(ask_who, ask_who.GetMark(Name), Name);
            ask_who.SetMark(Name, 0);
            return false;
        }
    }

    public class Wangong : TriggerSkill
    {
        public Wangong() : base("wangong")
        {
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Attack;
            events = new List<TriggerEvent> { TriggerEvent.PreCardUsed, TriggerEvent.CardUsed, TriggerEvent.CardResponded };
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && base.Triggerable(player, room))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if ((!(fcard is SkillCard) && player.GetMark(Name) > 0) || (fcard is BasicCard && player.GetMark(Name) == 0))
                    return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && base.Triggerable(player, room) && resp.Use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(resp.Card.Name);
                if ((!(fcard is SkillCard) && player.GetMark(Name) > 0) || (fcard is BasicCard && player.GetMark(Name) == 0))
                    return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.PreCardUsed && data is CardUseStruct _use && player.GetMark(Name) > 0)
            {
                FunctionCard fcard = Engine.GetFunctionCard(_use.Card.Name);
                if (fcard is Slash)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                if (triggerEvent == TriggerEvent.PreCardUsed)
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "#damage-add",
                        From = player.Name,
                        Arg = use.Card.Name,
                        Arg2 = "1"
                    };
                    room.SendLog(log);

                    use.ExDamage += 1;
                    data = use;

                    player.SetMark(Name, 0);
                    room.RemovePlayerStringMark(player, Name);
                }
                else
                {
                    FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                    if (fcard is BasicCard)
                    {
                        room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                        room.SendCompulsoryTriggerLog(player, Name);
                        player.SetMark(Name, 1);
                        room.SetPlayerStringMark(player, Name, string.Empty);
                    }
                    else
                    {
                        player.SetMark(Name, 0);
                        room.RemovePlayerStringMark(player, Name);
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp)
            {
                FunctionCard fcard = Engine.GetFunctionCard(resp.Card.Name);
                if (fcard is BasicCard)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.SendCompulsoryTriggerLog(player, Name);
                    player.SetMark(Name, 1);
                    room.SetPlayerStringMark(player, Name, string.Empty);
                }
                else
                {
                    player.SetMark(Name, 0);
                    room.RemovePlayerStringMark(player, Name);
                }
            }

            return false;
        }
    }

    public class WangongTar : TargetModSkill
    {
        public WangongTar() : base("#wangong", false) { }
        
        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern) => from.GetMark("wangong") > 0;
        public override bool CheckSpecificAssignee(Room room, Player from, Player to, WrappedCard card, string pattern) => from.GetMark("wangong") > 0;
    }

    public class Fengzi : TriggerSkill
    {
        public Fengzi() : base("fengzi")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.CardFinished };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play)
                player.SetFlags("-fengzi");
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play && !player.HasFlag(Name)
                && !player.IsKongcheng() && use.To.Count > 0 && use.Card.Name != Collateral.ClassName)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard.IsNDTrick() || fcard is BasicCard)
                {
                    WrappedCard card = new WrappedCard(use.Card.Name) { Skill = "_fengzi" };
                    foreach (Player p in use.To)
                    {
                        if (p.Alive && RoomLogic.IsProhibited(room, player, p, card) == null)
                            return new TriggerStruct(Name, player);
                    }
                }
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                List<string> ids = new List<string>();
                if (fcard is TrickCard)
                {
                    foreach (int id in player.GetCards("h"))
                    {
                        FunctionCard _f = Engine.GetFunctionCard(room.GetCard(id).Name);
                        if (_f is TrickCard && RoomLogic.CanDiscard(room, player, player, id))
                            ids.Add(id.ToString());
                    }
                }
                else
                {
                    foreach (int id in player.GetCards("h"))
                    {
                        FunctionCard _f = Engine.GetFunctionCard(room.GetCard(id).Name);
                        if (_f is BasicCard && RoomLogic.CanDiscard(room, player, player, id))
                            ids.Add(id.ToString());
                    }
                }
                room.SetTag(Name, data);
                List<int> discard = room.AskForExchange(player, Name, 1, 0, "@fengzi:::" + use.Card.Name, string.Empty, string.Join("#", ids), info.SkillPosition);
                room.RemoveTag(Name);
                if (discard.Count > 0)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.NotifySkillInvoked(player, Name);
                    room.ThrowCard(ref discard,
                        new CardMoveReason(MoveReason.S_REASON_THROW, player.Name, Name, string.Empty) { General = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition) },
                        player, null, Name);
                    player.SetFlags(Name);
                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Alive && data is CardUseStruct use)
            {
                List<Player> targets = new List<Player>();
                WrappedCard card = new WrappedCard(use.Card.Name) { Skill = "_fengzi" };
                foreach (Player p in use.To)
                {
                    if (p.Alive && RoomLogic.IsProhibited(room, player, p, card) == null)
                        targets.Add(p);
                }
                if (targets.Count > 0)
                    room.UseCard(new CardUseStruct(card, player, targets, false), true, true);
            }
            return false;
        }
    }

    public class Jizhan : TriggerSkill
    {
        public Jizhan() : base("jizhan")
        {
            events.Add(TriggerEvent.EventPhaseStart);
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Draw && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

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
            List<int> gets = new List<int>();
            int old = 0;
            bool big = true;
            while (true)
            {
                int id = room.GetNCards(1)[0];
                gets.Add(id);
                room.MoveCardTo(room.GetCard(id), player, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_TURNOVER, player.Name, Name, null), false);
                int next = room.GetCard(id).Number;
                if ((big && next > old) || (!big && next < old))
                {
                    if (old > 0)
                    {
                        List<string> arg = new List<string> { GameEventType.S_GAME_EVENT_JUDGE_RESULT.ToString(), id.ToString(), "true" };
                        room.DoBroadcastNotify(CommandType.S_COMMAND_LOG_EVENT, arg);
                        Thread.Sleep(400);
                    }

                    old = next;
                    string choice = room.AskForChoice(player, Name, "big+small", new List<string> { "@jizhan:::" + next.ToString() }, next, info.SkillPosition);
                    big = choice == "big";
                    LogMessage log = new LogMessage()
                    {
                        Type = "#Choose-Option",
                        From = player.Name,
                        Arg = "jizhan:" + choice,
                    };
                    room.SendLog(log);
                }
                else
                {
                    List<string> arg = new List<string> { GameEventType.S_GAME_EVENT_JUDGE_RESULT.ToString(), id.ToString(), "false" };
                    room.DoBroadcastNotify(CommandType.S_COMMAND_LOG_EVENT, arg);

                    Thread.Sleep(800);
                    break;
                }
            }
            gets.RemoveAll(t => room.GetCardPlace(t) != Place.PlaceTable);
            if (gets.Count > 0)
                room.MoveCards(new List<CardsMoveStruct>{ new CardsMoveStruct(gets, player, Place.PlaceHand, new CardMoveReason(MoveReason.S_REASON_GOTBACK, player.Name, Name, null)) }, true);

            return true;
        }
    }

    public class Fusong : TriggerSkill
    {
        public Fusong() : base("fusong")
        {
            events.Add(TriggerEvent.Death);
            skill_type = SkillType.Wizzard;
        }
        public override bool CanPreShow() => false;
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player != null && RoomLogic.PlayerHasSkill(room, player, Name)) return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@fusong", true, true, info.SkillPosition);
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
                string choice = room.AskForSkill(target, Name, "jizhan+fengzi", "@choose-skill", 1, 1, false, info.SkillPosition);
                room.HandleAcquireDetachSkills(target, choice, true);
            }
            return false;
        }
    }

    public class Zhuangshu : TriggerSkill
    {
        public Zhuangshu() : base("zhuangshu")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.BeforeCardsMove, TriggerEvent.EventPhaseStart, TriggerEvent.GameStart };
            skill_type = SkillType.Recover;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.BeforeCardsMove && data is CardsMoveOneTimeStruct move && move.From != null && move.From_places.Contains(Place.PlaceEquip)
                && (move.To_place != Place.PlaceEquip || move.To == null) && move.To_pile_name != "#virtual_cards")
            {
                List<int> remove = new List<int>();
                List<int> indexes = new List<int>();
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    int id = move.Card_ids[i];
                    WrappedCard card = Engine.GetRealCard(id);
                    if (move.From_places[i] == Place.PlaceEquip && (card.Name == Comb1.ClassName || card.Name == Comb2.ClassName || card.Name == Comb3.ClassName))
                    {
                        remove.Add(id);
                        indexes.Add(i);
                    }
                }
                if (remove.Count > 0)
                {
                    for (int i = indexes.Count - 1; i >= 0; i--)
                        move.From_places.RemoveAt(indexes[i]);
                    move.Card_ids.RemoveAll(t => remove.Contains(t));
                    if (move.Reason.Card != null)
                    {
                        List<int> subs = room.GetSubCards(move.Reason.Card);
                        subs.RemoveAll(t => remove.Contains(t));
                    }
                    data = move;

                    Player holder = room.Players[0];
                    room.AddToPile(holder, "#virtual_cards", remove, false);
                }
            }
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct _move && _move.From != null 
                && (_move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && _move.Reason.SkillName == Name && _move.Card_ids.Count == 1)
            {
                WrappedCard card = room.GetCard(_move.Card_ids[0]);
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                _move.From.SetTag(Name, fcard.TypeID);
            }
            else if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
            {
                foreach (int id in Engine.GetEngineCards())
                {
                    WrappedCard real_card = Engine.GetRealCard(id);
                    if ((real_card.Name == Comb1.ClassName || real_card.Name == Comb2.ClassName || real_card.Name == Comb3.ClassName) && room.GetCard(id) == null)
                        room.AddNewCard(id);
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.RoundStart)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (!p.IsKongcheng()) triggers.Add(new TriggerStruct(Name, p));
            }
            else if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                triggers.Add(new TriggerStruct(Name, player));
            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.GameStart)
            {
                string choice = room.AskForChoice(player, Name, "Comb1+Comb2+Comb3", null, null, info.SkillPosition);
                foreach (int id in room.RoomCards)
                {
                    WrappedCard card = room.GetCard(id);
                    if (card.Name == choice)
                    {
                        player.SetMark(Name, id);
                        break;
                    }
                }
                return info;
            }
            else
            {
                if (room.AskForDiscard(ask_who, Name, 1, 1, true, false, "@zhuangshu:" + player.Name, true, info.SkillPosition))
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.GameStart)
            {
                if (player.CanPutEquip(4))
                {
                    int card_id = player.GetMark(Name);
                    List<CardsMoveStruct> exchangeMove = new List<CardsMoveStruct>();
                    CardsMoveStruct move2 = new CardsMoveStruct(new List<int> { card_id }, room.GetCardOwner(card_id), player, room.GetCardPlace(card_id),
                                          Place.PlaceEquip, new CardMoveReason(MoveReason.S_REASON_PUT, player.Name, Name, string.Empty));
                    exchangeMove.Add(move2);
                    room.MoveCardsAtomic(exchangeMove, true);

                    LogMessage log = new LogMessage
                    {
                        From = player.Name,
                        Type = "$Install",
                        Card_str = card_id.ToString()
                    };
                    room.SendLog(log);
                }
            }
            else if (ask_who.ContainsTag(Name) && ask_who.GetTag(Name) is CardType type)
            {
                ask_who.RemoveTag(Name);
                if (player.Alive && !player.GetTreasure() && player.CanPutEquip(4))
                {
                    string card_name = string.Empty;
                    switch (type)
                    {
                        case CardType.TypeBasic:
                            card_name = Comb1.ClassName;
                            break;
                        case CardType.TypeTrick:
                            card_name = Comb2.ClassName;
                            break;
                        case CardType.TypeEquip:
                            card_name = Comb3.ClassName;
                            break;
                    }

                    int card_id = -1;
                    foreach (int id in room.RoomCards)
                    {
                        WrappedCard card = room.GetCard(id);
                        if (card.Name == card_name)
                        {
                            card_id = id;
                            break;
                        }
                    }

                    if (card_id > -1)
                    {
                        List<CardsMoveStruct> exchangeMove = new List<CardsMoveStruct>();
                        CardsMoveStruct move2 = new CardsMoveStruct(new List<int> { card_id }, room.GetCardOwner(card_id), player, room.GetCardPlace(card_id),
                                              Place.PlaceEquip, new CardMoveReason(MoveReason.S_REASON_PUT, player.Name, Name, string.Empty));
                        exchangeMove.Add(move2);
                        room.MoveCardsAtomic(exchangeMove, true);

                        LogMessage log = new LogMessage
                        {
                            From = player.Name,
                            Type = "$Install",
                            Card_str = card_id.ToString()
                        };
                        room.SendLog(log);
                    }
                }
            }

            return false;
        }
    }

    public class Chuiti : TriggerSkill
    {
        public Chuiti() : base("chuiti")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Wizzard;
            view_as_skill = new ChuitiVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD
                && move.To_place == Place.PlaceTable && ((base.Triggerable(move.From, room) && !move.From.HasFlag(Name))
                || move.From.HasTreasure(Comb1.ClassName) || move.From.HasTreasure(Comb2.ClassName) || move.From.HasTreasure(Comb2.ClassName)))
            {
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    int card_id = move.Card_ids[i];
                    if (room.GetCardPlace(card_id) == Place.PlaceTable && (move.From_places[i] == Place.PlaceHand || move.From_places[i] == Place.PlaceEquip))
                        room.GetCard(card_id).SetFlags(Name);
                }
            }
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To_place == Place.DiscardPile
                && (move.Reason.Reason & MoveReason.S_MASK_BASIC_REASON) == MoveReason.S_REASON_DISCARD && move.From != null && move.From.Alive)
            {
                if (base.Triggerable(move.From, room) && !move.From.HasFlag(Name))
                    triggers.Add(new TriggerStruct(Name, move.From));
                else if (move.From.HasTreasure(Comb1.ClassName) || move.From.HasTreasure(Comb2.ClassName) || move.From.HasTreasure(Comb2.ClassName))
                    foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                        if (!p.HasFlag(Name))
                            triggers.Add(new TriggerStruct(Name, p));
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p.GetPile(Name).Count > 0)
                        triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move)
            {
                List<int> ids = new List<int>();
                foreach (int id in move.Card_ids)
                {
                    WrappedCard card = room.GetCard(id);
                    FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                    if (room.GetCardPlace(id) == Place.DiscardPile && fcard.IsAvailable(room, ask_who, card) && card.HasFlag(Name))
                        ids.Add(id);
                }
                if (ids.Count > 0)
                {
                    List<int> result = room.NotifyChooseCards(ask_who, ids, Name, 1, 0, "@chuiti-pick", null, info.SkillPosition);
                    if (result.Count > 0)
                    {
                        ask_who.SetFlags(Name);
                        room.AddToPile(ask_who, Name, result);
                        room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                        room.NotifySkillInvoked(ask_who, Name);
                        return info;
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging)
            {
                while (ask_who.GetPile(Name).Count > 0)
                {
                    WrappedCard card = room.AskForUseCard(ask_who, RespondType.Skill, "@@chuiti", "@chuiti", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
                    if (card == null)
                        break;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info) => false;
    }

    public class ChuitiVS : OneCardViewAsSkill
    {
        public ChuitiVS() : base("chuiti") { response_pattern = "@@chuiti"; expand_pile = Name; }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player) => player.GetPile(expand_pile).Contains(to_select.Id);
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard ct = new WrappedCard(ChuitiCard.ClassName);
            ct.AddSubCard(card);
            return ct;
        }
    }

    public class ChuitiCard : SkillCard
    {
        public static string ClassName = "ChuitiCard";
        public ChuitiCard() : base(ClassName) { }
        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            WrappedCard wrapped = room.GetCard(use.Card.GetEffectiveId());
            return wrapped;
        }
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            WrappedCard wrapped = room.GetCard(card.GetEffectiveId());
            FunctionCard fcard = Engine.GetFunctionCard(wrapped.Name);
            return fcard.TargetsFeasible(room, targets, Self, wrapped);
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            WrappedCard wrapped = room.GetCard(card.GetEffectiveId());
            FunctionCard fcard = Engine.GetFunctionCard(wrapped.Name);
            return fcard.TargetFilter(room, targets, to_select, Self, wrapped);
        }
    }

    public class ChuitiClear : TriggerSkill
    {
        public ChuitiClear() : base("#chuiti")
        {
            events.Add(TriggerEvent.CardsMoveOneTime);
        }
        public override int Priority => 0;
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            CardsMoveOneTimeStruct move = (CardsMoveOneTimeStruct)data;
            if (move.From != null && move.To_place == Place.DiscardPile && move.From_places.Contains(Place.PlaceTable))
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    WrappedCard card = room.GetCard(move.Card_ids[i]);
                    if (move.From_places[i] == Place.PlaceTable && card.HasFlag("chuiti"))
                        card.SetFlags("-chuiti");
                }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            return new TriggerStruct();
        }
    }

    public class ZhouxuanZH : TriggerSkill
    {
        public ZhouxuanZH() : base("zhouxuan_zh")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.EventLoseSkill, TriggerEvent.EventPhaseEnd };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseEnd && player.Phase == PlayerPhase.Play && player.GetPile(Name).Count > 0)
                room.ClearOnePrivatePile(player, Name);
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct info && info.Info == Name && player.GetPile(Name).Count > 0)
                room.ClearOnePrivatePile(player, Name);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Discard && !player.IsKongcheng() && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> ids = room.AskForExchange(player, Name, Math.Min(5, player.HandcardNum), 0, "@zhouxuan_zh", string.Empty, ".", info.SkillPosition);
            if (ids.Count > 0)
            {
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.AddToPile(player, Name, ids, false);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info) => false;
    }

    public class ZhouxuanZhEffect : TriggerSkill
    {
        public ZhouxuanZhEffect() : base("#zhouxuan_zh")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded };
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && player.Alive && data is CardUseStruct use && !Engine.IsSkillCard(use.Card.Name) && player.GetPile("zhouxuan_zh").Count > 0)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use && player.Alive && player.GetPile("zhouxuan_zh").Count > 0)
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, "zhouxuan_zh");

            List<int> maps = player.GetPile("zhouxuan_zh");
            if (maps.Count > 0)
            {
                int draw = 1;
                bool only = true;
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.HandcardNum >= player.HandcardNum)
                    {
                        only = false;
                        break;
                    }
                }

                if (!only) draw = maps.Count;
                room.DrawCards(player, draw, "zhouxuan_zh");

                if (player.Alive)
                {
                    int card_id;
                    if (maps.Count == 1)
                        card_id = maps[0];
                    else
                    {
                        room.FillAG("zhouxuan_zh", maps, player);
                        card_id = room.AskForAG(player, maps, false, "zhouxuan_zh");
                        room.ClearAG(player);
                    }

                    LogMessage log = new LogMessage
                    {
                        Type = "$RemoveFromPile",
                        From = player.Name,
                        Arg = "zhouxuan_zh",
                        Card_str = card_id.ToString()
                    };
                    room.SendLog(log);

                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_REMOVE_FROM_PILE, null, "zhouxuan_zh", null);
                    List<int> ids = new List<int> { card_id };
                    room.ThrowCard(ref ids, reason, null);
                    room.ClearAG(player);
                }
            }

            return false;
        }
    }

    public class JuguanDraw : TriggerSkill
    {
        public JuguanDraw() : base("#juguan")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageDone, TriggerEvent.EventPhaseProceeding, TriggerEvent.CardUsed, TriggerEvent.TurnStart };
            skill_type = SkillType.Attack;
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && use.Card.GetSkillName() == "juguan" && player != null && player.Alive)
            {
                player.SetFlags(string.Format("juguan_{0}", RoomLogic.CardToString(room, use.Card)));
            }
            else if (triggerEvent == TriggerEvent.DamageDone && data is DamageStruct damage)
            {
                if (damage.Card != null && damage.Card.GetSkillName() == "juguan")
                {
                    Player from = null;
                    string flag = string.Format("juguan_{0}", RoomLogic.CardToString(room, damage.Card));
                    foreach (Player p in room.GetAlivePlayers())
                    {
                        if (p.HasFlag(flag))
                        {
                            from = p;
                            break;
                        }
                    }
                    if (from != null)
                    {
                        from.AddMark("juguan");
                        string str = string.Format("juguan_{0}", from.Name);
                        damage.To.AddMark(str);
                    }
                }

                if (damage.From != null && damage.To != null && damage.To.Alive)
                {
                    string str = string.Format("juguan_{0}", damage.To.Name);
                    if (damage.From.GetMark(str) > 0)
                    {
                        damage.From.SetMark(str, 0);
                        if (damage.To.GetMark("juguan") > 1)
                            damage.To.SetMark("juguan", 0);
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.TurnStart)
            {
                string str = string.Format("juguan_{0}", player.Name);
                foreach (Player p in room.GetAlivePlayers())
                    p.SetMark(str, 0);
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseProceeding && player.Phase == PlayerPhase.Draw && (int)data >= 0 && player.GetMark("juguan") > 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is int count)
            {
                int times = player.GetMark("juguan");
                player.SetMark("juguan", 0);
                count += 2 * times;
                data = count;
            }

            return false;
        }
    }

    public class Juguan : ViewAsSkill
    {
        public Juguan() : base("juguan")
        {
            response_or_use = true;
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (selected.Count == 0 && (room.GetCardPlace(to_select.Id) == Place.PlaceHand || room.GetCardPlace(to_select.Id) == Place.PlaceSpecial)
                && !RoomLogic.IsCardLimited(room, player, to_select, HandlingMethod.MethodUse, true))
                return true;
            return false;
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => player.UsedTimes("ViewAsSkill_juguanCard") < 1;
        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            if (cards.Count == 1)
            {
                WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = Name };
                slash.AddSubCards(cards);
                slash = RoomLogic.ParseUseCard(room, slash);
                if (Slash.IsAvailable(room, player, slash))
                    result.Add(slash);

                WrappedCard duel = new WrappedCard(Duel.ClassName) { Skill = Name };
                duel.AddSubCards(cards);
                duel = RoomLogic.ParseUseCard(room, duel);
                if (Duel.Instance.IsAvailable(room, player, duel))
                    result.Add(duel);
            }
            return result;
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
                return cards[0];

            return null;
        }
    }

    public class FengjiSP : TriggerSkill
    {
        public FengjiSP() : base("fengji_sp")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.EventPhaseProceeding, TriggerEvent.EventPhaseChanging };
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                room.RemovePlayerStringMark(player, "fengji_slash");
                player.SetMark(Name, 0);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Draw)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.EventPhaseProceeding && player != null && player.Alive && player.GetMark("fengji_draw") > 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                List<string> result = new List<string>(), choices = new List<string> { "draw", "slash", "cancel" };
                string choice = room.AskForChoice(player, Name, string.Join("+", choices), null, null, info.SkillPosition);
                if (choice != "cancel")
                {
                    result.Add(choice);
                    choices.Remove(choice);
                    choice = room.AskForChoice(player, Name, string.Join("+", choices), null, null, info.SkillPosition);
                    if (choice != "cancel") result.Add(choice);
                }
                room.SendCompulsoryTriggerLog(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                if (!result.Contains("draw"))
                {
                    player.AddMark("fengji_draw");
                    room.SetPlayerStringMark(player, "fengji_draw", player.GetMark("fengji_draw").ToString());
                }
                else
                {
                    player.AddMark("fengji_draw", -1);
                    room.SetPlayerStringMark(player, "fengji_draw", player.GetMark("fengji_draw").ToString());

                    Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@fengji_sp-draw", false, true, info.SkillPosition);
                    if (target != null)
                    {

                        target.AddMark("fengji_draw", 2);
                        room.SetPlayerStringMark(target, "fengji_draw", target.GetMark("fengji_draw").ToString());
                    }
                }
                if (!result.Contains("slash"))
                {
                    player.AddMark(Name);
                    room.SetPlayerStringMark(player, "fengji_slash", player.GetMark(Name).ToString());

                }
                else
                {
                    player.AddMark(Name, -1);
                    room.SetPlayerStringMark(player, "fengji_slash", player.GetMark(Name).ToString());

                    Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@fengji_sp-slash", false, true, info.SkillPosition);
                    if (target != null)
                    {
                        target.AddMark(Name, 2);
                        room.SetPlayerStringMark(target, "fengji_slash", target.GetMark(Name).ToString());
                    }
                }
            }
            else if (data is int count)
            {
                int add = player.GetMark("fengji_draw");
                count += add;
                data = count;
                player.SetMark("fengji_draw", 0);
                room.RemovePlayerStringMark(player, "fengji_draw");
            }

            return false;
        }
    }

    public class FengjiTar : TargetModSkill
    {
        public FengjiTar() : base("#fengji_sp", false) { }

        public override int GetResidueNum(Room room, Player from, WrappedCard card) => from.GetMark("fengji_sp");
    }

    public class Huamu : TriggerSkill
    {
        public Huamu() : base("huamu")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded };
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (room.ContainsTag(Name) && room.GetTag(Name) is WrappedCard.CardSuit suit && base.Triggerable(player, room))
            {
                WrappedCard.CardSuit use_suit = WrappedCard.CardSuit.SuitToBeDecided;
                if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && !use.Card.IsVirtualCard() && use.IsHandcard)
                {
                    if (suit != WrappedCard.CardSuit.NoSuit) suit = WrappedCard.IsBlack(suit) ? WrappedCard.CardSuit.NoSuitBlack : WrappedCard.CardSuit.NoSuitRed;
                    use_suit = WrappedCard.IsBlack(use.Card.Suit) ? WrappedCard.CardSuit.NoSuitBlack : WrappedCard.CardSuit.NoSuitRed;
                }
                else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use && resp.Handcard && !resp.Card.IsVirtualCard())
                {
                    if (suit != WrappedCard.CardSuit.NoSuit) suit = WrappedCard.IsBlack(suit) ? WrappedCard.CardSuit.NoSuitBlack : WrappedCard.CardSuit.NoSuitRed;
                    use_suit = WrappedCard.IsBlack(resp.Card.Suit) ? WrappedCard.CardSuit.NoSuitBlack : WrappedCard.CardSuit.NoSuitRed;
                }
                if (use_suit != WrappedCard.CardSuit.SuitToBeDecided && suit != use_suit) return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, data , info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                player.SetMark(Name, 1);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use)
                room.AddToPile(player, Name, use.Card.Id, true);
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp)
                room.AddToPile(player, Name, resp.Card.Id, true);
            return false;
        }
    }

    public class HuamuRecord : TriggerSkill
    {
        public HuamuRecord() : base("#huamu")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded, TriggerEvent.EventPhaseChanging };
        }
        public override int Priority => 1;
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                room.RemoveTag("huamu");
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && !Engine.IsSkillCard(use.Card.Name))
                room.SetTag("huamu", use.Card.Suit);
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use)
                room.SetTag("huamu", resp.Card.Suit);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who) => new TriggerStruct();
    }

    public class Qianmeng : TriggerSkill
    {
        public Qianmeng() : base("qianmeng")
        {
            events.Add(TriggerEvent.CardsMoveOneTime);
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Replenish;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (data is CardsMoveOneTimeStruct move)
            {
                Player from = null;
                if (move.From_pile_names.Contains("huamu") && move.From != null && move.From.Alive)
                    from = move.From;
                else if (move.To_pile_name == "huamu" && move.To != null && move.To.Alive)
                    from = move.To;

                if (from != null)
                {

                    int red = 0, black = 0;
                    foreach (int id in from.GetPile("huamu"))
                    {
                        if (WrappedCard.IsBlack(room.GetCard(id).Suit))
                            black++;
                        else
                            red++;
                    }

                    if (black == red || black ==0 || red == 0)
                    {
                        foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                            triggers.Add(new TriggerStruct(Name, p));
                    }
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            ask_who.SetMark(Name, 1);
            room.DrawCards(ask_who, 1, Name);
            return false;
        }
    }

    public class Liangyuan : TriggerSkill
    {
        public Liangyuan() : base("liangyuan")
        {
            events = new List<TriggerEvent> { TriggerEvent.RoundStart, TriggerEvent.CardUsedAnnounced };
            view_as_skill = new LiangyuanVS();
            skill_type = SkillType.Alter;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && use.Card.GetSkillName() == Name)
                player.AddMark(use.Card.Name == Peach.ClassName ? "liangyuan_peach" : "liangyuan_ana", 1);
            else if (triggerEvent == TriggerEvent.RoundStart)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    p.SetMark("liangyuan_peach", 0);
                    p.SetMark("liangyuan_ana", 0);
                }
            }
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class LiangyuanVS : ViewAsSkill
    {
        public LiangyuanVS() : base("liangyuan") { }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => false;
        public override bool IsEnabledAtPlay(Room room, Player player) => player.GetMark("liangyuan_peach") == 0 && player.IsWounded() || player.GetMark("liangyuan_ana") == 0;
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
        {
            if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE)
                return (MatchPeach(respond) && player.GetMark("liangyuan_peach") == 0) || (MatchAnaleptic(respond) && player.GetMark("liangyuan_ana") == 0);
            return false;
        }
        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE)
            {
                string pattern = room.GetRoomState().GetCurrentCardUsePattern();
                if (player.GetMark("liangyuan_peach") == 0)
                {
                    List<int> ids = new List<int>();
                    foreach (Player p in room.GetAlivePlayers())
                    {
                        foreach (int id in p.GetPile("huamu"))
                            if (WrappedCard.IsRed(room.GetCard(id).Suit)) ids.Add(id);
                    }
                    if (ids.Count > 0)
                    {
                        WrappedCard peach = new WrappedCard(Peach.ClassName) { Skill = Name };
                        peach.AddSubCards(ids);
                        peach = RoomLogic.ParseUseCard(room, peach);
                        if (Engine.MatchExpPattern(room, pattern, player, peach))
                            result.Add(peach);
                    }
                }
                if (player.GetMark("liangyuan_ana") == 0)
                {
                    List<int> ids = new List<int>();
                    foreach (Player p in room.GetAlivePlayers())
                    {
                        foreach (int id in p.GetPile("huamu"))
                            if (WrappedCard.IsBlack(room.GetCard(id).Suit)) ids.Add(id);
                    }
                    if (ids.Count > 0)
                    {
                        WrappedCard peach = new WrappedCard(Analeptic.ClassName) { Skill = Name };
                        peach.AddSubCards(ids);
                        peach = RoomLogic.ParseUseCard(room, peach);
                        if (Engine.MatchExpPattern(room, pattern, player, peach))
                            result.Add(peach);
                    }
                }
            }
            else
            {
                if (player.GetMark("liangyuan_peach") == 0 && player.IsWounded())
                {
                    List<int> ids = new List<int>();
                    foreach (Player p in room.GetAlivePlayers())
                    {
                        foreach (int id in p.GetPile("huamu"))
                            if (WrappedCard.IsRed(room.GetCard(id).Suit)) ids.Add(id);
                    }
                    if (ids.Count > 0)
                    {
                        WrappedCard peach = new WrappedCard(Peach.ClassName) { Skill = Name };
                        peach.AddSubCards(ids);
                        peach = RoomLogic.ParseUseCard(room, peach);
                        result.Add(peach);
                    }
                }
                if (player.GetMark("liangyuan_ana") == 0)
                {
                    List<int> ids = new List<int>();
                    foreach (Player p in room.GetAlivePlayers())
                    {
                        foreach (int id in p.GetPile("huamu"))
                            if (WrappedCard.IsBlack(room.GetCard(id).Suit)) ids.Add(id);
                    }
                    if (ids.Count > 0)
                    {
                        WrappedCard ana = new WrappedCard(Analeptic.ClassName) { Skill = Name };
                        ana.AddSubCards(ids);
                        ana = RoomLogic.ParseUseCard(room, ana);
                        if (player.UsedTimes(Analeptic.ClassName) <= Engine.CorrectCardTarget(room, TargetModSkill.ModType.Residue, player, ana)
                            || Engine.CorrectCardTarget(room, TargetModSkill.ModType.SpecificAssignee, player, player, ana))
                            result.Add(ana);
                    }
                }
            }
            return result;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
                return cards[0];
            return null;
        }
    }

    public class Jisi : TriggerSkill
    {
        public Jisi() : base("jisi")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            frequency = Frequency.Limited;
            limit_mark = "@jisi";
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Start && player.GetMark(limit_mark) > 0
                && (player.GetMark("huamu") > 0 || player.GetMark("qianmeng") > 0 || player.GetMark("liangyuan") > 0))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@jisi-tar", true, true, info.SkillPosition);
            if (target != null)
            {
                room.SetTag(Name, target);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.RemovePlayerMark(player, limit_mark);
                room.DoSuperLightbox(player, info.SkillPosition, Name);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.GetTag(Name) is Player target)
            {
                room.RemoveTag(Name);
                List<string> choices = new List<string>();
                if (player.GetMark("huamu") > 0)
                    choices.Add("huamu");
                if (player.GetMark("qianmeng") > 0)
                    choices.Add("qianmeng");
                if (player.GetMark("liangyuan") > 0)
                    choices.Add("liangyuan");

                if (choices.Count > 0)
                {
                    string choice = room.AskForChoice(player, Name, string.Join("+", choices), new List<string> { "@to-player:" + target.Name }, target, info.SkillPosition);
                    room.HandleAcquireDetachSkills(target, choice, true);
                }
                if (target.Alive && player.Alive)
                {
                    WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_jisi", DistanceLimited = false };
                    room.UseCard(new CardUseStruct(slash, player, target, false), false, true);
                }
            }
            return false;
        }
    }

    public class Qiangwu : TriggerSkill
    {
        public Qiangwu() : base("qiangwu")
        {
            events.Add(TriggerEvent.EventPhaseChanging);
            skill_type = SkillType.Attack;
            view_as_skill = new QiangwuVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetMark(Name) > 0)
            {
                player.SetMark(Name, 0);
                room.RemovePlayerStringMark(player, Name);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }
    public class QiangwuVS : ZeroCardViewAsSkill
    {
        public QiangwuVS() : base("qiangwu")
        {
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(QiangwuCard.ClassName);
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard card = new WrappedCard(QiangwuCard.ClassName)
            {
                Skill = Name
            };
            return card;
        }
    }

    public class QiangwuCard : SkillCard
    {
        public static string ClassName = "QiangwuCard";
        public QiangwuCard() : base(ClassName)
        {
            target_fixed = true;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            JudgeStruct judge = new JudgeStruct
            {
                Good = true,
                PlayAnimation = false,
                Who = player,
                Reason = "qiangwu"
            };

            room.Judge(ref judge);

            player.SetMark("qiangwu", judge.JudgeNumber);
            room.SetPlayerStringMark(player, "qiangwu", judge.JudgeNumber.ToString());
        }
    }

    public class QiangwuTar : TargetModSkill
    {
        public QiangwuTar() : base("#qiangwu-tar", false) { }

        public override int GetResidueNum(Room room, Player from, WrappedCard card) => from.GetMark("qiangwu") > 0 && RoomLogic.GetCardNumber(room, card) > from.GetMark("qiangwu") ? 999 : 0;

        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern)
        {
            return from.GetMark("qiangwu") > 0 && RoomLogic.GetCardNumber(room, card) < from.GetMark("qiangwu");
        }
    }

    public class Xueji : OneCardViewAsSkill
    {
        public Xueji() : base("xueji")
        {
            filter_pattern = ".|red";
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.IsNude() && !player.HasUsed(XuejiCard.ClassName);
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard xj = new WrappedCard(XuejiCard.ClassName)
            {
                Skill = Name
            };
            xj.AddSubCard(card);
            return xj;
        }
    }

    public class XuejiCard : SkillCard
    {
        public static string ClassName = "XuejiCard";
        public XuejiCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count < Math.Max(1, Self.GetLostHp());
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            List<Player> targets = new List<Player>(card_use.To);
            room.SortByActionOrder(ref targets);

            LogMessage log = new LogMessage("#UseCard")
            {
                From = player.Name,
                To = new List<string>(),
                Card_str = RoomLogic.CardToString(room, card_use.Card)
            };
            log.SetTos(targets);

            List<int> used_cards = new List<int>();
            List<CardsMoveStruct> moves = new List<CardsMoveStruct>();
            used_cards.AddRange(card_use.Card.SubCards);

            RoomThread thread = room.RoomThread;
            object data = card_use;
            thread.Trigger(TriggerEvent.PreCardUsed, room, player, ref data);

            card_use = (CardUseStruct)data;

            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_THROW, card_use.From.Name, null,
                card_use.Card.Skill, null)
            {
                Card = card_use.Card,
                General = RoomLogic.GetGeneralSkin(room, player, card_use.Card.Skill, card_use.Card.SkillPosition)
            };

            room.RecordSubCards(card_use.Card);
            room.MoveCardTo(card_use.Card, card_use.From, null, Place.PlaceTable, reason, true);
            room.SendLog(log);

            List<int> table_cardids = room.GetCardIdsOnTable(room.GetSubCards(card_use.Card));
            if (table_cardids.Count > 0)
            {
                CardsMoveStruct move = new CardsMoveStruct(table_cardids, player, null, Place.PlaceTable, Place.DiscardPile, reason);
                room.MoveCardsAtomic(new List<CardsMoveStruct> { move }, true);
                room.RemoveSubCards(card_use.Card);
            }

            room.RoomThread.Trigger(TriggerEvent.CardUsedAnnounced, room, player, ref data);
            room.RoomThread.Trigger(TriggerEvent.CardTargetAnnounced, room, player, ref data);

            room.RoomThread.Trigger(TriggerEvent.CardUsed, room, player, ref data);
            room.RoomThread.Trigger(TriggerEvent.CardFinished, room, player, ref data);
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            List<Player> targets = new List<Player>(card_use.To);
            foreach (Player p in targets)
                if (!p.Chained && RoomLogic.CanBeChainedBy(room, p, player))
                    room.SetPlayerChained(p, true);

            Player target = card_use.To[0];
            if (target.Alive)
                room.Damage(new DamageStruct("xeji", player, target, 1, DamageStruct.DamageNature.Fire));
        }
    }

    public class Huxiao : TriggerSkill
    {
        public Huxiao() : base("huxiao")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage };
            skill_type = SkillType.Attack;
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DamageStruct damage && damage.To.Alive && base.Triggerable(player, room) && damage.Nature == DamageStruct.DamageNature.Fire)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            if (data is DamageStruct damage && damage.To.Alive)
            {
                room.DrawCards(damage.To, new DrawCardStruct(1, player, Name));
                if (room.Current == player)
                    player.SetFlags(string.Format("{0}_{1}", Name, damage.To.Name));
            }

            return false;
        }
    }

    public class HuxiaoTar : TargetModSkill
    {
        public HuxiaoTar() : base("#huxiao-tar", false)
        {
            pattern = ".Basic";
        }

        public override bool CheckSpecificAssignee(Room room, Player from, Player to, WrappedCard card, string pattern)
        {
            return from != null && to != null && from.HasFlag(string.Format("huxiao_{0}", to.Name));
        }
    }

    public class Wuji : TriggerSkill
    {
        public Wuji() : base("wuji")
        {
            frequency = Frequency.Wake;
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.Damage, TriggerEvent.EventPhaseChanging };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Damage && base.Triggerable(player, room) && player.GetMark(Name) == 0
                && data is DamageStruct damage && player.Phase != PlayerPhase.NotActive)
                player.AddMark("wuji_count", damage.Damage);
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetMark("wuji_count") > 0)
                player.SetMark("wuji_count", 0);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish && player.GetMark(Name) == 0 && player.GetMark("wuji_count") >= 3)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            room.SetPlayerMark(player, Name, 1);

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

            room.HandleAcquireDetachSkills(player, "-huxiao");

            foreach (Player p in room.GetAlivePlayers())
            {
                if (p.Weapon.Value == ClassicBlade.ClassName)
                {
                    room.ObtainCard(player, p.Weapon.Key);
                    return false;
                }
            }
            foreach (int id in room.DrawPile)
            {
                if (room.GetCard(id).Name == ClassicBlade.ClassName)
                {
                    room.ObtainCard(player, id);
                    return false;
                }
            }
            foreach (int id in room.DiscardPile)
            {
                if (room.GetCard(id).Name == ClassicBlade.ClassName)
                {
                    room.ObtainCard(player, id);
                    break;
                }
            }

            return false;
        }
    }

    public class Liangzhu : TriggerSkill
    {
        public Liangzhu() : base("liangzhu")
        {
            events.Add(TriggerEvent.HpRecover);
            skill_type = SkillType.Replenish;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();

            if (player.Phase == PlayerPhase.Play)
            {
                List<Player> ssx = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in ssx)
                    triggers.Add(new TriggerStruct(Name, p));

            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target;
            if (player == ask_who)
            {
                target = player;
                target.SetMark(Name, 1);
            }
            else
            {
                List<string> prompts = new List<string> { string.Empty, "@liangzhu-let:" + player.Name };
                player.SetFlags(Name);
                string choice = room.AskForChoice(ask_who, Name, "let_draw+draw_self", prompts, player, info.SkillPosition);
                player.SetFlags("-liangzhu");
                if (choice == "let_draw")
                {
                    target = player;
                    target.SetMark(Name, 1);
                }
                else
                    target = ask_who;
            }
            room.DrawCards(target, new DrawCardStruct(target == player ? 2 : 1, ask_who, Name));

            return false;
        }
    }

    public class Fanxiang : PhaseChangeSkill
    {
        public Fanxiang() : base("fanxiang")
        {
            frequency = Frequency.Wake;
            skill_type = SkillType.Recover;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Start && base.Triggerable(player, room) && player.GetMark(Name) == 0)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.GetMark("liangzhu") > 0 && p.IsWounded())
                        return new TriggerStruct(Name, player);
                }
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

                room.HandleAcquireDetachSkills(player, "-liangzhu|xiaoji", false);
            }

            return false;
        }
    }

    public class Fengpo : TriggerSkill
    {
        public Fengpo() : base("fengpo")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen, TriggerEvent.Death };
            skill_type = SkillType.Attack;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Death && data is DeathStruct death && death.Damage.From != null && death.Damage.From != player)
                death.Damage.From.AddMark(Name);
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && base.Triggerable(player, room) && data is CardUseStruct use
                && (use.Card.Name == Duel.ClassName || use.Card.Name.Contains(Slash.ClassName)) && use.To.Count == 1 && !use.To[0].IsKongcheng())
            {
                return new TriggerStruct(Name, player, use.To);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player skill_target, ref object data, Player player, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, skill_target, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, skill_target.Name);
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player skill_target, ref object data, Player machao, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                room.ShowAllCards(skill_target, machao, Name, info.SkillPosition);
                int count = 0;
                foreach (int id in skill_target.GetCards("h"))
                {
                    WrappedCard card = room.GetCard(id);
                    if (card.Suit == WrappedCard.CardSuit.Diamond || (machao.GetMark(Name) > 0 && WrappedCard.IsRed(card.Suit))) count++;
                }

                if (count > 0)
                {
                    room.SetTag(Name, data);
                    string choice = room.AskForChoice(machao, Name, "draw+damage",
                        new List<string>
                        {
                            string.Format("@fengpo:{0}::{1}", skill_target.Name, use.Card.Name),
                            "@fengpo-draw:::" + count.ToString(),
                            "@fengpo-damage:::" + count.ToString()
                        }, skill_target, info.SkillPosition);
                    room.RemoveTag(Name);
                    if (choice == "draw")
                        room.DrawCards(machao, count, Name);
                    else
                    {
                        LogMessage log = new LogMessage
                        {
                            Type = "#fengpo",
                            From = machao.Name,
                            Arg = use.Card.Name,
                            Arg2 = count.ToString()
                        };
                        room.SendLog(log);

                        use.ExDamage += count;
                        data = use;
                    }
                }
            }
            return false;
        }
    }

    public class Zhengnan : TriggerSkill
    {
        public Zhengnan() : base("zhengnan")
        {
            events.Add(TriggerEvent.Dying);
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            List<Player> caopis = RoomLogic.FindPlayersBySkillName(room, Name);
            string mark = string.Format("{0}_{1}", Name, player.Name);
            foreach (Player caopi in caopis)
            {
                if (caopi.GetMark(mark) == 0)
                    triggers.Add(new TriggerStruct(Name, caopi));
            }

            return triggers;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player caopi, TriggerStruct info)
        {
            string mark = string.Format("{0}_{1}", Name, player.Name);
            caopi.SetMark(mark, 1);
            List<string> choices = new List<string>();
            if (!caopi.GetAcquiredSkills().Contains("wusheng_jx")) choices.Add("wusheng_jx");
            if (!caopi.GetAcquiredSkills().Contains("dangxian")) choices.Add("dangxian");
            if (!caopi.GetAcquiredSkills().Contains("zhiman_jx")) choices.Add("zhiman_jx");
            if (choices.Count == 0) choices.Add("draw");

            choices.Add("cancel");

            string choice = room.AskForChoice(caopi, Name, string.Join("+", choices), null, null, info.SkillPosition);
            if (choice != "cancel")
            {
                room.NotifySkillInvoked(caopi, Name);
                room.BroadcastSkillInvoke(Name, caopi, info.SkillPosition);
                caopi.SetTag(Name, choice);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player caopi, TriggerStruct info)
        {
            RecoverStruct recover = new RecoverStruct
            {
                Who = player,
                Recover = 1
            };
            room.Recover(caopi, recover, true);

            string choice = caopi.GetTag(Name).ToString();
            caopi.RemoveTag(Name);
            if (choice == "draw")
            {
                room.DrawCards(caopi, 3, Name);
            }
            else
            {
                room.DrawCards(caopi, 1, Name);
                room.HandleAcquireDetachSkills(caopi, choice, true);
            }


            return false;
        }
    }

    public class Xiefang : DistanceSkill
    {
        public Xiefang() : base("xiefang")
        {
        }

        public override int GetCorrect(Room room, Player from, Player to, WrappedCard card = null)
        {
            int count = 0;
            if (RoomLogic.PlayerHasShownSkill(room, from, this))
            {
                foreach (Player p in room.GetAlivePlayers())
                    if (!p.IsMale())
                        count--;
            }

            return count;
        }
    }

    public class Wuniang : TriggerSkill
    {
        public Wuniang() : base("wuniang")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded };
            skill_type = SkillType.Attack;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (!p.IsNude() && RoomLogic.CanGetCard(room, player, p, "he"))
                    targets.Add(p);

            if (targets.Count > 0)
            {
                Player target = null;
                if (targets.Count == 1 && room.AskForSkillInvoke(player, Name, targets[0], info.SkillPosition))
                    target = targets[0];
                else if (targets.Count > 1)
                    target = room.AskForPlayerChosen(player, targets, Name, "@wuniang", true, true, info.SkillPosition);
                if (target != null)
                {
                    player.SetTag(Name, target.Name);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.FindPlayer(player.GetTag(Name).ToString());
            player.RemoveTag(Name);
            if (RoomLogic.CanGetCard(room, player, target, "he"))
            {
                int id = room.AskForCardChosen(player, target, "he", Name, false, FunctionCard.HandlingMethod.MethodGet);
                room.ObtainCard(player, room.GetCard(id), new CardMoveReason(MoveReason.S_REASON_EXTRACTION, player.Name, target.Name, Name, string.Empty), false);
                if (target.Alive)
                    room.DrawCards(target, new DrawCardStruct(1, player, Name));

                if (player.GetMark("xushen") > 0)
                    foreach (Player p in room.GetAlivePlayers())
                        if (p.ActualGeneral1 == "guansuo")
                            room.DrawCards(p, new DrawCardStruct(1, player, Name));
            }

            return false;
        }
    }

    public class Xushen : TriggerSkill
    {
        public Xushen() : base("xushen")
        {
            events = new List<TriggerEvent> { TriggerEvent.Dying, TriggerEvent.QuitDying, TriggerEvent.GameStart };
            frequency = Frequency.Limited;
            limit_mark = "@xu";
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.GameStart)
            {
                room.HandleUsedGeneral("guansuo");
            }
            else if (triggerEvent == TriggerEvent.QuitDying && player.GetMark(Name) == 1 && player.Alive)
            {
                player.AddMark(Name);
                Player guansuo = null;
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.ActualGeneral1 == "guansuo")
                        guansuo = p;
                }

                if (guansuo == null)
                {
                    Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@xushen-change", true, true);
                    if (target != null)
                    {
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                        if (room.AskForChoice(target, Name, "change+cancel") == "change")
                        {
                            if (target.GetMark("@duanchang") > 0)
                            {
                                target.DuanChang = string.Empty;
                                room.BroadcastProperty(target, "DuanChang");
                                room.SetPlayerMark(target, "@duanchang", 0);
                            }

                            string from_general = target.ActualGeneral1;
                            if (!from_general.Contains("sujiang"))
                            {
                                room.DoAnimate(AnimateType.S_ANIMATE_REMOVE, target.Name, true.ToString());
                                room.HandleUsedGeneral("-" + from_general);
                            }

                            //room.HandleUsedGeneral("guansuo");
                            target.ActualGeneral1 = target.General1 = "guansuo";
                            target.HeadSkinId = 0;
                            target.Kingdom = "shu";
                            target.PlayerGender = Gender.Male;
                            room.BroadcastProperty(target, "Kingdom");
                            room.BroadcastProperty(target, "HeadSkinId");
                            room.BroadcastProperty(target, "PlayerGender");
                            room.NotifyProperty(room.GetClient(target), target, "ActualGeneral1");
                            room.BroadcastProperty(target, "General1");

                            int max = 4;
                            if (target.GetRoleEnum() == PlayerRole.Lord)
                                max = 4 + (room.Players.Count > 4 && target.GetRoleEnum() == PlayerRole.Lord ? 1 : 0);

                            if (max > target.MaxHp)
                            {
                                int count = max - target.MaxHp;
                                target.MaxHp = max;
                                room.BroadcastProperty(target, "MaxHp");
                                LogMessage log = new LogMessage
                                {
                                    Type = "$GainMaxHp",
                                    From = target.Name,
                                    Arg = count.ToString()
                                };
                                room.SendLog(log);
                                room.RoomThread.Trigger(TriggerEvent.MaxHpChanged, room, target);
                            }
                            else if (max < target.MaxHp)
                            {
                                room.LoseMaxHp(target, target.MaxHp - max);
                            }

                            List<string> skills = target.GetSkills(true, false);
                            foreach (string skill in skills)
                            {
                                Skill _s = Engine.GetSkill(skill);
                                if (_s != null && !_s.Attached_lord_skill)
                                    room.DetachSkillFromPlayer(target, skill, false, target.GetAcquiredSkills().Contains(skill), true);
                            }

                            foreach (string skill in Engine.GetGeneralRelatedSkills("guansuo", room.Setting.GameMode))
                                room.AddSkill2Game(skill);

                            foreach (string skill_name in Engine.GetGeneralSkills("guansuo", room.Setting.GameMode, true))
                            {
                                room.AddSkill2Game(skill_name);
                                room.AddPlayerSkill(target, skill_name);
                            }

                            room.SendPlayerSkillsToOthers(target);
                            room.FilterCards(target, target.GetCards("he"), true);
                        }

                        if (target.Alive) room.DrawCards(target, new DrawCardStruct(3, player, Name));
                    }
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Dying && base.Triggerable(player, room) && player.GetMark(limit_mark) > 0)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
            {
                room.RemovePlayerMark(player, limit_mark);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.DoSuperLightbox(player, info.SkillPosition, Name);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            player.SetMark(Name, 1);
            if (player.IsWounded())
            {
                RecoverStruct recover = new RecoverStruct
                {
                    Recover = 1,
                    Who = player
                };
                room.Recover(player, recover, true);
            }

            if (player.Alive)
                room.HandleAcquireDetachSkills(player, "zhennan", true);

            return false;
        }
    }
    /*
    public class Zhennan : TriggerSkill
    {
        public Zhennan() : base("zhennan")
        {
            events.Add(TriggerEvent.TargetConfirming);
            skill_type = SkillType.Attack;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && use.Card.Name == SavageAssault.ClassName && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@zhennan", true, true, info.SkillPosition);
            if (target != null)
            {
                player.SetTag(Name, target.Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.FindPlayer(player.GetTag(Name).ToString());
            player.RemoveTag(Name);
            Random ra = new Random();
            int result = ra.Next(1, 4);
            room.Damage(new DamageStruct(Name, player, target, result));
            return false;
        }
    }
    */

    public class Zhennan : TriggerSkill
    {
        public Zhennan() : base("zhennan")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen };
            skill_type = SkillType.Attack;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (data is CardUseStruct use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is TrickCard && use.To.Count > 1)
                {
                    List<Player> bsn = RoomLogic.FindPlayersBySkillName(room, Name);
                    foreach (Player p in bsn)
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player user, ref object data, Player player, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@zhennan", true, true, info.SkillPosition);
            if (target != null)
            {
                player.SetTag(Name, target.Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player user, ref object data, Player player, TriggerStruct info)
        {
            Player target = room.FindPlayer(player.GetTag(Name).ToString());
            player.RemoveTag(Name);
            room.Damage(new DamageStruct(Name, player, target));
            return false;
        }
    }

    public class Yuhua : TriggerSkill
    {
        public Yuhua() : base("yuhua")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.EventPhaseStart };
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && base.Triggerable(player, room) && triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change
                && change.To == PlayerPhase.Discard && player.HandcardNum > player.Hp)
                return new TriggerStruct(Name, player);
            else if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish && player.HandcardNum > player.MaxHp)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            if (triggerEvent == TriggerEvent.EventPhaseStart) return info;
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> guanxing = room.GetNCards(1, false);

            LogMessage log = new LogMessage
            {
                Type = "$ViewDrawPile",
                From = player.Name,
                Card_str = string.Join("+", JsonUntity.IntList2StringList(guanxing))
            };
            room.SendLog(log, player);
            log.Type = "$ViewDrawPile2";
            log.Arg = guanxing.Count.ToString();
            log.Card_str = null;
            room.SendLog(log, new List<Player> { player });

            room.AskForGuanxing(player, guanxing, Name, true, info.SkillPosition);
            return false;
        }
    }

    public class YuhuaMax : MaxCardsSkill
    {
        public YuhuaMax() : base("#yuhua-max") { }

        public override bool Ingnore(Room room, Player player, int card_id)
        {
            if (RoomLogic.PlayerHasShownSkill(room, player, "yuhua"))
            {
                FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(card_id).Name);
                return fcard is TrickCard || fcard is EquipCard;
            }

            return false;
        }
    }

    public class Qirang : TriggerSkill
    {
        public Qirang() : base("qirang")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardTargetAnnounced, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Wizzard;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
                player.RemoveTag(Name);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && base.Triggerable(player, room))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is EquipCard)
                    return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct _use && base.Triggerable(player, room) && _use.Card.ExtraTarget && player.ContainsTag(Name)
                && player.GetTag(Name) is List<int> ids && ids.Contains(_use.Card.GetEffectiveId()) && _use.To.Count == 1)
            {
                FunctionCard fcard = Engine.GetFunctionCard(_use.Card.Name);
                if (fcard.IsNDTrick() && _use.Card.Name != Collateral.ClassName && !_use.Card.Name.Contains(Nullification.ClassName))
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardUsed && room.AskForSkillInvoke(player, Name, data, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            else if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                List<Player> targets = new List<Player>();
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if ((fcard is IronChain && !p.Chained && !RoomLogic.CanBeChainedBy(room, player, p))
                        || (fcard is FireAttack && p.IsKongcheng())
                        || (fcard is Snatch && !Snatch.Instance.TargetFilter(room, new List<Player>(), p, player, use.Card))
                        || (fcard is Dismantlement && (!RoomLogic.CanDiscard(room, player, p, "hej") || p.IsAllNude()))) continue;

                    if (!use.To.Contains(p) && RoomLogic.IsProhibited(room, player, p, use.Card) == null)
                        targets.Add(p);
                }

                room.SetTag("extra_target_skill", data);                   //for AI
                Player target = room.AskForPlayerChosen(player, targets, Name, "@jieying_hf-extra:::" + use.Card.Name, true, true, info.SkillPosition);
                room.RemoveTag("extra_target_skill");
                if (target != null)
                {
                    LogMessage log = new LogMessage
                    {
                        Type = "$extra_target",
                        From = player.Name,
                        To = new List<string> { target.Name },
                        Card_str = RoomLogic.CardToString(room, use.Card),
                        Arg = Name
                    };
                    room.SendLog(log);

                    player.SetTag("extra_targets", target.Name);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardUsed)
            {
                List<int> ids = new List<int>(room.DrawPile);
                foreach (int id in ids)
                {
                    FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(id).Name);
                    if (fcard is TrickCard)
                    {
                        room.ObtainCard(player, id);
                        if (fcard.IsNDTrick() && fcard.Name != Collateral.ClassName && !fcard.Name.Contains(Nullification.ClassName))
                        {
                            List<int> record = player.ContainsTag(Name) ? (List<int>)player.GetTag(Name) : new List<int>();
                            record.Add(id);
                            player.SetTag(Name, record);
                        }
                        break;
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                string target_name = (string)player.GetTag("extra_targets");
                player.RemoveTag("extra_targets");
                Player target = room.FindPlayer(target_name);

                use.To.Add(target);
                room.SortByActionOrder(ref use);
                data = use;
            }

            return false;
        }
    }


    public class FanghunVS : OneCardViewAsSkill
    {
        public FanghunVS() : base("fanghun")
        {
            response_or_use = true;
        }
        public override bool ViewFilter(Room room, WrappedCard card, Player player)
        {
            CardUseReason reason = room.GetRoomState().GetCurrentCardUseReason();
            switch (reason)
            {
                case CardUseReason.CARD_USE_REASON_PLAY:
                    return card.Name == Jink.ClassName && !RoomLogic.IsCardLimited(room, player, card, HandlingMethod.MethodUse);
                case CardUseReason.CARD_USE_REASON_RESPONSE:
                case CardUseReason.CARD_USE_REASON_RESPONSE_USE:
                    if (RoomLogic.IsCardLimited(room, player, card, reason == CardUseReason.CARD_USE_REASON_RESPONSE ? HandlingMethod.MethodResponse : HandlingMethod.MethodUse))
                        return false;

                    string pattern = room.GetRoomState().GetCurrentCardUsePattern();
                    pattern = Engine.GetPattern(pattern).GetPatternString();
                    if (pattern.StartsWith(Slash.ClassName))
                    {
                        return card.Name == Jink.ClassName;
                    }
                    else if (pattern.StartsWith(Jink.ClassName))
                    {
                        FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                        return fcard is Slash;
                    }
                    break;
                default:
                    return false;
            }

            return false;
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return player.GetMark(Name) > 0 && Slash.IsAvailable(room, player);
        }
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
        {
            if (player.GetMark(Name) == 0) return false;
            return MatchJink(respond) || MatchSlash(respond);
        }
        public override WrappedCard ViewAs(Room room, WrappedCard originalCard, Player player)
        {
            FunctionCard fcard = Engine.GetFunctionCard(originalCard.Name);
            string pattern = room.GetRoomState().GetCurrentCardUsePattern();
            pattern = Engine.GetPattern(pattern).GetPatternString();
            if (fcard is Slash)
            {
                WrappedCard view = new WrappedCard(Jink.ClassName);
                view.AddSubCard(originalCard);
                view = RoomLogic.ParseUseCard(room, view);
                if (!Engine.MatchExpPattern(room, pattern, player, view)) return null;

                WrappedCard jink = new WrappedCard(FanghunCard.ClassName)
                {
                    UserString = Jink.ClassName
                };
                jink.AddSubCard(originalCard);
                return jink;
            }
            else if (fcard is Jink)
            {
                WrappedCard view = new WrappedCard(Slash.ClassName);
                view.AddSubCard(originalCard);
                view = RoomLogic.ParseUseCard(room, view);
                if (!Engine.MatchExpPattern(room, pattern, player, view)) return null;

                WrappedCard slash = new WrappedCard(FanghunCard.ClassName)
                {
                    UserString = Slash.ClassName
                };
                slash.AddSubCard(originalCard);
                return slash;
            }
            else
                return null;
        }
    }

    public class Fanghun : TriggerSkill
    {
        public Fanghun() : base("fanghun")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.Damaged };
            view_as_skill = new FanghunVS();
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DamageStruct damage && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                ask_who.AddMark(Name, damage.Damage);
                room.SetPlayerStringMark(ask_who, "meiying", ask_who.GetMark(Name).ToString());
                room.NotifySkillInvoked(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            }

            return false;
        }
    }

    public class FanghunDetach : DetachEffectSkill
    {
        public FanghunDetach() : base("fanghun", string.Empty) { }

        public override void OnSkillDetached(Room room, Player player, object data)
        {
            room.RemovePlayerStringMark(player, "meiying");
        }
    }

    public class FanghunCard : SkillCard
    {
        public static string ClassName = "FanghunCard";
        public FanghunCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE)
                return false;

            WrappedCard wrapped = new WrappedCard(card.UserString);
            FunctionCard fcard = Engine.GetFunctionCard(card.UserString);
            return fcard.TargetFilter(room, targets, to_select, Self, wrapped);
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE && targets.Count == 0)
                return true;

            WrappedCard wrapped = new WrappedCard(card.UserString);
            FunctionCard fcard = Engine.GetFunctionCard(card.UserString);
            return fcard.TargetsFeasible(room, targets, Self, wrapped);
        }

        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            use.From.AddMark("fanghun", -1);
            if (use.From.GetMark("fanghun") > 0)
                room.SetPlayerStringMark(use.From, "meiying", use.From.GetMark("fanghun").ToString());
            else
                room.RemovePlayerStringMark(use.From, "meiying");

            use.From.AddMark("fuhan");
            room.BroadcastSkillInvoke("fanghun", use.From, use.Card.SkillPosition);
            WrappedCard wrapped = new WrappedCard(use.Card.UserString) { Skill = "longdan_jx", SkillPosition = use.Card.SkillPosition, Mute = true };
            wrapped.AddSubCard(use.Card);
            wrapped = RoomLogic.ParseUseCard(room, wrapped);
            room.DrawCards(use.From, 1, "fanghun");
            return wrapped;
        }

        public override WrappedCard ValidateInResponse(Room room, Player player, WrappedCard card)
        {
            player.AddMark("fanghun", -1);
            if (player.GetMark("fanghun") > 0)
                room.SetPlayerStringMark(player, "meiying", player.GetMark("fanghun").ToString());
            else
                room.RemovePlayerStringMark(player, "meiying");

            player.AddMark("fuhan");
            room.BroadcastSkillInvoke("fanghun", player, card.SkillPosition);
            WrappedCard wrapped = new WrappedCard(card.UserString) { Skill = "longdan_jx", SkillPosition = card.SkillPosition, Mute = true };
            wrapped.AddSubCard(card);
            wrapped = RoomLogic.ParseUseCard(room, wrapped);
            room.DrawCards(player, 1, "fanghun");
            return wrapped;
        }
    }

    public class Fuhan : PhaseChangeSkill
    {
        public Fuhan() : base("fuhan")
        {
            frequency = Frequency.Limited;
            skill_type = SkillType.Wizzard;
            limit_mark = "@fuhan";
        }
        public override bool CanPreShow() => false;
        public override bool Triggerable(Player target, Room room)
        {
            return base.Triggerable(target, room) && target.Phase == PlayerPhase.RoundStart && target.GetMark(limit_mark) > 0 && target.GetMark(Name) + target.GetMark("fanghun") > 0;
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(player, Name, null, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                room.SetPlayerMark(player, limit_mark, 0);
                room.RemovePlayerStringMark(player, "meiying");
                player.AddMark(Name, player.GetMark("fanghun"));
                player.SetMark("fanghun", 0);
                return info;
            }
            return new TriggerStruct();
        }
        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            int max = player.GetMark(Name);
            room.DrawCards(player, max, Name);

            List<string> available = new List<string>();
            foreach (string name in room.Generals)
                if (!name.StartsWith("lord_") && !room.UsedGeneral.Contains(name) && Engine.GetGeneral(name, room.Setting.GameMode).Kingdom.Contains(General.GetKingdom(player)))
                    available.Add(name);

            if (available.Count > 0)
            {
                string from_general = player.ActualGeneral1;
                room.DoAnimate(AnimateType.S_ANIMATE_REMOVE, player.Name, true.ToString());

                Shuffle.shuffle(ref available);
                List<string> generals = new List<string>();
                for (int i = 0; i < Math.Min(5, available.Count); i++)
                    generals.Add(available[i]);

                string general_name = room.AskForGeneral(player, generals, null, true, Name, null, true, true);
                room.HandleUsedGeneral(general_name);
                room.HandleUsedGeneral("-" + from_general);

                General general = Engine.GetGeneral(general_name, room.Setting.GameMode);
                player.ActualGeneral1 = player.General1 = general_name;
                player.HeadSkinId = 0;
                room.BroadcastProperty(player, "HeadSkinId");
                room.NotifyProperty(room.GetClient(player), player, "ActualGeneral1");
                room.BroadcastProperty(player, "General1");
                player.PlayerGender = general.GeneralGender;
                room.BroadcastProperty(player, "PlayerGender");

                List<string> skills = player.GetSkills(false, false);
                foreach (string skill in skills)
                {
                    Skill _s = Engine.GetSkill(skill);
                    if (_s != null && !_s.Attached_lord_skill)
                        room.DetachSkillFromPlayer(player, skill, false, player.GetAcquiredSkills().Contains(skill), true);
                }

                foreach (string skill in Engine.GetGeneralRelatedSkills(general_name, room.Setting.GameMode))
                {
                    room.AddSkill2Game(skill);
                }

                foreach (string skill_name in Engine.GetGeneralSkills(general_name, room.Setting.GameMode, true))
                {
                    Skill s = Engine.GetSkill(skill_name);
                    room.AddSkill2Game(skill_name);

                    if (s.LordSkill && player.GetRoleEnum() != PlayerRole.Lord) continue;
                    room.AddPlayerSkill(player, skill_name);
                    if (s != null && s.SkillFrequency == Frequency.Limited && !string.IsNullOrEmpty(s.LimitMark))
                        room.SetPlayerMark(player, s.LimitMark, 1);

                    object data = new InfoStruct() { Info = skill_name, Head = true };
                    room.RoomThread.Trigger(TriggerEvent.EventAcquireSkill, room, player, ref data);
                }

                room.SendPlayerSkillsToOthers(player);
                room.FilterCards(player, player.GetCards("he"), true);
            }

            if (player.Alive)
            {
                max = Math.Min(room.Players.Count, max);
                if (max > player.MaxHp)
                {
                    int count = max - player.MaxHp;
                    player.MaxHp = max;
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
                else if (max < player.MaxHp)
                {
                    room.LoseMaxHp(player, player.MaxHp - max);
                }

                int hp = 100;
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.Hp < hp)
                        hp = p.Hp;
                }

                if (player.Hp == hp && player.IsWounded())
                {
                    RecoverStruct recover = new RecoverStruct
                    {
                        Recover = 1,
                        Who = player
                    };
                    room.Recover(player, recover, true);
                }
            }

            return false;
        }
    }

    public class Zishu : TriggerSkill
    {
        public Zishu() : base("zishu")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseStart };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To != null && base.Triggerable(move.To, room)
                && move.To.Phase == PlayerPhase.NotActive && move.To_place == Place.PlaceHand)
            {
                List<int> ids = move.To.ContainsTag(Name) ? (List<int>)move.To.GetTag(Name) : new List<int>();
                foreach (int id in move.Card_ids)
                    if (!ids.Contains(id))
                        ids.Add(id);

                move.To.SetTag(Name, ids);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.NotActive)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p.ContainsTag(Name))
                        triggers.Add(new TriggerStruct(Name, p));
            }
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To != null && base.Triggerable(move.To, room)
                && move.To == room.Current && move.Reason.SkillName != Name && move.To_place == Place.PlaceHand)
                triggers.Add(new TriggerStruct(Name, move.To));

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
            if (triggerEvent == TriggerEvent.EventPhaseStart && ask_who.GetTag(Name) is List<int> ids)
            {
                ask_who.RemoveTag(Name);
                List<int> discard = new List<int>();
                foreach (int id in ids)
                {
                    if (room.GetCardOwner(id) == ask_who && room.GetCardPlace(id) == Place.PlaceHand)
                        discard.Add(id);
                }
                if (discard.Count > 0)
                {
                    room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                    CardsMoveStruct move = new CardsMoveStruct(discard, null, Place.DiscardPile, new CardMoveReason(MoveReason.S_REASON_NATURAL_ENTER, ask_who.Name, Name, string.Empty));
                    room.MoveCardsAtomic(move, true);
                }
            }
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime)
            {
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                room.DrawCards(ask_who, 1, Name);
            }


            return false;
        }
    }

    public class Yingyuan : TriggerSkill
    {
        public Yingyuan() : base("yingyuan")
        {
            events.Add(TriggerEvent.CardFinished);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player from, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && base.Triggerable(from, room) && from == room.Current)
            {
                WrappedCard card = use.Card;
                List<int> ids = room.GetSubCards(card);
                string card_name = card.Name;
                if (card_name.Contains(Slash.ClassName)) card_name = Slash.ClassName;
                string str = string.Format("{0}_{1}", Name, card_name);
                if (!from.HasFlag(str) && ids.Count > 0 && ids.SequenceEqual(card.SubCards))
                {
                    bool check = true;
                    foreach (int id in card.SubCards)
                    {
                        if (room.GetCardPlace(id) != Place.DiscardPile)
                        {
                            check = false;
                            break;
                        }
                    }

                    if (check) return new TriggerStruct(Name, from);
                }
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                List<int> ids = new List<int>(use.Card.SubCards);
                if (ids.Count > 0)
                {
                    WrappedCard card = use.Card;
                    room.SetTag(Name, ids);
                    Player target = room.AskForPlayerChosen(ask_who, room.GetOtherPlayers(ask_who), Name, "@yingyuan:::" + card.Name, true, true, info.SkillPosition);
                    room.RemoveTag(Name);
                    if (target != null)
                    {
                        room.SetTag(Name, target);
                        room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                        return info;
                    }
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
                List<int> ids = new List<int>(use.Card.SubCards);
                if (ids.Count > 0)
                {
                    room.RemoveSubCards(use.Card);
                    ResultStruct result = ask_who.Result;
                    result.Assist += ids.Count;
                    ask_who.Result = result;

                    WrappedCard card = use.Card;
                    string card_name = card.Name;
                    if (card_name.Contains(Slash.ClassName)) card_name = Slash.ClassName;
                    string str = string.Format("{0}_{1}", Name, card_name);
                    ask_who.SetFlags(str);

                    room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, ask_who.Name, target.Name, Name, string.Empty));
                }
            }

            return false;
        }
    }

    public class ZiyuanCard : SkillCard
    {
        public static string ClassName = "ZiyuanCard";
        public ZiyuanCard() : base(ClassName)
        {
            will_throw = false;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            return targets.Count == 1 && card.SubCards.Count > 0;
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0];
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, card_use.From.Name, target.Name, "ziyuan", string.Empty);

            ResultStruct result = card_use.From.Result;
            result.Assist += card_use.Card.SubCards.Count;
            card_use.From.Result = result;

            room.ObtainCard(target, card_use.Card, reason, false);
            if (target.Alive && target.IsWounded())
            {
                RecoverStruct recover = new RecoverStruct
                {
                    Recover = 1,
                    Who = card_use.From
                };
                room.Recover(target, recover, true);
            }
        }
    }

    public class Ziyuan : ViewAsSkill
    {
        public Ziyuan() : base("ziyuan")
        {
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (room.GetCardPlace(to_select.Id) != Place.PlaceHand) return false;
            int number = 0;
            foreach (WrappedCard card in selected)
                number += card.Number;

            return number + to_select.Number <= 13;
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(ZiyuanCard.ClassName) && !player.IsKongcheng();
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
            {
                int number = 0;
                foreach (WrappedCard card in cards)
                    number += card.Number;

                if (number == 13)
                {
                    WrappedCard rende_card = new WrappedCard(ZiyuanCard.ClassName);
                    rende_card.AddSubCards(cards);
                    rende_card.Skill = Name;
                    rende_card.ShowSkill = Name;
                    return rende_card;
                }
            }

            return null;
        }
    }

    public class Jujia : TriggerSkill
    {
        public Jujia() : base("jujia")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.EventPhaseChanging };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            if (base.Triggerable(player, room) && triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change
                && change.To == PlayerPhase.Discard && RoomLogic.GetMaxCards(room, player) > player.Hp && player.HandcardNum > player.Hp)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.GameStart)
                return info;
            
            room.NotifySkillInvoked(player, Name);
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
            room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
            room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);

            room.DrawCards(player, player.MaxHp, Name);

            return false;
        }
    }

    public class JujiaMax : MaxCardsSkill
    {
        public JujiaMax() : base("#jujia-max") { }

        public override int GetExtra(Room room, Player target)
        {
            if (RoomLogic.PlayerHasSkill(room, target, "jujia"))
                return target.MaxHp;

            return 0;
        }
    }

    public class ZhuhaiJX : TriggerSkill
    {
        public ZhuhaiJX() : base("zhuhai_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Attack;
            view_as_skill = new ZhuhaiJXVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.Damage && player.Alive && room.Current == player)
                player.SetFlags(Name);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.Finish && player.HasFlag(Name))
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (player != p) triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Alive && ask_who.Alive)
                room.AskForUseCard(ask_who, RespondType.Skill, "@@zhuhai_jx", "@zhuhai_jx:" + player.Name, null, -1, HandlingMethod.MethodUse, false);

            return new TriggerStruct();
        }
    }

    public class ZhuhaiJXVS : ViewAsSkill
    {
        public ZhuhaiJXVS() : base("zhuhai_jx")
        {
            response_pattern = "@@zhuhai_jx";
            response_or_use = true;
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return selected.Count == 0 && room.GetCardPlace(to_select.Id) != Place.PlaceEquip && !RoomLogic.IsCardLimited(room, player, to_select, HandlingMethod.MethodUse);
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            if (cards.Count == 1)
            {
                WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = Name, ShowSkill = Name, DistanceLimited = false };
                slash.AddSubCards(cards);
                slash = RoomLogic.ParseUseCard(room, slash);
                result.Add(slash);
                WrappedCard dis = new WrappedCard(Dismantlement.ClassName) { Skill = Name, ShowSkill = Name };
                dis.AddSubCards(cards);
                dis = RoomLogic.ParseUseCard(room, dis);
                result.Add(dis);
            }
            return result;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
                return cards[0];
            return null;
        }
    }

    public class ZhuhaiJXTag : ProhibitSkill
    {
        public ZhuhaiJXTag() : base("#zhuhai_jx") { }
        public override bool IsProhibited(Room room, Player from, Player to, WrappedCard card, List<Player> others = null) => card != null && card.GetSkillName() == "zhuhai_jx" && room.Current != to;
    }

    public class Qianxin : TriggerSkill
    {
        public Qianxin() : base("qianxin")
        {
            frequency = Frequency.Wake;
            events.Add(TriggerEvent.Damage);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.GetMark(Name) == 0 && base.Triggerable(player, room) && player.IsWounded())
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            room.DoSuperLightbox(player, info.SkillPosition, Name);
            room.SetPlayerMark(player, Name, 1);
            room.SendCompulsoryTriggerLog(player, Name);

            room.LoseMaxHp(player);
            if (player.Alive) room.HandleAcquireDetachSkills(player, "jianyan", true);

            return false;
        }
    }

    public class Jianyan : ZeroCardViewAsSkill
    {
        public Jianyan() : base("jianyan")
        {
            skill_type = SkillType.Replenish;
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasFlag("jianyan_color") || !player.HasFlag("jianyan_type");
        }
        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(JianyanCard.ClassName) { Skill = Name };
        }
    }

    public class JianyanCard : SkillCard
    {
        public static string ClassName = "JianyanCard";
        public JianyanCard() : base(ClassName) { target_fixed = true; }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            List<string> choices = new List<string>();
            if (!player.HasFlag("jianyan_color"))
            {
                choices.Add("red");
                choices.Add("black");
            }
            if (!player.HasFlag("jianyan_type"))
            {
                choices.Add("basic");
                choices.Add("equip");
                choices.Add("trick");
            }

            string choice = room.AskForChoice(player, "jianyan", string.Join("+", choices), new List<string> { "@jianyan" }, null, card_use.Card.SkillPosition);
            List<int> ids = new List<int>();
            foreach (int id in room.DrawPile)
            {
                WrappedCard card = room.GetCard(id);
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                if (fcard.TypeID == CardType.TypeBasic && choice == "basic")
                {
                    player.SetFlags("jianyan_type");
                    ids.Add(id);
                    break;
                }
                else if (fcard.TypeID == CardType.TypeEquip && choice == "equip")
                {
                    player.SetFlags("jianyan_type");
                    ids.Add(id);
                    break;
                }
                else if (fcard.TypeID == CardType.TypeTrick && choice == "trick")
                {
                    player.SetFlags("jianyan_type");
                    ids.Add(id);
                    break;
                }
                else if (WrappedCard.IsBlack(card.Suit) && choice == "black")
                {
                    player.SetFlags("jianyan_color");
                    ids.Add(id);
                    break;
                }
                else if (WrappedCard.IsRed(card.Suit) && choice == "red")
                {
                    player.SetFlags("jianyan_color");
                    ids.Add(id);
                    break;
                }
            }
            if (ids.Count > 0)
            {
                room.MoveCardTo(room.GetCard(ids[0]), player, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_TURNOVER, player.Name, "jianyan", null), false);
                Thread.Sleep(500);
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetAlivePlayers())
                    if (p.IsMale()) targets.Add(p);

                if (targets.Count > 0)
                {
                    player.SetTag("jianyan", ids[0]);
                    Player target = room.AskForPlayerChosen(player, targets, "jianyan", "@jianyan-give", false, false, card_use.Card.SkillPosition);
                    player.RemoveTag("jianyan");
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);

                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GOTBACK, target.Name, "jianyan", string.Empty);
                    room.ObtainCard(target, ref ids, reason, true);
                }
            }
        }
    }

    public class Qianya : TriggerSkill
    {
        public Qianya() : base("qianya")
        {
            events.Add(TriggerEvent.TargetConfirmed);
            view_as_skill = new QianyaVS();
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && Engine.GetFunctionCard(use.Card.Name).TypeID == CardType.TypeTrick && !player.IsKongcheng() && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SetTag(Name, data);
            if (room.AskForUseCard(player, RespondType.Skill, "@@qianya", "@qianya", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition) == null)
                room.RemoveTag(Name);

            return new TriggerStruct();
        }
    }

    public class QianyaVS : ViewAsSkill
    {
        public QianyaVS() : base("qianya") { response_pattern = "@@qianya"; }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return room.GetCardPlace(to_select.Id) == Place.PlaceHand;
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => false;

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
            {
                WrappedCard qy = new WrappedCard(QianyaCard.ClassName) { Skill = Name };
                qy.AddSubCards(cards);
                return qy;
            }

            return null;
        }
    }

    public class QianyaCard : SkillCard
    {
        public static string ClassName = "QianyaCard";
        public QianyaCard() : base(ClassName) { will_throw = false; }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            room.RemoveTag("qianya");
            Player player = card_use.From, target = card_use.To[0];

            ResultStruct result = card_use.From.Result;
            result.Assist += card_use.Card.SubCards.Count;
            card_use.From.Result = result;

            List<int> ids = new List<int>(card_use.Card.SubCards);
            room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, "qianya", string.Empty), false);
        }
    }

    public class Shuimeng : TriggerSkill
    {
        public Shuimeng() : base("shuimeng") { events.Add(TriggerEvent.EventPhaseEnd); }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Play && base.Triggerable(player, room) && !player.IsKongcheng())
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player jiling, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(jiling))
            {
                if (RoomLogic.CanBePindianBy(room, p, jiling))
                    targets.Add(p);
            }
            if (targets.Count > 0)
            {
                Player victim = room.AskForPlayerChosen(jiling, targets, Name, "@shuimeng", true, true, info.SkillPosition);
                if (victim != null)
                {
                    room.SetTag(Name, victim);
                    room.BroadcastSkillInvoke(Name, jiling, info.SkillPosition);
                    return info;
                }
            }
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = (Player)room.GetTag(Name);
            room.RemoveTag(Name);
            PindianStruct pd = room.PindianSelect(player, target, Name);
            room.Pindian(ref pd);
            if (pd.Success)
            {
                WrappedCard ex = new WrappedCard(ExNihilo.ClassName) { Skill = "_shuimeng" };
                FunctionCard fcard = Engine.GetFunctionCard(ex.Name);
                if (fcard.IsAvailable(room, player, ex))
                    room.UseCard(new CardUseStruct(ex, player, new List<Player>()));
            }
            else
            {
                WrappedCard ex = new WrappedCard(Dismantlement.ClassName) { Skill = "_shuimeng" };
                FunctionCard fcard = Engine.GetFunctionCard(ex.Name);
                if (fcard.IsAvailable(room, target, ex) && RoomLogic.IsProhibited(room, target, player, ex) == null)
                    room.UseCard(new CardUseStruct(ex, target, player));
            }

            return false;
        }
    }

    public class FumanEffect : TriggerSkill
    {
        public FumanEffect() : base("#fuman")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.CardUsed, TriggerEvent.CardResponded };
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change)
            {
                if (change.From == PlayerPhase.Play)
                {
                    foreach (Player p in room.GetAlivePlayers())
                        if (p.HasFlag("fuman_" + player.Name))
                            p.SetFlags("-fuman_" + player.Name);
                }
                else if (change.To == PlayerPhase.NotActive && player.ContainsTag("fuman"))
                    player.RemoveTag("fuman");
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill
                && player.ContainsTag("fuman") && player.GetTag("fuman") is Dictionary<string, List<int>> record)
            {
                foreach (int id in use.Card.SubCards)
                {
                    foreach (string genreal in record.Keys)
                    {
                        if (record[genreal].Contains(id))
                            return new TriggerStruct(Name, player);
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && player.ContainsTag("fuman") && player.GetTag("fuman") is Dictionary<string, List<int>> _record)
            {
                foreach (int id in resp.Card.SubCards)
                {
                    foreach (string genreal in _record.Keys)
                    {
                        if (_record[genreal].Contains(id))
                            return new TriggerStruct(Name, player);
                    }
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill
                 && player.GetTag("fuman") is Dictionary<string, List<int>> record)
            {
                foreach (int id in use.Card.SubCards)
                {
                    foreach (string genreal in record.Keys)
                    {
                        if (record[genreal].Contains(id))
                        {
                            record[genreal].Remove(id);
                            Player target = room.FindPlayer(genreal, true);
                            targets.Add(target);
                        }
                    }
                }
                player.SetTag("fuman", record);
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && player.GetTag("fuman") is Dictionary<string, List<int>> _record)
            {
                foreach (int id in resp.Card.SubCards)
                {
                    foreach (string genreal in _record.Keys)
                    {
                        if (_record[genreal].Contains(id))
                        {
                            _record[genreal].Remove(id);
                            Player target = room.FindPlayer(genreal, true);
                            targets.Add(target);
                        }
                    }
                }
                player.SetTag("fuman", _record);
            }

            room.SortByActionOrder(ref targets);
            foreach (Player target in targets)
            {
                if (player.Alive) room.DrawCards(player, new DrawCardStruct(1, target, "fuman"));
                if (target.Alive) room.DrawCards(target, 1, "fuman");
            }

            return false;
        }
    }

    public class Fuman : OneCardViewAsSkill
    {
        public Fuman() : base("fuman") { filter_pattern = "..!"; }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.IsKongcheng();

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard fm = new WrappedCard(FumanCard.ClassName) { Skill = Name };
            fm.AddSubCard(card);
            return fm;
        }
    }

    public class FumanCard : SkillCard
    {
        public static string ClassName = "FumanCard";
        public FumanCard() : base(ClassName)
        {
            will_throw = true;
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && to_select != Self && !to_select.HasFlag("fuman_" + Self.Name);
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card) => targets.Count == 1 && card.SubCards.Count > 0;
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0];

            ResultStruct result = card_use.From.Result;
            result.Assist += card_use.Card.SubCards.Count;
            card_use.From.Result = result;

            int card_id = -1;
            CardMoveReason reason = new CardMoveReason();
            foreach (int id in room.DiscardPile)
            {
                if (room.GetCard(id).Name.Contains(Slash.ClassName))
                {
                    reason = new CardMoveReason(MoveReason.S_REASON_RECYCLE, card_use.From.Name, target.Name, "fuman", null);
                    card_id = id;
                    break;
                }
            }
            if (card_id == -1)
            {
                foreach (int id in room.DrawPile)
                {
                    if (room.GetCard(id).Name.Contains(Slash.ClassName))
                    {
                        reason = new CardMoveReason(MoveReason.S_REASON_GOTCARD, card_use.From.Name, target.Name, "fuman", null);
                        card_id = id;
                        break;
                    }
                }
            }

            if (card_id >= 0)
            {
                Dictionary<string, List<int>> record = target.ContainsTag("fuman") ? (Dictionary<string, List<int>>)target.GetTag("fuman") : new Dictionary<string, List<int>>();
                if (record.ContainsKey(card_use.From.Name))
                    record[card_use.From.Name].Add(card_id);
                else
                    record[card_use.From.Name] = new List<int> { card_id };
                target.SetTag("fuman", record);

                target.SetFlags("fuman_" + card_use.From.Name);
                room.ObtainCard(target, room.GetCard(card_id), reason, true);
            }
        }
    }

    public class Bingzheng : TriggerSkill
    {
        public Bingzheng() : base("bingzheng")
        {
            events.Add(TriggerEvent.EventPhaseEnd);
        }
        public override bool Triggerable(Player target, Room room)
        {
            return base.Triggerable(target, room) && target.Phase == PlayerPhase.Play;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetAlivePlayers())
                if (p.HandcardNum != p.Hp) targets.Add(p);

            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@bingzheng", true, true, info.SkillPosition);
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
            List<string> choices = new List<string> { "draw" };
            if (!target.IsKongcheng() && RoomLogic.CanDiscard(room, target, target, "h"))
                choices.Add("discard");

            target.SetFlags(Name);
            string choice = room.AskForChoice(player, Name, string.Join("+", choices), new List<string> { "@to-player:" + target.Name }, target, info.SkillPosition);
            target.SetFlags("-bingzheng");
            if (choice == "draw")
            {
                target.SetFlags(Name);
                room.DrawCards(target, new DrawCardStruct(1, player, Name));
                target.SetFlags("-bingzheng");
            }
            else
            {
                room.AskForDiscard(target, Name, 1, 1, false, false, "@bingzheng-discard", false, info.SkillPosition);
            }
            if (target.Alive && target.HandcardNum == target.Hp && player.Alive)
            {
                room.DrawCards(player, 1, Name);
                if (player.Alive && player != target && target.Alive)
                {
                    target.SetFlags(Name);
                    List<int> ids = room.AskForExchange(player, Name, 1, 0, "@bingzheng-give:" + target.Name, string.Empty, "..", info.SkillPosition);
                    target.SetFlags("-bingzheng");
                    if (ids.Count > 0)
                        room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty), false);
                }
            }

            return false;
        }
    }

    public class Sheyan : TriggerSkill
    {
        public Sheyan() : base("sheyan")
        {
            events.Add(TriggerEvent.TargetConfirming);
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && base.Triggerable(player, room) && use.To.Contains(player))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard.IsNDTrick() && use.Card.Name != Collateral.ClassName)
                    return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                List<Player> targets = new List<Player>();
                if (use.To.Contains(player) && use.To.Count > 1) targets.Add(player);

                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (use.To.Contains(p))
                        targets.Add(p);
                    else if (RoomLogic.IsProhibited(room, use.From, p, use.Card) == null)
                    {
                        if ((fcard is IronChain && !p.Chained && !RoomLogic.CanBeChainedBy(room, player, p))
                        || (fcard is FireAttack && p.IsKongcheng()) || (fcard is Snatch && (!RoomLogic.CanGetCard(room, player, p, "hej") || p == use.From || p.IsAllNude()))
                        || (fcard is Dismantlement && (!RoomLogic.CanDiscard(room, player, p, "hej") || p == use.From || p.IsAllNude()))
                        || (fcard is Duel && p == use.From) || ((fcard is ArcheryAttack || fcard is SavageAssault) && p == use.From)) continue;
                        targets.Add(p);
                    }
                }

                if (targets.Count > 0)
                {
                    room.SetTag(Name, data);
                    Player target = room.AskForPlayerChosen(player, targets, Name, string.Format("@sheyan:{0}::{1}", use.From.Name, use.Card.Name), true, true, info.SkillPosition);
                    room.RemoveTag(Name);
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
            Player target = (Player)room.GetTag(Name);
            room.RemoveTag(Name);
            if (data is CardUseStruct use)
            {
                if (use.To.Contains(target))
                {
                    if (target != player && (use.Card.Name == ArcheryAttack.ClassName || use.Card.Name == SavageAssault.ClassName))
                    {
                        ResultStruct result = player.Result;
                        result.Assist++;
                        ask_who.Result = result;
                    }

                    room.CancelTarget(ref use, target);
                    data = use;
                    if (target == player) return true;
                }
                else
                {
                    if (use.Card.Name == ExNihilo.ClassName)
                    {
                        ResultStruct result = player.Result;
                        result.Assist++;
                        ask_who.Result = result;
                    }

                    use.To.Add(target);
                    use.EffectCount.Add(new CardBasicEffect(target, 0, 1, 0));
                    room.SortByActionOrder(ref use);
                    data = use;
                }
            }

            return false;
        }
    }

    public class Baobian : TriggerSkill
    {
        public Baobian() : base("baobian")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged, TriggerEvent.EventLoseSkill };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Masochism;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name)
            {
                int count = player.GetMark(Name);
                if (count >= 3) room.HandleAcquireDetachSkills(player, "-shensu_jx", true);
                if (count >= 2) room.HandleAcquireDetachSkills(player, "-paoxiao_jx", true);
                if (count >= 1) room.HandleAcquireDetachSkills(player, "-tiaoxin_jx", true);

                player.SetMark(Name, 0);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && base.Triggerable(player, room) && player.GetMark(Name) < 3) return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            int count = player.GetMark(Name);
            switch (count)
            {
                case 0:
                    room.HandleAcquireDetachSkills(player, "tiaoxin_jx", true);
                    break;
                case 1:
                    room.HandleAcquireDetachSkills(player, "paoxiao_jx", true);
                    break;
                case 2:
                    room.HandleAcquireDetachSkills(player, "shensu_jx", true);
                    break;
            }
            player.AddMark(Name);

            return false;
        }
    }

    public class Dianhu : TriggerSkill
    {
        public Dianhu() : base("dianhu")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart, TriggerEvent.Damage, TriggerEvent.HpRecover };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Wizzard;
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.GameStart && base.Triggerable(player, room))
                triggers.Add(new TriggerStruct(Name, player));
            else if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && damage.To.ContainsTag(Name) && damage.To.GetTag(Name) is List<string> names
                && names.Contains(player.Name))
                triggers.Add(new TriggerStruct(Name, player));
            else if (triggerEvent == TriggerEvent.HpRecover && player.ContainsTag(Name) && player.GetTag(Name) is List<string> _names)
            {
                foreach (string genreal in _names)
                {
                    Player target = room.FindPlayer(genreal);
                    if (target != null) triggers.Add(new TriggerStruct(Name, target));
                }
            }

            return triggers;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.GameStart)
            {
                Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@dianhu", false, true, info.SkillPosition);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);

                List<string> names = target.ContainsTag(Name) ? (List<string>)target.GetTag(Name) : new List<string>();
                names.Add(player.Name);
                target.SetTag(Name, names);
                room.SetPlayerStringMark(target, Name, string.Empty);
            }
            else
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 2, gsk.General, gsk.SkinId);
                room.DrawCards(ask_who, 1, Name);
            }

            return false;
        }
    }

    public class Jianji : ZeroCardViewAsSkill
    {
        public Jianji() : base("jianji")
        { }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(JianjiCard.ClassName);
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(JianjiCard.ClassName) { Skill = Name };
        }
    }

    public class JianjiCard : SkillCard
    {
        public static string ClassName = "JianjiCard";
        public JianjiCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && Self != to_select;
        }
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player target = card_use.To[0];
            List<int> ids = room.DrawCards(target, new DrawCardStruct(1, card_use.From, "jianji"));
            if (ids.Count == 1)
            {
                int id = ids[0];
                WrappedCard card = room.GetCard(id);
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                if (target.Alive && room.GetCardOwner(id) == target && room.GetCardPlace(id) == Place.PlaceHand && fcard.IsAvailable(room, target, card))
                    room.AskForUseCard(target, RespondType.None, id.ToString(), "@jianji", null);
            }
        }
    }

    public class Yuxu : TriggerSkill
    {
        public Yuxu() : base("yuxu")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseChanging, TriggerEvent.CardFinished };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.GetMark(Name) > 0)
                player.SetMark(Name, 0);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill
                && base.Triggerable(player, room) && (player.GetMark(Name) == 0 || player.GetMark(Name) % 2 == 0) && player.Phase == PlayerPhase.Play
                && !use.Card.HasFlag("#yuxu"))
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForSkillInvoke(ask_who, Name, "@yuxu-draw", info.SkillPosition))
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                room.DrawCards(ask_who, 1, Name);
                ask_who.AddMark(Name);
                use.Card.SetFlags(Name);
            }
            return false;
        }
    }

    public class YuxuDiscard : TriggerSkill
    {
        public YuxuDiscard() : base("#yuxu")
        {
            events.Add(TriggerEvent.CardFinished);
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && (player.GetMark("yuxu") == 1 || player.GetMark("yuxu") % 2 == 1) && !use.Card.HasFlag("yuxu") && player.Phase == PlayerPhase.Play
                && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill)
            {
                return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, Name, info.SkillPosition);
                room.BroadcastSkillInvoke("yuxu", "male", 2, gsk.General, gsk.SkinId);

                use.Card.SetFlags(Name);
                player.AddMark("yuxu");
                room.AskForDiscard(player, "yuxu", 1, 1, false, true, "@yuxu-discard", false, info.SkillPosition);
            }
            return false;
        }
    }

    public class Shijian : TriggerSkill
    {
        public Shijian() : base("shijian")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardFinished, TriggerEvent.EventPhaseChanging };
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive)
            {
                if (player.GetMark(Name) > 0) player.SetMark(Name, 0);
                if (player.HasFlag(Name))
                {
                    player.SetFlags("-shijian");
                    room.HandleAcquireDetachSkills(player, "-yuxu", true);
                }
            }
            else if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && Engine.GetFunctionCard(use.Card.Name).TypeID != CardType.TypeSkill && player.Phase == PlayerPhase.Play)
            {
                player.AddMark(Name);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.CardFinished && player.GetMark(Name) == 2 && !player.HasFlag(Name) && player.Phase == PlayerPhase.Play)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                    if (p != player && !p.IsNude())
                        triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForDiscard(ask_who, Name, 1, 1, true, true, string.Format("@shijian:{0}", player.Name), true, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Alive)
            {
                player.SetFlags(Name);
                room.HandleAcquireDetachSkills(player, "yuxu", true);
            }

            return false;
        }
    }

    public class Youlong : TriggerSkill
    {
        public Youlong() : base("youlong")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventAcquireSkill, TriggerEvent.EventLoseSkill };
            view_as_skill = new YoulongVS();
            skill_type = SkillType.Wizzard;
            turn = true;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventAcquireSkill && data is InfoStruct info && info.Info == Name)
            {
                room.SetTurnSkillState(player, Name, false, info.Head ? "head" : "deputy");
            }
            else if (triggerEvent == TriggerEvent.EventLoseSkill && data is InfoStruct _info && _info.Info == Name)
            {
                room.RemoveTurnSkill(player);
                player.SetMark("youlong_trick", 0);
                player.SetMark("youlong_basic", 0);
                List<string> guhuo = ViewAsSkill.GetGuhuoCards(room, "bt");
                foreach (string card_name in guhuo)
                {
                    if (card_name.Contains(Slash.ClassName))
                        player.SetMark("youlong_Slash", 0);
                    else
                        player.SetMark("youlong_" + card_name, 0);
                }
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class YoulongVS : ViewAsSkill
    {
        public YoulongVS() : base("youlong")
        {
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            int count = player.GetMark("youlong") == 0 ? 1 : 2;
            if (((count == 1 && player.GetMark("youlong_trick") < room.Round) || (count == 2 && player.GetMark("youlong_basic") < room.Round))
                && GetGuhuoCardNames(room, player).Count > 0)
            {
                for (int i = 0; i < 5; i++)
                    if (!player.EquipIsBaned(i)) return true;
            }
            return false;
        }

        public override bool IsEnabledAtNullification(Room room, Player player)
        {
            if (player.GetMark("youlong") == 0 && player.GetMark("youlong_Nullification") == 0 && player.GetMark("youlong_trick") < room.Round)
            {
                for (int i = 0; i < 5; i++)
                    if (!player.EquipIsBaned(i)) return true;
            }
            return false;
        }

        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
        {
            int count = player.GetMark("youlong") == 0 ? 1 : 2;
            bool trick = count == 1;

            if (player.GetMark("youlong") == 1 && player.GetMark("youlong_basic") < room.Round && room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE
                && ((trick && MatchNTTrick(respond)) || (!trick && MatchBasic(respond))))
            {
                bool equip = false;
                for (int i = 0; i < 5; i++)
                {
                    if (!player.EquipIsBaned(i))
                    {
                        equip = true;
                        break;
                    }
                }

                if (equip)
                {
                    foreach (string card_name in GetGuhuoCardNames(room, player))
                    {
                        WrappedCard card = new WrappedCard(card_name);
                        if (Engine.MatchExpPattern(room, pattern, player, card))
                            return true;
                    }
                }
            }

            return false;
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            if (cards.Count == 0)
            {
                if (room.GetRoomState().GetCurrentCardUsePattern() == "Nullification")
                    result.Add(new WrappedCard(Nullification.ClassName) { Skill = "_youlong" });
                else
                    foreach (string card_name in GetGuhuoCardNames(room, player))
                        result.Add(new WrappedCard(card_name) { Skill = "_youlong" });
            }
            return result;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
            {
                return new WrappedCard(YoulongCard.ClassName) { Skill = Name, Mute = true, UserString = cards[0].Name };
            }
            return null;
        }

        private List<string> GetGuhuoCardNames(Room room, Player player)
        {
            List<string> cards = new List<string>();

            int count = player.GetMark("youlong") == 0 ? 1 : 2;
            List<string> guhuo = GetGuhuoCards(room, count == 1 ? "t" : "b");
            foreach (string card_name in guhuo)
            {
                if (card_name.Contains(Slash.ClassName))
                {
                    if (player.GetMark("youlong_Slash") == 0)
                        cards.Add(card_name);
                }
                else
                {
                    if (player.GetMark("youlong_" + card_name) == 0)
                        cards.Add(card_name);
                }
            }

            return cards;
        }
    }

    public class YoulongCard : SkillCard
    {
        public static string ClassName = "YoulongCard";
        public YoulongCard() : base(ClassName)
        {
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
            int count = player.GetMark("youlong") == 0 ? 1 : 2;
            player.SetMark("youlong", count == 1 ? 1 : 0);
            if (count == 1)
                player.SetMark("youlong_trick", room.Round);
            else
                player.SetMark("youlong_basic", room.Round);

            room.BroadcastSkillInvoke("youlong", player, use.Card.SkillPosition);

            List<string> choices = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                if (!player.EquipIsBaned(i))
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

            string choice = room.AskForChoice(player, "youlong", string.Join("+", choices), new List<string> { "@youlong" }, null, use.Card.SkillPosition);
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
            room.AbolisheEquip(player, index, Name);
            if (player.Alive)
            {
                string card_name = use.Card.UserString;
                if (card_name.Contains(Slash.ClassName))
                    player.SetMark("youlong_Slash", 1);
                else
                    player.SetMark("youlong_" + card_name, 1);
                room.SetTurnSkillState(player, "youlong", count == 1, use.Card.SkillPosition);

                WrappedCard card = new WrappedCard(use.Card.UserString) { Skill = "_youlong" };
                return card;
            }
            else
                return null;
        }

        public override WrappedCard ValidateInResponse(Room room, Player player, WrappedCard card)
        {
            int count = player.GetMark("youlong") == 0 ? 1 : 2;
            player.SetMark("youlong", count == 1 ? 1 : 0);
            if (count == 1)
                player.SetMark("youlong_trick", room.Round);
            else
                player.SetMark("youlong_basic", room.Round);

            room.BroadcastSkillInvoke("youlong", player, card.SkillPosition);
            List<string> choices = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                if (!player.EquipIsBaned(i))
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

            string choice = room.AskForChoice(player, "youlong", string.Join("+", choices), new List<string> { "@youlong" }, null, card.SkillPosition);
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
            room.AbolisheEquip(player, index, Name);
            if (player.Alive)
            {
                string card_name = card.UserString;
                if (card_name.Contains(Slash.ClassName))
                    player.SetMark("youlong_Slash", 1);
                else
                    player.SetMark("youlong_" + card_name, 1);
                room.SetTurnSkillState(player, "youlong", count == 1, card.SkillPosition);

                WrappedCard new_card = new WrappedCard(card.UserString) { Skill = "_youlong" };
                return new_card;
            }
            else
                return null;
        }
    }

    public class Luanfeng : TriggerSkill
    {
        public Luanfeng() : base("luanfeng")
        {
            events.Add(TriggerEvent.Dying);
            skill_type = SkillType.Recover;
            frequency = Frequency.Limited;
            limit_mark = "@luanfeng";
        }
        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            List<Player> dacongming = RoomLogic.FindPlayersBySkillName(room, Name);
            foreach (Player p in dacongming)
            {
                if (p.GetMark(limit_mark) > 0 && p.MaxHp <= player.MaxHp)
                    triggers.Add(new TriggerStruct(Name, p));
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Hp < 1 && room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition))
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.RemovePlayerMark(ask_who, limit_mark);
                room.DoSuperLightbox(ask_who, info.SkillPosition, Name);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            int count = Math.Min(player.MaxHp - player.Hp, 3 - player.Hp);
            RecoverStruct recover = new RecoverStruct();
            recover.Who = ask_who;
            recover.Recover = count;
            room.Recover(player, recover, true);

            int recover_count = 0;
            if (player.Alive)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (room.RecoverEquip(player, i))
                        recover_count++;
                }
            }

            if (player.Alive && player.HandcardNum < 6 - recover_count)
                room.DrawCards(player, new DrawCardStruct(6 - recover_count - player.HandcardNum, ask_who, Name));

            if (player.Alive && player == ask_who)
            {
                List<string> guhuo = ViewAsSkill.GetGuhuoCards(room, "bt");
                foreach (string card_name in guhuo)
                {
                    if (card_name.Contains(Slash.ClassName))
                        player.SetMark("youlong_Slash", 0);
                    else
                        player.SetMark("youlong_" + card_name, 0);
                }
            }

            return false;
        }
    }

    public class Xiuhao : TriggerSkill
    {
        public Xiuhao() : base("xiuhao")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageCaused, TriggerEvent.DamageInflicted };
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.DamageCaused && base.Triggerable(player, room) && !player.HasFlag(Name) && data is DamageStruct damage && damage.To != player)
            {
                return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.DamageInflicted && data is DamageStruct _damage && _damage.From != null && _damage.From != player && _damage.From.Alive
                && base.Triggerable(player, room) && !player.HasFlag(Name))
            {
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
            DamageStruct damage = (DamageStruct)data;
            player.SetFlags(Name);
            if (triggerEvent == TriggerEvent.DamageCaused)
            {
                LogMessage log = new LogMessage
                {
                    Type = "#damage-prevent",
                    From = player.Name,
                    To = new List<string> { damage.To.Name },
                    Arg = Name
                };
                room.SendLog(log);

                room.DrawCards(player, 2, Name);
            }
            else
            {
                LogMessage log = new LogMessage
                {
                    Type = "#damaged-prevent",
                    From = player.Name,
                    Arg = Name
                };
                room.SendLog(log);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, damage.From.Name);
                room.DrawCards(damage.From, new DrawCardStruct(2, player, Name));
            }

            return true;
        }
    }

    public class Sujian : TriggerSkill
    {
        public Sujian() : base("sujian")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseProceeding, TriggerEvent.CardsMoveOneTime, TriggerEvent.TurnStart };
            frequency = Frequency.Compulsory;
            view_as_skill = new SujianVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.TurnStart)
                player.RemoveTag(Name);
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To != null && move.To.Phase != PlayerPhase.NotActive
                && move.To_place == Place.PlaceHand)
            {
                List<int> ids = move.To.ContainsTag(Name) ? (List<int>)move.To.GetTag(Name) : new List<int>();
                foreach (int id in move.Card_ids)
                    if (!ids.Contains(id))
                        ids.Add(id);

                move.To.SetTag(Name, ids);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Discard && !player.IsKongcheng())
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> hands = player.GetCards("h");
            List<int> in_turn = player.ContainsTag(Name) ? (List<int>)player.GetTag(Name) : new List<int>();
            in_turn.RemoveAll(t => (room.GetCardPlace(t) != Place.PlaceHand || room.GetCardOwner(t) != player));
            hands.RemoveAll(t => in_turn.Contains(t));
            hands.RemoveAll(t => !RoomLogic.CanDiscard(room, player, player, t));

            room.SendCompulsoryTriggerLog(player, Name);
            List<string> choices = new List<string>();
            if (hands.Count > 0) choices.Add("discard");
            if (in_turn.Count > 0) choices.Add("give");

            if (choices.Count > 0)
            {
                string choice = room.AskForChoice(player, Name, string.Join("+", choices), null, null, info.SkillPosition);
                if (choice == "discard")
                {
                    int count = hands.Count;
                    room.ThrowCard(ref hands, player, null, null);

                    List<Player> targets = new List<Player>();
                    foreach (Player p in room.GetOtherPlayers(player))
                        if (!p.IsNude() && RoomLogic.CanDiscard(room, player, p, "he"))
                            targets.Add(p);

                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    if (targets.Count > 0)
                    {
                        player.SetTag(Name, count);
                        Player target = room.AskForPlayerChosen(player, targets, Name, "@sujian-discard:::{0}" + count.ToString(), false, true, info.SkillPosition);
                        player.RemoveTag(Name);
                        List<string> method = new List<string>();
                        for (int i = 0; i < count; i++)
                            method.Add("he^false^discard");

                        List<int> ids = room.AskForCardsChosen(player, target, method, Name);
                        if (ids.Count > 0)
                            room.ThrowCard(ref ids, new CardMoveReason(MoveReason.S_REASON_DISMANTLE, player.Name, target.Name, Name, string.Empty)
                                { General = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition) },
                                target, player);
                    }
                }
                else
                {
                    List<int> cards = new List<int>(in_turn);
                    player.PileChange("#sujian", cards);
                    List<Player> targets = new List<Player>();
                    List<CardsMoveStruct> moves = new List<CardsMoveStruct>();
                    while (cards.Count > 0)
                    {
                        WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@sujian", "@sujian", null, -1, HandlingMethod.MethodNone, true, info.SkillPosition);
                        if (card != null)
                        {
                            Player target = (Player)room.GetTag("sujian_target");
                            room.RemoveTag("sujian_target");
                            targets.Add(target);
                            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty);
                            CardsMoveStruct move = new CardsMoveStruct(new List<int>(card.SubCards), target, Place.PlaceHand, reason);
                            moves.Add(move);

                            player.PileChange("#sujian", card.SubCards, false);
                            cards.RemoveAll(t => card.SubCards.Contains(t));

                            List<string> args = new List<string> { JsonUntity.Object2Json(card.SubCards), "@attribute:" + target.Name };
                            room.DoNotify(room.GetClient(player), CommandType.S_COMMAND_UPDATE_CARD_FOOTNAME, args);
                        }
                        else
                            break;
                    }

                    if (cards.Count > 0)
                    {
                        if (moves.Count > 0)
                        {
                            moves[0].Card_ids.AddRange(cards);
                        }
                        else
                        {
                            Player target = room.GetOtherPlayers(player)[0];
                            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty);
                            CardsMoveStruct move = new CardsMoveStruct(cards, target, Place.PlaceHand, reason);
                            moves.Add(move);
                        }
                    }

                    player.PileChange("#sujian", cards, false);

                    if (moves.Count > 0)
                    {
                        room.BroadcastSkillInvoke(Name, player, info.SkillPosition);

                        LogMessage l = new LogMessage
                        {
                            Type = "#ChoosePlayerWithSkill",
                            From = player.Name,
                            Arg = Name
                        };
                        l.SetTos(targets);
                        room.SendLog(l);

                        room.MoveCardsAtomic(moves, false);
                    }

                    return false;
                }
            }

            room.SkipGameRule = true;
            return false;
        }
    }

    public class SujianVS : ViewAsSkill
    {
        public SujianVS() : base("sujian")
        {
            response_pattern = "@@sujian";
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return player.GetPile("#sujian").Contains(to_select.Id);
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            WrappedCard ss = new WrappedCard(SujianCard.ClassName);
            ss.AddSubCards(cards);
            return ss;
        }
    }

    public class SujianCard : SkillCard
    {
        public static string ClassName = "SujianCard";
        public SujianCard() : base(ClassName)
        {
            will_throw = false;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            room.SetTag("sujian_target", card_use.To[0]);

            ResultStruct result = card_use.From.Result;
            result.Assist += card_use.Card.SubCards.Count;
            card_use.From.Result = result;
        }
    }

    public class Juanxia : TriggerSkill
    {
        public Juanxia() : base("juanxia")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
            skill_type = SkillType.Attack;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Finish && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@juanxia", true, true, info.SkillPosition);
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
                WrappedCard fire = new WrappedCard(FireAttack.ClassName) { Skill = "_juanxia" };
                WrappedCard duel = new WrappedCard(Duel.ClassName) { Skill = "_juanxia" };
                WrappedCard dis = new WrappedCard(Dismantlement.ClassName) { Skill = "_juanxia" };
                WrappedCard snatch = new WrappedCard(Snatch.ClassName) { Skill = "_juanxia" };
                List<WrappedCard> cards = new List<WrappedCard> { fire, duel, dis, snatch };

                int count = 0;
                for (int i = 0; i < 2; i++)
                {
                    if (player.Alive && target.Alive)
                    {
                        List<string> choices = new List<string>();
                        if (cards.Contains(fire) && !player.IsKongcheng() && !target.IsKongcheng() && RoomLogic.IsProhibited(room, player, target, fire) == null)
                            choices.Add(fire.Name);
                        if (cards.Contains(duel) && RoomLogic.IsProhibited(room, player, target, duel) == null)
                            choices.Add(duel.Name);
                        if (cards.Contains(dis) && !target.IsNude() && RoomLogic.IsProhibited(room, player, target, dis) == null && RoomLogic.CanDiscard(room, player, target, "hej"))
                            choices.Add(dis.Name);
                        if (cards.Contains(snatch) && !target.IsNude() && RoomLogic.IsProhibited(room, player, target, snatch) == null && RoomLogic.CanGetCard(room, player, target, "hej"))
                            choices.Add(snatch.Name);

                        if (i == 1) choices.Add("cancel");
                        string choice = room.AskForChoice(player, Name, string.Join("+", choices), new List<string> { "@to-player:" + target.Name }, target, info.SkillPosition);
                        if (choice != "cancel")
                        {
                            count++;
                            WrappedCard card = cards.Find(t => t.Name == choice);
                            cards.Remove(card);
                            room.UseCard(new CardUseStruct(card, player, target));
                        }
                    }
                }

                if (player.Alive && target.Alive)
                {
                    Dictionary<string, int> keys = target.ContainsTag("juanxia_target") ? (Dictionary<string, int>)target.GetTag("juanxia_target") : new Dictionary<string, int>();
                    if (keys.ContainsKey(player.Name))
                        keys[player.Name] += count;
                    else
                        keys[player.Name] = count;
                    target.SetTag("juanxia_target", keys);
                }
            }

            return false;
        }
    }

    public class JuanxiaEffect : TriggerSkill
    {
        public JuanxiaEffect() : base("#juanxia")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (player.Phase == PlayerPhase.Finish && player.Alive && player.ContainsTag("juanxia_target"))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.GetTag("juanxia_target") is Dictionary<string, int> keys)
            {
                player.RemoveTag("juanxia_target");
                WrappedCard slash = new WrappedCard(Slash.ClassName);
                List<Player> targets = new List<Player>();
                foreach (string player_name in keys.Keys)
                {
                    Player target = room.FindPlayer(player_name);
                    if (target != null && RoomLogic.IsProhibited(room, player, target, slash) == null)
                        targets.Add(target);
                }
                if (targets.Count > 0)
                {
                    room.SortByActionOrder(ref targets);
                    foreach (Player p in targets)
                    {
                        for (int i = 0; i < keys[p.Name]; i++)
                        {
                            WrappedCard card = new WrappedCard(Slash.ClassName) { DistanceLimited = false };
                            if (player.Alive && p.Alive && RoomLogic.IsProhibited(room, player, p, card) == null && room.AskForSkillInvoke(player, Name, "@juanxia-slash:" + p.Name))
                                room.UseCard(new CardUseStruct(card, player, p));
                            else
                                break;
                        }
                    }
                }
            }
            return false;
        }
    }

    public class Dingcuo : TriggerSkill
    {
        public Dingcuo() : base("dingcuo")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.Damaged };
            skill_type = SkillType.Replenish;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && !player.HasFlag(Name))
                return new TriggerStruct(Name, player);

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
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> ids = room.DrawCards(player, 2, Name);
            if (ids.Count == 2 && WrappedCard.IsRed(room.GetCard(ids[0]).Suit) != WrappedCard.IsRed(room.GetCard(ids[1]).Suit) && !player.IsKongcheng())
                room.AskForDiscard(player, Name, 1, 1, false, false, "@dingcuo", false, info.SkillPosition);

            return false;
        }
    }

    public class Qiongshou : TriggerSkill
    {
        public Qiongshou() : base("qiongshou")
        {
            events = new List<TriggerEvent> { TriggerEvent.GameStart };
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who) => (base.Triggerable(player, room)) ? new TriggerStruct(Name, player) : new TriggerStruct();

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            for (int i = 0; i < 5; i++)
                if (player.Alive) room.AbolisheEquip(player, i, Name);

            if (player.Alive) room.DrawCards(player, 4, Name);
            return false;
        }
    }

    public class QiongshouMax : MaxCardsSkill
    {
        public QiongshouMax() : base("#qiongshou") { }
        public override int GetExtra(Room room, Player target) => RoomLogic.PlayerHasShownSkill(room, target, "qiongshou") ? 4 : 0;
    }

    public class Fenrui : TriggerSkill
    {
        public Fenrui() : base("fenrui") { events.Add(TriggerEvent.EventPhaseStart); skill_type = SkillType.Attack; }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish && !player.IsNude())
            {
                for (int i = 0; i < 5; i++)
                    if (player.EquipIsBaned(i))
                        return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (room.AskForDiscard(player, Name, 1, 1, true, true, "@fenrui", true, info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.Alive)
            {
                List<string> choices = new List<string>();
                for (int i = 0; i < 5; i++)
                {
                    if (player.EquipIsBaned(i))
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

                string choice = room.AskForChoice(player, Name, string.Join("+", choices), new List<string> { "@fenrui-recover" }, null, info.SkillPosition);
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
                room.RecoverEquip(player, index);

                int card_id = -1;
                foreach (int id in room.DrawPile)
                {
                    WrappedCard card = room.GetCard(id);
                    FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                    if (index == 0 && fcard is Weapon && fcard.IsAvailable(room, player, card))
                    {
                        card_id = id;
                        break;
                    }
                    else if (index == 1 && fcard is Armor && fcard.IsAvailable(room, player, card))
                    {
                        card_id = id;
                        break;
                    }
                    else if (index == 2 && fcard is DefensiveHorse && fcard.IsAvailable(room, player, card))
                    {
                        card_id = id;
                        break;
                    }
                    else if (index == 3 && fcard is OffensiveHorse && fcard.IsAvailable(room, player, card))
                    {
                        card_id = id;
                        break;
                    }
                    else if (index == 4 && fcard is Treasure && fcard.IsAvailable(room, player, card))
                    {
                        card_id = id;
                        break;
                    }
                }

                if (card_id == -1)
                {
                    foreach (int id in room.DiscardPile)
                    {
                        WrappedCard card = room.GetCard(id);
                        FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                        if (index == 0 && fcard is Weapon && fcard.IsAvailable(room, player, card))
                        {
                            card_id = id;
                            break;
                        }
                        else if (index == 1 && fcard is Armor && fcard.IsAvailable(room, player, card))
                        {
                            card_id = id;
                            break;
                        }
                        else if (index == 2 && fcard is DefensiveHorse && fcard.IsAvailable(room, player, card))
                        {
                            card_id = id;
                            break;
                        }
                        else if (index == 3 && fcard is OffensiveHorse && fcard.IsAvailable(room, player, card))
                        {
                            card_id = id;
                            break;
                        }
                        else if (index == 4 && fcard is Treasure && fcard.IsAvailable(room, player, card))
                        {
                            card_id = id;
                            break;
                        }
                    }
                }

                if (card_id != -1)
                    room.UseCard(new CardUseStruct(room.GetCard(card_id), player, new List<Player>(), false));

                if (player.GetMark(Name) == 0 && player.HasEquip())
                {
                    int count = player.GetEquips().Count;
                    List<Player> targets = new List<Player>();
                    foreach (Player p in room.GetOtherPlayers(player))
                        if (count > p.GetEquips().Count)
                            targets.Add(p);

                    if (targets.Count > 0)
                    {
                        Player target = room.AskForPlayerChosen(player, targets, Name, "@fenrui-damage", true, true, info.SkillPosition);
                        if (target != null)
                        {
                            player.SetMark(Name, 1);
                            room.Damage(new DamageStruct(Name, player, target, count - target.GetEquips().Count));
                        }
                    }
                }
            }

            return false;
        }
    }

    public class Xiaosi : OneCardViewAsSkill
    {
        public Xiaosi() : base("xiaosi") { expand_pile = "#xiaosi"; skill_type = SkillType.Attack; }
        public override bool IsEnabledAtPlay(Room room, Player player) => !player.HasUsed(XiaosiCard.ClassName);
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern) => pattern == "@@xiaosi";
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE)
                return to_select.Name != Jink.ClassName && player.GetPile("#xiaosi").Contains(to_select.Id);
            else
                return player.GetCards("h").Contains(to_select.Id) && Engine.GetFunctionCard(to_select.Name) is BasicCard && RoomLogic.CanDiscard(room, player, player, to_select.Id);
        }
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_RESPONSE_USE)
                return card;
            else
            {
                WrappedCard xs = new WrappedCard(XiaosiCard.ClassName) { Skill = Name };
                xs.AddSubCard(card);
                return xs;
            }
        }
    }

    public class XiaosiTag : TargetModSkill
    {
        public XiaosiTag() : base("#xiaosi-tar", false) { pattern = ".|.|.|$xiaosi"; }
        public override bool GetDistanceLimit(Room room, Player from, Player to, WrappedCard card, CardUseReason reason, string pattern) => reason == CardUseReason.CARD_USE_REASON_RESPONSE_USE && pattern == "@@xiaosi" ? true : false;
        public override bool CheckSpecificAssignee(Room room, Player from, Player to, WrappedCard card, string pattern) => pattern == "@@xiaosi" ? true : false;
    }

    public class XiaosiCard : SkillCard
    {
        public static string ClassName = "XiaosiCard";
        public XiaosiCard() : base(ClassName) { will_throw = true; }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card) => targets.Count == 0 && to_select != Self;
        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            Player target = card_use.To[0];

            bool draw = true;
            int card_id = -1;
            if (target.Alive && !target.IsKongcheng())
            {
                List<int> available = new List<int>();
                foreach (int id in target.GetCards("h"))
                {
                    if (Engine.GetFunctionCard(room.GetCard(id).Name) is BasicCard && RoomLogic.CanDiscard(room, target, target, id))
                        available.Add(id);
                }
                if (available.Count == 1)
                {
                    card_id = available[0];
                    draw = false;
                    room.ThrowCard(ref available, new CardMoveReason(MoveReason.S_REASON_THROW, target.Name, "xiaosi", string.Empty), target, null, null);
                }
                else if (available.Count > 1)
                {
                    string pattern = string.Join("#", available);
                    List<int> ids = room.AskForExchange(target, "xiaosi", 1, 1, string.Format("@xiaosi:{0}", player.Name), string.Empty, pattern, string.Empty);
                    if (ids.Count != 1)
                    {
                        card_id = available[0];
                        ids.Clear();
                        ids.Add(card_id);
                    }
                    card_id = ids[0];
                    draw = false;
                    room.ThrowCard(ref ids, new CardMoveReason(MoveReason.S_REASON_THROW, target.Name, "xiaosi", string.Empty), target, null, null);
                }
            }
            if (player.Alive)
            {
                List<int> can_use = new List<int>();
                if (room.GetCardPlace(card_use.Card.GetEffectiveId()) == Place.DiscardPile)
                    can_use.Add(card_use.Card.GetEffectiveId());
                if (card_id != -1 && room.GetCardPlace(card_id) == Place.DiscardPile)
                    can_use.Add(card_id);

                while (can_use.Count > 0 && player.Alive)
                {
                    player.Piles["#xiaosi"] = can_use;
                    WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@xiaosi", "@xiaosi-use", null, -1, HandlingMethod.MethodUse, false, card_use.Card.SkillPosition);
                    if (card != null)
                        can_use.Remove(card.GetEffectiveId());
                    else
                        break;
                }
                player.Piles["#xiaosi"].Clear();
            }
            if (player.Alive && draw) room.DrawCards(player, 1, "xiaosi");
        }
    }

    public class Hongyuan : TriggerSkill
    {
        public Hongyuan() : base("hongyuan")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime, TriggerEvent.EventPhaseChanging };
            view_as_skill = new HongyuanVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging)
                foreach (Player p in room.GetAlivePlayers())
                    p.SetFlags("-hongyuan");
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move)
            {
                if (move.To != null && base.Triggerable(move.To, room) && !move.To.HasFlag(Name) && move.To_place == Place.PlaceHand && move.Card_ids.Count >= 2)
                    return new TriggerStruct(Name, move.To);
            }

            return new TriggerStruct();
        }
        
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> cards = ask_who.GetCards("he");
            ask_who.PileChange("#hongyuan", cards);

            List<Player> targets = new List<Player>();
            List<Player> friends = room.GetOtherPlayers(ask_who);
            foreach (Player p in friends)
                p.SetFlags("shushou");

            List<CardsMoveStruct> moves = new List<CardsMoveStruct>();
            while (cards.Count > 0 && friends.Count > 0 && targets.Count < 2)
            {
                WrappedCard card = room.AskForUseCard(ask_who, RespondType.Skill, "@@hongyuan", "@hongyuan", null, -1, HandlingMethod.MethodNone, true, info.SkillPosition);
                if (card != null)
                {
                    Player target = (Player)room.GetTag("shushou_target");
                    room.RemoveTag("shushou_target");
                    target.SetFlags("-shushou");
                    friends.Remove(target);
                    targets.Add(target);
                    CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GIVE, ask_who.Name, target.Name, Name, string.Empty);
                    CardsMoveStruct move = new CardsMoveStruct(new List<int>(card.SubCards), target, Place.PlaceHand, reason);
                    moves.Add(move);

                    ask_who.PileChange("#hongyuan", card.SubCards, false);
                    cards.RemoveAll(t => card.SubCards.Contains(t));

                    List<string> args = new List<string> { JsonUntity.Object2Json(card.SubCards), "@attribute:" + target.Name };
                    room.DoNotify(room.GetClient(ask_who), CommandType.S_COMMAND_UPDATE_CARD_FOOTNAME, args);
                }
                else
                    break;
            }

            ask_who.PileChange("#hongyuan", cards, false);
            foreach (Player p in room.Players)
                p.SetFlags("-shushou");

            if (moves.Count > 0)
            {
                ask_who.SetFlags(Name);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                room.NotifySkillInvoked(ask_who, Name);
                LogMessage l = new LogMessage
                {
                    Type = "#ChoosePlayerWithSkill",
                    From = ask_who.Name,
                    Arg = Name
                };
                l.SetTos(targets);
                room.SendLog(l);

                room.MoveCardsAtomic(moves, false);
            }
            return false;
        }
    }

    public class Chenglie : TriggerSkill
    {
        public Chenglie() : base("chenglie")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChosen };
            skill_type = SkillType.Attack;
            view_as_skill = new ChenglieVS();
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && use.Card.Name.Contains(Slash.ClassName) && base.Triggerable(player, room))
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
            if (data is CardUseStruct use)
            {
                use.Card.SetFlags(Name);
                List<Player> targets = new List<Player>();
                foreach (Player p in use.To)
                    if (!targets.Contains(p)) targets.Add(p);

                List<int> card_ids = room.GetNCards(targets.Count);
                foreach (int id in card_ids)
                    room.MoveCardTo(room.GetCard(id), player, Place.PlaceTable, new CardMoveReason(MoveReason.S_REASON_TURNOVER, player.Name, Name, null), false);
                Thread.Sleep(400);
                room.AddToPile(player, Name, card_ids, false);
                if (player.Alive && player.HandcardNum > 0)
                {
                    player.SetFlags(Name);
                    player.PileChange("#chenglie", card_ids);
                    WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@chenglie", "@chenglie-change", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
                    player.Piles["#chenglie"].Clear();
                    player.SetFlags("-chenglie");

                    if (card != null)
                    {
                        List<int> hands = new List<int>(), piles = new List<int>();
                        if (room.GetCardPlace(card.SubCards[0]) == Place.PlaceHand)
                        {
                            hands.Add(card.SubCards[0]);
                            piles.Add(card.SubCards[1]);
                            card_ids.Add(card.SubCards[0]);
                        }
                        else
                        {
                            hands.Add(card.SubCards[1]);
                            piles.Add(card.SubCards[0]);
                            card_ids.Add(card.SubCards[1]);
                        }
                        List<CardsMoveStruct> moves = new List<CardsMoveStruct>();
                        CardsMoveStruct move1 = new CardsMoveStruct(piles, player, Place.PlaceHand, new CardMoveReason(MoveReason.S_REASON_EXCHANGE_FROM_PILE, player.Name, Name, string.Empty));
                        CardsMoveStruct move2 = new CardsMoveStruct(hands, player, Place.PlaceSpecial,
                            new CardMoveReason(MoveReason.S_REASON_REMOVE_FROM_GAME, player.Name, Name, string.Empty))
                        {
                            To_pile_name = Name
                        };
                        moves.Add(move1);
                        moves.Add(move2);
                        room.MoveCardsAtomic(moves, false);
                    }
                }
                if (player.Alive)
                {
                    Dictionary<Player, int> values = new Dictionary<Player, int>();
                    targets.RemoveAll(t => !t.Alive);
                    card_ids.RemoveAll(t => room.GetCardPlace(t) != Place.PlaceSpecial);
                    player.PileChange("#chenglie", card_ids);

                    Dictionary<WrappedCard, List<int>> ids = room.ContainsTag("chenglie_cards") ? (Dictionary<WrappedCard, List<int>>)room.GetTag("chenglie_cards")
                        : new Dictionary<WrappedCard, List<int>>();
                    ids[use.Card] = new List<int>(card_ids);
                    room.SetTag("chenglie_cards", ids);

                    foreach (Player p in targets)
                        p.SetFlags(Name);
                    while (card_ids.Count > 0 && targets.Count > 0)
                    {
                        Player target = null;
                        List<int> cards = new List<int>();
                        if (card_ids.Count > 1 && targets.Count > 1)
                        {
                            WrappedCard card = room.AskForUseCard(player, RespondType.Skill, "@@chenglie!", string.Format("@chenglie:::{0}", use.Card.Name), null, -1, HandlingMethod.MethodNone, true, info.SkillPosition);
                            if (card != null && room.GetTag("chenglie_target") is Player _target)
                            {
                                target = _target;
                                room.RemoveTag("chenglie_target");
                                cards.AddRange(card.SubCards);
                            }
                        }

                        if (target == null)
                        {
                            cards.Add(card_ids[0]);
                            target = targets[0];
                        }
                        target.SetFlags("-" + Name);
                        targets.Remove(target);
                        player.PileChange("#chenglie", cards, false);
                        card_ids.RemoveAll(t => cards.Contains(t));
                        if (WrappedCard.IsRed(room.GetCard(cards[0]).Suit)) values[target] = cards[0];
                    }

                    player.Piles["#chenglie"].Clear();
                    foreach (Player p in use.To)
                    {
                        p.SetFlags("-chenglie");
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, p.Name);
                    }
                    Dictionary<WrappedCard, Dictionary<Player, int>> pairs = room.ContainsTag(Name) ? (Dictionary<WrappedCard, Dictionary<Player, int>>)room.GetTag(Name)
                        : new Dictionary<WrappedCard, Dictionary<Player, int>>();
                    pairs[use.Card] = values;
                    room.SetTag(Name, pairs);
                }
            }
            return false;
        }
    }

    public class ChenglieEffect : TriggerSkill
    {
        public ChenglieEffect() : base("#chenglie-effect")
        {
            events = new List<TriggerEvent> { TriggerEvent.SlashMissed, TriggerEvent.CardFinished };
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.SlashMissed && data is SlashEffectStruct effect && effect.Slash.HasFlag("chenglie")
                && room.ContainsTag("chenglie") && room.GetTag("chenglie") is Dictionary<WrappedCard, Dictionary<Player, int>> pairs && pairs.ContainsKey(effect.Slash) && pairs[effect.Slash].ContainsKey(effect.To))
            {
                Dictionary<WrappedCard, List<Player>> results = room.ContainsTag("chenglie_result") ? (Dictionary<WrappedCard, List<Player>>)room.GetTag("chenglie_result")
                    : new Dictionary<WrappedCard, List<Player>>();
                if (!results.ContainsKey(effect.Slash))
                    results[effect.Slash] = new List<Player>();

                results[effect.Slash].Add(effect.To);
                room.SetTag("chenglie_result", results);
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardFinished && data is CardUseStruct use && use.Card.HasFlag("chenglie"))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                room.SendCompulsoryTriggerLog(player, "chenglie", true);
                Dictionary<WrappedCard, Dictionary<Player, int>> pairs = room.ContainsTag("chenglie") ? (Dictionary<WrappedCard, Dictionary<Player, int>>)room.GetTag("chenglie")
                    : new Dictionary<WrappedCard, Dictionary<Player, int>>();

                Dictionary<WrappedCard, List<Player>> results = room.ContainsTag("chenglie_result") ? (Dictionary<WrappedCard, List<Player>>)room.GetTag("chenglie_result")
                    : new Dictionary<WrappedCard, List<Player>>();

                Dictionary<WrappedCard, List<int>> cards = room.ContainsTag("chenglie_cards") ? (Dictionary<WrappedCard, List<int>>)room.GetTag("chenglie_cards")
                    : new Dictionary<WrappedCard, List<int>>();

                Dictionary<Player, int> value1 = pairs[use.Card];
                pairs.Remove(use.Card);
                List<Player> result1 = results.ContainsKey(use.Card) ? results[use.Card] : new List<Player>();
                results.Remove(use.Card);
                List<int> ids = cards[use.Card];
                cards.Remove(use.Card);

                if (pairs.Count > 0)
                    room.SetTag("chenglie", pairs);
                else
                    room.RemoveTag("chenglie");
                if (results.Count > 0)
                    room.SetTag("chenglie_result", results);
                else
                    room.RemoveTag("chenglie_result");

                if (cards.Count > 0)
                    room.SetTag("chenglie_cards", cards);
                else
                    room.RemoveTag("chenglie_cards");

                ids.RemoveAll(t => room.GetCardPlace(t) != Place.PlaceSpecial || room.GetCardOwner(t) != player);
                if (ids.Count > 0)
                {
                    CardsMoveStruct move = new CardsMoveStruct(ids, null, Place.DiscardPile, new CardMoveReason(MoveReason.S_REASON_REMOVE_FROM_PILE, player.Name, "chenglie", string.Empty))
                    {
                        To_pile_name = string.Empty,
                        From = player.Name
                    };
                    List<CardsMoveStruct> moves = new List<CardsMoveStruct> { move };
                    room.MoveCardsAtomic(moves, true);
                }

                List<Player> targets = new List<Player>(value1.Keys);
                room.SortByActionOrder(ref targets);
                foreach (Player p in targets)
                {
                    if (p != null)
                    {
                        int count = use.To.Count(t => t == p);
                        int jink = result1.Count(t => t == p);
                        count -= jink;
                        while (jink > 0 && player.Alive && p.Alive && !p.IsNude())
                        {
                            jink--;
                            List<int> give = room.AskForExchange(p, "chenglie", 1, 1, "@chenglie-give:" + player.Name, string.Empty, "..", null);
                            if (give.Count > 0)
                                room.ObtainCard(player, ref give, new CardMoveReason(MoveReason.S_REASON_GIVE, p.Name, player.Name, "chenglie", string.Empty), false);
                        }
                        while (count > 0 && p.Alive && p.IsWounded())
                        {
                            RecoverStruct recover = new RecoverStruct
                            {
                                Who = player,
                                Recover = 1
                            };
                            room.Recover(p, recover, true);
                        }
                    }
                }
            }
            return false;
        }
    }

    public class ChenglieVS : ViewAsSkill
    {
        public ChenglieVS() : base("chenglie")
        {
            expand_pile = "#chenglie";
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => false;
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern) => pattern.StartsWith("@@chenglie");
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (player.HasFlag(Name) && selected.Count < 2)
            {
                if (selected.Count == 0)
                    return room.GetCardPlace(to_select.Id) != Place.PlaceEquip;
                else
                {
                    if (room.GetCardPlace(selected[0].Id) == Place.PlaceHand)
                        return player.GetPile(expand_pile).Contains(to_select.Id);
                    else
                        return room.GetCardPlace(to_select.Id) == Place.PlaceHand;
                }
            }
            else
                return !player.HasFlag(Name) && selected.Count == 0 && player.GetPile(expand_pile).Contains(to_select.Id);
        }
        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (player.HasFlag(Name) && cards.Count == 2)
            {
                WrappedCard card = new WrappedCard(ChenglieCard.ClassName);
                card.AddSubCards(cards);
                return card;
            }
            else if (!player.HasFlag(Name) && cards.Count == 1)
            {
                WrappedCard card = new WrappedCard(ChenglieCard.ClassName);
                card.AddSubCards(cards);
                return card;
            }
            return null;
        }
    }

    public class ChenglieCard : SkillCard
    {
        public static string ClassName = "ChenglieCard";
        public ChenglieCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            if (card.SubCards.Count == 2)
                return false;
            else
                return targets.Count == 0 && to_select.HasFlag("chenglie");
        }
        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card) => (card.SubCards.Count == 2 && targets.Count == 0) || (card.SubCards.Count == 1 && targets.Count == 1);
        public override void OnUse(Room room, CardUseStruct card_use)
        {
            if (card_use.To.Count == 1)
                room.SetTag("chenglie_target", card_use.To[0]);
        }
    }

    public class ChenglieTar: TargetModSkill
    {
        public ChenglieTar() : base("#chenglie-tar", true) { }
        public override int GetExtraTargetNum(Room room, Player from, WrappedCard card) => RoomLogic.PlayerHasSkill(room, from, "chenglie") ? 2 : 0;
    }

    public class HongyuanVS : OneCardViewAsSkill
    {
        public HongyuanVS() : base("hongyuan")
        {
            response_pattern = "@@hongyuan";
        }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player) => player.GetPile("#hongyuan").Contains(to_select.Id);
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard ss = new WrappedCard(ShushouCard.ClassName);
            ss.AddSubCard(card);
            return ss;
        }
    }

    public class Huanshi : TriggerSkill
    {
        public Huanshi() : base("huanshi")
        {
            events.Add(TriggerEvent.AskForRetrial);
            skill_type = SkillType.Wizzard;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && !player.IsKongcheng())
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is JudgeStruct judge && judge.Who.Alive)
            {
                List<int> ids = new List<int>();
                foreach (int id in player.GetCards("h"))
                {
                    WrappedCard card = room.GetCard(id);
                    if (RoomLogic.IsCardLimited(room, player, card, FunctionCard.HandlingMethod.MethodResponse, true))
                        ids.Add(id);
                }

                if (ids.Count < player.HandcardNum)
                {
                    room.SetTag(Name, data);
                    bool invoke = room.AskForSkillInvoke(player, Name, judge.Who, info.SkillPosition);
                    room.RemoveTag(Name);
                    if (invoke)
                    {
                        room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                        room.SetTag(Name, data);
                        int id = room.AskForCardChosen(judge.Who, player, "he", Name, true, HandlingMethod.MethodResponse, ids);
                        room.RemoveTag(Name);
                        room.Retrial(room.GetCard(id), player, ref judge, Name, false, info.SkillPosition);
                        data = judge;
                        return info;
                    }
                }
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            JudgeStruct judge = (JudgeStruct)data;
            room.UpdateJudgeResult(ref judge);
            data = judge;
            return false;
        }
    }

    public class Mingzhe : TriggerSkill
    {
        public Mingzhe() : base("mingzhe")
        {
            events.Add(TriggerEvent.CardsMoveOneTime);
            skill_type = SkillType.Replenish;
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardsMoveOneTimeStruct move && move.From != null && (move.From_places.Contains(Place.PlaceEquip) || move.From_places.Contains(Place.PlaceHand))
                && base.Triggerable(move.From, room) && (move.To != move.From || move.To_place != Place.PlaceHand) && move.From.Phase != PlayerPhase.Play)
            {
                for (int i = 0; i < move.Card_ids.Count; i++)
                {
                    if ((move.From_places[i] == Place.PlaceEquip || move.From_places[i] == Place.PlaceHand) && WrappedCard.IsRed(room.GetCard(move.Card_ids[i]).Suit))
                        return new TriggerStruct(Name, move.From);
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, Name);
            room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
            room.DrawCards(ask_who, 1, Name);
            return false;
        }
    }

    public class Aocai : TriggerSkill
    {
        public Aocai() : base("aocai")
        {
            skill_type = SkillType.Defense;
            view_as_skill = new AocaiVS();
            events = new List<TriggerEvent> { TriggerEvent.DrawPileChanged, TriggerEvent.CardsMoveOneTime };
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.DrawPileChanged)
            {
                List<Player> zhugeke = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in zhugeke)
                    p.Piles["#aocai"] = new List<int>();
            }
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move)
            {
                if ((base.Triggerable(move.From, room) && move.From_places.Contains(Place.PlaceHand)))
                    move.From.Piles["#aocai"] = new List<int>();

                if ((base.Triggerable(move.To, room) && move.To_place == Place.PlaceHand))
                    move.To.Piles["#aocai"] = new List<int>();
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class AocaiVS : ViewAsSkill
    {
        public AocaiVS() : base("aocai")
        {
            expand_pile = "#aocai";
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return false;
        }
        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
        {
            if (player.Phase != PlayerPhase.NotActive && !MatchBasic(respond) && !MatchRetrial(respond))
                return false;

            return true;
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return selected.Count == 0 && player.GetPile(expand_pile).Contains(to_select.Id)
                && Engine.MatchExpPattern(room, room.GetRoomState().GetCurrentCardUsePattern(player), player, to_select);
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (player.GetPile(expand_pile).Count == 0)
                return new WrappedCard(AocaiCard.ClassName) { Skill = Name, Mute = true };
            else if (cards.Count == 1)
                return cards[0];

            return null;
        }
    }

    public class AocaiCard : SkillCard
    {
        public static string ClassName = "AocaiCard";
        public AocaiCard() : base(ClassName)
        {
            target_fixed = true;
        }
        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            View(room, use.From, use.Card.SkillPosition);
            return null;
        }

        public override WrappedCard ValidateInResponse(Room room, Player player, WrappedCard card)
        {
            View(room, player, card.SkillPosition);
            return null;
        }

        private void View(Room room, Player player, string head)
        {
            int count = 2;
            if (player.IsKongcheng()) count = 4;
            List<int> guanxing = room.GetNCards(count, false);
            room.NotifySkillInvoked(player, "aocai");
            room.BroadcastSkillInvoke("aocai", player, head);
            LogMessage log = new LogMessage
            {
                Type = "$ViewDrawPile",
                From = player.Name,
                Card_str = string.Join("+", JsonUntity.IntList2StringList(guanxing))
            };
            room.SendLog(log, player);
            log.Type = "$ViewDrawPile2";
            log.Arg = guanxing.Count.ToString();
            log.Card_str = null;
            room.SendLog(log, new List<Player> { player });

            player.Piles["#aocai"] = guanxing;
            room.SetPromotSkill(player, "aocai", head, room.GetRoomState().GetCurrentCardUsePattern(), room.GetRoomState().GetCurrentCardUseReason());
        }
    }

    public class Duwu : TriggerSkill
    {
        public Duwu() : base("duwu")
        {
            events.Add(TriggerEvent.QuitDying);
            skill_type = SkillType.Attack;
            view_as_skill = new DuwuVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is DyingStruct dying && dying.Damage.From != null && !string.IsNullOrEmpty(dying.Damage.Reason) && dying.Damage.Reason == Name && dying.Damage.From.Alive
                && !dying.Damage.Transfer && !dying.Damage.Chain && player.Alive)
            {
                LogMessage log = new LogMessage
                {
                    Type = "#duwu-lose",
                    From = dying.Damage.From.Name
                };

                dying.Damage.From.SetFlags(Name);
                room.SendLog(log);
                room.LoseHp(dying.Damage.From);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class DuwuVS : ViewAsSkill
    {
        public DuwuVS() : base("duwu")
        {
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasFlag(Name);
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            return RoomLogic.CanDiscard(room, player, player, to_select.Id);
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            WrappedCard dw = new WrappedCard(DuwuCard.ClassName)
            {
                Skill = Name
            };
            dw.AddSubCards(cards);
            return dw;
        }
    }

    public class DuwuCard : SkillCard
    {
        public static string ClassName = "DuwuCard";
        public DuwuCard() : base(ClassName)
        {
            will_throw = true;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != null && RoomLogic.InMyAttackRange(room, Self, to_select, card)
                && to_select.Hp == card.SubCards.Count && to_select != Self;
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            return targets.Count == 1;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            room.Damage(new DamageStruct("duwu", card_use.From, card_use.To[0]));
        }
    }

    public class Hongde : TriggerSkill
    {
        public Hongde() : base("hongde")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardsMoveOneTime };
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardsMoveOneTimeStruct move)
            {
                if (move.To != null && base.Triggerable(move.To, room) && move.To_place == Place.PlaceHand && move.Card_ids.Count >= 2)
                    return new TriggerStruct(Name, move.To);

                if (move.From != null && (move.To != move.From || move.To_place == Place.PlaceTable || move.To_place == Place.PlaceSpecial) && base.Triggerable(move.From, room))
                {
                    int count = 0;
                    foreach (Place place in move.From_places)
                        if (place == Place.PlaceHand || place == Place.PlaceEquip)
                            count++;

                    if (count >= 2)
                        return new TriggerStruct(Name, move.From);
                }
            }

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(ask_who, room.GetOtherPlayers(ask_who), Name, "@hongde", true, true, info.SkillPosition);
            if (target != null)
            {
                ask_who.SetTag(Name, target.Name);
                room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.FindPlayer(ask_who.GetTag(Name).ToString());
            ask_who.RemoveTag(Name);
            room.DrawCards(target, new DrawCardStruct(1, ask_who, Name));
            return false;
        }
    }

    public class Dingpan : ZeroCardViewAsSkill
    {
        public Dingpan() : base("dingpan")
        {
        }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            int count = 0;
            foreach (Player p in room.GetAlivePlayers())
                if (p.GetRoleEnum() == PlayerRole.Rebel)
                    count++;

            return player.UsedTimes(DingpanCard.ClassName) < count;
        }

        public override WrappedCard ViewAs(Room room, Player player)
        {
            return new WrappedCard(DingpanCard.ClassName) { Skill = Name };
        }
    }

    public class DingpanCard : SkillCard
    {
        public static string ClassName = "DingpanCard";
        public DingpanCard() : base(ClassName)
        {
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select.GetEquips().Count > 0;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            Player target = card_use.To[0];

            room.DrawCards(target, new DrawCardStruct(1, player, "dingpan"));
            if (target.Alive)
            {
                List<string> choices = new List<string>(), prompt = new List<string> { string.Format("@dingpan:{0}", player.Name) };
                foreach (int id in target.GetEquips())
                {
                    if (!choices.Contains("discard") && RoomLogic.CanDiscard(room, player, target, id))
                        choices.Add("discard");

                    if (!choices.Contains("get") && RoomLogic.CanGetCard(room, player, target, id))
                        choices.Add("get");
                }

                if (choices.Count > 0)
                {
                    string choice = room.AskForChoice(target, "dingpan", string.Join("+", choices), prompt, player, card_use.Card.SkillPosition);
                    if (choice == "discard")
                    {
                        int id = room.AskForCardChosen(player, target, "e", "dingpan", false, HandlingMethod.MethodDiscard);
                        room.ThrowCard(id, target, target != player ? player : null);
                    }
                    else
                    {
                        List<int> ids = target.GetEquips();
                        if (ids.Count > 0)
                            room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_RECYCLE, target.Name, "dingpan", string.Empty));

                        if (target.Alive)
                            room.Damage(new DamageStruct("dingpan", player, target));
                    }
                }
            }
        }
    }

    public class Xingwu : TriggerSkill
    {
        public Xingwu() : base("xingwu")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
            view_as_skill = new XingwuVS();
        }
        

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Discard && base.Triggerable(player, room) && !player.IsKongcheng())
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<int> ids = room.AskForExchange(player, Name, 1, 0, "@xingwu", string.Empty, ".", info.SkillPosition);
            if (ids.Count > 0)
            {
                room.NotifySkillInvoked(player, Name);
                GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                room.AddToPile(player, Name, ids);
                return info;
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<WrappedCard.CardSuit> suits = new List<WrappedCard.CardSuit>();
            List<int> ids = player.GetPile(Name);

            if (ids.Count >= 3 || player.GetCardCount(false) >= 2)
                room.AskForUseCard(player, RespondType.Skill, "@@xingwu", "@xingwu-target", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);

            return false;
        }
    }

    public class XingwuVS : ViewAsSkill
    {
        public XingwuVS() : base("xingwu")
        {
            response_pattern = "@@xingwu";
            expand_pile = Name;
        }
        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            if (selected.Count == 0)
                return room.GetCardPlace(to_select.Id) == Place.PlaceHand && RoomLogic.CanDiscard(room, player, player, to_select.Id)
                    || player.GetPile(Name).Contains(to_select.Id);
            else if (selected.Count > 0)
            {
                return room.GetCardPlace(selected[0].Id) == room.GetCardPlace(to_select.Id)
                    && ((room.GetCardPlace(to_select.Id) == Place.PlaceHand && selected.Count < 2 && RoomLogic.CanDiscard(room, player, player, to_select.Id))
                    || (player.GetPile(Name).Contains(to_select.Id) && selected.Count < 3));
            }
            else
                return false;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
            {
                if ((room.GetCardPlace(cards[0].Id) == Place.PlaceHand && cards.Count == 2) || room.GetCardPlace(cards[0].Id) != Place.PlaceHand && cards.Count == 3)
                {
                    WrappedCard xw = new WrappedCard(XingwuCard.ClassName) { Skill = Name, Mute = true };
                    xw.AddSubCards(cards);
                    return xw;
                }
            }

            return null;
        }
    }

    public class XingwuCard : SkillCard
    {
        public static string ClassName = "XingwuCard";
        public XingwuCard() : base(ClassName)
        {
            will_throw = true;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && Self != to_select;
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player player = card_use.From;
            Player target = card_use.To[0];
            if (card_use.Card.SubCards.Count == 2) room.TurnOver(player);
            GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, "xingwu", card_use.Card.SkillPosition);
            room.BroadcastSkillInvoke("xingwu", "male", 1, gsk.General, gsk.SkinId);

            if (target.Alive && player.Alive)
            {
                List<int> all = new List<int>();
                foreach (int id in target.GetCards("e"))
                    if (RoomLogic.CanDiscard(room, player, target, id))
                        all.Add(id);

                if (all.Count > 0)
                    room.ThrowCard(ref all, target, player);
            }

            if (player.Alive && target.Alive)
                room.Damage(new DamageStruct(Name, player, target, target.IsMale() ? 2 : 1));
        }
    }

    public class XingwuClear : DetachEffectSkill
    {
        public XingwuClear() : base("xingwu", "xingwu") { }
    }

    public class Luoyan : ViewHasSkill
    {
        public Luoyan() : base("luoyan")
        {
            viewhas_skills = new List<string> { "liuli", "tianxiang_jx" };
        }
        public override bool ViewHas(Room room, Player player, string skill_name)
        {
            if (player.Alive && RoomLogic.PlayerHasSkill(room, player, Name) && player.GetPile("xingwu").Count > 0)
                return true;
            return false;
        }
    }

    public class Meibu : TriggerSkill
    {
        public Meibu() : base("meibu")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.CardsMoveOneTime };
            skill_type = SkillType.Wizzard;
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.Play)
            {
                foreach (Player p in RoomLogic.FindPlayersBySkillName(room, Name))
                {
                    if (p != player && RoomLogic.InMyAttackRange(room, player, p))
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.From != null && move.To_place == Place.DiscardPile
                && move.Reason.SkillName == "zhixi" && move.Reason.Reason == MoveReason.S_REASON_THROW)
            {
                if (room.GetCardPlace(move.Card_ids[0]) == Place.DiscardPile)
                {
                    foreach (Player p in room.GetAlivePlayers())
                    {
                        if (p.HasFlag("MeibuFrom") && (int)room.GetCard(move.Card_ids[0]).Suit == p.GetMark(Name))
                            triggers.Add(new TriggerStruct(Name, p, p));
                    }
                }
            }

            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                List<int> ids = room.AskForExchange(ask_who, Name, 1, 0, "@meibu:" + player.Name, string.Empty, "..!", info.SkillPosition);
                if (ids.Count == 1)
                {
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    ask_who.SetMark(Name, (int)room.GetCard(ids[0]).Suit);
                    ask_who.SetFlags("MeibuFrom");
                    room.ThrowCard(ref ids, ask_who, null, Name);
                    return info;
                }
            }
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime)
                return info;

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive)
                room.HandleAcquireDetachSkills(player, "zhixi", true);
            else if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move)
            {
                int id = move.Card_ids[0];
                room.ObtainCard(ask_who, room.GetCard(id), new CardMoveReason(MoveReason.S_REASON_RECYCLE, ask_who.Name, Name, string.Empty));
            }

            return false;
        }
    }

    public class Mumu : PhaseChangeSkill
    {
        public Mumu() : base("mumu")
        {
        }

        public override bool Triggerable(Player target, Room room)
        {
            return base.Triggerable(target, room) && target.Phase == PlayerPhase.Play;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            if (player.HasEquip() && RoomLogic.CanGetCard(room, player, player, "e")) targets.Add(player);
            foreach (Player p in room.GetOtherPlayers(player))
                if (p.HasEquip() && (RoomLogic.CanDiscard(room, player, p, "e") || RoomLogic.CanGetCard(room, player, p, "e")))
                    targets.Add(p);
            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@mumu", true, true, info.SkillPosition);
                if (target != null)
                {
                    player.SetTag(Name, target.Name);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            Player target = room.FindPlayer(player.GetTag(Name).ToString());
            List<int> ids = new List<int>();
            if (target == player)
            {
                foreach (int id in target.GetEquips())
                    if (RoomLogic.CanGetCard(room, player, player, id)) ids.Add(id);

                List<int> get = room.AskForExchange(player, Name, 1, 1, "@mumu-get", string.Empty, string.Join("#", JsonUntity.IntList2StringList(ids)), info.SkillPosition);
                room.ObtainCard(player, ref get, new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, Name, string.Empty));
                player.SetFlags("mumu_decrease");
            }
            else
            {
                foreach (int id in target.GetEquips())
                    if (!RoomLogic.CanGetCard(room, player, target, id) && !RoomLogic.CanDiscard(room, player, target, id)) ids.Add(id);

                int card_id = room.AskForCardChosen(player, target, "e", Name, false, HandlingMethod.MethodNone, ids);
                List<string> choices = new List<string>();
                if (RoomLogic.CanGetCard(room, player, target, card_id) && Engine.GetFunctionCard(room.GetCard(card_id).Name) is Armor) choices.Add("get");
                if (RoomLogic.CanDiscard(room, player, target, card_id)) choices.Add("discard");
                if (room.AskForChoice(player, Name, string.Join("+", choices), null, card_id, info.SkillPosition) == "get")
                {
                    room.ObtainCard(player, card_id);
                    player.SetFlags("mumu_decrease");
                }
                else
                {
                    room.ThrowCard(card_id, target, player);
                    player.SetFlags("mumu_add");
                }
            }

            return false;
        }
    }

    public class MumuTar : TargetModSkill
    {
        public MumuTar() : base("#mumu", false)
        {
        }

        public override int GetResidueNum(Room room, Player from, WrappedCard card)
        {
            if (from.HasFlag("mumu_decrease")) return -1;
            else if (from.HasFlag("mumu_add")) return 1;
            else return 0;
        }
    }

    public class Zhixi : TriggerSkill
    {
        public Zhixi() : base("zhixi")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.EventPhaseChanging };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play)
                room.HandleAcquireDetachSkills(player, "-zhixi", true);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && base.Triggerable(player, room) && !player.IsKongcheng())
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash || fcard is TrickCard)
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.AskForDiscard(player, Name, 1, 1, false, false, "@zhixi", false, info.SkillPosition);
            return false;
        }
    }

    public class Lianpian : TriggerSkill
    {
        public Lianpian() : base("lianpian")
        {
            events = new List<TriggerEvent> { TriggerEvent.TargetChoosing, TriggerEvent.EventPhaseChanging };
            skill_type = SkillType.Replenish;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play && player.ContainsTag(Name))
            {
                player.RemoveTag(Name);
                player.SetMark(Name, 0);
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.TargetChoosing && data is CardUseStruct use && base.Triggerable(player, room) && player.Phase == PlayerPhase.Play
                && player.ContainsTag(Name) && player.GetTag(Name) is List<string> names && player.GetMark(Name) < 3)
            {
                foreach (Player p in use.To)
                    if (names.Contains(p.Name))
                        return new TriggerStruct(Name, player);
            }

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
            player.AddMark(Name);
            List<int> ids = room.DrawCards(player, 1, Name);
            if (player.Alive && ids.Count > 0)
            {
                if (data is CardUseStruct use && player.ContainsTag(Name) && player.GetTag(Name) is List<string> names)
                {
                    List<Player> targets = new List<Player>();
                    foreach (Player p in use.To)
                        if (p != player && names.Contains(p.Name) && p.Alive)
                            targets.Add(p);

                    if (targets.Count > 0)
                    {
                        Player target = room.AskForPlayerChosen(player, targets, Name, "@lianpian:::" + room.GetCard(ids[0]).Name, true, false, info.SkillPosition);
                        if (target != null)
                        {
                            room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                            room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty), false);
                        }
                    }
                }
            }

            return false;
        }
    }

    public class LianpianRecord : TriggerSkill
    {
        public LianpianRecord() : base("#lianpian")
        {
            events.Add(TriggerEvent.TargetChoosing);
        }
        public override int Priority => 2;

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (data is CardUseStruct use && player.Phase == PlayerPhase.Play)
            {
                if (use.To.Count > 0)
                {
                    List<string> names = new List<string>();
                    foreach (Player p in use.To)
                        names.Add(p.Name);

                    player.SetTag("lianpian", names);
                }
                else if (player.ContainsTag("lianpian"))
                    player.RemoveTag("lianpian");
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class Yinbing : TriggerSkill
    {
        public Yinbing() : base("yinbing")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart };
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                List<int> ids = room.AskForExchange(player, Name, 400, 0, "@yinbing", string.Empty, "TrickCard,EquipCard", info.SkillPosition);
                if (ids.Count > 0)
                {
                    room.NotifySkillInvoked(player, Name);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.AddToPile(player, Name, ids);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            return false;
        }
    }

    public class YinbingDamage : TriggerSkill
    {
        public YinbingDamage() : base("#yinbing")
        {
            events.Add(TriggerEvent.Damaged);
            frequency = Frequency.Compulsory;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && data is DamageStruct damage && player.GetPile("yinbing").Count > 0 && damage.Card != null
                && (damage.Card.Name.Contains(Slash.ClassName) || damage.Card.Name == Duel.ClassName))
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            List<int> maps = player.GetPile("yinbing");
            if (maps.Count > 0)
            {
                int card_id;
                if (maps.Count == 1)
                    card_id = maps[0];
                else
                {
                    room.FillAG("yinbing", maps, player);
                    card_id = room.AskForAG(player, maps, false, "yinbing");
                    room.ClearAG(player);
                }

                LogMessage log = new LogMessage
                {
                    Type = "$RemoveFromPile",
                    From = player.Name,
                    Arg = "yinbing",
                    Card_str = card_id.ToString()
                };
                room.SendLog(log);

                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_REMOVE_FROM_PILE, null, "yinbing", null);
                List<int> ids = new List<int> { card_id };
                room.ThrowCard(ref ids, reason, null);
                room.ClearAG(player);
            }
            return false;
        }
    }

    public class Juedi : PhaseChangeSkill
    {
        public Juedi() : base("juedi")
        {
            frequency = Frequency.Compulsory;
        }

        public override bool Triggerable(Player target, Room room)
        {
            return base.Triggerable(target, room) && target.Phase == PlayerPhase.Start && target.GetPile("yinbing").Count > 0;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (p.Hp <= player.Hp) targets.Add(p);

            room.RemoveTag(Name);
            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@juedi", true, true, info.SkillPosition);
                if (target != null) room.SetTag(Name, target);
            }
            return info;
        }

        public override bool OnPhaseChange(Room room, Player player, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            List<int> ids = player.GetPile("yinbing");
            if (room.ContainsTag(Name) && room.GetTag(Name) is Player target)
            {
                room.RemoveTag(Name);
                int count = ids.Count;
                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_GOTCARD, target.Name, Name, string.Empty);
                room.ObtainCard(target, ref ids, reason);
                if (target.Alive && target.IsWounded())
                {
                    RecoverStruct recover = new RecoverStruct
                    {
                        Recover = 1,
                        Who = player
                    };
                    room.Recover(target, recover, true);
                }
                if (target.Alive) room.DrawCards(target, new DrawCardStruct(count, target, Name));
            }
            else
            {
                CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_REMOVE_FROM_PILE, null, Name, null);
                room.ThrowCard(ref ids, reason, null);
                if (player.Alive && player.HandcardNum < player.MaxHp)
                    room.DrawCards(player, player.MaxHp - player.HandcardNum, Name);
            }

            return false;
        }
    }

    public class CanshiSH : DrawCardsSkill
    {
        public CanshiSH() : base("canshi_sh")
        {
            frequency = Frequency.Frequent;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Draw && (int)data >= 0)
            {
                int count = 0;
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.IsWounded() || (RoomLogic.PlayerHasSkill(room, player, "guiming") && p.Kingdom == "wu" && p != player))
                        count++;
                }

                if (count > 0)
                    return new TriggerStruct(Name, player);
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player lidian, ref object data, Player ask_who, TriggerStruct info)
        {
            int count = 0;
            foreach (Player p in room.GetAlivePlayers())
            {
                if (p.IsWounded() || (RoomLogic.PlayerHasSkill(room, lidian, "guiming") && p.Kingdom == "wu" && p != lidian))
                    count++;
            }
            if (room.AskForSkillInvoke(lidian, Name, "@canshi_sh:::" + count.ToString(), info.SkillPosition))
            {
                room.BroadcastSkillInvoke(Name, lidian, info.SkillPosition);
                return info;
            }

            return new TriggerStruct();
        }
        public override int GetDrawNum(Room room, Player lidian, int n)
        {
            lidian.SetFlags(Name);
            int count = 0;
            foreach (Player p in room.GetAlivePlayers())
            {
                if (p.IsWounded() || (RoomLogic.PlayerHasSkill(room, lidian, "guiming") && p.Kingdom == "wu" && p != lidian))
                    count++;
            }
            return n + count;
        }
    }

    public class CanshiDiscard : TriggerSkill
    {
        public CanshiDiscard() : base("#canshi-discard")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardUsed, TriggerEvent.CardResponded };
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardUsed && data is CardUseStruct use && player.HasFlag("canshi_sh"))
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash || (fcard.TypeID == CardType.TypeTrick && !(fcard is DelayedTrick)))
                    return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.CardResponded && data is CardResponseStruct resp && resp.Use && player.HasFlag("canshi_sh"))
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, "canshi_sh");
            room.AskForDiscard(player, "canshi_sh", 1, 1, false, true, "@canshi-discard", false, info.SkillPosition);
            return false;
        }
    }

    public class Chouhai : TriggerSkill
    {
        public Chouhai() : base("chouhai")
        {
            events = new List<TriggerEvent> { TriggerEvent.DamageInflicted };
            frequency = Frequency.Compulsory;
            skill_type = SkillType.Masochism;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is DamageStruct damage && base.Triggerable(player, room) && player.IsKongcheng() && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName))
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            DamageStruct damage = (DamageStruct)data;
            LogMessage log = new LogMessage
            {
                Type = "#AddDamaged",
                From = player.Name,
                Arg = Name,
                Arg2 = (++damage.Damage).ToString()
            };
            room.SendLog(log);

            data = damage;

            return false;
        }
    }

    public class Guiming : TriggerSkill
    {
        public Guiming() : base("guiming")
        {
            lord_skill = true;
            frequency = Frequency.Compulsory;
            events.Add(TriggerEvent.EventPhaseStart);
        }

        public override bool Triggerable(Player target, Room room)
        {
            if (base.Triggerable(target, room) && target.Phase == PlayerPhase.RoundStart)
            {
                foreach (Player p in room.GetOtherPlayers(target))
                    if (p.Kingdom == "wu") return true;
            }
            return false;
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(player, Name);
            room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
            foreach (Player p in room.GetOtherPlayers(player))
                if (p.Kingdom == "wu")
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, p.Name);

            return false;
        }
    }

    public class Xiashu : TriggerSkill
    {
        public Xiashu() : base("xiashu")
        {
            events.Add(TriggerEvent.EventPhaseStart);
            skill_type = SkillType.Wizzard;
        }

        public override bool Triggerable(Player target, Room room)
        {
            return base.Triggerable(target, room) && target.Phase == PlayerPhase.Play && !target.IsKongcheng();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@xiashu-target", true, true, info.SkillPosition);
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
            List<int> ids = player.GetCards("h");
            target.SetFlags(Name);
            room.ObtainCard(target, ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, player.Name, target.Name, Name, string.Empty), false);
            target.SetFlags("-xiashu");
            if (target.Alive && !target.IsKongcheng() && player.Alive)
            {
                List<int> showed = target.GetCards("h");
                if (showed.Count > 1) showed = room.AskForExchange(target, Name, showed.Count, 1, "@xiashu-shown:" + player.Name, string.Empty, ".", string.Empty);
                room.ShowCards(target, showed, Name);
                /*
                room.SetTag(Name, showed);
                room.FillAG(Name, showed, player, null, null);
                string choice = room.AskForChoice(player, Name, "shown+hide", null, target);
                room.ClearAG(player);
                room.RemoveTag(Name);
                if (choice == "shown")
                {
                    room.ObtainCard(player, ref showed, new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, target.Name, string.Empty));
                }
                else
                {
                    List<int> hands = target.GetCards("h");
                    hands.RemoveAll(t => showed.Contains(t));
                    if (hands.Count > 0)
                        room.ObtainCard(player, ref hands, new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, target.Name, string.Empty), false);
                }
                */

                AskForMoveCardsStruct move = room.AskForMoveCards(player, showed, new List<int>(), false, Name, 0, 0, true, false, new List<int>(), info.SkillPosition);
                room.RemoveTag(Name);
                if (move.Success)
                {
                    room.ObtainCard(player, ref showed, new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, target.Name, string.Empty));
                }
                else
                {
                    List<int> hands = target.GetCards("h");
                    hands.RemoveAll(t => showed.Contains(t));
                    if (hands.Count > 0)
                        room.ObtainCard(player, ref hands, new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, target.Name, string.Empty), false);
                }
            }

            return false;
        }
    }

    public class Kuanshi : TriggerSkill
    {
        public Kuanshi() : base("kuanshi")
        {
            events = new List<TriggerEvent> { TriggerEvent.TurnStart, TriggerEvent.EventPhaseStart, TriggerEvent.Death };
            skill_type = SkillType.Defense;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if ((triggerEvent == TriggerEvent.TurnStart || triggerEvent == TriggerEvent.Death) && player.GetMark(Name) > 0)
            {
                player.SetMark(Name, 0);
                foreach (Player p in room.GetAlivePlayers())
                    if (p.ContainsTag(Name) && p.GetTag(Name) is string name && name == player.Name)
                        p.RemoveTag(Name);
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish)
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetAlivePlayers())
                if (!p.ContainsTag(Name)) targets.Add(p);

            if (targets.Count > 0)
            {
                Player target = room.AskForPlayerChosen(player, targets, Name, "@kuanshi", true, false, info.SkillPosition);
                if (target != null)
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name, new List<Player> { player });
                    room.NotifySkillInvoked(player, Name);
                    room.SetTag(Name, target);
                    GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, player, Name, info.SkillPosition);
                    room.BroadcastSkillInvoke(Name, "male", 1, gsk.General, gsk.SkinId);
                    return info;
                }
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = (Player)room.GetTag(Name);
            room.RemoveTag(Name);
            player.AddMark(Name);
            target.SetTag(Name, player.Name);
            room.SetPlayerStringMark(target, Name, string.Empty);

            return false;
        }
    }

    public class KuanshiIm : TriggerSkill
    {
        public KuanshiIm() : base("#kuanshi")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damaged, TriggerEvent.EventPhaseChanging };
            frequency = Frequency.Compulsory;
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.GetMark("kuanshi_damage") > 0)
                player.SetMark("kuanshi_damage", 0);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damaged && data is DamageStruct damage && player.Alive && player.ContainsTag("kuanshi") && player.GetTag("kuanshi") is string name)
            {
                Player target = room.FindPlayer(name);
                if (target != null) return new TriggerStruct(Name, target);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is DamageStruct damage)
            {
                player.AddMark("kuanshi_damage", damage.Damage);
                if (player.GetMark("kuanshi_damage") > 1)
                {
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                    player.RemoveTag("kuanshi");
                    room.RemovePlayerStringMark(player, "kuanshi");
                    room.SendCompulsoryTriggerLog(ask_who, "kuanshi");
                    if (RoomLogic.PlayerHasSkill(room, ask_who, Name))
                    {
                        GeneralSkin gsk = RoomLogic.GetGeneralSkin(room, ask_who, "kuanshi", info.SkillPosition);
                        room.BroadcastSkillInvoke("kuanshi", "male", 2, gsk.General, gsk.SkinId);
                    }

                    RecoverStruct recover = new RecoverStruct
                    {
                        Recover = 1,
                        Who = ask_who
                    };
                    room.Recover(player, recover, true);
                }
            }

            return false;
        }
    }

    public class Qizhou : TriggerSkill
    {
        public Qizhou() : base("qizhou") { events.Add(TriggerEvent.GameStart); frequency = Frequency.Compulsory; }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (base.Triggerable(player, room))
                room.AddPlayerMark(player, "@fenwei");
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class QizhouVH : ViewHasSkill
    {
        public QizhouVH() : base("#qizhou")
        {
            viewhas_skills = new List<string> { "fenwei", "mashu_heqi", "duanbing", "yingzi_heqi" };
        }
        public override bool ViewHas(Room room, Player player, string skill_name)
        {
            if (player.Alive && RoomLogic.PlayerHasSkill(room, player, "qizhou") && player.HasEquip())
            {
                List<WrappedCard.CardSuit> suits = new List<WrappedCard.CardSuit>();
                foreach (int id in player.GetEquips())
                {
                    WrappedCard.CardSuit suit = room.GetCard(id).Suit;
                    if (!suits.Contains(suit)) suits.Add(suit);
                }

                if (skill_name == "mashu_heqi" && suits.Count >= 1) return true;
                if (skill_name == "yingzi_heqi" && suits.Count >= 2) return true;
                if (skill_name == "duanbing" && suits.Count >= 3) return true;
                if (skill_name == "fenwei" && suits.Count >= 4) return true;
            }
            return false;
        }
    }

    public class Shanxi : TriggerSkill
    {
        public Shanxi() : base("shanxi")
        {
            events = new List<TriggerEvent> {  TriggerEvent.CardsMoveOneTime };
            skill_type = SkillType.Attack;
            view_as_skill = new ShanxiVS();
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.CardsMoveOneTime && data is CardsMoveOneTimeStruct move && move.To_place == Place.PlaceTable
                && move.From != null && move.Reason.Reason == MoveReason.S_REASON_DISMANTLE && move.Reason.SkillName == Name
                && move.From.Name == move.Reason.TargetId && move.Card_ids.Count == 1)
            {
                bool equip = room.GetCard(move.Card_ids[0]).Name == Jink.ClassName;
                string tag_name = string.Format("{0}_{1}", Name, move.Reason.TargetId);
                Player pangde = room.FindPlayer(move.Reason.PlayerId, true);
                pangde.SetTag(tag_name, equip);
            }
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            return new List<TriggerStruct>();
        }
    }

    public class ShanxiVS : OneCardViewAsSkill
    {
        public ShanxiVS() : base("shanxi") { filter_pattern = "BasicCard|red!"; }

        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(ShanxiCard.ClassName);
        }

        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard sx = new WrappedCard(ShanxiCard.ClassName) { Skill = Name };
            sx.AddSubCard(card);
            return sx;
        }
    }

    public class ShanxiCard : SkillCard
    {
        public static string ClassName = "ShanxiCard";
        public ShanxiCard() : base(ClassName) { }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self && RoomLogic.InMyAttackRange(room, Self, to_select, card)
                && !to_select.IsNude() && RoomLogic.CanDiscard(room, Self, to_select, "he");
        }

        public override void Use(Room room, CardUseStruct card_use)
        {
            Player pangde = card_use.From, target = card_use.To[0];
            int to_throw = room.AskForCardChosen(pangde, target, "he", "shanxi", false, HandlingMethod.MethodDiscard);
            List<int> ids = new List<int> { to_throw };
            string tag_name = string.Format("{0}_{1}", "shanxi", target.Name);
            pangde.RemoveTag(tag_name);
            CardMoveReason reason = new CardMoveReason(MoveReason.S_REASON_DISMANTLE, pangde.Name, target.Name, "shanxi", string.Empty)
            {
                General = RoomLogic.GetGeneralSkin(room, pangde, "shanxi", card_use.Card.SkillPosition)
            };
            room.ThrowCard(ref ids, reason, target, pangde);
            if (ids.Count > 0)
            {
                Debug.Assert(pangde.ContainsTag(tag_name), "shanxi tag error!");
                if ((bool)pangde.GetTag(tag_name))
                    room.ShowAllCards(target, pangde, "shanxi", card_use.Card.SkillPosition);
                else
                    room.ShowAllCards(pangde, target, "shanxi", card_use.Card.SkillPosition);
            }
        }
    }

    public class Bizheng : TriggerSkill
    {
        public Bizheng() : base("bizheng")
        {
            events.Add(TriggerEvent.EventPhaseEnd);
            skill_type = SkillType.Replenish;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Draw)
                return new TriggerStruct(Name, player);

            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            Player target = room.AskForPlayerChosen(player, room.GetOtherPlayers(player), Name, "@bizheng", true, true, info.SkillPosition);
            if (target != null)
            {
                room.SetTag(Name, target);
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
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
                room.DrawCards(target, new DrawCardStruct(2, player, Name));

                if (player.Alive && player.HandcardNum > player.MaxHp)
                    room.AskForDiscard(player, Name, 2, 2, false, true, "@bizheng-discard");
                if (target.Alive && target.HandcardNum > target.MaxHp)
                    room.AskForDiscard(target, Name, 2, 2, false, true, "@bizheng-discard");
            }

            return false;
        }
    }

    public class Yidian : TriggerSkill
    {
        public Yidian() : base("yidian")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardTargetAnnounced };
            skill_type = SkillType.Wizzard;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct _use && base.Triggerable(player, room) && _use.Card.ExtraTarget)
            {
                FunctionCard fcard = Engine.GetFunctionCard(_use.Card.Name);
                if (fcard is BasicCard || (fcard.IsNDTrick() && _use.Card.Name != Collateral.ClassName && !_use.Card.Name.Contains(Nullification.ClassName)))
                {
                    bool same = false;
                    string card_name = _use.Card.Name;
                    if (card_name.Contains("Slash")) card_name = "Slash";
                    foreach (int id in room.DiscardPile)
                    {
                        if (room.GetCard(id).Name.Contains(card_name))
                        {
                            same = true;
                            break;
                        }
                    }

                    if (!same)
                    {
                        foreach (Player p in room.GetOtherPlayers(player))
                            if (!_use.To.Contains(p))
                                return new TriggerStruct(Name, player);
                    }
                }
            }
            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            CardUseStruct use = (CardUseStruct)data;
            if (triggerEvent == TriggerEvent.CardTargetAnnounced)
            {
                List<Player> targets = new List<Player>();
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if ((fcard is Peach && !p.IsWounded()) || (fcard is IronChain && !p.Chained && !RoomLogic.CanBeChainedBy(room, player, p))
                        || (fcard is FireAttack && p.IsKongcheng()) || (fcard is Snatch && !RoomLogic.CanGetCard(room, player, p, "hej"))
                        || (fcard is Dismantlement && !RoomLogic.CanDiscard(room, player, p, "hej"))) continue;

                    if (!use.To.Contains(p) && RoomLogic.IsProhibited(room, player, p, use.Card) == null)
                        targets.Add(p);
                }

                room.SetTag("extra_target_skill", data);                   //for AI
                Player target = room.AskForPlayerChosen(player, targets, Name, "@yidian:::" + use.Card.Name, true, true, info.SkillPosition);
                room.RemoveTag("extra_target_skill");
                if (target != null)
                {
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                    LogMessage log = new LogMessage
                    {
                        Type = "$extra_target",
                        From = player.Name,
                        To = new List<string> { target.Name},
                        Card_str = RoomLogic.CardToString(room, use.Card),
                        Arg = Name
                    };
                    room.SendLog(log);

                    room.SetTag("extra_targets", target);
                    return info;
                }
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            CardUseStruct use = (CardUseStruct)data;
            Player target = (Player)room.GetTag("extra_targets");
            room.RemoveTag("extra_targets");

            use.To.Add(target);
            room.SortByActionOrder(ref use);
            data = use;

            return false;
        }
    }

    public class Weiyi : TriggerSkill
    {
        public Weiyi() : base("weiyi")
        {
            skill_type = SkillType.Wizzard;
            events.Add(TriggerEvent.Damaged);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            List<TriggerStruct> triggers = new List<TriggerStruct>();
            if (player.Alive)
            {
                List<Player> ps = RoomLogic.FindPlayersBySkillName(room, Name);
                foreach (Player p in ps)
                {
                    if (p.GetMark(string.Format("{0}_{1}", Name, player.Name)) == 0 && (player.Hp >= p.Hp || (player.Hp <= p.Hp && player.IsWounded())))
                        triggers.Add(new TriggerStruct(Name, p));
                }
            }
            return triggers;
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            player.SetFlags(Name);
            bool invoke = room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition);
            player.SetFlags("-weiyi");
            if (invoke)
            {
                room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, ask_who.Name, player.Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                return info;
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            ask_who.SetMark(string.Format("{0}_{1}", Name, player.Name), 1);
            List<string> choices = new List<string>();
            if (player.Hp >= ask_who.Hp) choices.Add("losehp");
            if (player.Hp <= ask_who.Hp && player.IsWounded()) choices.Add("recover");

            player.SetFlags(Name);
            string choice = room.AskForChoice(ask_who, Name, string.Join("+", choices), new List<string> { "@to-player:" + player.Name }, player, info.SkillPosition);
            player.SetFlags("-weiyi");

            if (choice == "losehp")
                room.LoseHp(player);
            else
                room.Recover(player, 1);

            return false;
        }
    }

    public class JinzhiVS : ViewAsSkill
    {
        public JinzhiVS() : base("jinzhi")
        {
        }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player)
        {
            int count = player.GetMark(Name) + 1;
            if (selected.Count < count && RoomLogic.CanDiscard(room, player, player, to_select.Id))
            {
                if (selected.Count > 0 && WrappedCard.IsRed(to_select.Suit) != WrappedCard.IsRed(selected[0].Suit)) return false;
                return true;
            }
            return false;
        }

        public override bool IsEnabledAtPlay(Room room, Player player) => !player.IsNude();

        public override bool IsEnabledAtResponse(Room room, Player player, RespondType respond, string pattern)
        {
            bool invoke = false;
            if (!player.IsNude() && MatchBasic(respond))
            {
                foreach (WrappedCard card in GetGuhuo(room, player))
                {
                    if (Engine.MatchExpPattern(room, pattern, player, card))
                    {
                        invoke = true;
                        break;
                    }
                }
            }
            return invoke;
        }

        public override List<WrappedCard> GetGuhuoCards(Room room, List<WrappedCard> cards, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            int count = player.GetMark(Name) + 1;
            if (cards.Count == count)
            {
                foreach (WrappedCard card in GetGuhuo(room, player))
                {
                    card.AddSubCards(cards);
                    result.Add(card);
                }
            }

            return result;
        }

        private List<WrappedCard> GetGuhuo(Room room, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            List<string> guhuo = GetGuhuoCards(room, "b");

            foreach (string card_name in guhuo)
            {
                WrappedCard wrapped = new WrappedCard(card_name);
                result.Add(wrapped);
            }

            return result;
        }

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count == 1 && cards[0].IsVirtualCard())
            {
                string pattern = room.GetRoomState().GetCurrentCardUsePattern();
                pattern = Engine.GetPattern(pattern).GetPatternString();
                if (room.GetRoomState().GetCurrentCardUseReason() == CardUseReason.CARD_USE_REASON_PLAY || Engine.MatchExpPattern(room, pattern, player, cards[0]))
                {
                    WrappedCard hm = new WrappedCard(JinzhiCard.ClassName)
                    {
                        UserString = cards[0].Name
                    };
                    hm.AddSubCard(cards[0]);
                    return hm;
                }
            }

            return null;
        }
    }

    public class Jinzhi : TriggerSkill
    {
        public Jinzhi() : base("jinzhi")
        {
            skill_type = SkillType.Wizzard;
            view_as_skill = new JinzhiVS();
            events.Add(TriggerEvent.RoundStart);
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            foreach (Player p in room.GetAlivePlayers())
                if (p.GetMark(Name) > 0) p.SetMark(Name, 0);
        }

        public override List<TriggerStruct> Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data) => new List<TriggerStruct>();
    }

    public class JinzhiCard : SkillCard
    {
        public static string ClassName = "JinzhiCard";
        public JinzhiCard() : base(ClassName)
        {
            will_throw = true;
            handling_method = HandlingMethod.MethodDiscard;
        }

        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            WrappedCard wrapped = new WrappedCard(card.UserString);
            FunctionCard fcard = Engine.GetFunctionCard(card.UserString);
            return fcard.TargetFilter(room, targets, to_select, Self, wrapped);
        }

        public override bool TargetsFeasible(Room room, List<Player> targets, Player Self, WrappedCard card)
        {
            WrappedCard wrapped = new WrappedCard(card.UserString);
            FunctionCard fcard = Engine.GetFunctionCard(card.UserString);
            return fcard.TargetsFeasible(room, targets, Self, wrapped);
        }

        public override WrappedCard Validate(Room room, CardUseStruct use)
        {
            Player player = use.From;
            player.AddMark("jinzhi");
            room.BroadcastSkillInvoke("jinzhi", player, use.Card.SkillPosition);
            room.NotifySkillInvoked(player, "jinzhi");
            List<int> ids = new List<int>(use.Card.SubCards);
            room.ThrowCard(ref ids, player, null, "jinzhi");
            room.DrawCards(player, 1, "jinzhi");

            WrappedCard wrapped = new WrappedCard(use.Card.UserString) { Skill = "_jinzhi" };
            return wrapped;
        }

        public override WrappedCard ValidateInResponse(Room room, Player player, WrappedCard card)
        {
            player.AddMark("jinzhi");
            room.BroadcastSkillInvoke("jinzhi", player, card.SkillPosition);
            room.NotifySkillInvoked(player, "jinzhi");
            List<int> ids = new List<int>(card.SubCards);
            room.ThrowCard(ref ids, player, null, "jinzhi");

            room.DrawCards(player, 1, "jinzhi");

            WrappedCard wrapped = new WrappedCard(card.UserString) { Skill = "_jinzhi" };
            return wrapped;
        }
    }

    public class DuanbingJX : TriggerSkill
    {
        public DuanbingJX() : base("duanbing_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.CardTargetAnnounced, TriggerEvent.TargetChosen };
            skill_type = SkillType.Attack;
            frequency = Frequency.Compulsory;
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && base.Triggerable(player, room) && data is CardUseStruct use)
            {
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                if (fcard is Slash)
                {
                    List<Player> selected = new List<Player>(use.To);
                    foreach (Player p in room.GetOtherPlayers(player))
                        if (!use.To.Contains(p) && RoomLogic.DistanceTo(room, player, p, use.Card) == 1 && fcard.ExtratargetFilter(room, selected, p, player, use.Card))
                            return new TriggerStruct(Name, player);
                }
            }
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct _use && _use.Card != null && base.Triggerable(player, room))
            {
                FunctionCard fcard = Engine.GetFunctionCard(_use.Card.Name);
                if (fcard is Slash)
                {
                    List<Player> targets = new List<Player>();
                    foreach (Player p in _use.To)
                    {
                        if (RoomLogic.DistanceTo(room, player, p) == 1)
                            targets.Add(p);
                    }
                    if (targets.Count > 0)
                        return new TriggerStruct(Name, player, targets);
                }
            }

            return new TriggerStruct();
        }
        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                List<Player> targets = new List<Player>();
                List<Player> selected = new List<Player>(use.To);
                FunctionCard fcard = Engine.GetFunctionCard(use.Card.Name);
                foreach (Player p in room.GetOtherPlayers(player))
                    if (!use.To.Contains(p) && RoomLogic.DistanceTo(room, player, p, use.Card) == 1 && fcard.ExtratargetFilter(room, selected, p, player, use.Card))
                        targets.Add(p);

                if (targets.Count > 0)
                {
                    room.SetTag("extra_target_skill", data);                   //for AI
                    Player target = room.AskForPlayerChosen(player, targets, Name, string.Format("@duanbing-target:::{0}", use.Card.Name), true, false, info.SkillPosition);
                    room.RemoveTag("extra_target_skill");
                    if (target != null)
                    {
                        room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, target.Name);
                        room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                        room.NotifySkillInvoked(player, Name);
                        LogMessage log = new LogMessage
                        {
                            Type = "$extra_target",
                            From = player.Name,
                            To = new List<string> { target.Name },
                            Card_str = RoomLogic.CardToString(room, use.Card),
                            Arg = Name
                        };
                        room.SendLog(log);

                        player.SetTag("extra_targets", target.Name);
                        return info;
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.TargetChosen)
            {
                room.SetTag("WushuangData", data); // for AI
                room.SetTag("WushuangTarget", player); // for AI
                bool invoke = RoomLogic.PlayerHasShownSkill(room, ask_who, Name) || room.AskForSkillInvoke(ask_who, Name, player, info.SkillPosition);
                room.RemoveTag("WushuangData");
                room.RemoveTag("WushuangTarget");
                if (invoke)
                {
                    room.BroadcastSkillInvoke(Name, ask_who, info.SkillPosition);
                    return info;
                }
            }

            return new TriggerStruct();
        }
        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced)
            {
                Player target = room.FindPlayer((string)player.GetTag("extra_targets"));
                player.RemoveTag("extra_targets");

                if (target != null && data is CardUseStruct use)
                {
                    use.To.Add(target);
                    room.SortByActionOrder(ref use);
                    data = use;
                }
            }
            else
            {
                room.SendCompulsoryTriggerLog(ask_who, Name);
                CardUseStruct use = (CardUseStruct)data;
                if (triggerEvent != TriggerEvent.TargetChosen)
                    return false;

                int index = 0;
                for (int i = 0; i < use.EffectCount.Count; i++)
                {
                    CardBasicEffect effect = use.EffectCount[i];
                    if (effect.To == player)
                    {
                        index++;
                        if (index == info.Times)
                        {
                            effect.Effect2 = 2;
                            break;
                        }
                    }
                }

                data = use;
            }
            return false;
        }
    }


    public class FenxunJX : ZeroCardViewAsSkill
    {
        public FenxunJX() : base("fenxun_jx")
        {
            skill_type = SkillType.Attack;
        }
        public override bool IsEnabledAtPlay(Room room, Player player)
        {
            return !player.HasUsed(FenxunJXCard.ClassName);
        }
        public override WrappedCard ViewAs(Room room, Player player)
        {
            WrappedCard first = new WrappedCard(FenxunJXCard.ClassName)
            {
                Skill = Name,
                ShowSkill = Name
            };
            return first;
        }
    }

    public class FenxunJXEffect : TriggerSkill
    {
        public FenxunJXEffect() : base("#fenxun_jx")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.DamageDone, TriggerEvent.EventPhaseChanging };
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.DamageDone && data is DamageStruct damage && damage.From != null && damage.From.HasFlag("FenxunInvoker") && damage.To.HasFlag("FenxunTarget"))
            {
                damage.From.AddMark(string.Format("{0}_{1}", "fenxun_jx", damage.To.Name));
            }
            else if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.To == PlayerPhase.NotActive && player.ContainsTag("fenxun_jx")
                && player.GetTag("fenxun_jx") is List<string> targets)
            {
                player.RemoveTag("fenxun_jx");
                foreach (string target_name in targets)
                {
                    player.SetMark((string.Format("{0}_{1}", "fenxun_jx", target_name)), 0);
                }
            }

        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Finish && player.ContainsTag("fenxun_jx") && player.Alive
                && !player.IsNude() && player.GetTag("fenxun_jx") is List<string> targets)
            {
                foreach (string target_name in targets)
                {
                    if (player.GetMark(string.Format("{0}_{1}", "fenxun_jx", target_name)) == 0 && !player.IsNude())
                        return new TriggerStruct(Name, player);
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (player.GetTag("fenxun_jx") is List<string> targets)
            {
                foreach (string target_name in targets)
                {
                    if (player.Alive && player.GetMark(string.Format("{0}_{1}", "fenxun_jx", target_name)) == 0 && !player.IsNude())
                        room.AskForDiscard(player, Name, 1, 1, false, true, "@fenxun_jx:" + target_name, false, info.SkillPosition);
                }
            }

            return false;
        }
    }

    public class FenxunJXCard : SkillCard
    {
        public static string ClassName = "FenxunJXCard";
        public FenxunJXCard() : base(ClassName)
        {
        }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }
        public override void OnEffect(Room room, CardEffectStruct effect)
        {
            List<string> targets = effect.From.ContainsTag("fenxun_jx") ? (List<string>)effect.From.GetTag("fenxun_jx") : new List<string>();
            targets.Add(effect.To.Name);
            effect.From.SetTag("fenxun_jx", targets);
            effect.From.SetFlags("FenxunInvoker");
            effect.To.SetFlags("FenxunTarget");
        }
    }

    public class Lanjiang : TriggerSkill
    {
        public Lanjiang() : base("lanjiang")
        {
            events.Add(TriggerEvent.EventPhaseStart);
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && player.Phase == PlayerPhase.Finish)
            {
                foreach (Player p in room.GetOtherPlayers(player))
                    if (p.HandcardNum >= player.HandcardNum)
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
            List<Player> targets = new List<Player>();
            foreach (Player p in room.GetOtherPlayers(player))
                if (p.HandcardNum >= player.HandcardNum)
                    targets.Add(p);

            if (targets.Count > 0)
            {
                room.SortByActionOrder(ref targets);
                foreach (Player p in targets)
                    room.DoAnimate(AnimateType.S_ANIMATE_INDICATE, player.Name, p.Name);

                foreach (Player p in targets)
                {
                    if (player.Alive && p.Alive && room.AskForSkillInvoke(p, Name, "@lanjiang:" + player.Name))
                        room.DrawCards(player, new DrawCardStruct(1, p, Name));
                }

                if (player.Alive)
                {
                    List<Player> victims = new List<Player>();
                    foreach (Player p in targets)
                    {
                        if (p.Alive && p.HandcardNum == player.HandcardNum)
                            victims.Add(p);
                    }
                    if (victims.Count > 0)
                    {
                        Player target = room.AskForPlayerChosen(player, victims, Name, "@lanjiang-damage", true, true, info.SkillName);
                        if (target != null)
                            room.Damage(new DamageStruct(Name, player, target));
                    }
                }
                if (player.Alive && player.HandcardNum > 0)
                {
                    List<Player> victims = new List<Player>();
                    foreach (Player p in targets)
                    {
                        if (p.Alive && p.HandcardNum < player.HandcardNum)
                            victims.Add(p);
                    }
                    if (victims.Count > 0)
                    {
                        player.SetFlags(Name);
                        Player target = room.AskForPlayerChosen(player, victims, Name, "@lanjiang-draw", true, true, info.SkillName);
                        player.SetFlags("-lanjiang");
                        if (target != null)
                            room.DrawCards(target, new DrawCardStruct(1, player, Name));
                    }
                }
            }

            return false;
        }
    }

    public class Aichen : TriggerSkill
    {
        public Aichen() : base("aichen")
        {
            events = new List<TriggerEvent> { TriggerEvent.EventPhaseStart, TriggerEvent.Damaged, TriggerEvent.RoundStart };
            skill_type = SkillType.Masochism;
            view_as_skill = new AichenVS();
        }

        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.RoundStart)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    p.SetMark("aichen_1", 0);
                    p.SetMark("aichen_2", 0);
                    p.SetMark("aichen_3", 0);
                    p.SetMark("aichen_4", 0);
                }
            }
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if ((triggerEvent == TriggerEvent.EventPhaseStart && player.Phase == PlayerPhase.Start || triggerEvent == TriggerEvent.Damaged) && base.Triggerable(player, room))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<string> choices = new List<string>();
            if (player.GetMark("aichen_1") == 0 && player.GetMark("aichen_1_invalid") == 0)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.IsWounded())
                    {
                        choices.Add("recover");
                        break;
                    }
                }
            }
            if (player.GetMark("aichen_2") == 0 && player.GetMark("aichen_2_invalid") == 0)
            {
                bool add = true;
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.HasFlag("Global_Dying"))
                    {
                        add = false;
                        break;
                    }
                }
                if (add) choices.Add("losehp");
            }
            if (player.GetMark("aichen_3") == 0 && player.GetMark("aichen_3_invalid") == 0)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.GetCards("ej").Count > 0 && RoomLogic.CanDiscard(room, player, p, "ej"))
                    {
                        choices.Add("discard");
                        break;
                    }
                }
            }
            if (player.GetMark("aichen_4") == 0 && player.GetMark("aichen_4_invalid") == 0)
                choices.Add("draw");

            if (choices.Count > 0)
            {
                choices.Add("cancel");
                string choice = room.AskForChoice(player, Name, string.Join("+", choices), null, null, info.SkillPosition);
                if (choice != "cancel")
                {
                    room.NotifySkillInvoked(player, Name);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    player.SetTag(Name, choice);
                    return info;
                }
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
                    case "recover":
                        {
                            player.SetMark("aichen_1", 1);
                            List<Player> targets = new List<Player>();
                            foreach (Player p in room.GetAlivePlayers())
                                if (p.IsWounded()) targets.Add(p);

                            if (targets.Count > 0)
                            {
                                player.SetFlags("aichen_recover");
                                Player target = room.AskForPlayerChosen(player, targets, Name, "@aichen-recover", false, true, info.SkillPosition);
                                player.SetFlags("-aichen_recover");

                                RecoverStruct recover = new RecoverStruct
                                {
                                    Who = player,
                                    Recover = 1
                                };
                                room.Recover(target, recover, true);
                            }
                        }
                        break;
                    case "losehp":
                        {
                            player.SetMark("aichen_2", 1);

                            player.SetFlags("aichen_lose");
                            Player target = room.AskForPlayerChosen(player, room.GetAlivePlayers(), Name, "@aichen-losehp", false, true, info.SkillPosition);
                            player.SetFlags("-aichen_lose");

                            room.LoseHp(target);
                        }
                        break;
                    case "discard":
                        {
                            int count = 2;
                            player.SetMark("aichen_3", 1);

                            while (count > 0 && player.Alive)
                            {
                                List<Player> targets = new List<Player>();
                                foreach (Player p in room.GetAlivePlayers())
                                    if (p.GetCards("ej").Count > 0 && RoomLogic.CanDiscard(room, player, p, "ej")) targets.Add(p);

                                if (targets.Count > 0)
                                {
                                    player.SetFlags("aichen_discard");
                                    Player target = room.AskForPlayerChosen(player, targets, Name, "@aichen-discard", count != 2, true, info.SkillPosition);
                                    player.SetFlags("-aichen_discard");

                                    if (target != null)
                                    {
                                        int card_id = room.AskForCardChosen(player, target, "ej", Name, false, HandlingMethod.MethodDiscard);
                                        room.ThrowCard(card_id, room.GetCardPlace(card_id) == Place.PlaceDelayedTrick ? null : target, player != target ? player : null);
                                    }
                                }
                                count--;
                            }
                        }
                        break;
                    case "draw":
                        {
                            player.SetMark("aichen_4", 1);
                            room.DrawCards(player, 2, Name);
                            if (player.Alive && !player.IsNude())
                                room.AskForUseCard(player, RespondType.Skill, "@@aichen", "@aichen", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
                        }
                        break;
                }
            }

            return false;
        }
    }

    public class AichenVS : ViewAsSkill
    {
        public AichenVS() : base("aichen") { response_pattern = "@@aichen"; }

        public override bool ViewFilter(Room room, List<WrappedCard> selected, WrappedCard to_select, Player player) => true;

        public override WrappedCard ViewAs(Room room, List<WrappedCard> cards, Player player)
        {
            if (cards.Count > 0)
            {
                WrappedCard card = new WrappedCard(AichenCard.ClassName);
                card.AddSubCards(cards);
                return card;
            }
            return null;
        }
    }

    public class AichenCard : SkillCard
    {
        public static string ClassName = "AichenCard";
        public AichenCard() : base(ClassName) { }
        public override bool TargetFilter(Room room, List<Player> targets, Player to_select, Player Self, WrappedCard card)
        {
            return targets.Count == 0 && to_select != Self;
        }

        public override void OnUse(Room room, CardUseStruct card_use)
        {
            List<int> ids = new List<int>(card_use.Card.SubCards);
            room.ObtainCard(card_use.To[0], ref ids, new CardMoveReason(MoveReason.S_REASON_GIVE, card_use.From.Name, card_use.To[0].Name, "aichen", string.Empty), false);
        }
    }

    public class Luochong : TriggerSkill
    {
        public Luochong() : base("luochong")
        {
            events.Add(TriggerEvent.Dying);
            skill_type = SkillType.Recover;
            frequency = Frequency.Compulsory;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (base.Triggerable(player, room) && RoomLogic.PlayerHasSkill(room, player, "aichen"))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            List<string> choices = new List<string>();
            if (player.GetMark("aichen_1") == 0 && player.GetMark("aichen_1_invalid") == 0)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.IsWounded())
                    {
                        choices.Add("recover");
                        break;
                    }
                }
            }
            if (player.GetMark("aichen_2") == 0 && player.GetMark("aichen_2_invalid") == 0)
            {
                choices.Add("losehp");
            }
            if (player.GetMark("aichen_3") == 0 && player.GetMark("aichen_3_invalid") == 0)
            {
                foreach (Player p in room.GetAlivePlayers())
                {
                    if (p.GetCards("ej").Count > 0 && RoomLogic.CanDiscard(room, player, p, "ej"))
                    {
                        choices.Add("discard");
                        break;
                    }
                }
            }
            if (player.GetMark("aichen_4") == 0 && player.GetMark("aichen_4_invalid") == 0)
                choices.Add("draw");

            if (choices.Count > 1)
            {
                room.SendCompulsoryTriggerLog(player, Name);
                room.BroadcastSkillInvoke(Name, player, info.SkillPosition);

                int coun = 1 - player.Hp;
                if (coun > 0) room.Recover(player, coun);

                if (player.Alive)
                {
                    player.SetFlags(Name);
                    string choice = room.AskForChoice(player, "aichen", string.Join("+", choices), null, null, info.SkillPosition);
                    player.SetFlags("-luochong");

                    LogMessage log = new LogMessage
                    {
                        From = player.Name,
                        Type = "#luochong",
                        Arg = string.Format("aichen:{0}", choice)
                    };
                    room.SendLog(log);

                    switch (choice)
                    {
                        case "recover":
                            {
                                player.SetMark("aichen_1_invalid", 1);
                                List<Player> targets = new List<Player>();
                                foreach (Player p in room.GetAlivePlayers())
                                    if (p.IsWounded()) targets.Add(p);

                                if (targets.Count > 0)
                                {
                                    player.SetFlags("aichen_recover");
                                    Player target = room.AskForPlayerChosen(player, targets, "aichen", "@aichen-recover", false, true, info.SkillPosition);
                                    player.SetFlags("-aichen_recover");

                                    RecoverStruct recover = new RecoverStruct
                                    {
                                        Who = player,
                                        Recover = 1
                                    };
                                    room.Recover(target, recover, true);
                                }
                            }
                            break;
                        case "losehp":
                            {
                                player.SetMark("aichen_2_invalid", 1);

                                bool add = true;
                                foreach (Player p in room.GetAlivePlayers())
                                {
                                    if (p.HasFlag("Global_Dying"))
                                    {
                                        add = false;
                                        break;
                                    }
                                }

                                if (add)
                                {
                                    player.SetFlags("aichen_lose");
                                    Player target = room.AskForPlayerChosen(player, room.GetAlivePlayers(), "aichen", "@aichen-losehp", false, true, info.SkillPosition);
                                    player.SetFlags("-aichen_lose");

                                    room.LoseHp(target);
                                }
                            }
                            break;
                        case "discard":
                            {
                                int count = 2;
                                player.SetMark("aichen_3_invalid", 1);

                                while (count > 0 && player.Alive)
                                {
                                    List<Player> targets = new List<Player>();
                                    foreach (Player p in room.GetAlivePlayers())
                                        if (p.GetCards("ej").Count > 0 && RoomLogic.CanDiscard(room, player, p, "ej")) targets.Add(p);

                                    if (targets.Count > 0)
                                    {
                                        player.SetFlags("aichen_discard");
                                        Player target = room.AskForPlayerChosen(player, targets, "aichen", "@aichen-discard", count != 2, true, info.SkillPosition);
                                        player.SetFlags("-aichen_discard");

                                        if (target != null)
                                        {
                                            int card_id = room.AskForCardChosen(player, target, "ej", "aichen", false, HandlingMethod.MethodDiscard);
                                            room.ThrowCard(card_id, room.GetCardPlace(card_id) == Place.PlaceDelayedTrick ? null : target, player != target ? player : null);
                                        }
                                    }
                                    count--;
                                }
                            }
                            break;
                        case "draw":
                            {
                                player.SetMark("aichen_4_invalid", 1);
                                room.DrawCards(player, 2, "aichen");
                                if (player.Alive && !player.IsNude())
                                    room.AskForUseCard(player, RespondType.Skill, "@@aichen", "@aichen", null, -1, HandlingMethod.MethodUse, true, info.SkillPosition);
                            }
                            break;
                    }
                }
            }

            return false;
        }
    }

    public class Qingliang : TriggerSkill
    {
        public Qingliang() : base("qingliang")
        {
            events.Add(TriggerEvent.TargetConfirmed);
            skill_type = SkillType.Defense;
        }

        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (data is CardUseStruct use && use.From != null && use.From != player && base.Triggerable(player, room) && use.To.Count == 1 && !player.IsKongcheng() && !player.HasFlag(Name)
                && (use.Card.Name.Contains(Slash.ClassName) || use.Card.Name == Duel.ClassName || use.Card.Name == FireAttack.ClassName || use.Card.Name == ArcheryAttack.ClassName
                || use.Card.Name == SavageAssault.ClassName || use.Card.Name == Drowning.ClassName) && RoomLogic.CanDiscard(room, player, player, "h"))
                return new TriggerStruct(Name, player);
            return new TriggerStruct();
        }

        public override TriggerStruct Cost(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                room.SetTag(Name, data);
                bool invoke = room.AskForSkillInvoke(player, Name, string.Format("@qingliang:{0}::{1}", use.From.Name, use.Card.Name), info.SkillPosition);
                room.RemoveTag(Name);

                if (invoke)
                {
                    player.SetFlags(Name);
                    room.BroadcastSkillInvoke(Name, player, info.SkillPosition);
                    room.ShowAllCards(player);
                    return info;
                }
            }
            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            if (data is CardUseStruct use)
            {
                string prompt = use.From.Alive ? string.Format("@qingliang-choose:{0}::{1}", use.From.Name, use.Card.Name) : string.Format("@qingliang-discard:{0}::{1}", use.From.Name, use.Card.Name);
                List<int> ids = room.AskForExchange(player, Name, 1, use.From.Alive ? 0 : 1, prompt, string.Empty, ".!", info.SkillPosition);
                if (ids.Count == 0)
                {
                    List<Player> targets = new List<Player> { player, use.From };
                    room.SortByActionOrder(ref targets);
                    foreach (Player p in targets)
                        if (p.Alive) room.DrawCards(p, new DrawCardStruct(1, player, Name));
                }
                else
                {
                    WrappedCard.CardSuit suit = room.GetCard(ids[0]).Suit;
                    List<int> discard = new List<int>();
                    foreach (int id in player.GetCards("h"))
                        if (room.GetCard(id).Suit == suit && RoomLogic.CanDiscard(room, player, player, id))
                            discard.Add(id);

                    if (discard.Count > 0)
                    {
                        room.ThrowCard(ref discard, player, player, Name);
                        if (player.Alive)
                            room.CancelTarget(ref use, player);
                    }
                }
            }

            return false;
        }
    }

    public class QiaoliEffect : TriggerSkill
    {
        public QiaoliEffect() : base("#qiaoli")
        {
            events = new List<TriggerEvent> { TriggerEvent.Damage, TriggerEvent.EventPhaseChanging, TriggerEvent.TargetChosen, TriggerEvent.CardUsedAnnounced, TriggerEvent.EventPhaseStart };
            frequency = Frequency.Compulsory;
        }
        public override void Record(TriggerEvent triggerEvent, Room room, Player player, ref object data)
        {
            if (triggerEvent == TriggerEvent.EventPhaseChanging && data is PhaseChangeStruct change && change.From == PlayerPhase.Play)
            {
                player.SetMark("qiaoli_weapon", 0);
                player.SetMark("qiaoli_equip", 0);
            }
            else if (triggerEvent == TriggerEvent.CardUsedAnnounced && data is CardUseStruct use && use.Card.GetSkillName() == "qiaoli")
            {
                FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(use.Card.GetEffectiveId()).Name);
                if (fcard is Weapon)
                    player.AddMark("qiaoli_weapon");
                else
                {
                    use.Card.Cancelable = false;
                    player.AddMark("qiaoli_equip");
                    player.SetFlags("qiaoli");
                }
            }
        }
        public override TriggerStruct Triggerable(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who)
        {
            if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage && damage.Card != null && damage.Card.Name == Duel.ClassName && damage.ByUser
                && damage.Card.GetSkillName() == "qiaoli" && player.Alive)
            {
                FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(damage.Card.GetEffectiveId()).Name);
                if (fcard is Weapon) return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use && use.Card.Name == Duel.ClassName && use.Card.GetSkillName() == "qiaoli" && !use.Card.Cancelable)
            {
                return new TriggerStruct(Name, player);
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart && player.Alive && player.Phase == PlayerPhase.Finish && player.HasFlag("qiaoli"))
            {
                return new TriggerStruct(Name, player);
            }

            return new TriggerStruct();
        }

        public override bool Effect(TriggerEvent triggerEvent, Room room, Player player, ref object data, Player ask_who, TriggerStruct info)
        {
            room.SendCompulsoryTriggerLog(ask_who, "qiaoli");
            if (triggerEvent == TriggerEvent.TargetChosen && data is CardUseStruct use)
            {
                LogMessage log = new LogMessage
                {
                    Type = "$NoRespond",
                    From = player.Name,
                    Card_str = RoomLogic.CardToString(room, use.Card)
                };
                room.SendLog(log);
                for (int i = 0; i < use.EffectCount.Count; i++)
                {
                    CardBasicEffect effect = use.EffectCount[i];
                    effect.Effect2 = 0;
                }
            }
            else if (triggerEvent == TriggerEvent.Damage && data is DamageStruct damage)
            {
                FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(damage.Card.GetEffectiveId()).Name);
                if (fcard is Weapon weapon)
                {
                    List<int> yiji_cards = room.DrawCards(player, weapon.Range, "qiaoli");
                    List<int> origin_yiji = new List<int>(yiji_cards);
                    while (player.Alive && yiji_cards.Count > 0)
                    {
                        if (!room.AskForYiji(player, ref yiji_cards, "qiaoli", true, false, true, -1, room.GetOtherPlayers(player), null, null, null, false, info.SkillPosition))
                            break;
                    }
                }
            }
            else if (triggerEvent == TriggerEvent.EventPhaseStart)
            {
                int card_id = -1;
                foreach (int id in room.DrawPile)
                {
                    FunctionCard fcard = Engine.GetFunctionCard(room.GetCard(id).Name);
                    if (fcard is Weapon)
                    {
                        card_id = id;
                        break;
                    }
                }
                if (card_id >= 0)
                    room.ObtainCard(player, room.GetCard(card_id), new CardMoveReason(MoveReason.S_REASON_GOTCARD, player.Name, "qiaoli", string.Empty), true);
            }

            return false;
        }
    }

    public class Qiaoli : OneCardViewAsSkill
    {
        public Qiaoli() : base("qiaoli")
        {
            response_or_use = true;
            skill_type = SkillType.Wizzard;
        }
        public override bool ViewFilter(Room room, WrappedCard to_select, Player player)
        {
            if (!RoomLogic.IsCardLimited(room, player, to_select, HandlingMethod.MethodUse))
            {
                FunctionCard fcard = Engine.GetFunctionCard(to_select.Name);
                return (player.GetMark("qiaoli_weapon") == 0 && fcard is Weapon) || (player.GetMark("qiaoli_equip") == 0 && fcard is EquipCard && !(fcard is Weapon));
            }
            return false;
        }
        public override bool IsEnabledAtPlay(Room room, Player player) => player.GetMark("qiaoli_weapon") == 0 || player.GetMark("qiaoli_equip") == 0;
        public override WrappedCard ViewAs(Room room, WrappedCard card, Player player)
        {
            WrappedCard duel = new WrappedCard(Duel.ClassName) { Skill = Name };
            duel.AddSubCard(card);
            duel = RoomLogic.ParseUseCard(room, duel);
            return duel;
        }
    }
}
