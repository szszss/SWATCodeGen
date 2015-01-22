//#define CHINESE

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace SWATCodeGen
{
    public partial class Form1 : Form
    {
        //public const bool CHINESE = true;

#if CHINESE
        public Weapon rif = new Weapon("突击步枪", "一般射速,中等射距,中等溅射范围,平庸而全面的武器.", 0);
        public Weapon rif2 = new Weapon("突击步枪MKII", "一般射速,中等射距,中等溅射范围,平庸而全面的武器.\nMKII拥有更快的射速和更大的溅射范围.", 0);
        public Weapon snp = new Weapon("狙击步枪", "低射速,长射程,无溅射,定点清除利器.", 0);
        public Weapon snp2 = new Weapon("狙击步枪MKII", "低射速,长射程,无溅射,定点清除利器.\nMKII拥有更快的射速.", 1);
        public Weapon chi = new Weapon("转轮机枪", "高射速,短射程,低溅射,消灭大量而分散的敌人.", 0);
        public Weapon chi2 = new Weapon("转轮机枪MKII", "高射速,短射程,低溅射,消灭大量而分散的敌人.\nMKII拥有更快的射速.", 2);
        public Weapon chiV = new Weapon("复仇者转轮机枪", "高射速,短射程,低溅射.\n复仇者型号的射速较慢,但单发杀伤力高,DPS和旧型号保持不变.", 0);
        public Weapon rok = new Weapon("火箭发射器", "低射速,长射程,大范围溅射,消灭大量而密集的敌人.", 0);
        public Weapon rok2 = new Weapon("火箭发射器MKII", "低射速,长射程,大范围溅射,消灭大量而密集的敌人.\nMKII拥有更快的射速.", 3);
        public Weapon flm = new Weapon("火焰喷射器", "超高射速,超短射程,中范围溅射,消灭大量近身的敌人.", 0);
        public Weapon flm2 = new Weapon("火焰喷射器MKII", "超高射速,超短射程,中范围溅射,消灭大量近身的敌人.\nMKII拥有更快的射速.", 4);
        public Weapon las = new Weapon("激光步枪", "射程长,射速慢,威力高,适合定点清除.", 0);
        public Weapon lasChi = new Weapon("转轮激光枪", "射程短,射速快,威力一般,适合扫灰.", 1);
        public Weapon pis = new Weapon("风暴手枪", "风暴手枪适宜清理大量的杂兵.副武器为风暴拳套,近战武器.", 0);

        public Armour light = new Armour("轻型装甲", "基础速度290,伤害吸收1.4,装备小型纳米护盾发生器.", 0);
        public Armour mid = new Armour("中型装甲", "基础速度250,伤害吸收2.1,装备中型纳米护盾发生器.", 1);
        public Armour heave = new Armour("重型装甲", "基础速度220,伤害吸收2.8,装备大型纳米护盾发生器.", 2);
        public Armour adv = new Armour("改进型装甲", "基础速度230,伤害吸收2.8,装备大型纳米护盾发生器.", 3);

        public Skill[] traits = new Skill[] {new Skill("技能熟练","开局护盾技能为2级,其它技能为1级.\n实验室的'技能点'植入可植入2次",0),
            new Skill("天赋异禀","活力,敏捷,智力各增加5点.移动速度增加30.\n减轻脑震荡造成的智力损失",1),
            new Skill("生存专家","活力和生命值各增加60点.不会受到撕裂伤害,扭伤几率极小,减少受到损伤的几率85%.\n能整合护甲,濒死状态HP恢复速度+2~4",2),
            new Skill("重视武力","武器伤害+17%,最大弹药等级+2.\n纳米护盾最大等级+1,护甲+3.",3),
            new Skill("身手敏捷","对轻中重甲:拥有30%几率闪避攻击.疾跑持续时间增加1秒,对轻中甲减少10%疾跑CD,对重甲减少20%疾跑CD.\n对改进型甲:拥有33%几率闪避攻击.",4),
            new Skill("快速学习","增加所有经验获得率30%,传奇等级期间增加150%经验获得率.\n完成任务可获得经验奖励.",5),
            new Skill("医学精通","使用绷带额外恢复50HP,更有效地治愈撕裂伤口,\n若目标单位处于非绷带治疗状态中,可恢复其中一个损伤.\n复活物品可叠加,且忽视智力要求,并且可作为急救包,用于自己复活自己.\n解毒剂必能治愈感染,并加快33%恢复速度.",6),
            new Skill("药物敏感","3种药物拥有4倍药效,但作用时间减半.\n巴福特可治疗各种损伤.安非他明增加移动速度20.满塔特增加10%经验获得率.\n单位注射兴奋剂时降低33%效果.",7),
            new Skill("药物依赖","3种药的持续时间增长5倍,减轻服药过多的不良反应.所有人的药包容量增加20%,自身药包开局额外携带三种药各一个.",8),
            new Skill("抵抗辐射","能完全免疫辐射对自身的影响,减慢放射性碎片的刷新速度.碎片扫描效率增强.",9),
            new Skill("机械设计","各种物品智力需求-22.增加消耗品的叠放数量.\n当突击机器人被击毁时,会掉落所有合成进去的非消耗性物品.",10),
            new Skill("夜间潜行","在夜间,增加32敏捷和10%移动速度,增大夜间视野.\n按下H键保持原位时,会激活声纳传感器,提供穿墙视野并反隐.\n按M键点地面能部署传感哨,敌对单位经过时会发出警报.",11),
            new Skill("能量增幅","增加能量回复速度33%.能量低于250时供电电池自动回复500点能量,冷却时间150秒.",12),
            new Skill("背包老鼠","增加6个额外背包空间.背包内的电池在能量低于250点时会自动使用.其他物品需要拿出背包后才能使用.\n一只能搜索物品的老鼠也会跟着玩家,机器人遥控设备能和机器人整合.\n保险柜内的物品传送技能CD缩短.",13),
            new Skill("工程制造","物品智力需求-33%.可对普通非消耗品进行复制供个人使用.\n能够更容易地从箱子中发现设计图纸.",14),
            new Skill("突击成才","从Lv2-Lv20,每逢偶数等级额外获得1技能点.\n纳米护盾有效等级减1.最后5点护盾等级每级将消耗2技能点.",15)};

        public Skill[] specialization = new Skill[] {new Skill("武器强化","最大弹药等级+1,武器相关技能+1.突击步枪使用穿甲弹药.等离子弹获得额外伤害奖励.",0),
            new Skill("装甲强化","增加伤害吸收3.2和1点防御.使用电磁护盾电容器不会降低移动速度,死亡时不会损坏动力装甲.",1),
            new Skill("附加能源","每个蓄能电池额外增加250能量上限.",2),
            new Skill("自身控制","增加50HP和4智力.濒死状态下移动速度增加75,减轻由脑震荡造成的智力下降.",3),
            new Skill("战地急救","绷带能完全恢复被治疗者的重伤状态,自身使用会额外恢复25HP.绷带堆叠上限加倍.\n解毒剂不会解毒失败.",4),
            new Skill("物质重构","使用药包服用物品能让一片药当三片吃.减轻服药过度的副作用.\n使用兴奋剂智力需求-10,给自己注射兴奋剂效果增强33%.",5),
            new Skill("领导才能","开局拥有英勇点13点,能为一位队友额外增加1技能点.增加市民移动速度10%.",6),
            new Skill("机械助手","玩家拥有一个机器宠物.装备弱点扫描仪,中子立场和小型能量场.",7),
            new Skill("斥候系统","对狙击手:监控探头耗魔降低一半,潜行时移动速度增加30,疾跑持续时间增加2秒.\n对非狙击手:在不开火时会维持隐身状态.降低回电速度8%~33%,纳米盾等级减1.",8)};

        public Talent courage = new Talent("勇气", "升级时有几率获得1英勇点", 0);
        public Talent wiring = new Talent("电力线圈", "+14%回电速度", 1);
        public Talent running = new Talent("疾行", "增加移动速度15.", 2);
        public Talent spotting = new Talent("侦测", "+266视野.有效作用于玩家本人,狙击的监视器,纵火的萤火虫,心理的心灵视野,爆破的C4.", 3);
        public Talent toughness = new Talent("坚韧", "HP+40,装甲+1", 4);
        public Talent thinkering = new Talent("技师", "智力+3~4", 5);
        public Talent hacking = new Talent("黑客", "可以从恢复工作的黑市偷钱,一个黑市能偷两次.\n可以拍卖储物箱内的东西.", 6);

        public ClassType sniper = new ClassType("狙击手", "吸水恶魔:打枪插眼开箱子", 0);
        public ClassType medic = new ClassType("战地医生", "asjk:哪盘都少不了医生!", 1);
        public ClassType tactician = new ClassType("战术专家", "ExIA:抗住,轨道离子炮来了!\nszszss被ExIA误杀了!", 2);
        public ClassType psy = new ClassType("心理学家", "windancer:心理...就是个球啊.", 3);
        public ClassType maverick = new ClassType("全能战士", "ExIA:全能的本体是狗,那个人是赠品.", 10);
        public ClassType heavy = new ClassType("重装火力手", "Tnme:看哥单修电站...(Kaboom)", 4);
        public ClassType demo = new ClassType("爆破专家", "SP.Fate:这是什么? SP.Fate发射了一枚核弹!\nxxx被SP.Fate误杀了!ooo被SP.Fate误杀了...", 5);
        public ClassType cyborg = new ClassType("电子人", "szszss:不管遇见什么都得是我扛着!看见TNT胖子都得内牛满面地上去顶!", 6);
        public ClassType pyro = new ClassType("纵火犯", "ExIA:纵火特苦逼,总是烧自己.", 7);
        public ClassType watchman = new ClassType("巡夜者", "\"sz求巡夜\",这是我听到的最多的话.", 8);
        public ClassType techops = new ClassType("机械师", "hong:MB你们等等我,我的震暴跑得慢...", 15);
        public ClassType clone = new ClassType("安布雷拉克隆人", "作者最近想画一个辐射废墟的红字本,求支持.", 16);

        public Medal[] medal = new Medal[] {new Medal("英雄勋章", "可以使用-color指令.当你选中这个勋章时,等级会强制设为12级."),
            new Medal("荣誉奖章", "纳米护盾等级+1.当你选中这个勋章时,等级会强制设为12级."),
            new Medal("战斗勋章", "增加武器威力.最低等级要求为10级."),
            new Medal("嘉奖令", "回电速度+16%"),
            new Medal("救援勋章", "每次升级有33%的几率获得1英勇点."),
            new Medal("杰出贡献勋章1", "增加自己的危险津贴40~80.可以得到3个."),
            new Medal("杰出贡献勋章2", "增加自己的危险津贴40~80.可以得到3个."),
            new Medal("杰出贡献勋章3", "增加自己的危险津贴40~80.可以得到3个.")};
#else
        public Weapon rif = new Weapon("Assault Rifle", "The assault rifle is fairly effective in all situations thanks to its well-rounded qualities. But of course it doesn't excel at anything either.", 0);
        public Weapon rif2 = new Weapon("Assault Rifle MKII", "The assault rifle is fairly effective in all situations thanks to its well-rounded qualities. But of course it doesn't excel at anything either.\nMKII has more rapidly fire rate and wider splash radius.", 0);
        public Weapon snp = new Weapon("Sniper Rifle", "The sniper rifle is designed to deliver high damage to a single unit from a safe range. It's great against high-hitpoint enemies, especially bosses. This gun is much less effective when confronted by many nearly-dead enemies.", 0);
        public Weapon snp2 = new Weapon("Sniper Rifle MKII", "The sniper rifle is designed to deliver high damage to a single unit from a safe range. It's great against high-hitpoint enemies, especially bosses. This gun is much less effective when confronted by many nearly-dead enemies.\nMKII has more rapidly fire rate.", 1);
        public Weapon chi = new Weapon("Chaingun", "The chaingun is good for taking out single or tightly-packed units.\nIts rapid fire rate is very effective against masses of nearly-dead enemies, and combined with Plasma Rounds, it can deliver incredible damage which briefly hinders targets' movement speed.\nShort range and Plasma's high energy cost offset this gun's power.", 0);
        public Weapon chi2 = new Weapon("Chaingun MKII", "The chaingun is good for taking out single or tightly-packed units.\nIts rapid fire rate is very effective against masses of nearly-dead enemies, and combined with Plasma Rounds, it can deliver incredible damage which briefly hinders targets' movement speed.\nShort range and Plasma's high energy cost offset this gun's power.\nMKII has more rapidly fire rate.", 2);
        public Weapon chiV = new Weapon("Vindicator", "The vindicator is a redesigned chaingun that fires more slowly but causes more damage per burst, yielding the same overall damage.\nIt uses Plasma-V Rounds that focus on energy-efficiency rather than slowing targets, and it can utilize an extra ammo upgrade.", 0);
        public Weapon rok = new Weapon("Rocket Launcher", "The rocket launcher's range and large splash area make it ideal against hordes of incoming units. Its overall damage output, however, can be pretty low if its splash isn't fully taken advantage of.\nRocket damage is reduced by 66% against nanites.", 0);
        public Weapon rok2 = new Weapon("Rocket Launcher MKII", "The rocket launcher's range and large splash area make it ideal against hordes of incoming units. Its overall damage output, however, can be pretty low if its splash isn't fully taken advantage of.\nRocket damage is reduced by 66% against nanites.\nMKII has more rapidly fire rate.", 3);
        public Weapon flm = new Weapon("Flamethrower", "The flamethrower delivers superior damage to tightly-packed units, but it's fairly ineffective against a single unit or spread-out units.", 0);
        public Weapon flm2 = new Weapon("Flamethrower MKII", "The flamethrower delivers superior damage to tightly-packed units, but it's fairly ineffective against a single unit or spread-out units.\nMKII has more rapidly fire rate.", 4);
        public Weapon las = new Weapon("Laser Rifle", "The laser rifle is good for taking out priority targets at long range.\nIt also does bonus damage to bosses, and it's good against Umbrellas because laser damage ignores evasion and is not reduced vs power armor.", 0);
        public Weapon lasChi = new Weapon("Gatling Laser", "The gatling laser is effective against streams of single units because of its rapid fire rate.\nIt also does bonus damage to bosses, and it's good against Umbrellas because laser damage ignores evasion and is not reduced vs power armor.", 1);
        public Weapon pis = new Weapon("Pistols", "Pistols offer two-target cover fire while the Umbrella Clone prepares for her next melee engagement.", 0);

        public Armour light = new Armour("Light", "Move Spd. 290, Absorption 1.4, Compact nanites.", 0);
        public Armour mid = new Armour("Medium", "Move Spd. 250, Absorption 2.1, Standard nanites.", 1);
        public Armour heave = new Armour("Heavy", "Move Spd. 220, Absorption 2.8, Large nanites.", 2);
        public Armour adv = new Armour("Advanced", "Move Spd. 230, Absorption 2.8, Large nanites.", 3);

        public Skill[] traits = new Skill[] {new Skill("Skilled","Nanites start at level 2, and all other skills start at level 1 instead of unlearned.\nSkillz can be implanted twice.",0),
            new Skill("Gifted","Vitality, Agility, and Intelligence are increased by 5, and movement speed is increased by 30.\nHead injuries reduce intelligence by less.",1),
            new Skill("Survivalist","Vitality and health start 60 points higher than normal.\nImmune to open wounds, ankle injuries are minor, and chance to get injured reduced by 85%.\nCan integrate kevlar and combat vests regardless of intelligence. Health regen increased by 2-4 hit points per second while health is critical.\nHero becomes more resilient, surviving most damage when not in critical health.\nReduces death's maximum health penalty.",2),
            new Skill("Dragoon","Increases weapon damage by about 17%, max ammo level by 2, effective nanites level by 1, and armor by 3.",3),
            new Skill("Acrobat","Gives a 30% chance to avoid an attack.\nSprint duration increased by 1 second and cooldown reduced by 10% for light and medium and 20% for heavy.\nCyborgs and Watchmen get a 33% chance to avoid an attack since they can't sprint.",4),
            new Skill("Swift Learner","Increases all experience gained by 30%; bonus is 150% during epic levels.\nObjectives award bonus exp. Hero contributes less uber.",5),
            new Skill("Healer","Bandages restore an additional 50 health, heal open wounds more effectively, and remove one injury if target not recently bandaged.\nRevive item can be stacked, used regardless of intelligence, and acts as an emergency life kit. Antidote fully heals zombie and converts it 33% more quickly.\nBandages are also more effective on civilians.",6),
            new Skill("Flower Child","Buffout, Speed, and Mentats are four times as effective but last half as long.\nBuffout heals injuries, Speed increases movement speed by 20, and Mentats increase all experience gained by 10%.\nStims used on the flower child are 33% worse.",7),
            new Skill("Chem. Reliant","Buffout, Speed, and Mentats last five times longer than normal. Reduces penalty for excessive drug use.\nPouch capacity increased by 20% for everyone, and pouch initially contains one of each drug.",8),
            new Skill("Rad. Resistant","Provides complete immunity to radiation damage and combats city radiation. Hero can passively detect rads in a small radius.\nPersonal frag. locator is more advanced.",9),
            new Skill("Gadgeteer","Intelligence is +22 for the purpose of determining item usability.\nIncreases the auto-stack size of consumables.\nWhen destroyed, Assault Droids drop non-consumable fused items.",10),
            new Skill("Prowler","At night, agility is increased by 32, movement speed is increased by 10%, and night vision goggles increase sight range.\nWhile holding position, a heartbeat sensor with sonar provides full sight of the immediate area, even revealing cloaked units.\nAllows the use of motion sensors which can detect enemy movement, even through fog.",11),
            new Skill("Energizer","Increases energy regeneration by 33%.\nEnergizer battery restores 500 energy when energy drops below 250. Requires 150 seconds to recharge.",12),
            new Skill("Pack Rat","Backpack holds extra items. Batteries will be automatically used if energy drops below 250, but other items are disabled in the backpack.\nOfficer is followed by a Rat-Cam equipped pet that scavenges for items. Droid remote is fused into its droid.\nMinimizes cooldown of locker's Teleport Item ability.",13),
            new Skill("Engineer","Items require 33% less intelligence to use.\nCommon, non-consumable items can be replicated for personal use. Design plans are more likely to be found in crates. Can also combine certain items to produce improved versions of the items. Only one Engineered Item can be held at a time.\nEngineered items require a circuit board to disassemble.\nBase 100 intelligence is omitted when calculating the requirement reduction.",14),
            new Skill("Reckless","Extra skill point awarded at each even level from 2 to 20.\nDecreases effective nanites level by 1, and upgrading the last five levels in nanites requires 2 skill points each.",15)};

        public Skill[] specialization = new Skill[] {new Skill("Weaponry","Increases max ammo level by 1 and effective weapon-skill level by 1. Assault rifles fire antipersonnel rounds. Plasma Rounds do extra damage.",0),
            new Skill("Power Armor","Increases damage absorption by 3.2 and armor by 1.\nReduces movement speed penalty of Shield Capacitor.\nDeath does not damage power armor.",1),
            new Skill("Energy Cells","Storage Cells items increase maximum energy capacity by an extra 250 each.",2),
            new Skill("Cybernetics","Increases health by 50 and intelligence by 3-5. Movement speed increased by 75 while health is critical. Head injuries reduce intelligence by less.",3),
            new Skill("Triage","Bandages fully recover recipient from critically low health, don't cause recently bandaged status, and restore an additional 25 health when used on self.\nIncreases the auto-stack size of bandages by 100%.\nAntidote never fails to convert zombie and is more likely to finalize inoculation.",4),
            new Skill("Chemistry","Buffout, Speed, and Mentats are consumed in thirds but still provide their full bonus. Reduces the experience penalty for overdosing.\nIntelligence is +10 for the purpose of using stims, and self-administered stims are 33% better.",5),
            new Skill("Leadership","Increases initial valor by 12-14.\nCan assign 1 extra skill point to a comrade.\nIncreases movement speed of civilians by 10%.\nIssuing a move or patrol command creates a movement indicator.",6),
            new Skill("Robotics","Officer is accompanied by a pet robot which can employ a vulnerability scanner, zephyr field, or minor energy field.",7),
            new Skill("Espionage","For sniper:Surveillance cameras cost half as much energy to construct. Movement speed increased by 30 while sneaking, and sprint duration increased by 2 seconds.\nFor other classes:Officer is cloaked while idle and moving.\nDecreases energy regeneration by 8-33% and effective nanites level by 1.",8)};

        public Talent courage = new Talent("Courage", "Gives a chance to gain an additional valor point each level-up.", 0);
        public Talent wiring = new Talent("Wiring", "Increases energy regeneration by 14%.", 1);
        public Talent running = new Talent("Running", "Movement speed is increased by 15.", 2);
        public Talent spotting = new Talent("Spotting", "Increases sight range by 266.\nBonus affects the officer, prowler's sensor, pyro's firefly, psy's clairvoyance, and demo's C4", 3);
        public Talent toughness = new Talent("Toughness", "Increases health by 40 and armor by 1.", 4);
        public Talent thinkering = new Talent("Tinkering", "Intelligence is +3-4 for the purpose of determining item usability.", 5);
        public Talent hacking = new Talent("Hacking", "Allows you to auction items and confiscate credits from the black market via your Lab. Locker.", 6);

        public ClassType sniper = new ClassType("Covert Sniper", "吸水恶魔:Break box, break box, and... break box...", 0);
        public ClassType medic = new ClassType("Field Medic", "asjk: All you need is a medic.", 1);
        public ClassType tactician = new ClassType("Tactician", "ExIA:Hold on, orbital strike incoming!\nszszss was killed by ExIA!", 2);
        public ClassType psy = new ClassType("Psychologist", "windancer:Psychologist's value is ... his ball.", 3);
        public ClassType maverick = new ClassType("Maverick", "ExIA:Maverick is the dog, and the man is a free gift.", 10);
        public ClassType heavy = new ClassType("Heavy Ordnance", "Tnme:I can repair a station by myself...(Boom)", 4);
        public ClassType demo = new ClassType("Demolitions", "SP.Fate:What the fuck it is? SP.Fate launched an nuclear missile!\nxxx was killed by SP.Fate! ooo was killed by SP.Fate...", 5);
        public ClassType cyborg = new ClassType("Cyborg", "szszss:I have to tank any thing, even an abomination with bomb!", 6);
        public ClassType pyro = new ClassType("Pyrotechnician", "ExIA:纵火特苦逼,总是烧自己. (Ohshit, I don't know how to translate it.)", 7);
        public ClassType watchman = new ClassType("Watchman", "\"SZ give me an code of Watchman plz\", that's what I often heard.", 8);
        public ClassType techops = new ClassType("Tech Ops", "hong:Fuuuuuck, wait for me you fag♂boys, my robot is slowly...", 15);
        public ClassType clone = new ClassType("Umbrella Clone", "I want to create an adult book whose character is Alice, support me plz!", 16);

        public Medal[] medal = new Medal[] {new Medal("Key to the City", "Grants usage of the -color chat command. Min.rank is 12."),
            new Medal("Medal of Honor", "Increases effective nanites level by 1. Min.rank is 12."),
            new Medal("Police Combat Cross", "Modifies weapon, increasing its damage. Min.rank is 10."),
            new Medal("Commendation Bar", "Increases energy regeneration by 16%."),
            new Medal("Life Saving Award", "Gives a 33% chance for +1 valor each level-up."),
            new Medal("Recognition for Exceptional Merit 1", "Increases personal hazard pay by 40-80. Can get three."),
            new Medal("Recognition for Exceptional Merit 2", "Increases personal hazard pay by 40-80. Can get three."),
            new Medal("Recognition for Exceptional Merit 3", "Increases personal hazard pay by 40-80. Can get three.")};
#endif

        public string[] moeStringLite = new string[] {
            //"生命诚可贵,百合价更高",
            //"慧sama是大baka",
            //"生当八云紫的罪袋,死做幽幽子的亡灵",
            //"人生最大乐趣莫过于对着幽幽子撸一管",
            "作者要出辐射废墟的红字本,求支持",
            "一切都是asjk那傻货在两群之间煽风点火",
            "重装不是人形使",
            "Nuclear is not free",
            "巡夜不会隙间",
            "错的不是我,是Redscull.",
            //"我就不信她能到我身后把我脑袋按在键qwrfqwgnvekjdnezeqtiojeq",
            //"此生不闻高久屋,安能自称萌大撸",
            //"啊...紫...紫的身体好棒...啊...",
            //"此生无悔入东方,来世愿毁幻想乡",
            //"\\(≧▽≦)/  (╯▽╰)  (>^ω^<) ╮(╯▽╰)╭",
            "《金阁寺下的双生花》",
            "《紫妹异闻录》",
            "壮哉我Windows!",
            "玛艾露贝莉赫恩的正确拼写是Marble Hen.",
            //"Windows8一定是潜伏在微软的卧底策划的...",
            //"Clef? Are you there?",
            //"Bukkit is a bitch.",
            //"Dig out Minecraft style",
            //"The world where you are.",
            "星系争霸战Evo已经坑了!作者考虑开源War3版然后制作SC2版...",
            "限制区601也是个打僵尸的生存图,很有意思哦!",
            //"360很糟糕,大多数程序员都不喜欢360.",
            //"我不喜欢GPL,但它确实是阻击资本主义的一道利器.",
            "太无聊了,这太无聊了."};

        public string[] moeStringExtra = new string[] {
            "生命诚可贵,百合价更高",
            "慧sama是大baka",
            "生当八云紫的罪袋,死做幽幽子的亡灵",
            "人生最大乐趣莫过于对着幽幽子撸一管",
            "我就不信她能到我身后把我脑袋按在键qwrfqwgnvekjdnezeqtiojeq",
            "此生不闻高久屋,安能自称萌大撸",
            "啊...紫...紫的身体好棒...啊...",
            "此生无悔入东方,来世愿毁幻想乡",
            "\\(≧▽≦)/  (╯▽╰)  (>^ω^<) ╮(╯▽╰)╭",
            "Windows8一定是潜伏在微软的卧底策划的...",
            "Clef? Are you there?",
            "Bukkit is a bitch.",
            "Dig out Minecraft style",
            "The world where you are.",
            "360很糟糕,大多数程序员都不喜欢360.",
            "我不喜欢GPL,但它确实是阻击资本主义的一道利器."};


        public bool selOne = false;
        public About aboutWin = new About();
        public int[] factor1 = {171,142,175,157,167,150,149,151,153,165 };
        public int[] factor2 = { 169,170,166,173,158,177,161,180,186,159 };

        public interface IDescable
        {
            string GetDesc();
        }

        public class ClassType : IDescable
        {
            public string name;
            public string desc;
            public int typeInt;
            public Weapon[] weapons;
            public Armour[] armours;
            public Talent[] talents;

            public ClassType (string n,string d,int i)
            {
                name = n;
                desc = d;
                typeInt = i;
            }

            public override string ToString()
            {
                return name;
            }

            public string GetDesc()
            {
                return desc;
            }
        }

        public class Weapon : IDescable
        {
            public string name;
            public int typeIntFix;
            public string desc;

            public Weapon(string n,string d,int i)
            {
                name = n;
                typeIntFix = i;
                desc = d;
            }

            public override string ToString()
            {
                return name;
            }

            public string GetDesc()
            {
                return desc;
            }
        }

        public class Armour : IDescable
        {
            public string name;
            public int armourInt;
            public string desc;

            public Armour(string n,string d,int i)
            {
                name = n;
                armourInt = i;
                desc = d;
            }

            public override string ToString()
            {
                return name;
            }

            public string GetDesc()
            {
                return desc;
            }
        }

        public class Skill : IDescable
        {
            public string name;
            public int index;
            public string desc;

            public Skill(string n,string d,int i)
            {
                name = n;
                index = i;
                desc = d;
            }

            public override string ToString()
            {
                return name;
            }

            public string GetDesc()
            {
                return desc;
            }
        }

        public class Talent : IDescable
        {
            public string name;
            public int index;
            public string desc;

            public Talent(string n,string d,int i)
            {
                name = n;
                index = i;
                desc = d;
            }

            public override string ToString()
            {
                return name;
            }

            public string GetDesc()
            {
                return desc;
            }
        }

        public class Medal : IDescable
        {
            public string name;
            public string desc;

            public Medal(string n, string d)
            {
                name = n;
                desc = d;
            }

            public override string ToString()
            {
                return name;
            }

            public string GetDesc()
            {
                return desc;
            }
        }

        private string moeString = " ~ 少女祈祷中";

        //The moe text in title of application 
        public void getMoeString()
        {
            try
            {
                WebRequest webRequest = WebRequest.Create("http://www.hakugyokurou.net/api/randomword.php");
                WebResponse webRespone = webRequest.GetResponse();
                StreamReader sr = new StreamReader(webRespone.GetResponseStream(),Encoding.UTF8);
                moeString = " ~ " + sr.ReadToEnd();
                sr.Close();
                Random random = new Random();
                if (random.Next(2) == 1)
                {
                    moeString = " ~ " + moeStringLite[random.Next(moeStringLite.Length)];
                }
            }
            catch
            {
                string[] newString = new string[moeStringLite.Length + moeStringExtra.Length];
                Array.Copy(moeStringExtra,newString,moeStringExtra.Length);
                Array.Copy(moeStringLite,0, newString, moeStringExtra.Length,moeStringLite.Length);
                Random random = new Random();
                moeString = " ~ " + newString[random.Next(newString.Length)];
            }
        }

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
            sniper.weapons = new Weapon[] { snp };
            sniper.armours = new Armour[] { light, mid, heave };
            sniper.talents = new Talent[] { wiring, running, thinkering };
            medic.weapons = new Weapon[] { rif };
            medic.armours = new Armour[] { light, mid, heave };
            medic.talents = new Talent[] { wiring, toughness, hacking };
            tactician.weapons = new Weapon[] { rif };
            tactician.armours = new Armour[] { light, mid, heave };
            tactician.talents = new Talent[] { wiring, running, hacking };
            psy.weapons = new Weapon[] { rif };
            psy.armours = new Armour[] { light, mid, heave };
            psy.talents = new Talent[] { wiring, spotting, hacking };
            maverick.weapons = new Weapon[] { rif2,snp2,chi2,rok2,flm2 };
            maverick.armours = new Armour[] { light, mid, heave };
            maverick.talents = new Talent[] { running, thinkering, hacking };
            heavy.weapons = new Weapon[] { chi };
            heavy.armours = new Armour[] { light, mid, heave };
            heavy.talents = new Talent[] { running, toughness, thinkering };
            demo.weapons = new Weapon[] { rok };
            demo.armours = new Armour[] { light, mid, heave };
            demo.talents = new Talent[] { running, spotting, toughness };
            cyborg.weapons = new Weapon[] { chiV };
            cyborg.armours = new Armour[] { adv };
            cyborg.talents = new Talent[] { running, spotting, hacking };
            pyro.weapons = new Weapon[] { flm };
            pyro.armours = new Armour[] { light, mid, heave };
            pyro.talents = new Talent[] { spotting, toughness, thinkering };
            watchman.weapons = new Weapon[] { las,lasChi };
            watchman.armours = new Armour[] { adv };
            watchman.talents = new Talent[] { spotting, toughness, thinkering };
            techops.weapons = new Weapon[] { snp };
            techops.armours = new Armour[] { light, mid, heave };
            techops.talents = new Talent[] { hacking, wiring, thinkering };
            clone.weapons = new Weapon[] { pis };
            clone.armours = new Armour[] { light, mid, heave };
            clone.talents = new Talent[] { wiring, spotting, toughness };

            listBoxType.Items.Add(sniper);
            listBoxType.Items.Add(medic);
            listBoxType.Items.Add(tactician);
            listBoxType.Items.Add(psy);
            listBoxType.Items.Add(maverick);
            listBoxType.Items.Add(heavy);
            listBoxType.Items.Add(demo);
            listBoxType.Items.Add(cyborg);
            listBoxType.Items.Add(pyro);
            listBoxType.Items.Add(watchman);
            listBoxType.Items.Add(techops);
            listBoxType.Items.Add(clone);

            foreach (Medal m in medal)
            {
                checkedListBoxXZ.Items.Add(m, true);
            }
        }

        private int getMedal(int i)
        {
            if(i!=5 && checkedListBoxXZ.GetItemChecked(i))
            {
                return 1; 
            }
            if (i == 5)
            {
                int a = checkedListBoxXZ.GetItemChecked(5) ? 1 : 0;
                int b = checkedListBoxXZ.GetItemChecked(6) ? 1 : 0;
                int c = checkedListBoxXZ.GetItemChecked(7) ? 1 : 0;
                return a + b + c;
                //Damned hard code.
            }
            return 0;
        }

        private int getPlayerLevel()
        {
            //return 14;
            return ((int)numericUpDown1.Value)-1;
        }

        private string getPlayerName()
        {
            return textBoxPlayerName.Text;
        }

        private int getMou(int i, int j)
        {
            return (i - i % j) / j;
        }

        //Gen code!!
        private string getCode(int type, int armour, int trait, int spec, int talent, int diff, int level, int unusedXP, int medal1, int medal2, int medal3, int medal4, int medal5, int medal6)
        {
            string code1 = getFirstCode(type, armour, trait, spec, talent, diff, level, unusedXP, medal1, medal2, medal3, medal4, medal5, medal6);
            //richTextBox1.AppendText("Debug - Ep:" + code1);
            //richTextBox1.AppendText("\n");
            string code2 = getSecondCode(type, armour, trait, spec, talent, diff, level, unusedXP, medal1, medal2, medal3, medal4, medal5, medal6);
            //richTextBox1.AppendText("Debug - OldXp:" + code2);
            //richTextBox1.AppendText("\n");
            string code3 = code1.Substring(0, 2) + code2.Substring(4, 1) + code1.Substring(2, 2) + code1.Substring(4, 2) + code2.Substring(3, 1) + code1.Substring(6, 2) + code2.Substring(1, 2) + code1.Substring(8, 3) + code2.Substring(0, 1);
            //richTextBox1.AppendText("Debug - NewXp:" + code3);
            //richTextBox1.AppendText("\n");
            int i = Convert.ToInt32(code3.Substring(0, 1));
            string code4 = code3.Substring(0, 1) + code3.Substring(16 - i) + code3.Substring(1, 15 - i);
            return code4;
        }

        private string fixString(string str, int length)
        {
            while (str.Length < length)
            {
                str = "0" + str;
            }
            return str;
        }

        private string getFirstCode(int type, int armour, int trait, int spec, int talent, int diff, int level, int unusedXP, int medal1, int medal2, int medal3, int medal4, int medal5, int medal6)
        {
            //return "57794000019";
            int random = new Random().Next(0, 5) * 2;
            if (type == 0)
            {
                if (talent == 1)
                    talent = 1;
                else if (talent == 2)
                    talent = 2;
                else if (talent == 5)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type == 1)
            {
                if (talent == 1)
                    talent = 1;
                else if (talent == 4)
                    talent = 2;
                else if (talent == 6)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type == 2)
            {
                if (talent == 1)
                    talent = 1;
                else if (talent == 2)
                    talent = 2;
                else if (talent == 6)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type == 3)
            {
                if (talent == 1)
                    talent = 1;
                else if (talent == 3)
                    talent = 2;
                else if (talent == 6)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type>9&&type<15)
            {
                if (talent == 2)
                    talent = 1;
                else if (talent == 6)
                    talent = 2;
                else if (talent == 5)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type == 4)
            {
                if (talent == 2)
                    talent = 1;
                else if (talent == 4)
                    talent = 2;
                else if (talent == 5)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type == 5)
            {
                if (talent == 2)
                    talent = 1;
                else if (talent == 4)
                    talent = 2;
                else if (talent == 3)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type == 6)
            {
                if (talent == 3)
                    talent = 1;
                else if (talent == 2)
                    talent = 2;
                else if (talent == 6)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type == 7)
            {
                if (talent == 3)
                    talent = 1;
                else if (talent == 5)
                    talent = 2;
                else if (talent == 4)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type>7&&type<10)
            {
                if (talent == 4)
                    talent = 1;
                else if (talent == 5)
                    talent = 2;
                else if (talent == 3)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type == 15)
            {
                if (talent == 1)
                    talent = 1;
                else if (talent == 5)
                    talent = 2;
                else if (talent == 6)
                    talent = 3;
                else
                    talent = 0;
            }
            else if (type == 16)
            {
                if (talent == 1)
                    talent = 1;
                else if (talent == 3)
                    talent = 2;
                else if (talent == 4)
                    talent = 3;
                else
                    talent = 0;
            }
            if (type == 6)
            {
                armour = 2;
            }
            if (type == 8)
            {
                armour = 0;
                type = 6;
            }
            if (type == 9)
            {
                type = 6;
                armour = 1;
            }
            if (type > 9)
            {
                type -= 10;
                random++;
            }
            if (armour > 2)
            {
                armour = 2;
            }
            if (level > 10)
            {
                if ((medal1 + medal2) > 1)
                {
                    level = 14;
                }
                else if (medal1 > 0)
                {
                    level = 13;
                }
                else if (medal2 > 0)
                {
                    level = 12;
                }
            }
            if (level > 8)
            {
                if (diff < 4)
                {
                    if (medal3 < 1)
                    {
                        diff = 1;
                    }
                    else
                    {
                        diff = 2;
                    }
                }
                else
                {
                    if (medal3 < 1)
                    {
                        diff = 3;
                    }
                }
            }
            else if (level > 5 && diff < 2)
            {
                diff = 2;
            }
            else if (level > 2 && diff < 1)
            {
                diff = 1;
            }
            if (level < 9)
            {
                if (diff < 3)
                {
                    medal4 = 0;
                    medal5 = 0;
                }
                else if (diff < 1)
                {
                    medal6 = 0;
                }
            }
            int code = getMou(unusedXP, 10) + 50 * level + 50 * 15 * diff + 50 * 15 * 5 * medal4 + 50 * 15 * 5 * 2 * medal5 + 50 * 15 * 5 * 2 * 2 * medal6;
            code += 50 * 15 * 5 * 2 * 2 * 4 * (type + 8 * armour + 8 * 3 * trait + 8 * 3 * 18 * spec + 8 * 3 * 18 * 9 * talent);
            return random.ToString() + fixString(code.ToString(), 9) + (unusedXP % 10).ToString();
        }

        private string getSecondCode(int type, int armour, int trait, int spec, int talent, int diff, int level, int unusedXP, int medal1, int medal2, int medal3, int medal4, int medal5, int medal6)
        {
            //return "68714";
            int BF=type + 20;
            int ol=talent;
            if(BF == 6)
            {
                if(ol==3)
                    talent=1;
            }
            else if(BF == 7)
            {
                if(ol==4)
                    talent=6;
                else if(ol==3)
                    talent=2;
            }
            else if(BF == 8 || BF == 9)
            {
                if(ol==3)
                    talent=6;
            }
            else if(BF >9 && BF < 15)
            {
                if(ol==6)
                    talent=4;
            }
            else if(BF == 4)
            {
                if(ol==2)
                    talent=3;
            }
            else if(BF == 1)
            {
                if(ol==4)
                    talent=3;
            }
            else if(BF == 3)
            {
                if(ol==6)
                    talent=4;
            }
            else if(BF == 0)
            {
                if(ol==2)
                    talent=3;
            }
            else if(BF == 5)
            {
                if(ol==3)
                    talent=6;
            }
            else if(BF == 2)
            {
                if(ol==6)
                    talent=3;
            }
            else if(BF == 15)
            {
                talent = 0;
            }
            string ym = getThirdCode(type, armour, trait, spec, talent, diff, level, unusedXP, medal1, medal2, medal3, medal4, medal5, medal6);
            talent = ol; //wtf? it is not ref! what the hell I thought when I wrote it!
            return ym;
        }

        private string getThirdCode(int type, int armour, int tianfu1, int tianfu2, int teji, int diff, int level, int unusedXP, int xz1, int xz2, int xz3, int xz4, int xz5, int xz6)
        {
            //talent = 5;
            int i = getPlayerNameInt2(getPlayerName()) * (tianfu2 + 1) + (tianfu1 + 4) * (tianfu1 + 6) + (level + 1) * (unusedXP + 1) + (teji + 1) * 43 * factor1[getPlayerNameInt2(getPlayerName()) % 10] - (type + 1) * (241 + factor2[getPlayerNameInt2(getPlayerName()) % 10]) - (xz6 + 1) * 50;
            //richTextBox1.AppendText("i1:" + i);
            //richTextBox1.AppendText("\n");
            i+=(xz1+1)*4+(xz2+1)*9+(xz3+1)*19+(xz4+1)*39+(xz5+1)*79+(armour+1)*159;
            //richTextBox1.AppendText("i2:" + i);
            //richTextBox1.AppendText("\n");
            i += 100 * (diff + 1) * (i % 1000);
            //richTextBox1.AppendText("i3:" + i);
            //richTextBox1.AppendText("\n");
            while (i >= 100000)
            {
                i = (i % 100000) + getMou(i, 100000);
            }
            return fixString(i.ToString(),5);
            /*int i = getPlayerNameInt(getPlayerName()) * (talent + 1) + (type + 4) * (type + 6) + (level + 1) * (unusedXP + 1) + (spec + 1) * 7654 - (trait + 1) * 419 - (armour + 1) * 50;
            richTextBox1.AppendText("i1:" + i);
            richTextBox1.AppendText("\n");
            i += (medal1 + 1) * 4 + (medal2 + 1) * 9 + (medal3 + 1) * 19 + (medal4 + 1) * 39 + (medal5 + 1) * 79 + (medal6 + 1) * 159;
            richTextBox1.AppendText("i2:" + i);
            richTextBox1.AppendText("\n");
            i += 100 * (diff + 1) * (i % 1000);*/
        }

        private int getPlayerNameInt2(string name)
        {
            char[] cs = name.ToCharArray();
            int i = 0;
            int j = 0;
            int loop = 1;
            foreach (char c in cs)
            {
                if (c == 'r' || c == 'R') i = 12;
                else if (c == 'd' || c == 'D') i = 25;
                else if (c == 'y' || c == 'Y') i = 23;
                else if (c == 'n' || c == 'N') i = 22;
                else if (c == 's' || c == 'S') i = 13;
                else if (c == 'z' || c == 'Z') i = 36;
                else if (c == 'q' || c == 'Q') i = 35;
                else if (c == 'c' || c == 'C') i = 24;
                else if (c == 't' || c == 'T') i = 14;
                else if (c == 'g' || c == 'G') i = 30;
                else if (c == 'f' || c == 'F') i = 33;
                else if (c == 'w' || c == 'W') i = 32;
                else if (c == 'x' || c == 'X') i = 31;
                else if (c == 'o' || c == 'O') i = 21;
                else if (c == 'l' || c == 'L') i = 15;
                else if (c == 'i' || c == 'I') i = 19;
                else if (c == 'b' || c == 'B') i = 37;
                else if (c == 'p' || c == 'P') i = 26;
                else if (c == 'a' || c == 'A') i = 18;
                else if (c == 'u' || c == 'U') i = 20;
                else if (c == 'e' || c == 'E') i = 17;
                else if (c == 'k' || c == 'K') i = 28;
                else if (c == 'v' || c == 'V') i = 34;
                else if (c == 'j' || c == 'J') i = 27;
                else if (c == 'm' || c == 'M') i = 16;
                else if (c == 'h' || c == 'H') i = 29;
                else if (c == '1') i = 9;
                else if (c == '0') i = 11;
                else if (c == '6') i = 8;
                else if (c == '5') i = 10;
                else if (c == '7') i = 6;
                else if (c == '9') i = 2;
                else if (c == '4') i = 3;
                else if (c == '2') i = 7;
                else if (c == '3') i = 5;
                else if (c == '8') i = 4;
                else if (c == '_') i = 1;
                else if (c == '(' || c == ')') i = 38;
                else if (c == '-') i = 39;
                else if (c == '[' || c == ']') i = 40;
                else if (c == '.') i = 41;
                else if (c == '!') i = 42;
                else
                {
                    int number = Encoding.UTF8.GetByteCount(new char[] { c });
                    i = number * 43;
                }
                j += i * ((loop % 3) + 1);
                loop++;
            }
            //richTextBox1.AppendText("Debug - PlayerInt:" + j.ToString());
            //richTextBox1.AppendText("\n");
            return j;
        }

        //时代的眼泪,无视它吧
        //UNUSED! UNUSED! UNUSED!
        private int getPlayerNameInt(string name)
        {
            char[] cs = name.ToCharArray();
            int i = 0;
            int j = 0;
            int loop = 1;
            foreach (char c in cs)
            {
                if (c == 'a' || c == 'A') i = 12;
                else if (c == 'b' || c == 'B') i = 25;
                else if (c == 'c' || c == 'C') i = 23;
                else if (c == 'd' || c == 'D') i = 22;
                else if (c == 'e' || c == 'E') i = 13;
                else if (c == 'f' || c == 'F') i = 36;
                else if (c == 'g' || c == 'G') i = 35;
                else if (c == 'h' || c == 'H') i = 24;
                else if (c == 'i' || c == 'I') i = 14;
                else if (c == 'j' || c == 'J') i = 30;
                else if (c == 'k' || c == 'K') i = 33;
                else if (c == 'l' || c == 'L') i = 32;
                else if (c == 'm' || c == 'M') i = 31;
                else if (c == 'n' || c == 'N') i = 21;
                else if (c == 'o' || c == 'O') i = 15;
                else if (c == 'p' || c == 'P') i = 19;
                else if (c == 'q' || c == 'Q') i = 37;
                else if (c == 'r' || c == 'R') i = 26;
                else if (c == 's' || c == 'S') i = 18;
                else if (c == 't' || c == 'T') i = 20;
                else if (c == 'u' || c == 'U') i = 17;
                else if (c == 'v' || c == 'V') i = 28;
                else if (c == 'w' || c == 'W') i = 34;
                else if (c == 'x' || c == 'X') i = 27;
                else if (c == 'y' || c == 'Y') i = 16;
                else if (c == 'z' || c == 'Z') i = 29;
                else if (c == '0') i = 9;
                else if (c == '1') i = 11;
                else if (c == '2') i = 8;
                else if (c == '3') i = 10;
                else if (c == '4') i = 6;
                else if (c == '5') i = 2;
                else if (c == '6') i = 3;
                else if (c == '7') i = 7;
                else if (c == '8') i = 5;
                else if (c == '9') i = 4;
                else if (c == '_') i = 1;
                else if (c == '-') i = 38;
                else if (c == '!') i = 39;
                else if (c == '.') i = 40;
                else if (c == '(' || c == ')') i = 41;
                else if (c == '[' || c == ']') i = 42;
                else i = 43;
                j += i * ((loop % 3) + 1);
                loop++;
            }
            //richTextBox1.AppendText("Debug - PlayerInt:" + j.ToString());
            //richTextBox1.AppendText("\n");
            return j;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxType.SelectedItem == null ||
                listBoxTal.SelectedItem == null ||
                listBoxSk2.SelectedItem == null ||
                listBoxSk1.SelectedItem == null ||
                listBoxWeapon.SelectedItem == null ||
                listBoxArmour.SelectedItem == null)
            {
#if CHINESE
                richTextBox1.AppendText("无法输出,你有一项或多项未选择.");
#else
                richTextBox1.AppendText("Error: one or several options are unselected.");
#endif
                richTextBox1.AppendText("\n");
                return;
            }
            if (getPlayerName().Equals(""))
            {
#if CHINESE
                richTextBox1.AppendText("注意,你当前的用户名是空白的.");
#else
                richTextBox1.AppendText("Warning: your username is empty.");
#endif
                richTextBox1.AppendText("\n");
            }
            string str = "";
            try
            {
                ClassType classType = (ClassType)listBoxType.SelectedItem;
                Weapon weapon = (Weapon)listBoxWeapon.SelectedItem;
                Armour armour = (Armour)listBoxArmour.SelectedItem;
                Skill sk1 = (Skill)listBoxSk1.SelectedItem;
                Skill sk2 = (Skill)listBoxSk2.SelectedItem;
                Talent talent = (Talent)listBoxTal.SelectedItem;
                //string str = getCode(1, 1, 2, 2, 1, 4, 11, 0, 1, 1, 1, 1, 1, 1);
                str = getCode(classType.typeInt + weapon.typeIntFix, armour.armourInt, sk1.index, sk2.index, talent.index, 4, getPlayerLevel(), 0, getMedal(0), getMedal(1), getMedal(2), getMedal(3), getMedal(4), getMedal(5));
            }
            catch (Exception ex)
            {
#if CHINESE
                richTextBox1.AppendText("出现一个未知的错误,导致算号失败.\n");
                richTextBox1.AppendText("请把这个错误报告给作者:\n");
                richTextBox1.AppendText(ex.Message);
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText("很抱歉刷分器挂掉了/v\\ 不好意思...\n");
                
#else
                richTextBox1.AppendText("Generating failed.\n");
                richTextBox1.AppendText("Please report this exception to szszss:\n");
                richTextBox1.AppendText(ex.Message);
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText("Sorry... /v\\\n");
#endif
            return;
            }
            if (checkBox1.Checked)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(str);
                }
                catch
                {
#if CHINESE
                    richTextBox1.AppendText("未能写入剪切板,请手动复制下列密码:");
#else
                    richTextBox1.AppendText("Failed to auto-copy, please copy this code by yourself:");
#endif
                    richTextBox1.AppendText("\n");
                }
            }
            richTextBox1.AppendText(str);
            richTextBox1.AppendText("\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DO NOTHING!
        }

        private void listBoxType_MouseMove(object sender, MouseEventArgs e)
        {
            int i = ((ListBox)sender).IndexFromPoint(e.Location);
            if (i == -1)
            {
                toolTip1.SetToolTip((ListBox)sender, "");
                return;
            }
            if (toolTip1.GetToolTip((ListBox)sender).Equals(((IDescable)((ListBox)sender).Items[i]).GetDesc()))
            {
                return;
            }
            toolTip1.SetToolTip((ListBox)sender, ((IDescable)((ListBox)sender).Items[i]).GetDesc());
        }

        private void listBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset((ClassType)listBoxType.SelectedItem);
        }

        private void reset(ClassType classType)
        {
            if (!selOne)
            {
                listBoxSk1.Items.AddRange(traits);
                listBoxSk2.Items.AddRange(specialization);
                selOne = true;
            }
            listBoxWeapon.Items.Clear();
            listBoxWeapon.Items.AddRange(classType.weapons);
            listBoxArmour.Items.Clear();
            listBoxArmour.Items.AddRange(classType.armours);
            listBoxTal.Items.Clear();
            listBoxTal.Items.Add(courage);
            listBoxTal.Items.AddRange(classType.talents);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 12)
            {
                checkedListBoxXZ.SetItemChecked(0, false);
                checkedListBoxXZ.SetItemChecked(1, false);
            }
            if (numericUpDown1.Value < 10)
            {
                checkedListBoxXZ.SetItemChecked(2, false);
            }
        }

        private void checkList()
        {
            if (checkedListBoxXZ.GetItemChecked(0) || checkedListBoxXZ.GetItemChecked(1))
            {
                numericUpDown1.Value = 12;
            }
            if (checkedListBoxXZ.GetItemChecked(2) && numericUpDown1.Value < 10)
            {
                numericUpDown1.Value = 10;
            }
        }

        private void checkedListBoxXZ_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //checkList();
        }

        private void checkedListBoxXZ_Click(object sender, EventArgs e)
        {
            checkList();
        }

        private void checkedListBoxXZ_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            checkList();
        }

        private void checkedListBoxXZ_MouseDown(object sender, MouseEventArgs e)
        {
            checkList();
        }

        private void checkedListBoxXZ_MouseUp(object sender, MouseEventArgs e)
        {
            checkList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://night.org/swat2/playerdb/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hakugyokurou.net/wordpress/?page_id=341");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutWin.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            getMoeString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Text = this.Text + moeString;
        }
    }
}
