﻿using System;
using System.Collections.Generic;
using CommonClass;
using CommonClass.Game;
using SanguoshaServer.Game;
using SanguoshaServer.Package;
using static CommonClass.Game.Player;
using static SanguoshaServer.Package.FunctionCard;

namespace SanguoshaServer.AI
{
    public class AnniversaryAI : AIPackage
    {
        public AnniversaryAI() : base("Anniversary")
        {
            events = new List<SkillEvent>
            {
                new YanjiaoAI(),
                new XingshenAI(),
                new AndongAI(),
                new YingshiAI(),
                new SanwenAI(),
                new QiaiAI(),
                new DenglouAI(),
                new LvliAI(),
                new QingjiaoAI(),
                new ZhenxingAI(),
                new WeiluAI(),
                new ZengdaoAI(),
                new YinjuAI(),
                new QianxinZGAI(),
                new ZhuilieAI(),
                new PianchongAI(),
                new ZunweiAI(),
                new YizhengCSAI(),
                new LiluAI(),
                new YisheDFRAI(),
                new ShunshiAI(),
                new XianweiAI(),
                new TongyuanAI(),
                new CuijianAI(),
                new ZhushiAI(),
                new CaiyiAI(),
                new TuoxianAI(),

                new TunanAI(),
                new ManyiAI(),
                new MansiAI(),
                new SouyingAI(),
                new XiliAI(),
                new ZhanyuanAI(),
                new YouyanAI(),
                new ZhuihuanAI(),
                new BazhanAI(),
                new JiaoyingAI(),
                new JianliangAI(),
                new WeimengAI(),
                new QuanjianAI(),
                new TujueAI(),
                new XunbieAI(),

                new GuolunAI(),
                new SongSangAI(),
                new QinguoAI(),
                new YoudiAI(),
                new DuanfaAI(),
                new GongqingAI(),
                new BiaozhaoAI(),
                new YechouAI(),
                new ZhafuAI(),
                new FuhaiAI(),
                new SongshuAI(),
                new SibianAI(),
                new ZhirenAI(),
                new YanerAI(),
                new ZhukouAI(),
                new YuyunAI(),
                new YusuiClassicAI(),
                new BoyanClassicAI(),

                new KannanAI(),
                new JiedaoAI(),
                new JixuAI(),
                new KuizhuLSAI(),
                new FenyueAI(),
                new XuheAI(),
                new ShiyuanAI(),
                new DushiAI(),
                new ZhuideAI(),
                new MinsiAI(),
                new JijingAI(),
                new JieyingHFAI(),
                new WeipoAI(),
                new PanshiAI(),
                new CixiaoAI(),
                new GongjianAI(),
                new NiluanAI(),
                new WeiwuAI(),
                new YujueAI(),
                new TuxinAI(),
                new LiangyingClassicAI(),
                new ShishouAI(),
                new YixiangSPAI(),
                new YirangSPAI(),
                new GuowuAI(),
                new ZhengeAI(),
                new ChaofengAI(),
                new ChuanshuAI(),
                new ChuanyunAI(),
                new TianzeAI(),
                new DifaAI(),
                new XuezhaoAI(),
                new ChanniAI(),
                new MouzhuAI(),
                new TiqiAI(),
                new BaoshuAI(),
                new XiaowuAI(),
                new ShawuAI(),
                new HuapingAI(),
                new JinggongAI(),
                new XiaoxiAI(),
                new XiongraoAI(),
            };

            use_cards = new List<UseCard>
            {
                new GuolunCardAI(),
                new YanjiaoCardAI(),
                new DuanfaCardAI(),
                new TunanCardAI(),
                new JixuCardAI(),
                new ZengdaoCardAI(),
                new ZhafuCardAI(),
                new SongshuCardAI(),
                new FenyueCardAI(),
                new MinsiCardAI(),
                new CixiaoCardAI(),
                new YujueCardAI(),
                new ZunweiCardAI(),
                new ShunshiCardAI(),
                new CuijianCardAI(),
                new BazhanCardAI(),
                new XuezhaoCardAI(),
                new ChanniCardAI(),
                new BoyanCCardAI(),
                new WeimengCardAI(),
                new MouzhuCardAI(),
                new XiaowuCardAI(),
                new YingshiCardAI(),
                new QuanjianCardAI(),
            };
        }
    }

    public class YanjiaoAI : SkillEvent
    {
        public YanjiaoAI() : base("yanjiao")
        {
        }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(YanjiaoCard.ClassName) && ai.FriendNoSelf.Count > 0)
                return new List<WrappedCard> { new WrappedCard(YanjiaoCard.ClassName) { Skill = Name } };

            return new List<WrappedCard>();
        }

        public override AskForMoveCardsStruct OnMoveCards(TrustedAI ai, Player player, List<int> cards, List<int> empty, int min, int max)
        {
            AskForMoveCardsStruct move = new AskForMoveCardsStruct
            {
                Top = new List<int>(),
                Bottom = new List<int>(),
                Success = false
            };

            Room room = ai.Room;
            Player target = room.Current;
            if (ai.IsEnemy(target) && ai.HasSkill("zishu"))
                return move;

            List<List<int>> tops = new List<List<int>>(), downs = new List<List<int>>();
            int half = cards.Count / 2;
            for (int i = 1; i <= half; i++)
            {
                List<List<int>> top = TrustedAI.GetCombinationList(new List<int>(cards), i);
                foreach (List<int> combine in top)
                {
                    int top_count = 0;
                    foreach (int card_id in combine)
                        top_count += Engine.GetRealCard(card_id).Number;

                    List<int> others = new List<int>(cards);
                    others.RemoveAll(t => combine.Contains(t));
                    for (int i2 = 1; i2 <= others.Count; i2++)
                    {
                        List<List<int>> down = TrustedAI.GetCombinationList(new List<int>(others), i2);
                        foreach (List<int> combine2 in down)
                        {
                            int down_count = 0;
                            foreach (int card_id in combine2)
                                down_count += Engine.GetRealCard(card_id).Number;

                            if (top_count == down_count)
                            {
                                tops.Add(combine);
                                downs.Add(combine2);
                            }
                        }
                    }
                }
            }

            if (tops.Count > 0 && downs.Count > 0)
            {
                int best = -1;
                double good = -100;
                bool use = !ai.IsWeak();
                for (int i = 0; i < downs.Count; i++)
                {
                    double value = 0;
                    foreach (int id in downs[i])
                        value += use ? ai.GetUseValue(id, player, Place.PlaceHand) : ai.GetKeepValue(id, player, Place.PlaceHand);

                    if (value > good)
                    {
                        good = value;
                        best = i;
                    }
                }

                if (best >= 0)
                {
                    move.Top = tops[best];
                    move.Bottom = downs[best];
                    move.Success = true;
                }
            }
            /*
            if (tops.Count > 0 && downs.Count > 0)
            {
                for (int i = 0; i < tops.Count; i++)
                {
                    int top_count = 0;
                    List<string> downs_number = new List<string>(), tops_number = new List<string>();
                    foreach (int card_id in tops[i])
                    {
                        int number = Engine.GetRealCard(card_id).Number;
                        top_count += number;
                        tops_number.Add(number.ToString());
                    }

                    int down_count = 0;
                    foreach (int card_id in downs[i])
                    {
                        int number = Engine.GetRealCard(card_id).Number;
                        down_count += number;
                        downs_number.Add(number.ToString());
                    }

                    Debug(string.Format("组合{0} 合计{1}，上：cards:{3} number {2}", i + 1, top_count, string.Join("+", tops_number), string.Join("+", JsonUntity.IntList2StringList(tops[i]))));
                    Debug(string.Format("组合{0} 合计{1}，下：cards:{3} number {2}", i + 1, down_count, string.Join("+", downs_number), string.Join("+", JsonUntity.IntList2StringList(downs[i]))));
                }
            }
            */
            return move;
        }
    }

    public class YanjiaoCardAI : UseCard
    {
        public YanjiaoCardAI() : base(YanjiaoCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                Player target = use.To[0];
                if (ai.GetPlayerTendency(target) != "unknown")
                    ai.UpdatePlayerRelation(player, target, true);
            }
        }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> friends = ai.FriendNoSelf;
            if (friends.Count > 0)
            {
                use.Card = card;
                foreach (Player p in friends)
                {
                    if (ai.HasSkill("qingjian", p))
                    {
                        use.To = new List<Player> { p };
                        return;
                    }
                }
                foreach (Player p in friends)
                {
                    if (ai.HasSkill(TrustedAI.CardneedSkill, p))
                    {
                        use.To = new List<Player> { p };
                        return;
                    }
                }
                ai.SortByDefense(ref friends, false);
                foreach (Player p in friends)
                {
                    if (!ai.HasSkill("zishu", p))
                    {
                        use.To = new List<Player> { p };
                        return;
                    }
                }
                use.To = new List<Player> { friends[0] };
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card)
        {
            return 9;
        }
    }

    public class XingshenAI : SkillEvent
    {
        public XingshenAI() : base("xingshen") { }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            return true;
        }

        public override ScoreStruct GetDamageScore(TrustedAI ai, DamageStruct damage)
        {
            ScoreStruct score = new ScoreStruct
            {
                Score = 0
            };
            if (ai.HasSkill(Name, damage.To) && damage.Damage < damage.To.Hp)
                score.Score += 1.5;

            return score;
        }
    }

    public class AndongAI : SkillEvent
    {
        public AndongAI() : base("andong")
        {
        }

        public override ScoreStruct GetDamageScore(TrustedAI ai, DamageStruct damage)
        {
            ScoreStruct score = new ScoreStruct
            {
                Score = 0
            };
            if (ai.HasSkill(Name, damage.To) && damage.From != null && damage.From != damage.To && !ai.IsFriend(damage.To, damage.From)
                && !damage.To.IsKongcheng() && ai.Self == damage.From)
            {
                Room room = ai.Room;
                List<int> ids = new List<int>();
                foreach (int id in ai.Self.GetCards("h"))
                    if (room.GetCard(id).Suit == WrappedCard.CardSuit.Heart) ids.Add(id);

                if (damage.Card != null)
                    ids.RemoveAll(t => damage.Card.SubCards.Contains(t));

                double value = 0;
                if (ai.Self.Phase == PlayerPhase.Play)
                {
                    foreach (int id in ids)
                        value += ai.GetUseValue(id, ai.Self);

                }
                else
                {
                    foreach (int id in ids)
                        value += ai.GetKeepValue(id, ai.Self);
                }
                score.Score -= value / 2;
            }

            return score;
        }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (data is DamageStruct damage)
            {
                Player target = damage.To;
                ScoreStruct score = ai.GetDamageScore(damage);
                if (score.Score > 0)
                    return "view";
                else
                    return "prevent";
            }

            return "view";
        }
    }

    public class YingshiAI : SkillEvent
    {
        public YingshiAI() : base("yingshi")
        {
        }
        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            Room room = ai.Room;

            CardUseStruct use = new CardUseStruct(null, player, new List<Player>());

            if (player.HasFlag("yingshi_slasher"))
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetOtherPlayers(player))
                    if (p.HasFlag("SlashAssignee")) targets.Add(p);

                List<ScoreStruct> values = ai.CaculateSlashIncome(player, null, targets);
                if (values.Count > 0 && values[0].Score > 0)
                {
                    use.Card = values[0].Card;
                    use.To = values[0].Players;
                }
            }
            else
            {
                List<Player> enemies = ai.GetEnemies(player);
                if (enemies.Count > 0)
                {
                    ai.SortByDefense(ref enemies, false);
                    Player from = null;
                    List<Player> friends = ai.FriendNoSelf;
                    ai.SortByHandcards(ref friends);
                    if (friends.Count > 0)
                    {
                        foreach (Player p in friends)
                        {
                            if (ai.HasSkill("wushuang|tieqi_jx|liegong_jx|duanbing_jx|pojun|jianchu|moukui"))
                            {
                                from = p;
                                break;
                            }
                        }
                    }
                    if (from == null)
                    {
                        List<WrappedCard> slashes = ai.GetCards(Slash.ClassName, player);
                        if (slashes.Count > 0)
                        {
                            foreach (Player p in enemies)
                            {
                                List<ScoreStruct> values = ai.CaculateSlashIncome(player, slashes, enemies);
                                if (values.Count > 0 && values[0].Score > 0)
                                {
                                    List<int> ids = player.GetCards("h");
                                    ai.SortByUseValue(ref ids, false);
                                    ids.RemoveAll(t => values[0].Card.SubCards.Contains(t));
                                    use.Card = new WrappedCard(YingshiCard.ClassName) { Skill = Name };
                                    use.Card.AddSubCard(ids[0]);
                                    use.To.Add(player);
                                    use.To.Add(values[0].Players[0]);
                                }
                            }
                        }
                        else
                        {
                            if (friends.Count > 0)
                            {
                                List<int> ids = player.GetCards("h");
                                ai.SortByUseValue(ref ids, false);
                                use.Card = new WrappedCard(YingshiCard.ClassName) { Skill = Name };
                                use.Card.AddSubCard(ids[0]);
                                use.To.Add(friends[0]);
                                use.To.Add(enemies[0]);
                            }
                        }
                    }
                    else
                    {
                        List<int> ids = player.GetCards("h");
                        ai.SortByUseValue(ref ids, false);
                        use.Card = new WrappedCard(YingshiCard.ClassName) { Skill = Name };
                        use.Card.AddSubCard(ids[0]);
                        use.To.Add(from);
                        use.To.Add(enemies[0]);
                    }
                }
            }
            return use;
        }
    }

    public class YingshiCardAI : UseCard
    {
        public YingshiCardAI() : base(YingshiCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                if (ai.GetPlayerTendency(use.To[0]) != "unknown") ai.UpdatePlayerRelation(player, use.To[0], true);
                if (ai.GetPlayerTendency(use.To[1]) != "unknown") ai.UpdatePlayerRelation(player, use.To[1], false);
            }
        }
    }

    public class SanwenAI : SkillEvent
    {
        public SanwenAI() : base("sanwen") { }

        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            List<int> ids = new List<int>();
            Room room = ai.Room;
            List<string> patterns = new List<string>(pattern.Split('#'));
            foreach (int id in player.GetCards("h"))
            {
                WrappedCard card = room.GetCard(id);
                string remove = string.Empty;
                foreach (string p in patterns)
                {
                    if (Engine.MatchExpPattern(room, pattern, player, card))
                    {
                        ids.Add(id);
                        remove = p;
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(remove)) patterns.Remove(remove);
            }

            return ids;
        }
    }

    public class QiaiAI : SkillEvent
    {
        public QiaiAI() : base("qiai") { }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;

        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            List<int> ids = player.GetCards("he");
            ai.SortByKeepValue(ref ids, false);
            Player target = null;
            Room room = ai.Room;
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (p.HasFlag(Name))
                {
                    target = p;
                    break;
                }
            }

            if (ai.IsFriend(target))
            {
                foreach (int id in player.GetCards("h"))
                    if (room.GetCard(id).Name == Analeptic.ClassName) return new List<int> { id };

                foreach (int id in player.GetCards("h"))
                    if (room.GetCard(id).Name == Peach.ClassName) return new List<int> { id };
            }

            return new List<int> { ids[0] };
        }
    }

    public class DenglouAI : SkillEvent
    {
        public DenglouAI() : base("denglou") { }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;

        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            Room room = ai.Room;
            CardUseStruct use = new CardUseStruct(null, player, new List<Player>());
            List<int> ids = player.GetPile("#denglou");

            foreach (int id in ids)
            {
                WrappedCard card = room.GetCard(id);
                if (card.Name == Analeptic.ClassName && Analeptic.Instance.IsAvailable(room, player, card))
                {
                    use.Card = card;
                    return use;
                }
                else if (card.Name == Peach.ClassName && Peach.Instance.IsAvailable(room, player, card))
                {
                    use.Card = card;
                    return use;
                }
            }

            foreach (int id in ids)
            {
                WrappedCard card = room.GetCard(id);
                if (card.Name.Contains(Slash.ClassName))
                {
                    List<WrappedCard> slashes = new List<WrappedCard> { card };
                    List<ScoreStruct> scores = ai.CaculateSlashIncome(player, slashes, null, false);
                    if (scores.Count > 0 && scores[0].Score > 0 && scores[0].Players != null && scores[0].Players.Count > 0)
                    {
                        use.Card = card;
                        use.To = scores[0].Players;
                        return use;
                    }
                }
            }

            return use;
        }
    }

    public class LvliAI : SkillEvent
    {
        public LvliAI() : base("lvli") { }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;
    }

    public class QingjiaoAI : SkillEvent
    {
        public QingjiaoAI() : base("qingjiao") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => player.Hp <= 2 || player.HandcardNum < 4;
    }

    public class ZhenxingAI : SkillEvent
    {
        public ZhenxingAI() : base("zhenxing") { }
        public override ScoreStruct GetDamageScore(TrustedAI ai, DamageStruct damage)
        {
            ScoreStruct score = new ScoreStruct
            {
                Score = 0
            };
            if (ai.HasSkill(Name, damage.To) && damage.Damage == 1)
                score.Score += ai.IsFriend(damage.To) ? 1.5 : -1.5;
            return score;
        }
    }

    public class WeiluAI : SkillEvent
    {
        public WeiluAI() : base("weilu") { }
        public override ScoreStruct GetDamageScore(TrustedAI ai, DamageStruct damage)
        {
            ScoreStruct score = new ScoreStruct
            {
                Score = 0
            };
            if (ai.HasSkill(Name, damage.To) && damage.Damage == 1 && damage.From != null && damage.From != damage.To && damage.From.Hp > 1 && damage.Damage < damage.To.Hp)
            {
                if (ai.HasSkill("zhaxiang", damage.From))
                {
                    if (ai.IsFriend(damage.From)) score.Score += 5;
                    if (ai.IsEnemy(damage.From)) score.Score -= 5;
                    return score;
                }
                if (ai.IsFriend(damage.From)) score.Score -= 3;
                if (ai.IsEnemy(damage.From)) score.Score += 3;
            }

            return score;
        }
    }

    public class ZengdaoAI : SkillEvent
    {
        public ZengdaoAI() : base("zengdao") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (player.GetEquips().Count >= 2 && player.GetMark("@zengdao") > 0)
            {
                WrappedCard card = new WrappedCard(ZengdaoCard.ClassName) { Skill = Name, Mute = true };
                card.AddSubCards(player.GetEquips());
                return new List<WrappedCard> { card };
            }

            return null;
        }

        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.From != null && damage.From.Alive && damage.From.GetPile(Name).Count > 0)
                damage.Damage++;
        }
    }

    public class ZengdaoCardAI : UseCard
    {
        public ZengdaoCardAI() : base(ZengdaoCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                Player target = use.To[0];
                if (ai.GetPlayerTendency(target) != "unknown")
                    ai.UpdatePlayerRelation(player, target, true);
            }
        }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> friends = ai.FriendNoSelf;
            if (friends.Count > 0)
            {
                Room room = ai.Room;
                room.SortByActionOrder(ref friends);
                foreach (Player p in friends)
                {
                    if (!ai.WillSkipPlayPhase(p) && ai.HasSkill("liegong_jx|tieqi_jx|xueji|kurou_jx|ganglie_jx", p))
                    {
                        use.Card = card;
                        use.To.Add(p);
                        return;
                    }
                }

                foreach (Player p in friends)
                {
                    if (!ai.WillSkipPlayPhase(p) && (p.GetWeapon() || p.GetOffensiveHorse()))
                    {
                        use.Card = card;
                        use.To.Add(p);
                        return;
                    }
                }
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 1.5;
    }

    public class YinjuAI : SkillEvent
    {
        public YinjuAI() : base("yinju") { }
        public override double TargetValueAdjust(TrustedAI ai, WrappedCard card, Player from, List<Player> targets, Player to)
        {
            if (card != null && from != null && to != null && Engine.GetFunctionCard(card.Name).TypeID != CardType.TypeSkill
                && to.HasFlag(string.Format("{0}_{1}", Name, from.Name)))
            {
                if (ai.IsFriend(from)) return 1.5;
                else if (ai.IsEnemy(from)) return -1.5;
            }
            return 0;
        }
    }

    public class YinjuCardAI : UseCard
    {
        public YinjuCardAI() : base(YinjuCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                Player target = use.To[0];
                if (ai.GetPlayerTendency(target) != "unknown")
                    ai.UpdatePlayerRelation(player, target, true);
            }
        }
    }

    public class QianxinZGAI : SkillEvent
    {
        public QianxinZGAI() : base("qianxin_zg") { }
        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            Room room = ai.Room;
            if (room.GetTag(Name) is List<Player> from)
            {
                foreach (Player p in from)
                {
                    if (ai.IsFriend(p)) return "draw";
                }
                foreach (Player p in from)
                {
                    if (ai.IsEnemy(p))
                    {
                        int max = RoomLogic.GetMaxCards(room, player);
                        if (player.HandcardNum - (max - 2) < 4 - p.HandcardNum) return "max";
                    }
                }
            }

            return "draw";
        }
    }

    public class ZhuilieAI : SkillEvent
    {
        public ZhuilieAI() : base("zhuilie") { }

        public override double TargetValueAdjust(TrustedAI ai, WrappedCard card, Player from, List<Player> targets, Player to)
        {
            double value = 0;
            Room room = ai.Room;
            if (card != null && card.Name.Contains(Slash.ClassName) && from != null && ai.HasSkill(Name) && to != null && !RoomLogic.InMyAttackRange(room, from, to, card))
            {
                if (ai.IsFriend(from, to)) return -10;
                if (ai.IsEnemy(from, to)) return 2;
            }
            return value;
        }
    }

    public class PianchongAI : SkillEvent
    {
        public PianchongAI() : base("pianchong")
        {}

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;
        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            int red = 0, black = 0;
            foreach (int id in player.GetCards("h"))
            {
                if (WrappedCard.IsBlack(ai.Room.GetCard(id).Suit))
                    black++;
                else
                    red++;
            }

            if (red >= black) return "red";
            else return "black";
        }
    }

    public class ZunweiAI : SkillEvent
    {
        public ZunweiAI() : base("zunwei") { }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            if (!player.HasUsed(ZunweiCard.ClassName))
            {
                ai.Target[Name] = null;
                Room room = ai.Room;
                if (player.GetMark("zunwei_3") == 0 && player.GetLostHp() >= 2)
                {
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.Hp - player.Hp >= player.GetLostHp())
                        {
                            result.Add(new WrappedCard(ZunweiCard.ClassName) { Skill = Name });
                            ai.Target[Name] = p;
                            ai.Choice[Name] = "hp";
                            break;
                        }
                    }
                }
                if (ai.Target[Name] == null && player.GetMark("zunwei_1") == 0)
                {
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.HandcardNum - player.HandcardNum >= 3)
                        {
                            result.Add(new WrappedCard(ZunweiCard.ClassName) { Skill = Name });
                            ai.Target[Name] = p;
                            ai.Choice[Name] = "handcard";
                            break;
                        }
                    }
                }
                if (ai.Target[Name] == null && player.GetMark("zunwei_2") == 0)
                {
                    int count = player.GetEquips().Count;
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.GetEquips().Count - count >= 2)
                        {
                            result.Add(new WrappedCard(ZunweiCard.ClassName) { Skill = Name });
                            ai.Target[Name] = p;
                            ai.Choice[Name] = "equip";
                            break;
                        }
                    }
                }
            }
            return result;
        }

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data) => ai.Choice[Name];
    }

    public class ZunweiCardAI : UseCard
    {
        public ZunweiCardAI() : base(ZunweiCard.ClassName) { }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            use.Card = card;
            use.To.Add(ai.Target["zunwei"]);
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 9;
    }

    public class LiluAI : SkillEvent
    {
        public LiluAI() : base("lilu") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (player.MaxHp - player.HandcardNum >= 3 || player.MaxHp - player.HandcardNum >= 1 && ai.FriendNoSelf.Count > 0 && player.HandcardNum + 1 > player.GetMark(Name))
                return true;
            return false;
        }

        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            Room room = ai.Room;
            CardUseStruct use = new CardUseStruct(new WrappedCard(LiluCard.ClassName), player, new List<Player>());
            List<int> ids = player.GetCards("h");
            ai.SortByUseValue(ref ids, false);
            if (ai.FriendNoSelf.Count > 0)
            {
                KeyValuePair<Player, int> valuePair = ai.GetCardNeedPlayer(ids);
                if (player.HandcardNum > player.GetMark(Name))
                {
                    if (valuePair.Key != null && valuePair.Value >= 0)
                    {
                        use.To.Add(valuePair.Key);
                        use.Card.AddSubCard(valuePair.Value);
                        ids.Remove(valuePair.Value);
                    }
                    else
                        use.To.Add(ai.FriendNoSelf[0]);

                    while (use.Card.SubCards.Count <= player.GetMark(Name))
                    {
                        use.Card.AddSubCard(ids[0]);
                        ids.RemoveAt(0);
                    }
                }
                else
                {
                    if (valuePair.Key != null && valuePair.Value >= 0)
                    {
                        use.To.Add(valuePair.Key);
                        use.Card.AddSubCard(valuePair.Value);
                    }
                    else
                    {
                        use.To.Add(ai.FriendNoSelf[0]);
                        use.Card.AddSubCard(ids[0]);
                    }
                }
            }
            else
            {
                use.To.Add(room.GetOtherPlayers(player)[0]);
                use.Card.AddSubCard(ids[0]);
            }

            return use;
        }
    }

    public class YisheDFRAI : SkillEvent
    {
        public YisheDFRAI() : base("yishe_dfr")
        {
            key = new List<string> { "skillInvoke:yishe_dfr:yes" };
        }

        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.ChoiceMade && data is string str && ai.Self != player)
            {
                Room room = ai.Room;
                if (str == key[0])
                {
                    Player target = null;
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.HasFlag(Name))
                        {
                            target = p;
                            break;
                        }
                    }
                    if (ai.GetPlayerTendency(target) != "unknown") ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (data is string str)
            {
                string[] strs = str.Split(':');
                Player target = ai.Room.FindPlayer(strs[1]);
                return ai.IsFriend(target);
            }
            return false;
        }

        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.To.GetMark(Name) > 0 && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName))
                damage.Damage += damage.To.GetMark(Name);
        }
    }

    public class ShunshiAI : SkillEvent
    {
        public ShunshiAI() : base("shunshi")
        { }
        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            CardUseStruct use = new CardUseStruct(null, player, new List<Player>());
            List<int> ids = player.GetCards("he");
            if (ids.Count > 0)
            {
                Room room = ai.Room;
                ai.SortByKeepValue(ref ids, false);
                int red = -1;
                int black = -1;
                foreach (int id in ids)
                {
                    bool is_black = WrappedCard.IsBlack(room.GetCard(id).Suit);
                    if (red == -1 && !is_black)
                        red = id;
                    else if (black == -1 && is_black)
                        black = id;
                }
                if (red > -1)
                {
                    List<Player> friends = new List<Player>(ai.FriendNoSelf);
                    if (friends.Count > 0)
                    {
                        ai.SortByDefense(ref friends, false);
                        foreach (Player p in friends)
                        {
                            if (p.IsWounded())
                            {
                                use.Card = new WrappedCard(ShunshiCard.ClassName) { Skill = Name, Mute = true };
                                use.Card.AddSubCard(red);
                                use.To.Add(p);
                                return use;
                            }
                        }
                    }
                }
                if (black > -1)
                {
                    List<Player> enemies = ai.GetEnemies(player);
                    if (enemies.Count > 0)
                    {
                        ai.SortByDefense(ref enemies, false);
                        use.Card = new WrappedCard(ShunshiCard.ClassName) { Skill = Name, Mute = true };
                        use.Card.AddSubCard(black);
                        use.To.Add(enemies[0]);
                        return use;
                    }
                }
            }

            return use;
        }
    }

    public class ShunshiCardAI : UseCard
    {
        public ShunshiCardAI() : base(ShunshiCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use && player != ai.Self)
            {
                Player target = use.To[0];
                if (ai.GetPlayerTendency(target) != "unknown" && WrappedCard.IsBlack(ai.Room.GetCard(use.Card.GetEffectiveId()).Suit))
                    ai.UpdatePlayerRelation(player, target, false);
            }
        }
    }

    public class XianweiAI : SkillEvent
    {
        public XianweiAI() : base("xianwei")
        {
            key = new List<string> { "playerChosen:xianwei" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (ai.Self == player) return;
            if (data is string choice)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;
                    Player target = room.FindPlayer(choices[2]);

                    if (ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (choice.Contains("Treasure")) return "Treasure";
            else if (choice.Contains("Treasure")) return "Treasure";
            else if (choice.Contains("DefensiveHorse")) return "DefensiveHorse";
            else if (choice.Contains("Armor")) return "Armor";
            else if (choice.Contains("Weapon")) return "Weapon";
            return "OffensiveHorse";
        }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            if (player.GetTag(Name) is int index)
            {
                ai.SortByDefense(ref targets, false);
                foreach (Player p in targets)
                {
                    if (ai.IsFriend(p) && ai.HasSkill(TrustedAI.LoseEquipSkill, p))
                        return new List<Player> { p };
                }
                foreach (Player p in targets)
                {
                    if (ai.IsFriend(p) && !p.HasEquip(index))
                        return new List<Player> { p };
                }
            }

            return new List<Player>();
        }
    }

    public class CuijianAI : SkillEvent
    {
        public CuijianAI() : base("cuijian")
        {}

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(CuijianCard.ClassName))
                return new List<WrappedCard> { new WrappedCard(CuijianCard.ClassName) { Skill = Name } };
            return new List<WrappedCard>();
        }
        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            return base.OnExchange(ai, player, pattern, min, max, pile);
        }
    }

    public class TongyuanAI : SkillEvent
    {
        public TongyuanAI() : base("tongyuan") { }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            Room room = ai.Room;
            if (room.GetTag("extra_target_skill") is CardUseStruct use)
            {
                if (use.Card.Name == Peach.ClassName)
                {
                    ai.SortByDefense(ref targets, false);
                    foreach (Player p in targets)
                    {
                        if (ai.IsFriend(p) && p.IsWounded())
                            return new List<Player> { p };
                    }
                }
                else if (use.Card.Name.Contains(Slash.ClassName))
                {
                    List<ScoreStruct> best = new List<ScoreStruct>();
                    foreach (Player p in targets)
                    {
                        List<ScoreStruct> scores = ai.CaculateSlashIncome(player, new List<WrappedCard> { use.Card }, new List<Player> { p }, false);
                        if (scores.Count > 0 && scores[0].Score > 0)
                            best.Add(scores[0]);
                    }
                    if (best.Count > 0)
                    {
                        best.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
                        return best[0].Players;
                    }
                }
            }

            return new List<Player>();
        }
    }

    public class CuijianCardAI : UseCard
    {
        public CuijianCardAI() : base(CuijianCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                Player target = use.To[0];
                if (ai.GetPlayerTendency(target) != "unknown")
                    ai.UpdatePlayerRelation(player, target, false);
            }
        }

        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> enemies = new List<Player>();
            foreach (Player p in ai.GetEnemies(player))
                if (!p.IsKongcheng()) enemies.Add(p);

            if (enemies.Count > 0)
            {
                ai.SortByDefense(ref enemies, false);
                use.Card = card;
                use.To.Add(enemies[0]);
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 7;
    }

    public class ZhushiAI : SkillEvent
    {
        public ZhushiAI() : base("zhushi")
        {
            key = new List<string> { "skillInvoke:zhushi" };
        }

        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.ChoiceMade && data is string str && ai.Self != player)
            {
                Room room = ai.Room;
                List<string> strs = new List<string>(str.Split(':'));
                if (strs[1] == Name)
                {
                    Player target = null;
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.HasFlag("zhushi_target"))
                        {
                            target = p;
                            break;
                        }
                    }
                    if (ai.GetPlayerTendency(target) != "unknown") ai.UpdatePlayerRelation(player, target, strs[2] == "yes");
                }
            }
        }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (data is Player target && ai.IsFriend(target))
                return true;
            return false;
        }
    }

    public class CaiyiAI : SkillEvent
    {
        public CaiyiAI() : base("caiyi") { }
        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            List<string> choices = new List<string>(choice.Split('+'));
            if (data is int count)
            {
                if (choices.Contains("draw") || choices.Contains("reset") || choices.Contains("recover") || choices.Contains("random_0"))
                {
                    if (choices.Contains("reset") && !player.FaceUp) return "reset";
                    float value_draw = count * 1.2f;
                    float heal = Math.Min(count, player.GetLostHp()) * 2;
                    if (heal > 0) return value_draw > heal ? "draw" : "recover";
                    if (value_draw > 0) return "draw";
                }
                else
                {
                    if (choices.Contains("damaged"))
                    {
                        DamageStruct damage = new DamageStruct(Name, ai.Room.Current, player, count);
                        if (ai.GetDamageScore(damage).Score > -2) return "damaged";
                    }
                    if (choices.Contains("discard")) return "discard";
                }
            }
            return choices[0];
        }
    }

    public class TuoxianAI : SkillEvent
    {
        public TuoxianAI() : base("tuoxian")
        { }

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (data is Player from)
            {
                int count = player.GetMark("tuoxian_count");
                List<int> ids = player.GetCards("hej");
                List<double> values = ai.SortByKeepValue(ref ids, false);
                double value = 0;
                for (int i = 0; i < Math.Min(count, ids.Count); i++)
                    value += values[0];

                if (value <= 0) return "discard";
                if (ai.IsEnemy(ai.Room.Current, from) && ai.Room.Current.HandcardNum >= 3 && ai.IsWeak(from)) return "discard";
            }
            return "invalid";
        }
    }

    public class YizhengCSAI : SkillEvent
    {
        public YizhengCSAI() : base("yizheng_cs")
        {
            key = new List<string> { "playerChosen:yizheng_cs" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (ai.Self == player) return;
            if (data is string choice)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;
                    Player target = room.FindPlayer(choices[2]);

                    if (ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }

        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.From != null && damage.From.ContainsTag("yizheng_from") && damage.From.GetTag("yizheng_from") is string from_name)
            {
                Room room = ai.Room;
                Player from = room.FindPlayer(from_name);
                if (from != null && damage.From.MaxHp < from.MaxHp)
                    damage.Damage++;
            }
        }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            foreach (Player p in targets)
                if (ai.IsFriend(p) && p.MaxHp < player.MaxHp)
                    return new List<Player> { p };

            return new List<Player>();
        }
    }

    public class TunanAI : SkillEvent
    {
        public TunanAI() : base("tunan") { }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            return !player.HasUsed(TunanCard.ClassName) ? new List<WrappedCard> { new WrappedCard(TunanCard.ClassName) { Skill = Name } } : null;
        }

        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            Room room = ai.Room;
            CardUseStruct use = new CardUseStruct(null, player, new List<Player>());
            int id = player.GetMark(Name);

            if (player.HasFlag(Name))
            {
                WrappedCard card = new WrappedCard(Slash.ClassName) { Skill = "_tunan" };
                card.AddSubCard(id);
                card = RoomLogic.ParseUseCard(room, card);
                List<WrappedCard> slashes = new List<WrappedCard> { card };
                List<ScoreStruct> scores = ai.CaculateSlashIncome(player, slashes, null, false);
                if (scores.Count > 0 && scores[0].Score > 0 && scores[0].Players != null && scores[0].Players.Count > 0)
                {
                    use.Card = scores[0].Card;
                    use.To = scores[0].Players;
                }
            }
            else
            {
                WrappedCard card = room.GetCard(id);
                if (card.Name.Contains(Slash.ClassName))
                {
                    List<WrappedCard> slashes = new List<WrappedCard> { card };
                    List<ScoreStruct> scores = ai.CaculateSlashIncome(player, slashes, null, false);
                    if (scores.Count > 0 && scores[0].Score > 0 && scores[0].Players != null && scores[0].Players.Count > 0)
                    {
                        use.Card = card;
                        use.To = scores[0].Players;
                        return use;
                    }
                }
                else
                {
                    WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_tunan" };
                    slash.AddSubCard(id);
                    slash = RoomLogic.ParseUseCard(room, slash);
                    List<WrappedCard> slashes = new List<WrappedCard> { slash };
                    List<ScoreStruct> scores = ai.CaculateSlashIncome(player, slashes, null, false);
                    if (scores.Count > 0 && scores[0].Score > 5 && scores[0].Players != null && scores[0].Players.Count > 0)
                        return use;

                    UseCard e = Engine.GetCardUsage(card.Name);
                    e.Use(ai, player, ref use, card);
                    if (use.Card == card)
                        return use;
                    else
                        use.Card = null;
                }
            }

            return use;
        }
    }

    public class TunanCardAI : UseCard
    {
        public TunanCardAI() : base(TunanCard.ClassName) { }

        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                Player target = use.To[0];
                if (ai.GetPlayerTendency(target) != "unknown")
                    ai.UpdatePlayerRelation(player, target, true);
            }
        }

        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> friends = ai.FriendNoSelf;
            if (friends.Count > 0)
            {
                Room room = ai.Room;
                List<ScoreStruct> scores = new List<ScoreStruct>();
                WrappedCard slash = new WrappedCard(Slash.ClassName);

                foreach (Player p in friends)
                {
                    foreach (Player enemy in ai.GetEnemies(player))
                    {
                        if (RoomLogic.InMyAttackRange(room, p, enemy, slash) && RoomLogic.IsProhibited(room, p, enemy, slash) == null)
                        {
                            ScoreStruct score = new ScoreStruct
                            {
                                Players = new List<Player> { p },
                                Card = slash,
                            };

                            DamageStruct damage = new DamageStruct(slash, p, enemy);
                            if (ai.HasArmorEffect(enemy, Vine.ClassName) && slash.Name == Slash.ClassName && p.HasWeapon(Fan.ClassName))
                            {
                                WrappedCard fan = new WrappedCard(FireSlash.ClassName);
                                fan.AddSubCard(slash);
                                fan = RoomLogic.ParseUseCard(room, fan);
                                damage.Card = fan;
                            }

                            if (damage.Card.Name == FireSlash.ClassName)
                                damage.Nature = DamageStruct.DamageNature.Fire;
                            else if (damage.Card.Name == ThunderSlash.ClassName)
                                damage.Nature = DamageStruct.DamageNature.Thunder;

                            ScoreStruct damage_score = ai.GetDamageScore(damage);
                            if (damage_score.Score > 0)
                            {
                                ScoreStruct effect = ai.SlashIsEffective(damage.Card, p, enemy);
                                if (effect.Score > 0)
                                {
                                    score.Score = effect.Score;
                                    if (effect.Rate > 0)
                                    {
                                        score.Score += Math.Min(1, effect.Rate) * damage_score.Score;
                                        scores.Add(score);
                                    }
                                }
                            }
                        }
                    }
                }
                if (scores.Count > 0)
                {
                    scores.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
                    if (scores[0].Score > 0)
                    {
                        use.To = scores[0].Players;
                        use.Card = card;
                        return;
                    }
                }

                foreach (Player p in friends)
                {
                    if (ai.HasSkill("jiang|jizhi_jx|jizhi", p))
                    {
                        use.Card = card;
                        use.To = new List<Player> { p };
                        return;
                    }
                }

                use.Card = card;
                use.To = new List<Player> { friends[0] };
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card)
        {
            return 9;
        }
    }

    public class ManyiAI : SkillEvent
    {
        public ManyiAI() : base("manyi") { }
        public override bool IsCardEffect(TrustedAI ai, WrappedCard card, Player from, Player to)
        {
            if (ai.HasSkill(Name, to) && card != null && card.Name == SavageAssault.ClassName)
                return false;

            return true;
        }
    }

    public class MansiAI : SkillEvent
    {
        public MansiAI() : base("mansi") { }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            List<WrappedCard> cards = new List<WrappedCard>();
            if (!player.IsKongcheng() && !player.HasUsed("ViewAsSkill_mansiCard"))
            {
                Room room = ai.Room;
                bool invoke = true;
                foreach (int id in player.GetCards("h"))
                {
                    WrappedCard card = room.GetCard(id);
                    if (RoomLogic.IsCardLimited(room, player, card, HandlingMethod.MethodUse))
                        invoke = false;
                }

                if (invoke)
                {
                    WrappedCard card = new WrappedCard(SavageAssault.ClassName) { Skill = Name };
                    card.AddSubCards(player.GetCards("h"));
                    cards.Add(card);
                }

                return cards;
            }
            return cards;
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, CardUseStruct use)
        {
            if (use.Card != null && use.Card.Name == SavageAssault.ClassName && use.Card.GetSkillName() == Name)
                return -10;

            return 0;
        }
    }

    public class XiliAI : SkillEvent
    {
        public XiliAI() : base("xili") { }
        public override List<int> OnDiscard(TrustedAI ai, Player player, List<int> ids, int min, int max, bool option)
        {
            Room room = ai.Room;
            if (room.GetTag(Name) is DamageStruct damage && ai.IsFriend(damage.From))
            {
                ai.SortByKeepValue(ref ids, false);
                if (ai.IsEnemy(damage.To))
                {
                    return new List<int> { ids[0] };
                }
                else
                {
                    DamageStruct new_damage = new DamageStruct(damage.Reason, damage.From, damage.To, damage.Damage + 1, damage.Nature)
                    {
                        Card = damage.Card,
                        Chain = damage.Chain,
                        Transfer = damage.Transfer,
                        TransferReason = damage.TransferReason
                    };
                    if (ai.GetDamageScore(damage).Score >= ai.GetDamageScore(new_damage).Score)
                        return new List<int> { ids[0] };
                }
            }

            return new List<int>();
        }
    }

    public class SouyingAI : SkillEvent
    {
        public SouyingAI() : base("souying"){}
        public override List<int> OnDiscard(TrustedAI ai, Player player, List<int> ids, int min, int max, bool option)
        {
            return base.OnDiscard(ai, player, ids, min, max, option);
        }
    }

    public class ZhanyuanAI : SkillEvent
    {
        public ZhanyuanAI() : base("zhanyuan") { }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            ai.SortByDefense(ref targets);
            foreach (Player p in targets)
                if (ai.IsFriend(p)) return new List<Player> { p };

            return new List<Player>();
        }
    }

    public class YouyanAI : SkillEvent
    {
        public YouyanAI() : base("youyan") { }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;
    }

    public class ZhuihuanAI : SkillEvent
    {
        public ZhuihuanAI() : base("zhuihuan")
        {
            key = new List<string> { "playerChosen:zhuihuan" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (ai.Self == player) return;
            if (data is string choice)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;
                    Player target = room.FindPlayer(choices[2]);

                    if (target != player && ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            List<Player> friends = ai.GetFriends(player);
            ai.SortByDefense(ref friends, false);
            return new List<Player> { friends[0] };
        }
        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (data is Player target)
            {
                if (ai.IsFriend(target))
                {
                    if (!target.FaceUp) return "reset";
                    return "recover";
                }
            }
            return "cancel";
        }
    }

    public class BazhanAI : SkillEvent
    {
        public BazhanAI() : base("bazhan") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(BazhanCard.ClassName))
                return new List<WrappedCard> { new WrappedCard(BazhanCard.ClassName) { Skill = Name } };
            return new List<WrappedCard>();
        }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;
    }

    public class BazhanCardAI : UseCard
    {
        public BazhanCardAI() : base(BazhanCard.ClassName) { }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            Room room = ai.Room;
            if (player.GetMark("bazhan") == 1)
            {
                List<Player> enemies = new List<Player>();
                foreach (Player p in ai.GetEnemies(player))
                    if (!p.IsKongcheng() && RoomLogic.CanGetCard(room, player, p, "h"))
                        enemies.Add(p);
                if (enemies.Count > 0)
                {
                    use.Card = card;
                    ai.SortByDefense(ref enemies, false);
                    foreach (Player p in enemies)
                    {
                        if (p.HandcardNum >= 2)
                        {
                            use.To.Add(p);
                            return;
                        }
                    }
                    use.To.Add(enemies[0]);
                }
            }
            else if (player.HandcardNum > 0)
            {
                List<int> heart = new List<int>();
                foreach (int id in player.GetCards("h"))
                    if (room.GetCard(id).Suit == WrappedCard.CardSuit.Heart || room.GetCard(id).Name == Analeptic.ClassName)
                        heart.Add(id);

                List<Player> friends = ai.FriendNoSelf;
                if (friends.Count > 0)
                {
                    ai.SortByDefense(ref friends, false);
                    if (heart.Count > 0)
                    {
                        foreach (Player p in friends)
                        {
                            if (p.IsWounded())
                            {
                                ai.SortByUseValue(ref heart, false);
                                use.Card = card;
                                use.To.Add(p);
                                use.Card.AddSubCard(heart[0]);
                                return;
                            }
                        }
                    }
                    List<int> ids = player.GetCards("h");
                    KeyValuePair<Player, int> keys = ai.GetCardNeedPlayer(ids, friends);
                    if (keys.Key != null && keys.Value >= 0)
                    {
                        use.Card = card;
                        use.To.Add(keys.Key);
                        use.Card.AddSubCard(keys.Value);

                        ids.Remove(keys.Value);
                        KeyValuePair<Player, int> keys2 = ai.GetCardNeedPlayer(ids, new List<Player> { keys.Key });
                        if (keys2.Key != null && keys2.Value >= 0) use.Card.AddSubCard(keys2.Value);
                    }
                }
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => player.GetMark("bazhan") == 1 ? 5 : 1;
    }

    public class JiaoyingAI : SkillEvent
    {
        public JiaoyingAI() : base("jiaoying")
        {
            key = new List<string> { "playerChosen:jiaoying" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (ai.Self == player) return;
            if (data is string choice)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;
                    Player target = room.FindPlayer(choices[2]);

                    if (ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            int _min = 10;
            foreach (Player p in targets)
                if (ai.IsFriend(p) && p.HandcardNum < _min) _min = p.HandcardNum;
            foreach (Player p in targets)
                if (ai.IsFriend(p) && p.HandcardNum == _min) return new List<Player> { p };
            return new List<Player>();
        }
    }

    public class JianliangAI : SkillEvent
    {
        public JianliangAI() : base("jianliang")
        {
            key = new List<string> { "playerChosen:jianliang" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (ai.Self == player) return;
            if (data is string choice)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;
                    string[] strs = choices[2].Split('+');
                    foreach (string str in strs)
                    {
                        Player target = room.FindPlayer(str);
                        if (ai.GetPlayerTendency(target) != "unknown")
                            ai.UpdatePlayerRelation(player, target, true);
                    }
                }
            }
        }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            List<Player> friends = ai.GetFriends(player);
            ai.SortByDefense(ref friends, false);

            List<Player> result = new List<Player>();
            for (int i = 0; i < Math.Min(2, friends.Count); i++)
                result.Add(friends[i]);
            return result;
        }
    }

    public class WeimengAI : SkillEvent
    {
        public WeimengAI() : base("weimeng") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(WeimengHCard.ClassName))
                return new List<WrappedCard> { new WrappedCard(WeimengCard.ClassName) { Skill = Name } };

            return new List<WrappedCard>();
        }
        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            List<int> ids = new List<int>();
            List<int> cards = player.GetCards("he");
            ai.SortByUseValue(ref cards, false);
            for (int i = 0; i < Math.Min(cards.Count, min); i++)
                ids.Add(cards[i]);

            return ids;
        }
    }

    public class WeimengCardAI : UseCard
    {
        public WeimengCardAI() : base(WeimengCard.ClassName) { }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> enemies = ai.GetEnemies(player);
            if (enemies.Count > 0)
            {
                ai.SortByDefense(ref enemies, false);
                foreach (Player p in enemies)
                {
                    if (!p.IsKongcheng())
                    {
                        use.Card = card;
                        use.To.Add(p);
                        return;
                    }
                }
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 7;
    }

    public class QuanjianAI : SkillEvent
    {
        public QuanjianAI() : base("quanjian") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasFlag("quanjian_draw") || !player.HasFlag("quanjian_damage"))
                return new List<WrappedCard> { new WrappedCard(QuanjianCard.ClassName) { Skill = Name } };
            return new List<WrappedCard>();
        }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (data is string str)
            {
                if (str.StartsWith("@quanjian-draw"))
                    return true;
                else
                {
                    Room room = ai.Room;
                    string[] strs = str.Split(':');
                    Player victim = room.FindPlayer(strs[2]);
                    DamageStruct damage = new DamageStruct(Name, player, victim);
                    if (ai.GetDamageScore(damage).Score >= -1)
                        return true;
                }
            }
            return false;
        }

        public override List<int> OnDiscard(TrustedAI ai, Player player, List<int> ids, int min, int max, bool option)
        {
            if (min <= 2)
            {
                Room room = ai.Room;
                List<int> cards = new List<int>(), result = new List<int>();
                foreach (int id in player.GetCards("h"))
                    if (RoomLogic.CanDiscard(room, player, player, id)) cards.Add(id);

                if (cards.Count >= min)
                {
                    ai.SortByKeepValue(ref cards, false);
                    for (int i = 0; i < min; i++)
                        result.Add(cards[i]);

                    return result;
                }
            }
            return new List<int>();
        }

        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            damage.Damage += damage.To.GetMark(Name);
        }
    }

    public class QuanjianCardAI : UseCard
    {
        public QuanjianCardAI() : base(QuanjianCard.ClassName) { }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            if (!player.HasFlag("quanjian_draw"))
            {
                List<Player> friends = ai.FriendNoSelf;
                friends.RemoveAll(t => t.HandcardNum >= 5 || t.HandcardNum >= t.MaxHp);

                if (friends.Count > 0)
                {
                    use.Card = card;
                    friends.Sort((x, y) => { return Math.Min(5, x.MaxHp) - x.HandcardNum > Math.Min(5, y.MaxHp) - y.HandcardNum ? -1 : 1; });
                    foreach (Player p in friends)
                    {
                        if (!ai.WillSkipPlayPhase(p) && !ai.HasSkill("zishu", p))
                        {
                            use.To.Add(p);
                            return;
                        }
                    }

                    use.To.Add(friends[0]);
                    return;
                }
                List<Player> enmies = ai.GetEnemies(player);
                if (enmies.Count > 0)
                {
                    ai.SortByHandcards(ref enmies);
                    if (enmies[0].HandcardNum > enmies[0].MaxHp)
                    {
                        use.Card = card;
                        use.To.Add(enmies[0]);
                        return;
                    }
                    ai.SortByHp(ref enmies, false);
                    foreach (Player p in enmies)
                    {
                        if (p.Hp == 1 && p.MaxHp - p.HandcardNum <= 2 && Slash.IsAvailable(ai.Room, player) && player.GetCards(Slash.ClassName).Count > 0
                            && RoomLogic.InMyAttackRange(ai.Room, player, p))
                        {
                            use.Card = card;
                            use.To.Add(p);
                            return;
                        }
                    }
                }
            }
            else
            {
                Room room = ai.Room;
                List<ScoreStruct> scores = new List<ScoreStruct>();
                foreach (Player p in ai.FriendNoSelf)
                {
                    foreach (Player p2 in room.GetOtherPlayers(p))
                    {
                        if (RoomLogic.InMyAttackRange(room, p, p2))
                        {
                            ScoreStruct score = ai.GetDamageScore(new DamageStruct(Name, p, p2));
                            if (score.Score > 0)
                            {
                                score.Players = new List<Player> { p, p2 };
                                scores.Add(score);
                            }
                        }
                    }
                }
                if (scores.Count > 0)
                {
                    scores.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
                    use.Card = card;
                    use.To = scores[0].Players;
                    return;
                }
                scores.Clear();
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    foreach (Player p2 in room.GetOtherPlayers(p))
                    {
                        if (RoomLogic.InMyAttackRange(room, p, p2))
                        {
                            ScoreStruct score = ai.GetDamageScore(new DamageStruct(Name, p, p2));
                            if (score.Score > 0)
                            {
                                score.Players = new List<Player> { p, p2 };
                                scores.Add(score);
                            }
                        }
                    }
                }
            }
        }
        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 4;
    }

    public class TujueAI : SkillEvent
    {
        public TujueAI() : base("tujue") { }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            List<Player> friends = ai.FriendNoSelf;
            foreach (Player p in friends)
            {
                if (ai.HasSkill(TrustedAI.CardneedSkill, p) && (!ai.WillSkipPlayPhase(p) || ai.HasSkill(TrustedAI.NotActiveCardneedSkill, p)))
                    return new List<Player> { p };
            }
            foreach (Player p in friends)
            {
                if (!ai.WillSkipPlayPhase(p) && !ai.HasSkill("zishu", p))
                    return new List<Player> { p };
            }
            if (friends.Count > 0) return new List<Player> { friends[0] };
            foreach (Player p in ai.Room.GetOtherPlayers(player))
                if (ai.WillSkipPlayPhase(p) || ai.HasSkill("zishu", p))
                    return new List<Player> { p };

            return new List<Player> { targets[0] };
        }
    }

    public class XunbieAI : SkillEvent
    {
        public XunbieAI() : base("xunbie") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;
        public override string OnChoice(TrustedAI ai, Player player, string choice, object data) => "mifuren";
        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.To.HasFlag(Name)) damage.Damage = -10;
        }
    }

    public class GuolunAI : SkillEvent
    {
        public GuolunAI() : base("guolun") { key = new List<string> { "cardExchange:guolun" }; }

        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.ChoiceMade && data is string str && ai.Self != player)
            {
                string[] strs = str.Split(':');
                if (strs[1] == Name)
                {
                    Player target = null;
                    Room room = ai.Room;
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.HasFlag(Name))
                        {
                            target = p;
                            break;
                        }
                    }
                    int id = player.GetMark(Name);
                    if (int.TryParse(strs[2], out int give) && ai.GetPlayerTendency(target) != "unknown" && room.GetCard(id).Number < room.GetCard(give).Number)
                        ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.IsKongcheng() && !player.HasUsed(GuolunCard.ClassName))
            {
                return new List<WrappedCard> { new WrappedCard(GuolunCard.ClassName) { Skill = Name } };
            }

            return new List<WrappedCard>();
        }
        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            int id = player.GetMark(Name);
            List<int> ids = player.GetCards("h");
            ai.SortByUseValue(ref ids, false);
            Player target = null;
            Room room = ai.Room;
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (p.HasFlag(Name))
                {
                    target = p;
                    break;
                }
            }

            if (ai.IsFriend(target))
            {
                KeyValuePair<Player, int> pair = ai.GetCardNeedPlayer(ids, new List<Player> { target });
                if (pair.Key == target && (room.GetCard(pair.Value).Number != room.GetCard(id).Number || ai.HasSkill("zhanji")))
                {
                    return new List<int> { pair.Value };
                }

                double value = ai.GetKeepValue(id, target, Place.PlaceHand);
                foreach (int card in ids)
                {
                    double keep = ai.GetKeepValue(card, target, Place.PlaceHand);
                    if (room.GetCard(card).Number != room.GetCard(id).Number && keep >= value)
                        return new List<int> { card };
                }
                if (ai.HasSkill("zhanji"))
                {
                    foreach (int card in ids)
                    {
                        if (room.GetCard(card).Number != room.GetCard(id).Number)
                            return new List<int> { card };
                    }

                    return new List<int> { ids[0] };
                }
            }
            else
            {
                double value = ai.GetUseValue(id, player, Place.PlaceHand);
                foreach (int card in ids)
                {
                    double keep = ai.GetKeepValue(card, target, Place.PlaceHand);
                    if (room.GetCard(card).Number < room.GetCard(id).Number && keep < value)
                        return new List<int> { card };
                }

                if (ai.HasSkill("zhanji"))
                {
                    foreach (int card in ids)
                    {
                        double keep = ai.GetKeepValue(card, target, Place.PlaceHand);
                        if (room.GetCard(card).Number == room.GetCard(id).Number && keep < value)
                            return new List<int> { card };
                    }
                }
            }

            return new List<int>();
        }
    }

    public class GuolunCardAI : UseCard
    {
        public GuolunCardAI() : base(GuolunCard.ClassName) { }

        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            ai.Number[Name] = 2.9;
            List<int> ids = player.GetCards("h");
            if (ids.Count > 0)
            {
                Room room = ai.Room;
                ai.SortByUseValue(ref ids);
                int give = -1;
                foreach (int id in ids)
                {
                    if (ai.GetUseValue(id, player) < 2 && room.GetCard(id).Number < 5)
                    {
                        give = id;
                        break;
                    }
                }

                if (give >= 0)
                {
                    List<Player> enemies = ai.GetEnemies(player);
                    ai.SortByDefense(ref enemies, false);
                    foreach (Player p in enemies)
                    {
                        if (!p.IsKongcheng())
                        {
                            ai.Number[Name] = 9;
                            use.Card = card;
                            use.To = new List<Player> { p };
                            return;
                        }
                    }
                }

                List<Player> friends = ai.FriendNoSelf;
                ai.SortByDefense(ref friends);
                foreach (Player p in friends)
                {
                    if (!p.IsKongcheng())
                    {
                        use.Card = card;
                        use.To = new List<Player> { p };
                        return;
                    }
                }
            }
            foreach (Player p in ai.GetEnemies(player))
            {
                if (!p.IsKongcheng() && ai.GetKnownCards(p).Count < p.HandcardNum)
                {
                    use.Card = card;
                    use.To = new List<Player> { p };
                    return;
                }
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card)
        {
            return ai.Number[Name];
        }
    }

    public class SongSangAI : SkillEvent
    {
        public SongSangAI() : base("songsang") { }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            return true;
        }
    }

    public class QinguoAI : SkillEvent
    {
        public QinguoAI() : base("qinguo") { }

        public override double CardValue(TrustedAI ai, Player player, WrappedCard card, bool isUse, Place place)
        {
            return card != null && !card.IsVirtualCard() && Engine.GetFunctionCard(card.Name) is EquipCard ? 2 : 0;
        }

        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            CardUseStruct use = new CardUseStruct(null, player, new List<Player>());
            WrappedCard card = new WrappedCard(Slash.ClassName) { Skill = Name, ShowSkill = Name };
            List<WrappedCard> slashes = new List<WrappedCard> { card };
            List<ScoreStruct> scores = ai.CaculateSlashIncome(player, slashes, null, false);
            if (scores.Count > 0 && scores[0].Score > 0 && scores[0].Players != null && scores[0].Players.Count > 0)
            {
                use.Card = scores[0].Card;
                use.To = scores[0].Players;
            }

            return use;
        }
    }

    public class YoudiAI : SkillEvent
    {
        public YoudiAI() : base("youdi")
        {
            key = new List<string> { "cardChosen:youdi" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            //针对所选择的卡牌判断敌友
            Room room = ai.Room;
            if (triggerEvent == TriggerEvent.ChoiceMade && data is string str)
            {
                List<string> strs = new List<string>(str.Split(':'));
                if (strs[1] == Name)
                {
                    int card_id = int.Parse(strs[2]);
                    Player target = room.FindPlayer(strs[4]);

                    if (room.GetCardPlace(card_id) == Place.PlaceEquip)
                        ai.UpdatePlayerRelation(player, target, ai.GetKeepValue(card_id, target, Place.PlaceEquip) <= 0);
                    else
                        ai.UpdatePlayerRelation(player, target, false);
                }
            }
        }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            List<int> ids = player.GetCards("h");
            Room room = ai.Room;
            int slash = 0, black = 0;
            foreach (int id in ids)
            {
                WrappedCard card = room.GetCard(id);
                if (WrappedCard.IsBlack(card.Suit)) black++;
                if (card.Name.Contains(Slash.ClassName)) slash++;
            }
            if ((double)(slash + black) / (ids.Count * 2) >= (double)1 / 3) return new List<Player>();

            List<ScoreStruct> scores = new List<ScoreStruct>();
            foreach (Player p in targets)
            {
                if (!RoomLogic.CanGetCard(room, player, p, "he")) continue;
                if (ai.IsFriend(p))
                {
                    bool lose = false;
                    foreach (int id in p.GetEquips())
                    {
                        if (ai.GetKeepValue(id, p, Place.PlaceEquip) < 0)
                        {
                            lose = true;
                            break;
                        }
                    }
                    if (lose)
                        scores.Add(ai.FindCards2Discard(player, p, Name, "he", HandlingMethod.MethodGet));
                }
                else
                {
                    scores.Add(ai.FindCards2Discard(player, p, Name, "he", HandlingMethod.MethodGet));
                }
            }

            if (scores.Count > 0)
            {
                scores.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
                if (scores[0].Score > 0)
                    return scores[0].Players;
            }

            return new List<Player>();
        }

        public override double CardValue(TrustedAI ai, Player player, WrappedCard card, bool isUse, Place place)
        {
            double value = 0;
            if (ai.HasSkill(Name, player) && player.Phase == PlayerPhase.Discard && !isUse)
            {
                Room room = ai.Room;
                if (card.Name.Contains(Slash.ClassName) && room.GetCardPlace(card.GetEffectiveId()) == Place.PlaceHand) return value -=2;
                if (WrappedCard.IsBlack(card.Suit) && room.GetCardPlace(card.GetEffectiveId()) == Place.PlaceHand) value -= 2;
            }

            return value;
        }
    }

    public class DuanfaAI : SkillEvent
    {
        public DuanfaAI() : base("duanfa") { }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (player.GetMark(Name) < player.MaxHp)
            {
                Room room = ai.Room;
                List<int> sub = new List<int>();
                List<int> ids = player.GetCards("he");
                if (ids.Count > 0)
                {
                    List<double> values = ai.SortByKeepValue(ref ids, false);
                    for (int i = 0; i < ids.Count; i++)
                    {
                        if (values[i] < 0)
                        {
                            if (RoomLogic.CanDiscard(room, player, player, ids[i]) && WrappedCard.IsBlack(room.GetCard(ids[i]).Suit))
                                sub.Add(ids[i]);
                        }
                        else
                            break;

                        if (sub.Count + player.GetMark(Name) >= player.MaxHp)
                            break;
                    }
                }

                List<int> hands = player.GetCards("h");
                hands.RemoveAll(t => sub.Contains(t));
                if (hands.Count > 0)
                {
                    ai.SortByUseValue(ref hands, false);
                    foreach (int id in hands)
                    {
                        if (RoomLogic.CanDiscard(room, player, player, id) && WrappedCard.IsBlack(room.GetCard(id).Suit))
                            sub.Add(id);

                        if (sub.Count + player.GetMark(Name) >= player.MaxHp)
                            break;
                    }
                }

                if (sub.Count > 0)
                {
                    WrappedCard zhiheng_card = new WrappedCard(DuanfaCard.ClassName)
                    {
                        Skill = Name,
                        ShowSkill = Name
                    };
                    zhiheng_card.AddSubCards(sub);
                    return new List<WrappedCard> { zhiheng_card };
                }
            }

            return new List<WrappedCard>();
        }
    }

    public class DuanfaCardAI : UseCard
    {
        public DuanfaCardAI() : base(DuanfaCard.ClassName) { }

        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            use.Card = card;
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card)
        {
            return 1;
        }
    }

    public class GuanweiAI : SkillEvent
    {
        public GuanweiAI() : base("guanwei")
        {
            key = new List<string> { "cardDiscard:guanwei" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            Room room = ai.Room;
            if (data is string choice && player != room.Current)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    if (ai.GetPlayerTendency(room.Current) != "unknown")
                        ai.UpdatePlayerRelation(player, room.Current, true);
                }
            }
        }

        public override List<int> OnDiscard(TrustedAI ai, Player player, List<int> cards, int min, int max, bool option)
        {
            Room room = ai.Room;
            if (ai.IsFriend(room.Current) && (ai.IsSituationClear() || ai.IsWeak(room.Current)))
            {
                List<int> ids = new List<int>();
                foreach (int id in player.GetCards("he"))
                    if (RoomLogic.CanDiscard(room, player, player, id))
                        ids.Add(id);

                if (ids.Count > 0)
                {
                    List<double> values = new List<double>();
                    if (room.Current == player)
                        values = ai.SortByUseValue(ref ids, false);
                    else
                        values = ai.SortByKeepValue(ref ids, false);

                    return new List<int> { ids[0] };
                }
            }

            return new List<int>();
        }
    }

    public class GongqingAI : SkillEvent
    {
        public GongqingAI() : base("gongqing") { }
        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.From != null && damage.From.Alive && ai.HasSkill(Name, damage.To) && step == DamageStruct.DamageStep.Done)
            {
                bool weapon = true;
                if (damage.Card != null && damage.Card.SubCards.Contains(damage.From.Weapon.Key))
                    weapon = false;
                int range = RoomLogic.GetAttackRange(ai.Room, damage.From, weapon);
                if (range > 3) damage.Damage++;
            }
        }
    }

    public class BiaozhaoAI : SkillEvent
    {
        public BiaozhaoAI() : base("biaozhao")
        {
            key = new List<string> { "playerChosen:juedi" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (ai.Self == player) return;
            if (data is string choice)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;
                    Player target = room.FindPlayer(choices[2]);

                    if (ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            Room room = ai.Room;
            int count = 0;
            foreach (Player p in room.GetAlivePlayers())
                if (p.HandcardNum > count) count = p.HandcardNum;
            
            double value = 0;
            Dictionary<Player, double> points = new Dictionary<Player, double>();
            foreach (Player p in targets)
            {
                if (!ai.IsFriend(p) || ai.HasSkill("zishu", p)) continue;
                int draw = Math.Min(count - p.HandcardNum, 5);
                double _value = draw * 1.5;
                if (p.IsWounded()) _value += 3;
                if (ai.HasSkill(TrustedAI.CardneedSkill, p)) _value += draw;
                points[p] = _value;
            }

            if (points.Count > 0)
            {
                List<Player> frineds = new List<Player>(points.Keys);
                frineds.Sort((x, y) => { return points[x] > points[y] ? -1 : 1; });
                if (value < points[frineds[0]]) return new List<Player> { frineds[0] };
            }

            return new List<Player>();
        }
        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            List<int> ids = player.GetCards("he");
            if (ids.Count > 0)
            {
                List<double> values = ai.SortByKeepValue(ref ids, false);
                if (values[0] < 6) return new List<int> { ids[0] };
            }

            return new List<int>();
        }
    }

    public class YechouAI : SkillEvent
    {
        public YechouAI() : base("yechou") { }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            if (ai is StupidAI && (player.GetRoleEnum() == PlayerRole.Loyalist || player.GetRoleEnum() == PlayerRole.Rebel))
            {
                Room room = ai.Room;
                Dictionary<Player, double> points = new Dictionary<Player, double>();
                foreach (Player p in targets)
                {
                    if (!ai.IsEnemy(p)) continue;
                    double basic = 1;
                    if (player.GetRoleEnum() == PlayerRole.Rebel && p.GetRoleEnum() != PlayerRole.Lord) basic = 0.6;
                    int count = 1;
                    Player next = room.GetNextAlive(room.Current, 1, false);
                    while (next != p)
                    {
                        if (next.FaceUp)
                            count++;
                        next = room.GetNextAlive(next, 1, false);
                    }
                    points[p] = count * basic;
                }

                if (points.Count > 0)
                {
                    List<Player> players = new List<Player>(points.Keys);
                    players.Sort((x, y) => { return points[x] > points[y] ? -1 : 1; });
                    return new List<Player> { players[0] };
                }
            }

            return new List<Player>();
        }

        public override ScoreStruct GetDamageScore(TrustedAI ai, DamageStruct damage)
        {
            ScoreStruct score = new ScoreStruct
            {
                Score = 0
            };
            if (ai is StupidAI _ai && ai.HasSkill(Name, damage.To) && damage.Damage >= damage.To.Hp && ai.IsSituationClear())
            {
                Room room = ai.Room;
                if ((_ai.GetRolePitts(PlayerRole.Rebel) > 1 || _ai.GetRolePitts(PlayerRole.Renegade) > 0) && ai.GetPlayerTendency(damage.To) == "rebel")
                {
                    Player lord = null;
                    foreach (Player p in room.GetAlivePlayers())
                    {
                        if (p.GetRoleEnum() == PlayerRole.Lord && p.GetLostHp() > 1)
                        {
                            lord = p;
                            break;
                        }
                    }

                    if (lord != null)
                    {
                        int count = 1;
                        Player next = room.GetNextAlive(room.Current, 1, false);
                        while (next != lord)
                        {
                            if (next.FaceUp && next != damage.To)
                                count++;
                            next = room.GetNextAlive(next, 1, false);
                        }

                        if (count > lord.Hp)
                        {
                            switch (ai.Self.GetRoleEnum())
                            {
                                case PlayerRole.Lord:
                                case PlayerRole.Loyalist:
                                case PlayerRole.Renegade:
                                    score.Score = -40;
                                    break;
                                case PlayerRole.Rebel:
                                    score.Score = 20;
                                    break;
                            }
                        }
                    }
                }
            }

            return score;
        }
    }

    public class ZhafuAI : SkillEvent
    {
        public ZhafuAI() : base("zhafu") { }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (player.GetMark("@zhafu") > 0)
                return new List<WrappedCard> { new WrappedCard(ZhafuCard.ClassName) { Skill = Name, Mute = true } };
            return null;
        }
    }

    public class ZhafuCardAI : UseCard
    {
        public ZhafuCardAI() : base(ZhafuCard.ClassName) { }

        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> enemies = ai.GetEnemies(player);
            if (enemies.Count > 0)
            {
                ai.SortByHandcards(ref enemies);
                foreach (Player p in enemies)
                {
                    if (!ai.WillSkipPlayPhase(p) && p.HandcardNum > 3)
                    {
                        use.Card = card;
                        use.To.Add(p);
                        return;
                    }
                }
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card)
        {
            return 0;
        }
    }

    public class FuhaiAI : SkillEvent
    {
        public FuhaiAI() : base("fuhai") { }
        public override WrappedCard OnCardShow(TrustedAI ai, Player player, Player requestor, object data)
        {
            Room room = ai.Room;
            if (room.GetTag(Name) is int id)
            {
                int target = room.GetCard(id).Number;
                List<int> ids = player.GetCards("h");
                List<double> values = ai.SortByKeepValue(ref ids, false);
                for (int i = 0; i < ids.Count; i++)
                {
                    if (room.GetCard(ids[i]).Number > target && (values[i] < 4 || ai.IsFriend(room.Current) || room.Current.GetMark(Name) > 1))
                        return room.GetCard(ids[i]);
                }

                for (int i = 0; i < ids.Count; i++)
                {
                    if (room.GetCard(ids[i]).Number <= target)
                        return room.GetCard(ids[i]);
                }
            }

            return null;
        }
    }

    public class SongshuAI : SkillEvent
    {
        public SongshuAI() : base("songshu") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasFlag(Name) && !player.IsKongcheng())
                return new List<WrappedCard> { new WrappedCard(SongshuCard.ClassName) { Skill = Name } };

            return null;
        }

        public override WrappedCard OnPindian(TrustedAI ai, Player requestor, List<Player> players)
        {
            if (ai.Self == requestor)
            {
                int id = (int)ai.Number[Name];
                if (id >= 0 && requestor.GetCards("h").Contains(id))
                    return ai.Room.GetCard((int)ai.Number[Name]);

                if (ai.IsFriend(players[0])) return ai.GetMinCard();
            }

            return ai.GetMaxCard();
        }
    }

    public class SongshuCardAI : UseCard
    {
        public SongshuCardAI() : base(SongshuCard.ClassName) { }

        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> friends = ai.FriendNoSelf;
            ai.Number["songshu"] = -1; ai.Number[Name] = 1;
            if (friends.Count > 0)
            {
                Room room = ai.Room;
                List<int> ids = player.GetCards("h");
                List<double> values = ai.SortByUseValue(ref ids, false);
                for (int i = 0; i < ids.Count; i++)
                {
                    if (values[i] < 4)
                    {
                        foreach (Player p in friends)
                        {
                            if (!RoomLogic.CanBePindianBy(room, p, player) || ai.HasSkill("zishu", p)) continue;
                            foreach (int hand in ai.GetKnownCards(p))
                            {
                                if (room.GetCard(hand).Number >= room.GetCard(ids[i]).Number)
                                {
                                    ai.Number[Name] = 4;
                                    ai.Number["songshu"] = ids[i];
                                    use.Card = card;
                                    use.To.Add(p);
                                    return;
                                }
                            }

                            if (p.HandcardNum != ai.GetKnownCards(p).Count && room.GetCard(ids[i]).Number < 6)
                            {
                                ai.Number[Name] = 4;
                                ai.Number["songshu"] = ids[i];
                                use.Card = card;
                                use.To.Add(p);
                                return;
                            }
                        }
                    }
                }

                if (ai.GetOverflow(player) > 0)
                {
                    values = ai.SortByKeepValue(ref ids, false);
                    for (int i = 0; i < ids.Count; i++)
                    {
                        if (values[i] < 6)
                        {
                            foreach (Player p in friends)
                            {
                                if (!RoomLogic.CanBePindianBy(room, p, player) || ai.HasSkill("zishu", p)) continue;
                                foreach (int hand in ai.GetKnownCards(p))
                                {
                                    if (room.GetCard(hand).Number >= room.GetCard(ids[i]).Number)
                                    {
                                        ai.Number["songshu"] = ids[i];
                                        use.Card = card;
                                        use.To.Add(p);
                                        return;
                                    }
                                }

                                if (p.HandcardNum != ai.GetKnownCards(p).Count && room.GetCard(ids[i]).Number < 6)
                                {
                                    ai.Number["songshu"] = ids[i];
                                    use.Card = card;
                                    use.To.Add(p);
                                    return;
                                }
                            }

                            foreach (Player p in ai.GetEnemies(player))
                            {
                                if (RoomLogic.CanBePindianBy(room, p, player) && ai.HasSkill("zishu", p))
                                {
                                    ai.Number["songshu"] = ids[i];
                                    use.Card = card;
                                    use.To.Add(p);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => ai.Number[Name];
    }

    public class SibianAI : SkillEvent
    {
        public SibianAI() : base("sibian") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            Room room = ai.Room;
            room.SortByActionOrder(ref targets);
            foreach (Player p in targets)
                if (ai.IsFriend(p) && !ai.WillSkipPlayPhase(p) && !ai.HasSkill("zishu", p)) return new List<Player> { p };

            foreach (Player p in targets)
                if (ai.IsFriend(p) && !ai.WillSkipPlayPhase(p)) return new List<Player> { p };

            foreach (Player p in targets)
                if (ai.IsFriend(p)) return new List<Player> { p };

            return new List<Player>();
        }
    }


    public class ZhirenAI : SkillEvent
    {
        public ZhirenAI() : base("zhiren")
        {
            key = new List<string> { "cardChosen:zhiren" };
        }

        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            //针对所选择的卡牌判断敌友
            if (ai.Self == player && !(ai is StupidAI)) return;
            Room room = ai.Room;
            if (triggerEvent == TriggerEvent.ChoiceMade && data is string str)
            {
                List<string> strs = new List<string>(str.Split(':'));
                if (strs[1] == Name)
                {
                    int card_id = int.Parse(strs[2]);
                    Player target = room.FindPlayer(strs[4]);
                    if (room.GetCardPlace(card_id) == Place.PlaceJudge)
                    {
                        if (room.GetCard(card_id).Name != Lightning.ClassName)
                            ai.UpdatePlayerRelation(player, target, true);
                        else
                        {
                            Player winner = ai.GetWizzardRaceWinner(room.GetCard(card_id).Name, target, target);
                            if (winner != null && ai.IsFriend(winner, target))
                                ai.UpdatePlayerRelation(player, target, false);
                            else
                                ai.UpdatePlayerRelation(player, target, true);
                        }
                    }
                    else if (room.GetCardPlace(card_id) == Place.PlaceEquip)
                        ai.UpdatePlayerRelation(player, target, ai.GetKeepValue(card_id, target, Player.Place.PlaceEquip) > 0 ? false : true);
                }
            }
        }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            string flag = "ej";
            if (player.HasFlag("zhiren_e")) flag = "e";
            else if (player.HasFlag("zhiren_j")) flag = "j";
            Room room = ai.Room;
            List<ScoreStruct> scores = new List<ScoreStruct>();
            foreach (Player p in targets)
                scores.Add(ai.FindCards2Discard(player, p, Name, flag, HandlingMethod.MethodDiscard));

            scores.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });

            //room.Debug(string.Format("first {0} last {1}", scores[0].Score, scores[scores.Count - 1].Score));
            if (scores[0].Score > 0) return scores[0].Players;
            return new List<Player>();
        }

        public override AskForMoveCardsStruct OnMoveCards(TrustedAI ai, Player player, List<int> ups, List<int> downs, int min, int max) => ai.Guanxing(ups);
    }

    public class YanerAI : SkillEvent
    {
        public YanerAI() : base("yaner")
        {
            key = new List<string> { "skillInvoke:yaner:yes" };
        }

        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.ChoiceMade && data is string str && ai.Self != player)
            {
                Room room = ai.Room;
                if (str == key[0])
                {
                    Player target = null;
                    foreach (Player p in room.GetOtherPlayers(player))
                    {
                        if (p.HasFlag("yaner_target"))
                        {
                            target = p;
                            break;
                        }
                    }
                    if (ai.GetPlayerTendency(target) != "unknown") ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (data is Player target)
                return ai.IsFriend(target);
            return false;
        }
    }

    public class ZhukouAI : SkillEvent
    {
        public ZhukouAI() : base("zhukou") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (data is string str && str.StartsWith("@zhukou-draw"))
                return true;

            return false;
        }

        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            CardUseStruct use = new CardUseStruct(null, player, new List<Player>());
            Room room = ai.Room;

            List<Player> victims = new List<Player>();
            List<ScoreStruct> scores = new List<ScoreStruct>();
            foreach (Player p in ai.Room.GetOtherPlayers(player))
            {
                ScoreStruct score = ai.GetDamageScore(new DamageStruct(Name, player, p));
                score.Players = new List<Player> { p };
                scores.Add(score);
            }
            double value = 0;
            scores.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
            for (int i = 0; i < Math.Min(2, scores.Count); i++)
            {
                value += scores[i].Score;
                victims.AddRange(scores[i].Players);
            }

            if (value > 0)
            {
                use.Card = new WrappedCard(ZhukouCard.ClassName);
                use.To = victims;
            }

            return use;
        }
    }

    public class YuyunAI : SkillEvent
    {
        public YuyunAI() : base("yuyun") { }
        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (choice.Contains("maxhp"))
                return player.Hp < player.MaxHp && player.GetLostHp() > 1 ? "maxhp" : "hp";
            else if (choice.Contains("draw"))
                return "draw";
            else if (choice.Contains("full"))
            {
                Room room = ai.Room;
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.HandcardNum <= 5 && p.MaxHp - p.HandcardNum >= 2 && ai.IsFriend(p))
                        return "full";
                }
            }
            else if (choice.Contains("max") && ai.GetOverflow(player) > 3)
                return "max";
            else if (choice.Contains("discard"))
                return "discard";

            return "slash";
        }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            if (player.HasFlag("yuyun_full"))
            {
                foreach (Player p in targets)
                {
                    if (p.MaxHp - p.HandcardNum >= 2 && ai.IsFriend(p))
                        return new List<Player> { p };
                }
            }
            else if (player.HasFlag("yuyun_slash"))
            {
                List<Player> victims = new List<Player>();
                List<ScoreStruct> scores = new List<ScoreStruct>();
                foreach (Player p in targets)
                {
                    ScoreStruct score = ai.GetDamageScore(new DamageStruct(Name, player, p));
                    score.Players = new List<Player> { p };
                    scores.Add(score);
                }
                scores.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
                if (scores[0].Score > 0) return scores[0].Players;
            }
            else
            {
                List<ScoreStruct> scores = new List<ScoreStruct>();
                foreach (Player p in targets)
                    scores.Add(ai.FindCards2Discard(player, p, Name, "hej", HandlingMethod.MethodGet));

                scores.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
                if (scores[0].Score > 0) return scores[0].Players;
            }
            return new List<Player>();
        }
    }

    public class YusuiClassicAI : SkillEvent
    {
        public YusuiClassicAI() : base("yusui_classic") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (data is Player target)
            {
                if (target.Alive && ai.IsEnemy(target) && player.Hp > 1)
                {
                    int count = Math.Min(target.HandcardNum, target.MaxHp);
                    if (count >= 3 || target.Hp - player.Hp - 1 >= 2) return true;
                }
            }
            return false;
        }
    }

    public class BoyanClassicAI : SkillEvent
    {
        public BoyanClassicAI() : base("boyan_classic") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(BoyanCCard.ClassName)) return new List<WrappedCard> { new WrappedCard(BoyanCCard.ClassName) { Skill = Name } };
            return new List<WrappedCard>();
        }
    }

    public class BoyanCCardAI : UseCard
    {
        public BoyanCCardAI() : base(BoyanCCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                foreach (Player p in use.To)
                    if (ai.GetPlayerTendency(p) != "unknown")
                    {
                        int count = Math.Min(5 - p.HandcardNum, p.MaxHp - p.HandcardNum);
                        if (count >= 2)
                            ai.UpdatePlayerRelation(player, p, true);
                        else if (count == 0)
                            ai.UpdatePlayerRelation(player, p, false);
                    }
            }
        }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> friends = ai.FriendNoSelf;
            if (friends.Count > 0)
            {
                int max = 0;
                foreach (Player p in friends)
                {
                    int count = Math.Min(5 - p.HandcardNum, p.MaxHp - p.HandcardNum);
                    if (count > max)
                        max = count;
                }

                foreach (Player p in friends)
                {
                    int count = Math.Min(5 - p.HandcardNum, p.MaxHp - p.HandcardNum);
                    if (count == max)
                    {
                        use.Card = card;
                        use.To.Add(p);
                        return;
                    }
                }
            }

            List<Player> enemies = ai.GetEnemies(player);
            if (enemies.Count > 0)
            {
                ai.SortByDefense(ref enemies, false);
                foreach (Player p in enemies)
                {
                    int count = Math.Min(5 - p.HandcardNum, p.MaxHp - p.HandcardNum);
                    if (count == 0)
                    {
                        use.Card = card;
                        use.To.Add(p);
                        return;
                    }
                }
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 3.7;
    }

    public class KannanAI : SkillEvent
    {
        public KannanAI() : base("kannan")
        {
        }

        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.From != null && damage.Card != null && damage.Card.Name.Contains(Slash.ClassName) && damage.From.GetMark(Name) > 0)
            {
                Room room = ai.Room;
                List<CardUseStruct> use_list = room.GetUseList();

                if (use_list.Count == 0 || use_list[use_list.Count - 1].Card != damage.Card)
                    damage.Damage += damage.From.GetMark(Name);
            }
        }

        public override WrappedCard OnPindian(TrustedAI ai, Player requestor, List<Player> players)
        {
            Room room = ai.Room;
            Player player = ai.Self;
            List<int> ids = player.GetCards("h");

            if (player == requestor)
            {
                Player target = players[0];
                ai.SortByUseValue(ref ids, false);
                if (!ai.IsFriend(target))
                {
                    return ai.GetMaxCard();
                }
                else
                    return room.GetCard(ids[0]);
            }
            else
            {
                ai.SortByKeepValue(ref ids, false);
                if (ai.IsFriend(requestor))
                {
                    return room.GetCard(ids[0]);
                }
                else
                    return ai.GetMaxCard();
            }
        }
    }

    public class JiedaoAI : SkillEvent
    {
        public JiedaoAI() : base("jiedao") { }

        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.From != null && ai.HasSkill(Name, damage.From) && damage.From.GetMark(Name) == 0 && damage.From.IsWounded()
                && step <= DamageStruct.DamageStep.Caused && !ai.IsEnemy(damage.From, damage.To))
                damage.Damage += damage.From.GetLostHp();
        }
    }

    public class JixuAI : SkillEvent
    {
        public JixuAI() : base("jixu") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            Room room = ai.Room;
            if (data is CardUseStruct use)
            {
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.HasFlag(Name) && ai.IsFriend(p) && ai.SlashIsEffective(use.Card, p).Score < 0)
                        return false;
                }
            }
            return true;
        }

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            Room room = ai.Room;
            Player target = room.Current;
            foreach (int id in ai.GetKnownCards(player))
            {
                if (room.GetCard(id).Name.Contains(Slash.ClassName))
                    return !ai.IsFriend(target) ? "has" : "nohas";
            }
            if (Shuffle.random(player.HandcardNum, 4)) return !ai.IsFriend(target) ? "has" : "nohas";
            return "nohas";
        }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(JixuCard.ClassName) && !player.IsKongcheng())
                return new List<WrappedCard> { new WrappedCard(JixuCard.ClassName) { Skill = Name } };
            return null;
        }
    }

    public class JixuCardAI : UseCard
    {
        public JixuCardAI() : base(JixuCard.ClassName) { }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> enemies = ai.GetEnemies(player);
            if (enemies.Count > 0)
            {
                ai.SortByDefense(ref enemies, false);
                for (int i = 0; i < Math.Min(player.Hp, enemies.Count); i++)
                    use.To.Add(enemies[i]);
            }
            if (use.To.Count < player.Hp)
            {
                foreach (Player p in ai.Room.GetOtherPlayers(player))
                {
                    if (!use.To.Contains(p))
                    {
                        use.To.Add(p);
                        if (use.To.Count >= player.Hp) break;
                    }
                }
            }
            use.Card = card;
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card)
        {
            List<int> ids = player.GetCards("h");
            bool has = false;
            Room room = ai.Room;
            foreach (int id in ids)
            {
                if (room.GetCard(id).Name.Contains(Slash.ClassName))
                {
                    has = true;
                    break;
                }
            }
            if (ids.Count >= 3) return has ? 2 : 9;
            return 5;
        }
    }

    public class KuizhuLSAI : SkillEvent
    {
        public KuizhuLSAI() : base("kuizhu_ls") { }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            Room room = ai.Room;
            if (player.HasFlag(Name))
            {
                Player target = null;
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    if (p.HasFlag("kuizhu_target"))
                    {
                        target = p;
                        break;
                    }
                }

                foreach (Player p in targets)
                {
                    DamageStruct damage = new DamageStruct(Name, target, p);
                    if (ai.GetDamageScore(damage).Score > 6)
                        return new List<Player> { p };
                }
            }
            else
            {
                ai.SortByHandcards(ref targets);
                foreach (Player p in targets)
                    if (ai.IsFriend(p) && Math.Min(5, p.HandcardNum) - Math.Min(5, targets[0].HandcardNum) >= -1) return new List<Player> { p };

                return new List<Player> { targets[0] };
            }

            return new List<Player>();
        }

        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            Room room = ai.Room;
            Player target = room.Current;
            if (ai.IsFriend(target) && player.GetCardCount(false) >= 2)
            {
                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetOtherPlayers(player))
                    if (RoomLogic.InMyAttackRange(room, player, p)) targets.Add(p);

                bool discard = false;
                if (targets.Count > 0)
                {
                    foreach (Player p in targets)
                    {
                        DamageStruct damage = new DamageStruct(Name, player, p);
                        if (ai.GetDamageScore(damage).Score > 6)
                            discard = true;
                    }
                }

                if (discard)
                {
                    List<int> ids = player.GetCards("h"), subs = new List<int>();
                    ai.SortByKeepValue(ref ids, false);
                    foreach (int id in ids)
                    {
                        if (RoomLogic.CanDiscard(room, player, player, id)) subs.Add(id);
                        if (subs.Count >= 2) break;
                    }

                    if (subs.Count == 2) return subs;
                }
            }
            else if (!ai.IsFriend(target) && room.GetTag(Name) is List<int> ids && !ai.HasSkill("zishu"))
            {
                List<int> hands = new List<int>();
                foreach (int id in player.GetCards("h"))
                    if (RoomLogic.CanDiscard(room, player, player, id)) hands.Add(id);

                if (hands.Count > 0)
                {
                    List<double> hand_values = ai.SortByKeepValue(ref hands, false);
                    List<double> target_values = ai.SortByKeepValue(ref ids);
                    if (hand_values[0] <= target_values[0])
                        return new List<int> { hands[0] };
                }
            }

            return new List<int>();
        }

        public override AskForMoveCardsStruct OnMoveCards(TrustedAI ai, Player player, List<int> ups, List<int> downs, int min, int max)
        {
            List<double> target_values = ai.SortByKeepValue(ref ups);
            AskForMoveCardsStruct move = new AskForMoveCardsStruct
            {
                Top = new List<int>(),
                Bottom = new List<int>(),
                Success = true
            };
            for (int i = 0; i < min; i++)
                move.Bottom.Add(ups[i]);
            ups.RemoveAll(t => move.Bottom.Contains(t));
            move.Top = ups;
            return move;
        }
    }

    public class FenyueAI : SkillEvent
    {
        public FenyueAI() : base("fenyue") { }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.IsKongcheng())
            {
                Room room = ai.Room;
                int count = 0;
                foreach (Player p in room.GetOtherPlayers(player))
                {
                    PlayerRole role = p.GetRoleEnum();
                    if (role == PlayerRole.Lord || role == PlayerRole.Loyalist)
                    {
                        if (player.GetRoleEnum() != PlayerRole.Lord && player.GetRoleEnum() != PlayerRole.Loyalist)
                            count++;
                    }
                    else if (player.GetRoleEnum() != p.GetRoleEnum())
                        count++;
                }
                if (player.UsedTimes(FenyueCard.ClassName) < count)
                {
                    WrappedCard card = new WrappedCard(FenyueCard.ClassName) { Skill = Name };
                    return new List<WrappedCard> { card };
                }
            }

            return null;
        }

        public override WrappedCard OnPindian(TrustedAI ai, Player requestor, List<Player> players)
        {
            if (ai.Self == requestor)
            {
                List<int> ids = requestor.GetCards("h");
                ai.SortByUseValue(ref ids, false);
                return ai.Room.GetCard(ids[0]);
            }
            else
            {
                return ai.GetMaxCard();
            }
        }
    }

    public class FenyueCardAI : UseCard
    {
        public FenyueCardAI() : base(FenyueCard.ClassName)
        {
        }

        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                Player target = use.To[0];
                if (ai.GetPlayerTendency(target) != "unknown")
                    ai.UpdatePlayerRelation(player, target, false);
            }
        }

        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> enemies = ai.GetEnemies(player);
            if (enemies.Count > 0)
            {
                ai.SortByDefense(ref enemies, false);
                foreach (Player p in enemies)
                {
                    if (RoomLogic.CanBePindianBy(ai.Room, p, player))
                    {
                        use.Card = card;
                        use.To.Add(p);
                        return;
                    }
                }
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card)
        {
            return 4;
        }
    }

    public class XuheAI : SkillEvent
    {
        public XuheAI() : base("xuhe") { }

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            double draw = 0;
            double discard = 0;
            Room room = ai.Room;
            if (RoomLogic.CanDiscard(room, player, player, "he")) discard += ai.FindCards2Discard(player, player, Name, "he", HandlingMethod.MethodDiscard).Score;
            draw += 1.5;
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (RoomLogic.DistanceTo(room, player, p) == 1)
                {
                    if (RoomLogic.CanDiscard(room, player, p, "he"))
                        discard += ai.FindCards2Discard(player, p, Name, "he", HandlingMethod.MethodDiscard).Score;

                    draw += ai.HasSkill("zishu", p) ? 0 : ai.IsFriend(p) ? 1.5 : -1.5;
                }
            }
            if (draw >= discard && draw > 2)
                return "draw";
            else if (discard >= draw && discard > 2)
                return "discard";

            return "cancle";
        }
    }

    public class ShiyuanAI : SkillEvent
    {
        public ShiyuanAI() : base("shiyuan") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;
    }

    public class DushiAI : SkillEvent
    {
        public DushiAI() : base("dushi") { }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            List<Player> enemies = ai.GetEnemies(player);
            if (player.GetRoleEnum() == PlayerRole.Loyalist)
            {
                foreach (Player p in enemies)
                    if (p.GetRoleEnum() == PlayerRole.Lord)
                        return new List<Player> { p };
            }
            if (enemies.Count > 0) return new List<Player> { enemies[0] };
            return new List<Player> { targets[0] };
        }
    }

    public class ZhuideAI : SkillEvent
    {
        public ZhuideAI() : base("zhuide") { }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            List<Player> friends = ai.FriendNoSelf;
            if (friends.Count > 1) ai.SortByDefense(ref friends, false);
            if (friends.Count > 0) return new List<Player> { friends[0] };
            return new List<Player>();
        }
    }

    public class MinsiAI : SkillEvent
    {
        public MinsiAI() : base("minsi") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(MinsiCard.ClassName))
            {
                Room room = ai.Room;
                List<int> cards = player.GetCards("he");
                List<List<int>> result = new List<List<int>>();
                for (int i = 1; i <= cards.Count; i++)
                {
                    List<List<int>> top = TrustedAI.GetCombinationList(new List<int>(cards), i);
                    foreach (List<int> comb in top)
                    {
                        int count = 0;
                        foreach (int id in comb)
                            count += room.GetCard(id).Number;

                        if (count == 13)
                            result.Add(comb);
                    }
                }

                if (result.Count > 0)
                {
                    if (result.Count > 2)
                        result.Sort((x, y) => { return x.Count > y.Count ? -1 : 1; });

                    WrappedCard ms = new WrappedCard(MinsiCard.ClassName) { Skill = Name };
                    ms.AddSubCards(result[0]);
                    return new List<WrappedCard> { ms };
                }
            }
            return null;
        }
    }

    public class MinsiCardAI : UseCard
    {
        public MinsiCardAI() : base(MinsiCard.ClassName) { }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            use.Card = card;
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 6.5;
    }

    public class JijingAI : SkillEvent
    {
        public JijingAI() : base("jijing") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;
        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            int count = player.GetMark(Name);
            CardUseStruct use = new CardUseStruct();
            Room room = ai.Room;
            List<int> cards = player.GetCards("h");
            ai.SortByKeepValue(ref cards, false);
            foreach (int id in cards)
            {
                if (room.GetCard(id).Number == count && RoomLogic.CanDiscard(room, player, player, id) && ai.GetKeepValue(id, player) <= 4)
                {
                    WrappedCard ms = new WrappedCard(JijingCard.ClassName) { Skill = Name, Mute = true };
                    ms.AddSubCard(id);
                    use.From = player;
                    use.Card = ms;
                    return use;
                }
            }

            return use;
        }
    }

    public class JieyingHFAI : SkillEvent
    {
        public JieyingHFAI() : base("jieying_hf") { }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            if (player.HasFlag(Name))
            {
                foreach (Player p in targets)
                {
                    if (ai.IsFriend(p) && ai.GetOverflow(p) == 0)
                        return new List<Player> { p };
                }
            }
            else
            {
                Room room = ai.Room;
                if (room.GetTag("extra_target_skill") is CardUseStruct use)
                {
                    List<Player> result = new List<Player>();
                    if (use.Card.Name == Peach.ClassName)
                    {
                        foreach (Player p in targets)
                        {
                            if (ai.IsFriend(p) && p.IsWounded())
                            {
                                result.Add(p);
                                break;
                            }
                        }
                    }
                    else if (use.Card.Name == ExNihilo.ClassName)
                    {
                        foreach (Player p in targets)
                        {
                            if (ai.IsFriend(p) && (!ai.HasSkill("zishu", p) || p.Phase != PlayerPhase.NotActive))
                            {
                                result.Add(p);
                                break;
                            }
                        }
                    }
                    else if (use.Card.Name.Contains(Slash.ClassName))
                    {
                        foreach (Player p in targets)
                        {
                            List<ScoreStruct> scores = ai.CaculateSlashIncome(player, new List<WrappedCard> { use.Card }, new List<Player> { p }, false);
                            if (scores.Count > 0 && scores[0].Score > 2)
                            {
                                result.Add(p);
                                break;
                            }
                        }
                    }
                    else if (use.Card.Name == Snatch.ClassName)
                    {
                        foreach (Player p in targets)
                        {
                            if (ai.FindCards2Discard(player, p, use.Card.Name, "hej", HandlingMethod.MethodGet).Score > 0)
                            {
                                result.Add(p);
                                break;
                            }
                        }
                    }
                    else if (use.Card.Name == Dismantlement.ClassName)
                    {
                        foreach (Player p in targets)
                        {
                            if (ai.FindCards2Discard(player, p, use.Card.Name, "hej", HandlingMethod.MethodDiscard).Score > 0)
                            {
                                result.Add(p);
                                break;
                            }
                        }
                    }
                    else if (use.Card.Name == FireAttack.ClassName)
                    {
                        foreach (Player p in targets)
                        {
                            if (ai.IsEnemy(p))
                            {
                                result.Add(p);
                                break;
                            }
                        }
                    }
                    return result;
                }
            }
            return new List<Player>();
        }
    }

    public class WeipoAI : SkillEvent
    {
        public WeipoAI() : base("weipo") { }
        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            Room room = ai.Room;
            Player target = null;
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (p.HasFlag("weipo_target"))
                {
                    target = p;
                    break;
                }
            }

            List<int> ids = player.GetCards("h");
            if (ai.IsFriend(target))
            {
                KeyValuePair<Player, int> key = ai.GetCardNeedPlayer(ids, new List<Player> { target });
                if (key.Key == target && key.Value >= 0)
                    return new List<int> { key.Value };
            }
            ai.SortByKeepValue(ref ids, false);
            return new List<int> { ids[0] };
        }
    }

    public class PanshiAI : SkillEvent
    {
        public PanshiAI() : base("panshi") { }

        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.Card != null && damage.Card.Name.Contains(Slash.ClassName) && damage.From != null && ai.HasSkill(Name, damage.From) &&
                ai.HasSkill("cixiao", damage.To))
                damage.Damage++;
        }
    }

    public class CixiaoAI : SkillEvent
    {
        public CixiaoAI() : base("cixiao")
        {
            key = new List<string> { "playerChosen:cixiao" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.ChoiceMade && data is string choice)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;
                    Player target = room.FindPlayer(choices[2]);

                    if (ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, false);
                }
            }
        }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            foreach (Player p in targets)
                if (ai.IsEnemy(p)) return new List<Player> { p };
            return new List<Player>();
        }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            bool invoke = false;
            Room room = ai.Room;
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (p.GetMark("foster_son") > 0 && !ai.IsEnemy(p))
                {
                    invoke = true;
                    break;
                }
            }

            if (invoke && !player.IsNude() && !player.HasUsed(CixiaoCard.ClassName))
            {
                WrappedCard cx = new WrappedCard(CixiaoCard.ClassName) { Skill = Name };
                return new List<WrappedCard> { cx };
            }
            return null;
        }
    }

    public class CixiaoCardAI : UseCard
    {
        public CixiaoCardAI() : base(CixiaoCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                foreach (Player p in use.To)
                    if (ai.GetPlayerTendency(p) != "unknown" && p.GetMark("foster_son") == 0)
                        ai.UpdatePlayerRelation(player, p, false);
            }
        }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<int> cards = player.GetCards("he");
            ai.SortByKeepValue(ref cards, false);
            Room room = ai.Room;
            Player from = null, target = null;
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (p.GetMark("foster_son") > 0)
                    from = p;
                else if (target == null && ai.IsEnemy(p))
                    target = p;
            }

            if (from != null && target != null && cards.Count > 0)
            {
                use.To = new List<Player> { from, target };
                use.Card = card;
                use.Card.AddSubCard(cards[0]);
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card)
        {
            return 0;
        }
    }

    public class GongjianAI : SkillEvent
    {
        public GongjianAI() : base("gongjian") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            Room room = ai.Room;
            if (room.ContainsTag(Name) && room.GetTag(Name) is List<Player> players && data is CardUseStruct use)
            {
                foreach (Player p in use.To)
                {
                    if (players.Contains(p) && !p.IsNude() && ai.IsEnemy(p) && !(p.GetCardCount(true) == 1 && ai.HasArmorEffect(p, SilverLion.ClassName)))
                        return true;
                }
            }
            return false;
        }

        public override double TargetValueAdjust(TrustedAI ai, WrappedCard card, Player from, List<Player> targets, Player to)
        {
            Room room = ai.Room;
            double value = 0;
            if (room.ContainsTag(Name) && room.GetTag(Name) is List<Player> players)
            {
                foreach (Player p in targets)
                {
                    if (players.Contains(p) && !p.IsNude() && ai.IsEnemy(p))
                        value += 4;
                }
            }

            return value;
        }
    }

    public class NiluanAI : SkillEvent
    {
        public NiluanAI() : base("niluang") { }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            Room room = ai.Room;
            if (!player.IsNude() && Slash.IsAvailable(room, player))
            {
                List<int> ids = player.GetCards("he");
                ids.AddRange(player.GetHandPile());
                ai.SortByUseValue(ref ids, false);
                foreach (int id in ids)
                {
                    if (ai.GetUseValue(id, player) <= Engine.GetCardUseValue(Slash.ClassName) + 1 && WrappedCard.IsBlack(room.GetCard(id).Suit))
                    {
                        WrappedCard await = new WrappedCard(Slash.ClassName);
                        await.AddSubCard(id);
                        await.Skill = Name;
                        return new List<WrappedCard> { await };
                    }
                }
            }
            return null;
        }
    }

    public class WeiwuAI : SkillEvent
    {
        public WeiwuAI() : base("weiwu") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            Room room = ai.Room;
            if (player.UsedTimes("ViewAsSkill_weiwuCard") == 0)
            {
                List<int> ids = player.GetCards("he");
                ids.AddRange(player.GetHandPile());
                ai.SortByUseValue(ref ids, false);
                foreach (int id in ids)
                {
                    if (ai.GetUseValue(id, player) <= Engine.GetCardUseValue(Snatch.ClassName) && WrappedCard.IsRed(room.GetCard(id).Suit))
                    {
                        WrappedCard await = new WrappedCard(Snatch.ClassName)
                        {
                            DistanceLimited = false,
                            Skill = Name,
                            ShowSkill = Name
                        };
                        await.AddSubCard(id);
                        return new List<WrappedCard> { await };
                    }
                }
            }
            return null;
        }
    }

    public class YujueAI : SkillEvent
    {
        public YujueAI() : base("yujue") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(YujueCard.ClassName))
            {
                for (int i = 0; i < 5; i++)
                    if (!player.EquipIsBaned(i))
                        return new List<WrappedCard> { new WrappedCard(YujueCard.ClassName) { Skill = Name } };
            }
            return null;
        }

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (choice.Contains("Treasure"))
                return "Treasure";
            else if (choice.Contains("DHorse"))
                return "DHorse";
            else if (choice.Contains("OHorse"))
                return "OHorse";
            else
                return "Armor";
        }
    }

    public class YujueCardAI : UseCard
    {
        public YujueCardAI() : base(YujueCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                foreach (Player p in use.To)
                    if (ai.GetPlayerTendency(p) != "unknown")
                        ai.UpdatePlayerRelation(player, p, true);
            }
        }

        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> friends = ai.FriendNoSelf;
            ai.Room.SortByActionOrder(ref friends);
            foreach (Player p in friends)
            {
                if (!ai.WillSkipPlayPhase(p) && !ai.WillSkipDrawPhase(p) && !p.IsKongcheng())
                {
                    use.Card = card;
                    use.To.Add(p);
                    return;
                }
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 2;
    }

    public class TuxinAI : SkillEvent
    {
        public TuxinAI() : base("tuxin") { }
        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.From != null && damage.From.GetMark(Name) > 0)
                damage.Damage++;
        }
    }

    public class LiangyingClassicAI : SkillEvent
    {
        public LiangyingClassicAI() : base("liangying_classic") { }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            return true;
        }

        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            List<int> ids = player.GetPile("#liangying");
            List<int> hands = player.GetCards("h");
            hands.RemoveAll(t => !ids.Contains(t));
            if (ai.GetOverflow(player) > player.HandcardNum - hands.Count)
                ids.RemoveAll(t => !hands.Contains(t));

            Room room = ai.Room;
            CardUseStruct use = new CardUseStruct(null, player, new List<Player>());

            List<Player> targets = new List<Player>();
            foreach (Player p in ai.FriendNoSelf)
                if (p.HasFlag(Name)) targets.Add(p);

            if (ids.Count > 0 && targets.Count > 0)
            {
                KeyValuePair<Player, int> pair = ai.GetCardNeedPlayer(ids, targets);
                if (pair.Key != null)
                {
                    use.Card = new WrappedCard(LiangyingClassicCard.ClassName) { Skill = Name };
                    use.Card.AddSubCard(pair.Value);
                    use.To.Add(pair.Key);
                    return use;
                }

                if (ai.GetOverflow(player) > 0)
                {
                    ai.SortByDefense(ref targets, false);
                    ai.SortByUseValue(ref ids);
                    use.Card = new WrappedCard(LiangyingClassicCard.ClassName) { Skill = Name };
                    use.Card.AddSubCard(ids[0]);
                    use.To.Add(targets[0]);
                    return use;
                }
            }

            return use;
        }
    }

    public class ShishouAI : SkillEvent
    {
        public ShishouAI() : base("shishou") { }
        public override ScoreStruct GetDamageScore(TrustedAI ai, DamageStruct damage)
        {
            ScoreStruct score = new ScoreStruct();
            if (ai.HasSkill(Name, damage.To) && damage.To.GetMark("@gd_liang") > 0 && damage.Nature == DamageStruct.DamageNature.Fire)
            {
                int count = Math.Min(damage.Damage, damage.To.GetMark("@gd_liang"));
                double value = 4 * count;
                if (count >= damage.To.GetMark("@gd_liang")) value += 10;
                if (ai.IsFriend(damage.To))
                    value = -value;

                score.Score = value;
            }

            return score;
        }
    }

    public class YixiangSPAI : SkillEvent
    {
        public YixiangSPAI() : base("yixiang_sp") { }
        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.From != null && damage.From.Phase == PlayerPhase.Play && ai.HasSkill(Name, damage.To) && damage.Card != null)
            {
                FunctionCard fcard = Engine.GetFunctionCard(damage.Card.Name);
                if (!(fcard is SkillCard))
                {
                    Room room = ai.Room;
                    if (room.GetRoomState().GetCurrentCardUsePattern() == "..")
                    {
                        if (damage.From.GetMark(Name) == 0)
                            damage.Damage--;
                    }
                    else if (damage.Card.HasFlag("yixiang_first"))
                        damage.Damage--;
                }
            }
        }

        public override bool IsCardEffect(TrustedAI ai, WrappedCard card, Player from, Player to)
        {
            if (card != null && to != null && from != null && from.Phase == PlayerPhase.Play && ai.HasSkill(Name, to))
            {
                FunctionCard fcard = Engine.GetFunctionCard(card.Name);
                if (!(fcard is DelayedTrick) && WrappedCard.IsBlack(card.Suit) && !(fcard is SkillCard))
                {
                    Room room = ai.Room;
                    if (room.GetRoomState().GetCurrentCardUsePattern() == "..")
                    {
                        return from.GetMark(Name) != 1;
                    }
                    else
                        return !card.HasFlag("yixiang_second");
                }
            }
            return true;
        }
    }

    public class YirangSPAI : SkillEvent
    {
        public YirangSPAI() : base("yirang_sp")
        {
            key = new List<string> { "playerChosen:yirang_sp" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (ai.Self == player) return;
            if (data is string choice)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;
                    Player target = room.FindPlayer(choices[2]);

                    if (ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            bool equip = false, trick = false;
            Room room = ai.Room;
            List<int> ids = new List<int>();
            foreach (int id in player.GetCards("he"))
            {
                WrappedCard card = room.GetCard(id);
                CardType type = Engine.GetFunctionCard(card.Name).TypeID;
                if (type == CardType.TypeBasic) continue;
                ids.Add(id);
                if (type == CardType.TypeTrick)
                    trick = true;
                else if (type == CardType.TypeEquip)
                    equip = true;

                if (card.Name == Vine.ClassName)
                {
                    foreach (Player p in targets)
                        if (ai.IsFriend(p) && !ai.HasSkill("zishu", p) && ai.HasSkill("shixin", p))
                            return new List<Player> { p };
                }
                if (card.Name == SilverLion.ClassName)
                {
                    foreach (Player p in targets)
                        if (ai.IsFriend(p) && !ai.HasSkill("zishu", p) && ai.HasSkill("dingpan", p))
                            return new List<Player> { p };
                }
                if (card.Name == Spear.ClassName)
                {
                    foreach (Player p in targets)
                        if (ai.IsFriend(p) && !ai.HasSkill("zishu", p) && ai.HasSkill("tushe", p))
                            return new List<Player> { p };
                }
                if (card.Name == EightDiagram.ClassName)
                {
                    foreach (Player p in targets)
                        if (ai.IsFriend(p) && !ai.HasSkill("zishu", p) && ai.HasSkill("tiandu", p))
                            return new List<Player> { p };
                }
            }

            if (equip)
            {
                foreach (Player p in targets)
                    if (ai.IsFriend(p) && ai.HasSkill(TrustedAI.LoseEquipSkill, p) && !ai.WillSkipPlayPhase(p) && !ai.HasSkill("zishu", p))
                        return new List<Player> { p };
                foreach (Player p in targets)
                    if (ai.IsFriend(p) && ai.HasSkill(TrustedAI.NeedEquipSkill, p) && !ai.WillSkipPlayPhase(p) && !ai.HasSkill("zishu", p))
                        return new List<Player> { p };
            }
            if (trick)
            {
                foreach (Player p in targets)
                    if (ai.IsFriend(p) && ai.HasSkill("jizhi|jizhi_jx", p) && !ai.WillSkipPlayPhase(p) && !ai.HasSkill("zishu", p))
                        return new List<Player> { p };
            }
            foreach (Player p in targets)
                if (ai.IsFriend(p) && ai.HasSkill(TrustedAI.CardneedSkill, p) && !ai.WillSkipPlayPhase(p) && !ai.HasSkill("zishu", p))
                    return new List<Player> { p };

            if (player.MaxHp == 1)
            {
                foreach (Player p in targets)
                    if (ai.IsFriend(p) && !ai.WillSkipPlayPhase(p) && !ai.HasSkill("zishu", p))
                        return new List<Player> { p };

                foreach (Player p in targets)
                    if (ai.IsFriend(p) && !ai.HasSkill("zishu", p))
                        return new List<Player> { p };

                if (ids.Count <= 2)
                {
                    int max_hp = 0;
                    foreach (Player p in targets)
                    {
                        if (p.MaxHp > max_hp)
                            max_hp = p.MaxHp;
                    }
                    foreach (Player p in targets)
                        if (p.MaxHp == max_hp && p.MaxHp - 1 >= ids.Count) return new List<Player> { p };
                }
            }

            return new List<Player>();
        }
    }

    public class GuowuAI : SkillEvent
    {
        public GuowuAI() : base("guowu") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;
    }

    public class ZhengeAI : SkillEvent
    {
        public ZhengeAI() : base("zhenge")
        {
            key = new List<string> { "playerChosen:zhenge" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (ai.Self == player || player.HasFlag(Name)) return;
            if (data is string choice)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;
                    Player target = room.FindPlayer(choices[2]);

                    if (ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            Room room = ai.Room;
            if (player.HasFlag(Name) && room.GetTag(Name) is Player target)
            {
                List<ScoreStruct> scores = new List<ScoreStruct>();
                WrappedCard slash = new WrappedCard(Slash.ClassName);
                foreach (Player p in targets)
                {
                    ScoreStruct effect = ai.SlashIsEffective(slash, target, p);
                    effect.Players = new List<Player> { p };
                    scores.Add(effect);
                }

                if (scores.Count > 0)
                {
                    scores.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
                    if (scores[0].Score > 0) return scores[0].Players;
                }
            }
            else
            {
                List<Player> friends = ai.GetFriends(player);
                foreach (Player p in friends)
                    if (p.GetMark(Name) == 0) return new List<Player> { p };

                foreach (Player p in friends)
                    if (ai.HasSkill("wushuang|tieqi_jx|liegong_jx|duanbing_jx|pojun|jianchu|moukui", p)) return new List<Player> { p };

                foreach (Player p in friends)
                    if (p.GetMark(Name) < 2 && !p.GetWeapon()) return new List<Player> { p };

                return new List<Player> { player };
            }

            return new List<Player>();
        }
    }

    public class ChaofengAI : SkillEvent
    {
        public ChaofengAI() : base("chaofeng") { }
        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            Room room = ai.Room;
            if (room.GetTag("chaofeng_damage") is DamageStruct damage)
            {
                double damage_v = 0;
                List<int> ids = new List<int>();
                Dictionary<int, double> points_keep = new Dictionary<int, double>();
                Dictionary<int, double> points_use = new Dictionary<int, double>();
                foreach (int id in player.GetCards("h"))
                {
                    if (RoomLogic.CanDiscard(room, player, player, id))
                        ids.Add(id);
                }
                if (ids.Count > 0)
                {
                    List<double> values = ai.SortByKeepValue(ref ids);
                    for (int i = 0; i < values.Count; i++)
                        points_keep[ids[i]] = 2.5 - values[i];

                    List<double> values_use = ai.SortByUseValue(ref ids);
                    for (int i = 0; i < values_use.Count; i++)
                        points_use[ids[i]] = 2.5 - values_use[i];

                    if (damage.Card != null && !Engine.IsSkillCard(damage.Card.Name))
                    {
                        DamageStruct _damage = new DamageStruct(damage.Reason, damage.From, damage.To, damage.Damage + 1, damage.Nature);
                        _damage.Card = damage.Card;
                        damage_v = ai.GetDamageScore(_damage).Score - ai.GetDamageScore(damage).Score;
                        FunctionCard damage_type = Engine.GetFunctionCard(damage.Card.Name);

                        foreach (int id in ids)
                        {
                            double count = 0;
                            WrappedCard card = room.GetCard(id);
                            if (damage.Card.Suit != WrappedCard.CardSuit.NoSuit && WrappedCard.IsBlack(damage.Card.Suit) == WrappedCard.IsBlack(card.Suit)) count += 2.5;
                            if (Engine.GetFunctionCard(card.Name).TypeID == damage_type.TypeID) count += damage_v;
                            points_keep[id] += count;
                            points_use[id] += count;
                        }
                    }
                }

                ids.Sort((x, y) => { return points_keep[x] > points_keep[y] ? -1 : 1; });
                int keep = ids[0];
                ids.Sort((x, y) => { return points_use[x] > points_use[y] ? -1 : 1; });
                int use = ids[0];

                if (player.Phase == PlayerPhase.NotActive && points_use[use] > 0 && points_use[use] > points_keep[keep])
                    return new List<int> { use };
                else if (points_keep[keep] > 0)
                    return new List<int> { keep };
            }
            return new List<int>();
        }
    }

    public class ChuanshuAI : SkillEvent
    {
        public ChuanshuAI() : base("chuanshu") { }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            List<Player> friends = ai.FriendNoSelf;
            if (friends.Count > 0)
            {
                ai.SortByDefense(ref friends);
                return new List<Player> { friends[0] };
            }
            return new List<Player>();
        }
    }

    public class ChuanyunAI : SkillEvent
    {
        public ChuanyunAI() : base("chuanyun") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (data is Player target && !ai.IsFriend(target) && !ai.HasSkill(TrustedAI.LoseEquipSkill, target))
                return true;

            return false;
        }
    }

    public class TianzeAI : SkillEvent
    {
        public TianzeAI() : base("tianze") { }
        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            Room room = ai.Room;
            Player target = null;
            foreach (Player p in room.GetOtherPlayers(player))
            {
                if (p.HasFlag("tianze_target"))
                {
                    target = p;
                    break;
                }
            }
            List<int> ids = new List<int>();
            foreach (int id in player.GetCards("h"))
                if (RoomLogic.CanDiscard(room, player, player, id) && WrappedCard.IsBlack(room.GetCard(id).Suit)) ids.Add(id);

            if (ids.Count > 0)
            {
                double score = ai.GetDamageScore(new DamageStruct(Name, player, target)).Score;
                if (score > 0)
                {
                    List<double> values = ai.SortByKeepValue(ref ids, false);
                    if (values[0] < score)
                        return new List<int> { ids[0] };
                }
            }
            return new List<int>();
        }
    }

    public class DifaAI : SkillEvent
    {
        public DifaAI() : base("difa") { }
        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            Room room = ai.Room;
            List<string> strs = new List<string>(pattern.Split('#'));
            List<int> ids = JsonUntity.StringList2IntList(strs);
            List<double> values = ai.SortByUseValue(ref ids, false);
            List<int> dis = new List<int>();
            for (int i = 0; i < ids.Count; i++)
            {
                if (values[i] < 5.5) dis.Add(ids[i]);
            }
            return dis;
        }

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (choice.Contains(ExNihilo.ClassName)) return ExNihilo.ClassName;
            if (choice.Contains(Dismantlement.ClassName)) return Dismantlement.ClassName;
            if (choice.Contains(Snatch.ClassName)) return Snatch.ClassName;
            if (choice.Contains(Duel.ClassName)) return Duel.ClassName;
            return string.Empty;
        }
    }

    public class XuezhaoAI : SkillEvent
    {
        public XuezhaoAI() : base("xuezhao") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(XuezhaoCard.ClassName))
            {
                int id = LijianAI.FindLijianCard(ai, player);
                if (id >= 0)
                {
                    WrappedCard lijian = new WrappedCard(XuezhaoCard.ClassName) { Skill = Name };
                    lijian.AddSubCard(id);
                    return new List<WrappedCard> { lijian };
                }
            }

            return null;
        }

        public override List<int> OnExchange(TrustedAI ai, Player player, string pattern, int min, int max, string pile)
        {
            Player target = ai.Room.Current;
            List<int> ids = player.GetCards("he");
            if (ids.Count > 0)
            {
                List<double> values = ai.SortByKeepValue(ref ids, false);
                if (values[0] < (ai.IsFriend(target) ? 0 : -3))
                    return new List<int> { ids[0] };

                if (ai.IsFriend(target))
                {
                    KeyValuePair<Player, int> key = ai.GetCardNeedPlayer(ids, new List<Player> { target });
                    if (key.Key != null && key.Value >= 0)
                        return new List<int> { key.Value };

                    foreach (int id in player.GetCards("h"))
                        if (ai.Room.GetCard(id).Name.Contains(Slash.ClassName))
                            return new List<int> { id };
                }
            }

            return new List<int>();
        }
    }

    public class XuezhaoCardAI : UseCard
    {
        public XuezhaoCardAI() : base(XuezhaoCard.ClassName) { }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> targets = new List<Player>();
            int count = player.Hp;
            List<Player> enemies = ai.GetEnemies(player);
            foreach (Player p in ai.FriendNoSelf)
                if (!p.IsNude() && !(p.GetCardCount(true) == 1 && p.HasEquip(ClassicWoodenOxCard.ClassName) && p.GetPile("wooden_ox").Count > 0))
                    targets.Add(p);

            if (enemies.Count > 0)
            {
                ai.SortByDefense(ref enemies, false);
                targets.AddRange(enemies);
            }

            if (targets.Count > 0)
            {
                use.Card = card;
                for (int i = 0; i < Math.Min(targets.Count, count); i++)
                    use.To.Add(targets[i]);
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 7;
    }

    public class ChanniAI : SkillEvent
    {
        public ChanniAI() : base("channi") { }

        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            CardUseStruct use = new CardUseStruct();
            Room room = ai.Room;
            int count = player.GetMark(Name);
            List<int> hands = new List<int>();
            foreach (int id in player.GetCards("h"))
                if (!RoomLogic.IsCardLimited(room, player, room.GetCard(id), HandlingMethod.MethodUse, true))
                    hands.Add(id);

            if (hands.Count >= count)
            {
                WrappedCard duel = new WrappedCard(Duel.ClassName) { Skill = "_channi" };
                ai.SortByKeepValue(ref hands);
                //for (int i = 0; i < count; i++)
                //    duel.AddSubCard(hands[i]);
                duel.AddSubCard(hands[0]);

                List<Player> targets = new List<Player>();
                foreach (Player p in room.GetOtherPlayers(player))
                    if (RoomLogic.IsProhibited(room, player, p, duel) == null)
                        targets.Add(p);

                if (targets.Count > 0)
                {
                    int slash = ai.GetCards(Slash.ClassName, player, true).Count;

                    List<ScoreStruct> scores = new List<ScoreStruct>();
                    foreach (Player p in targets)
                    {
                        ScoreStruct score = ai.GetDamageScore(new DamageStruct(duel, player, p));
                        score.Players = new List<Player> { p };
                        scores.Add(score);
                    }

                    scores.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
                    foreach (ScoreStruct score in scores)
                    {
                        if (score.Score > 0 && (ai.IsFriend(score.Players[0]) || ai.GetKnownCardsNums(Slash.ClassName, "h", score.Players[0], player) <= slash))
                        {
                            use.From = player;
                            use.To = score.Players;
                            use.Card = duel;
                            return use;
                        }
                    }
                }
            }
            return use;
        }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(ChanniCard.ClassName) && !player.IsKongcheng())
                return new List<WrappedCard> { new WrappedCard(ChanniCard.ClassName) { Skill = Name } };

            return new List<WrappedCard>();
        }

        public override ScoreStruct GetDamageScore(TrustedAI ai, DamageStruct damage)
        {
            ScoreStruct score = new ScoreStruct();
            if (damage.Card != null && damage.From != null && damage.Card.GetSkillName() == Name && damage.From.HasFlag(Name))
                score.Score += damage.Card.SubCards.Count * 1.2;
            return score;
        }
    }

    public class ChanniCardAI : UseCard
    {
        public ChanniCardAI() : base(ChanniCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                foreach (Player p in use.To)
                    if (ai.GetPlayerTendency(p) != "unknown")
                        ai.UpdatePlayerRelation(player, p, true);
            }
        }

        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> friends = ai.FriendNoSelf;
            if (friends.Count > 0)
            {
                ai.SortByDefense(ref friends, false);
                use.Card = card;
                use.Card.AddSubCards(player.GetCards("h"));
                foreach (Player p in friends)
                {
                    if (ai.HasSkill("wushuang", p))
                    {
                        use.To.Add(p);
                        return;
                    }
                }

                foreach (Player p in friends)
                {
                    if (ai.HasSkill("wusheng|wusheng_jx", p))
                    {
                        use.To.Add(p);
                        return;
                    }
                }

                use.To.Add(friends[0]);
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 1.2;
    }

    public class MouzhuAI : SkillEvent
    {
        public MouzhuAI() : base("mouzhu") { }
        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(MouzhuCard.ClassName))
                return new List<WrappedCard> { new WrappedCard(MouzhuCard.ClassName) { Skill = Name } };
            return new List<WrappedCard>();
        }

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (choice.Contains("slash") && data is Player target)
            {
                WrappedCard slash = new WrappedCard(Slash.ClassName) { Skill = "_mouzhu", DistanceLimited = false };
                List<ScoreStruct> scores = ai.CaculateSlashIncome(player, new List<WrappedCard> { slash }, new List<Player> { target }, false);
                if (scores.Count > 0 && scores[0].Score > 0)
                    return "slash";
            }
            if (choice.Contains("duel"))
                return "duel";
            else
                return "slash";
        }
    }

    public class MouzhuCardAI : UseCard
    {
        public MouzhuCardAI() : base(MouzhuCard.ClassName) { }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.CardTargetAnnounced && data is CardUseStruct use)
            {
                foreach (Player p in use.To)
                    if (ai.GetPlayerTendency(p) != "unknown")
                        ai.UpdatePlayerRelation(player, p, false);
            }
        }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            List<Player> enemies = ai.GetEnemies(player);
            List<Player> targets = enemies.FindAll(t => !t.IsKongcheng() && (t.Hp == player.Hp || RoomLogic.DistanceTo(ai.Room, player, t) == 1));
            if (targets.Count > 0)
            {
                use.Card = card;
                use.To = targets;
            }
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 5;
    }

    public class TiqiAI : SkillEvent
    {
        public TiqiAI() : base("tiqi")
        { key = new List<string> { "skillChoice:tiqi" }; }

        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.ChoiceMade && data is string str && ai.Self != player)
            {
                string[] strs = str.Split(':');
                if (strs[1] == Name)
                {
                    Player target = ai.Room.Current;
                    Room room = ai.Room;

                    if (ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, strs[2] == "add");
                }
            }
        }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => true;

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (data is Player target)
            {
                if (ai.IsFriend(target)) return "add";
                else if (ai.IsEnemy(target)) return "reduce";
            }
            return "cancel";
        }
    }

    public class BaoshuAI : SkillEvent
    {
        public BaoshuAI() : base("baoshu")
        {
            key = new List<string> { "playerChosen:aichen" };
        }
        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (ai.Self == player) return;
            if (data is string choice && ai.Self != player)
            {
                string[] choices = choice.Split(':');
                if (choices[1] == Name)
                {
                    Room room = ai.Room;

                    foreach (string player_name in choices[2].Split('+'))
                    {
                        Player target = room.FindPlayer(player_name);
                        if (ai.GetPlayerTendency(target) != "unknown")
                            ai.UpdatePlayerRelation(player, target, true);
                    }
                }
            }
        }
        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            List<Player> friends = ai.GetFriends(player);
            ai.Room.SortByActionOrder(ref friends);
            List<Player> results = new List<Player>();
            for (int i = 0; i < Math.Min(friends.Count, max); i++)
                results.Add(friends[i]);

            return results;
        }
    }

    public class XiaowuAI : SkillEvent
    {
        public XiaowuAI() : base("xiaowu")
        { key = new List<string> { "skillChoice:xiaowu" }; }

        public override void OnEvent(TrustedAI ai, TriggerEvent triggerEvent, Player player, object data)
        {
            if (triggerEvent == TriggerEvent.ChoiceMade && data is string str && ai.Self != player)
            {
                string[] strs = str.Split(':');
                if (strs[1] == Name)
                {
                    Player target = ai.Room.Current;
                    Room room = ai.Room;

                    int let = target.GetMark("xiaowu_draw");
                    int self = target.GetMark("xiaowu_let");
                    if (self < let && strs[2] == "let" && ai.GetPlayerTendency(target) != "unknown")
                        ai.UpdatePlayerRelation(player, target, true);
                }
            }
        }

        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (data is Player target)
            {
                if (!ai.IsFriend(target))
                {
                    Room room = ai.Room;
                    int left = 0;
                    foreach (Player p in room.GetOtherPlayers(player))
                        if (p.HasFlag(Name)) left++;

                    int let = target.GetMark("xiaowu_draw");
                    int self = target.GetMark("xiaowu_self");
                    if (self >= let)
                    {
                        if (left + let + 1 < self || ai.GetDamageScore(new DamageStruct(Name, target, player)).Score >= 0)
                            return "draw";
                    }
                    else
                    {
                        return "draw";
                    }
                }
            }

            return "let";
        }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            if (!player.HasUsed(XiaowuCard.ClassName))
                return new List<WrappedCard> { new WrappedCard(XiaowuCard.ClassName) { Skill = Name } };
            return new List<WrappedCard>();
        }
    }

    public class XiaowuCardAI : UseCard
    {
        public XiaowuCardAI() : base(XiaowuCard.ClassName) { }
        public override void Use(TrustedAI ai, Player player, ref CardUseStruct use, WrappedCard card)
        {
            use.Card = card;
            foreach (Player p in ai.Room.GetOtherPlayers(player))
                use.To.Add(p);
        }

        public override double UsePriorityAdjust(TrustedAI ai, Player player, List<Player> targets, WrappedCard card) => 9;
    }

    public class HuapingAI : SkillEvent
    {
        public HuapingAI() : base("huaping") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (ai.Room.GetOtherPlayers(player).Count > 1)
                return player.GetMark("shawu") > 4;
            return true;
        }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            foreach (Player p in targets)
                if (ai.IsFriend(p)) return new List<Player> { p };
            return new List<Player>();
        }
    }

    public class ShawuAI : SkillEvent
    {
        public ShawuAI() : base("shawu") { }
        public override CardUseStruct OnResponding(TrustedAI ai, Player player, string pattern, string prompt, object data)
        {
            CardUseStruct use = new CardUseStruct(null, player, new List<Player>());
            if (player.GetMark(Name) == 0 && player.HandcardNum >= 2)
            {
                Room room = ai.Room;
                string target_name = prompt.Split(':')[1];
                Player target = room.FindPlayer(target_name);
                if (target != null && ai.IsEnemy(target))
                {
                    List<int> ids = new List<int>();
                    foreach (int id in player.GetCards("h"))
                        if (RoomLogic.CanDiscard(room, player, player, id))
                            ids.Add(id);
                    if (ids.Count >= 2)
                    {
                        List<double> values = ai.SortByUseValue(ref ids);
                        if (ai.GetDamageScore(new DamageStruct(Name, player, target)).Score >= (values[0] + values[1]) * 2 / 3)
                        {
                            use.Card = new WrappedCard(ShawuCard.ClassName);
                            use.Card.AddSubCard(ids[0]);
                            use.Card.AddSubCard(ids[1]);
                        }
                    }
                }
            }
            return use;
        }

        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data)
        {
            if (data is string prompt)
            {
                Room room = ai.Room;
                string target_name = prompt.Split(':')[1];
                Player target = room.FindPlayer(target_name);
                if (target != null && ai.IsEnemy(target))
                    return ai.GetDamageScore(new DamageStruct(Name, player, target)).Score > 0;
            }

            return false;
        }
    }

    public class JinggongAI : SkillEvent
    {
        public JinggongAI() : base("jinggong") { }
        public override List<WrappedCard> GetViewAsCards(TrustedAI ai, string pattern, Player player)
        {
            List<WrappedCard> result = new List<WrappedCard>();
            Room room = ai.Room;
            if (pattern == Slash.ClassName && (room.GetRoomState().GetCurrentCardUseReason() == CardUseStruct.CardUseReason.CARD_USE_REASON_PLAY
                || room.GetRoomState().GetCurrentCardUseReason() == CardUseStruct.CardUseReason.CARD_USE_REASON_RESPONSE_USE))
            {
                List<int> ids = player.GetCards("he");
                ids.AddRange(player.GetHandPile());
                foreach (int id in ids)
                {
                    if (Engine.GetFunctionCard(room.GetCard(id).Name) is EquipCard)
                    {
                        WrappedCard slash = new WrappedCard(Slash.ClassName)
                        {
                            Skill = Name,
                            DistanceLimited = false
                        };
                        slash.AddSubCard(id);
                        slash = RoomLogic.ParseUseCard(room, slash);
                        result.Add(slash);
                    }
                }
            }

            return result;
        }

        public override List<WrappedCard> GetTurnUse(TrustedAI ai, Player player)
        {
            Room room = ai.Room;
                List<int> ids = player.GetCards("he");
                ids.AddRange(player.GetHandPile());
            ai.SortByKeepValue(ref ids, false);
            foreach (int id in ids)
                {
                    if (Engine.GetFunctionCard(room.GetCard(id).Name) is EquipCard)
                    {
                        WrappedCard slash = new WrappedCard(Slash.ClassName)
                        {
                            Skill = Name,
                            DistanceLimited = false
                        };
                        slash.AddSubCard(id);
                        slash = RoomLogic.ParseUseCard(room, slash);
                        return new List<WrappedCard> { slash };
                    }
                }

            return null;
        }

        public override void DamageEffect(TrustedAI ai, ref DamageStruct damage, DamageStruct.DamageStep step)
        {
            if (damage.From != null && damage.Card != null && damage.Card.GetSkillName() == Name && step <= DamageStruct.DamageStep.Caused)
            {
                int count = Math.Max(1, RoomLogic.DistanceTo(ai.Room, damage.From, damage.To));
                count = Math.Min(3, count);
                if (count != damage.Damage)
                    damage.Damage = count;
            }
        }
    }

    public class XiaoxiAI : SkillEvent
    {
        public XiaoxiAI() : base("xiaoxi") { }
        public override string OnChoice(TrustedAI ai, Player player, string choice, object data)
        {
            if (data is Player target)
                return ai.Choice[Name];
            else
                return "1";
        }

        public override List<Player> OnPlayerChosen(TrustedAI ai, Player player, List<Player> targets, int min, int max)
        {
            WrappedCard slash = new WrappedCard(Slash.ClassName);
            List<ScoreStruct> gets = new List<ScoreStruct>();
            List<ScoreStruct> slashes = ai.CaculateSlashIncome(player, new List<WrappedCard> { slash }, targets, false);
            foreach (Player p in targets)
            {
                if (!p.IsNude() && RoomLogic.CanDiscard(ai.Room, player, p , "he"))
                {
                    ScoreStruct score = ai.FindCards2Discard(player, p, Name, "he", HandlingMethod.MethodGet);
                    score.Players = new List<Player> { p };
                    gets.Add(score);
                }
            }
            if (gets.Count > 0)
            {
                gets.Sort((x, y) => { return x.Score > y.Score ? -1 : 1; });
                if (slashes.Count > 0)
                {
                    if (slashes[0].Score > gets[0].Score)
                    {
                        ai.Choice[Name] = "slash";
                        return new List<Player> { slashes[0].Players[0] };
                    }
                    else
                    {
                        ai.Choice[Name] = "getcard";
                        return gets[0].Players;
                    }
                }
                else
                    return gets[0].Players;
            }
            else
                return new List<Player> { slashes[0].Players[0] };
        }
    }

    public class XiongraoAI : SkillEvent
    {
        public XiongraoAI() : base("xiongrao") { }
        public override bool OnSkillInvoke(TrustedAI ai, Player player, object data) => player.Hp == 1 && player.MaxHp < 7 || player.MaxHp < 3;
    }
}