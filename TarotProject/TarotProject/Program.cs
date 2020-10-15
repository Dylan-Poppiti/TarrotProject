using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TarotProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //

            string[] Suits = { "Wands", "Cups", "Swords", "Pentacles" };
            string[] MinorValues = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Page", "Knight", "Queen", "King" };
            string[] MajorNames = { "The Fool","The Magician","The High Priestess","The Empress","The Emperor","The Hierophant", "The Lovers",
                "The Chariot","Strength","The Hermit","Wheel of Fortune","Justice","The Hanged Man","Death",
                "Temperance","The Devil", "The Tower","The Star","The Moon","The Sun","Judgment","The World" };
            Spread[] SpreadName = { new Spread("Tetraktys",10),new Spread("Cross and Triangle",9),new Spread("Celtic Cross",10),new Spread("Astrological",13),new Spread("Relationship",9),new Spread("Planetary",8),
                new Spread("Birthday",9),new Spread("Mandala",9),new Spread("Star Guide",6),new Spread("Tree of Life",10),new Spread("Past Life",8), new Spread("Dream Exploration",3), new Spread("General",15), new Spread("5 DeckCrd",5)};

            List<Card> MinorDeck = new List<Card>();
            //for(int i = 0; i < MinorValues.Length; i++)
            //{
            //    for(int s = 0; s < Suits.Length; s++)
            //    {
            //        Card DeckCrd = new Card(Suits[s], MinorValues[i]);
            //        Card.Add(DeckCrd);
            //    }
            //}

            //Pentacles King -> 1
            string[] sMeaning = { "A Rich Man", "steady", "reliable", "earthly", "helpful", "sensual" };
            string[] rMeaning = { "Too Materialistic", "stuborn", "preverse use of talents", "Dangerous when Angry", "Addiction to physical Comfort" };
            Card DeckCrd = new Card(Suits[3] + " " + MinorValues[13], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Queen
            sMeaning = new string[] { "Warm", "Generous woman who has the seekers best interest", "No Fear of Hard Work", "Monetary Gifts", "Intelligence", "Thoughtfulness" };
            rMeaning = new string[] { "Too Dependent", "Duties Neglected", "Untrusting", "False Prosperity", "Changeable Nature Due to Fear of Failure" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[12], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Knight
            sMeaning = new string[] { "Mature Man", "Responsible", "Reliable", "Utilitarian", "A Person Who Will Help the Seeker", "Honorable", "Solid", "Travel is Possible" };
            rMeaning = new string[] { "Problem at Work", "Warning Against Travel", "The Seeker should Gaurd against Deceit", "Carlessness", "inertia", "Laziness" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[11], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Page
            sMeaning = new string[] { "Careful Child", "Deep Concentration", "Scholarship News", "Bringer of Messages", "Make the Seeker Proud" };
            rMeaning = new string[] { "Bad News", "Delinquency", "Illogical", "Thoughtless", "Wastefulness" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[10], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Ten
            sMeaning = new string[] { "Prosperity", "Riches", "Home and family matters", "Positive domestic changes" };
            rMeaning = new string[] { "Loss of Belongings", "Emotional Loss or a Death", "Gamblining", "Bad Risk" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[9], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Nine
            sMeaning = new string[] { "Solitary wealth and luxury", "Accomplishment", "Discretion", "Safety", "Security", "Femininity", "Material Comfort", "Love of Nature", "Solitary Achievements", "Working Alone" };
            rMeaning = new string[] { "Threat", "Loss of Security", "Danger" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[8], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Eight
            sMeaning = new string[] { "Leanring", "Apprenticeship", "Gaining New Knowledge/Skill", "Working Very Hard at Low-Paying Levels", "Nose to the Grindstone", "Creation" };
            rMeaning = new string[] { "Lack of Emotion", "Vanity", "Caution Against Borrowning Money" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[7], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Seven
            sMeaning = new string[] { "Material Progress", "Cleverness", "Growth Through Hard Work", "Surprisingly Good News", "Help Will Prove Useful" };
            rMeaning = new string[] { "Anxiety About Finances", "Money Lost", "Bad Investments" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[6], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Six
            sMeaning = new string[] { "Gratification", "Help with Finances", "Return of a Favor", "Gifts", "Stability", "Gratifying Your Desire to Help or Repay Another" };
            rMeaning = new string[] { "Jealousy Can Cause Harm", "Unstable Finances Frustrante Plans", "Desire", "Avarice", "A Bad Debt" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[5], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Five
            sMeaning = new string[] { "Misery", "Destitution", "Loss", "Loneliness", "Being out in the Cold", "Lovers Who Cannot Find a Meeting Place", "Poor Health", "Spiritual Impoverishment" };
            rMeaning = new string[] { "Lessons in Charity to be Learned", "New Employement", "New Courage", "New Interest in Spiritual Matter" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[4], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Four
            sMeaning = new string[] { "Miser", "Miserliness", "Greed", "Selfishness", "Avarice", "Suspicion", "Mistrust", "Inability to Let Go of Anything", "An Emotional Black Hole", "Shortsightedness", "Imbalance", "Desperation" };
            rMeaning = new string[] { "Suspense of Gain", "Opposition", "Reversal of Fortunes" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[3], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Three
            sMeaning = new string[] { "Master Craftsman", "Skills and Abilities will be Appreciated and Rewarded", "Artistic Ability", "Rank", "Power", "Achievement", "Success Through Effort" };
            rMeaning = new string[] { "Slopiness in Workmanship", "Delay of Recognition or Recompense", "Preoccupation with Gain at the Cost of Craft", "Mediocrity" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[2], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Two
            sMeaning = new string[] { "The Juggler/Balance", "Ability to Handle several things at once", "Harmony in the Midst of Conflict and Change", "Fun and Games", "Knowing the Ropes", "Balance in Self and Life", "Control" };
            rMeaning = new string[] { "Too Much to Handle", "Instability", "Lack of Control", "Forced Gaiety" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[1], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Pentacles Ace
            sMeaning = new string[] { "Reward", "Riches", "Pure Contentment", "Attainment", "Bright Prospect", "Prosperity (Matieralistic and Spiritual)" };
            rMeaning = new string[] { "Unhappiness with Wealth", "Misuse of Power", "Corruption" };
            DeckCrd = new Card(Suits[3] + " " + MinorValues[0], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Sword King -> 1
            sMeaning = new string[] { "Perceptive", "Intelligent", "Strong Willed Person" };
            rMeaning = new string[] { "Cruel", "Hardhearted", "Pig-headed", "Untrustworthy", "Crafty" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[13], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Queen
            sMeaning = new string[] { "Strong", "Confident", "Quick-Witted", "Intensely Perceptive" };
            rMeaning = new string[] { "Keeness", "Sharpened to Cruelty", "Sly", "Deceitful", "Narrow-Minded", "Gossip", "Quarelsome" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[12], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Knight
            sMeaning = new string[] { "A Soldier", "Heroic", "Brave", "Righteous Anger", "Triumph Over an Opposition", "Practical Solution to a Problem" };
            rMeaning = new string[] { "Unsuccessful", "Erratic Behavior", "Bad Judgment", "Extravagance", "Seeker Makes an Impulsive Mistake" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[11], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Page
            sMeaning = new string[] { "Vigilance", "Agility", "Insight", "Keen Vision", "Service Done in Secret", "Help from a Younger Person" };
            rMeaning = new string[] { "Childish Cruelty", "Unfortunate Circumstance", " Unforeseen", "Vulnerability in the Face of Opposing Force" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[10], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Ten
            sMeaning = new string[] { "Misfortune", "Ruin", "Defeat", "Loss", "Failure", "Pain", "Desolation", "Beynd Tears", "Alternatively, Evils or Misfortunes Which are Over" };
            rMeaning = new string[] { "Evil Overthrown", "Courage", "Success", "Recovery", "Turning Toward Higher Source" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[9], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Nine
            sMeaning = new string[] { "Suffering", "Desolation", "Doubt", "Suspicion", "Misery", "Dishonesty", "Slander", "Vicious Circle", "Illness or Injury to a Loved One", "Alternatively, Troubles which Aren't Over/The Worst is Yet to Come" };
            rMeaning = new string[] { "End to Suffering", "Desolation", "Doubt", "Patience", "Faithfulnesss", "Good News About a Loved One" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[8], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Eight
            sMeaning = new string[] { "Fear", "Bondage", "Paralysis Due to Censure", "Indecision", "Illness", "Difficulties", "Nearly Impossible Task", "Prison" };
            rMeaning = new string[] { "Respite from Fear", "New Beginnings", "Freedom", "Release" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[7], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Seven
            sMeaning = new string[] { "Failure of a Plan", "Taking Something That Belongs to Another", "Unreliability", "Betrayal", "Spying", "Less-Than-Honorable Action", "Stealth", "Alternatively, Brave and Care" };
            rMeaning = new string[] { "Anxiety About Finances", "Money Lost", "Bad Investments" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[6], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Six
            sMeaning = new string[] { "Water Journey", "Passage to a Higher State of Consciousness", "Leaving Difficulties for a Safe Refuge", "Finding an Understanding" };
            rMeaning = new string[] { "No Escape", "Journey Postponed", "A Trip to a Higher Level of Consciousness is Advised" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[5], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Five
            sMeaning = new string[] { "Failure", "Defeat", "Degradation", "Winning by Unfair Means", "Trickery", "Cowardice", "Manipulation", "A Loss Decreed by the Gods" };
            rMeaning = new string[] { "Same as Upright Meaning, but Lessened", "Empty Victory", "Unfairness and Slyness in Dealing with Others" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[4], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Four
            sMeaning = new string[] { "Rest", "Seclusion", "Convalescence", "Return to the Basics", "Meditation" };
            rMeaning = new string[] { "An End to Rest", "Return to Active Life" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[3], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Three
            sMeaning = new string[] { "Sorrow", "Loss", "Emotional Pain", "Grief", "Separation", "End of an Affair of the Heart" };
            rMeaning = new string[] { "Same as upright Meaning, but less Exptreme" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[2], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Two
            sMeaning = new string[] { "Dangerous Spot", "Precarious Balance", "Possible Probems Ahead", "A Choice of the Lesser of Two Evils", "Seeker has the Knowledge and Ability to Balance the Situation and make the Best of it." };
            rMeaning = new string[] { "The Waiting is Over", "Stalemate Ended", "Beware of New Situation", "Seeker or Someone known to the seeker, may travel soon" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[1], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Sword Ace
            sMeaning = new string[] { "Seeker Might be a Champion", "Hero", "Leader", "Birth of a Valiant Child may be Indicated", "Attainment of Power or Goals" };
            rMeaning = new string[] { "Excessive Use of Force", "Destruction", "Obstacles", "Tyranny", "Separation", "Beware of Using Too Much Power to Gain Your Ends" };
            DeckCrd = new Card(Suits[2] + " " + MinorValues[0], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Wand King -> 1
            sMeaning = new string[] { "Man of Passion", "Handsome", "Conscientious", "Noble", "Strong", "Sometimes Hasty" };
            rMeaning = new string[] { "Severe Man", "Harsh", "Opinionated", "Strict", "Quarrelsome", "Intolerant or Prejudiced" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[13], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Queen
            sMeaning = new string[] { "Considerable Energy", "Very Active", "Very Passionate", "Found of Nature", "Generous", "Practical" };
            rMeaning = new string[] { "Strict", "Domineering", "Jealous", "Vengeful", "Decietful", "Passion overrules all other concerns", "Tendancy Toward Unfaithfulness" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[12], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Knight
            sMeaning = new string[] { "A Journey", "Practical Action Taken in Spite of Distractions", "Change of Residence" };
            rMeaning = new string[] { "Separation", "Discord", "Misunderstanding", "Progress Interrupted", "A Quarrel" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[11], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Page
            sMeaning = new string[] { "Child With Too Much Energy", "Faithful or Loyal", "Stranger explodes into the Seekers Life with Good Intentions", "Great Idea Leading to Success", "Good Employee" };
            rMeaning = new string[] { "Childish Pranks", "Indecision", "Bad News", "Behavior of an Acquaintance Leads theSeeker to Doubt his or her Sincerity", "Gossip" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[10], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Ten
            sMeaning = new string[] { "Success Becomes Opression", "Heavy Burdern", "Martyr Complex", "Too Willing to do Other's Work", "Takes more than the Seeker Can Handle" };
            rMeaning = new string[] { "Selfishness", "Shifting Responsibility", "Passing the Buck" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[9], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Nine
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[8], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Eight
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[7], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Seven
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[6], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Six
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[5], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Five
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[4], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Four
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[3], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Three
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[2], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Two
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[1], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Wand Ace
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[0] + " " + MinorValues[0], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Cup King -> 1
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[13], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Queen
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[12], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Knight
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[11], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Page
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[10], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Ten
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[9], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Nine
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[8], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Eight
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[7], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Seven
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[6], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Six
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[5], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Five
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[4], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Four
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[3], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Three
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[2], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Two
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[1], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            //Cup Ace
            sMeaning = new string[] { "" };
            rMeaning = new string[] { "" };
            DeckCrd = new Card(Suits[1] + " " + MinorValues[0], sMeaning, rMeaning);
            MinorDeck.Add(DeckCrd);

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            List<Card> MajorArcana = new List<Card>();

            //The Fool 0
            sMeaning = new string[] { "Thoughtlessness", "Folly", "Lightheartedness", "Innocence" };
            rMeaning = new string[] { "Carelessness", "Vanity", "Indecision", "Poor Judgment", "Apathy" };
            Card C = new Card("The Fool", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Magician 1

            sMeaning = new string[] { "Skill", "Self-Reliance", "Originality", "Creativity", "Imagination", "Diplomacy" };
            rMeaning = new string[] { "Unskilled", "Clumsy", "Insecure", "Disgraced" };
            C = new Card("The Magician", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The High Priestess 2

            sMeaning = new string[] { "Practicality", "Good Judgment", "Wisdom", "Mystery", "The Clouded Future" };
            rMeaning = new string[] { "Passion", "Conceit", "Lack of Sense", "Poor Intuition", "Ignorance", "Bad Judgment" };
            C = new Card("The High Priestess", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Empress 3

            sMeaning = new string[] { "Pregnancy", "Fertility", "Good Advice", "Safety", "Security", "Hidden Actions" };
            rMeaning = new string[] { "Uncertainty", "Infidelity", "Infertility" };
            C = new Card("The Empress", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Emperor 4

            sMeaning = new string[] { "Father Figure", "Stable", "Authoritative", "Powerful Leader" };
            rMeaning = new string[] { "Confusion", "Obstruction", "Immaturity", "Ineffectiveness", "Megalomania", "Weak Character" };
            C = new Card("The Emperor", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Hierophant 5

            sMeaning = new string[] { "Tradition", "Captivity", "Servitude", "Ritual", "Inactivity", "Retention", "Timid" };
            rMeaning = new string[] { "Foolish Generosity", "Eccentricity", "Intrigue", "Weakness" };
            C = new Card("The Hierophant", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Lovers 6

            sMeaning = new string[] { "Love", "Respect", "Partnership", "Trust", "Communication", "Perfection", "Honor", "Romance", "Beauty" };
            rMeaning = new string[] { "Failure", "Unreliability", "Separation", "Frustration in Marriage", "instability", "Confusion", "Silence" };
            C = new Card("The Lovers", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Chariot 7

            sMeaning = new string[] { "Purpose", "Triumph", "Harmony", "Balance", "Work and Travel" };
            rMeaning = new string[] { "Quarrels", "Trouble", "Defeat", "Failure" };
            C = new Card("The Chariot", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //Strength 8

            sMeaning = new string[] { "Power", "Energy", "Stregth", "Courage", "Conviction" };
            rMeaning = new string[] { "Weakness", "Sickness", "Lack of Faith", "Depotism", "Discord", "Abuse of power" };
            C = new Card("Strength", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Hermit 9

            sMeaning = new string[] { "Meditation", "Good Counsel", "Wisdom", "Prudence" };
            rMeaning = new string[] { "Hastiness", "Imprudence", "Unreasoning", "Fear", "Emotional Immaturity" };
            C = new Card("The Hermit", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //Wheel of Fortune 10

            sMeaning = new string[] { "Change", "Destiny", "Fortune", "Good Luck" };
            rMeaning = new string[] { "Failure", "Bad Luck", "Unexpected Interference" };
            C = new Card("Wheel of Fortune", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //Justice 11

            sMeaning = new string[] { "Fairness", "Balance", "Equality", "Rightness", "Negotiations" };
            rMeaning = new string[] { "Bias", "Prejudice", "Bigotry", "Intolerance", "Cruel Punishment" };
            C = new Card("Justice", sMeaning, rMeaning);

            //The Hanged Man 12

            sMeaning = new string[] { "Suspense", "Life Interruped", "Change", "Sacrifice of Wisdom" };
            rMeaning = new string[] { "Useless Gesture", "Wasteful Search", "Selfishness" };
            C = new Card("The Hanged Man", sMeaning, rMeaning);
            MajorArcana.Add(C);
            MajorArcana.Add(C);

            //Death 13

            sMeaning = new string[] { "End of an Era", "Mortality", "Great Change" };
            rMeaning = new string[] { "Lethargy", "Great Inertia", "Depression", "Resisting the Inevitable" };
            C = new Card("Death", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //Temperance 14

            sMeaning = new string[] { "Economy", "Patience", "Moderate Lifestyle", "Meditation", "Moderation" };
            rMeaning = new string[] { "Competitive Interest", "Hostility", "Overly Cautious", "Misunderstanding" };
            C = new Card("Temperance", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Devil 15

            sMeaning = new string[] { "Greed", "Monkey Trap", "Vehement Desire", "Lust", "Disolution", "Fated Choice", "Poor Influence" };
            rMeaning = new string[] { "Realse From Bodage", "Rest", "New Direction" };
            C = new Card("The Devil", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Tower 16

            sMeaning = new string[] { "Suden Change", "Broken Friendships", "Destruction", "Security Lost", "Disgrace" };
            rMeaning = new string[] { "Tyranny", "Opression", "Unchanging", "Monetary Losses" };
            C = new Card("The Tower", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Star 17

            sMeaning = new string[] { "Hope and Faith", "Best of Past and Present", "Bright Prospects", "Awareness of Two Worlds" };
            rMeaning = new string[] { "Laziness and Indifference", "Unrealized Hopes", "Arrogance", "Pride", "Delays", "Hopelessness" };
            C = new Card("The Star", sMeaning, rMeaning);
            MajorArcana.Add(C);
            //The Moon 18

            sMeaning = new string[] { "Warning", "Deception", "Hidden Threats", "Darkness", "Continue Your Path" };
            rMeaning = new string[] { "White Lie", "Trick", "Small Mistake", "Silence", "Stillness", "A Gain With No Cost" };
            C = new Card("The Moon", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The Sun 19

            sMeaning = new string[] { "Accomplishment", "Success", "Material Happiness", "Good Marriage", "Pleasure", "Joy", "Liberation", "Freedom", "Contentment" };
            rMeaning = new string[] { "Lesser Joy", "Separation from Loved Ones", "Delayed Success", "Postponed Security", "Uncertain Future" };
            C = new Card("The Sun", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //Judgement 20

            sMeaning = new string[] { "Change of Position", "Rejuvenation", "Rebirth", "Reward", "Purpose", "Atonement" };
            rMeaning = new string[] { "Weakness", "Lost Affections", "Separation", "Divorce", "Confrontation", "Avoidance of Obligations" };
            C = new Card("Judgement", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //The World 21

            sMeaning = new string[] { "Completion", "End of a Way of Life", "New Beginnings", "Changing Location", "Future Hope", "Triumph", "Admiration of Friends" };
            rMeaning = new string[] { "Disappointment", "Discouraginly small Advance", "Failure", "Cannont Finish", "Permanence", "Stagnation" };
            C = new Card("The World", sMeaning, rMeaning);
            MajorArcana.Add(C);

            //
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
