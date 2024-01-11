using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TripDAL
    {
        public TripDAL()
        {

        }
        public void saveTrip(TripPrice tr)
        {
            using (Database6 ctx = new Database6())
            {
                ctx.TripPrice.Add(tr);
                ctx.SaveChanges();
            }

        }


        //    //       public int NumberOfTravelers { get; set; }
        //    //public DateTime StartDate { get; set; }
        //    //public DateTime EndDate { get; set; }





        //    //public Season Season { get; set; }
        //    //public Audience Audience { get; set; }
        //    //public string ActivityTime { get; set; }


        //    //public string Area { get; set; }
        //}
        public static List<TripSite> GetAlldal()
        {
            try
            {
   using (Database6 ctx = new Database6())
            {

                return ctx.TripSite.ToList();
            }
            }
            catch
            {
                return null;
            }
         
        }

        public void InitTrips()
        {
            
            using (Database6 ctx = new Database6())
            {
                

                ctx.Database.ExecuteSqlCommand("delete from TripSites");
                ctx.TripSite.Add(new TripSite() { SiteName = "חוות האפרסמון", Description = "", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף.ToString(), Audience = Audience.קבוצות.ToString()+',' + Audience.זוגות.ToString(), ActivityTime = "", Phone = "02-9945271", Website = "", Area = "דרום", Settlement = "אלמוג", Email = "erlichg@hotmail.com", Address = "קיבוץ אלמוג, דרום", Contact = "גיא ארליך", Img = "chavathafarsemon1.bmp", Lengthoftrip = "חצי יום", KindTrip = KindTrip.טבע.ToString() });
                ctx.TripSite.Add(new TripSite() { SiteName = " אחוזת דניאלה - חווית גידול אורגני ", Description = "חווית גידול אורגני בחממה ראשונה מסוגה בארץ לגידול ירקות באופן פרטי בכל ימות השנה,  הדרכה צמודה לאורך כל תהליך הגידול עד לתוצר חקלאי.", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString() + "," + Audience.זוגות.ToString() + "," + Audience.ילדים.ToString() + "," + Audience.משפחות.ToString(), ActivityTime = "א' עד ו' 08:00-23:00", Phone = "08-9165163", Website = "", Area = "השפלה וירושלים", Settlement = "מצליח", Email = "yossimoshe4@hotmail.com", Address = "ישוב מצליח", Contact = "יוסף משה", Img = "daniela2.jpg", Lengthoftrip = "חצי יום", KindTrip = KindTrip.טבע.ToString() });
                ctx.TripSite.Add(new TripSite() { SiteName = "מרכז מבקרים ויידור חלון לחקלאות בערבה", Description = "המרכז מציע למבקרים בו, חוויה רב חושית המתמקדת באופיו המיוחד של אזור הערבה. אורחי המרכז נחשפים לחקלאות המתקדמת, לעולם החי והצומח, לאתגרי האקלים, הקרקע והמים במדבר.", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString() + "," + Audience.ילדים.ToString() + "," + Audience.משפחות.ToString(), ActivityTime = "א' עד ש' 10:00-16:00", Phone = "08-6581638", Website = "http://www.vidor-center.co.il", Area = "דרום", Settlement = "חצבה", Email = "visit@arava.co.il", Address = "חצבה, ערבה", Contact = "גיא ארליך", Img = "vidor-center-greenhouse.jpg", Lengthoftrip = "טיול יותר מיום", KindTrip = KindTrip.טבע.ToString() });
                ctx.TripSite.Add(new TripSite() { SiteName = " בשבילי התבור ", Description = " טיולי שטח בנהיגה עצמית כוללת לווי והסברים על האיזור", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString()+"," + Audience.זוגות.ToString() + "," + Audience.ילדים.ToString(), ActivityTime = " א-ה משעה 05:00 עד 23:15 ", Phone = "", Website = "https://batavor.co.il", Area = "צפון", Settlement = "כפר קיש", Email = "DROR8007@GMAIL.COM", Address = "הזית 3, כפר קיש", Contact = "צחי דרור", Img = "tavor.jpg", Lengthoftrip = "טיול יותר מיום", KindTrip = KindTrip.אטרקציה.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = "  תיירות דן חקלאות וטבע בגליל -", Description = "  מחפשים תיירות עם ערך מוסף? אנו מזמינים אתכם לבקר בענפי החקלאות השונים בקיבוץ דן ולקחת חלק בחוויה מעשירה, מרתקת ומחכימה אשר חושפת את מאחורי הקלעים של עולם החקלאות ואף מאפשרת לקחת בהם חלק", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString() + "," + Audience.משפחות.ToString() + "," + Audience.ילדים.ToString(), ActivityTime = "   ימים א'-שבת מ: 08:00 עד 18:00 	", Phone = " 04-6958111", Website = "http://www.dantours.co.il/", Area = "צפון", Settlement = "דן", Email = "tayarut2@kibutzdan.co.il", Address = "קיבוץ דן", Contact = "יעל ארבל", Img = "Dan.jpg", Lengthoftrip = "יום מלא", KindTrip = KindTrip.טבע.ToString() });
                ctx.TripSite.Add(new TripSite() { SiteName = " תיירות יד מרדכי", Description = "   תיירות יד מרדכי מגוון אטרקציות לילדים ולכל המשפחה. פתוחים לקהל הרחב במשך ימות השבוע וחול המועד. פתוחים לקבוצות במהלך כל השנה בתיאום מראש.", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString() + "," + Audience.משפחות.ToString() + "," + Audience.ילדים.ToString(), ActivityTime = "  ימים א'-שבת מ: 08:00 עד 17:00 פתוחים לקהל הרחב בכל שבת ראשונה כל חודש, בחגים וחול המועד.", Phone = " 04-6958111", Website = "https://www.facebook.com/tourym/", Area = "דרום", Settlement = "יד מרדכי", Email = "tym-avital@yadmor.co.il", Address = "קיבוץ יד מרדכי	", Contact = "אביטל כרמי", Img = "mordchi.jpg", Lengthoftrip = "יום מלא", KindTrip = KindTrip.אטרקציה.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = " משק עפאים לחקלאות בת קיימא ", Description = "מרכז המבקרים מציע ביקורים, סיורים, סדנאות וארוחות עשירות כל ימות השנה, בתאום מראש.במשק עפאים לחקלאות בת-קיימא מארחים בחנות ובמרכז מבקרים בסמוך ללול ולדיר העיזים.", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString() + "," + Audience.משפחות.ToString() + "," + Audience.ילדים.ToString(), ActivityTime = "  ימים א'-ו' משעה 08:00 עד 20:00", Phone = " 04-6958111", Website = "   http://www.ofaimme.com/", Area = "דרום", Settlement = "עידן", Email = "adi@ofaimme.com", Address = "", Contact = "חבשוש אליסף", Img = "2023-01-01(3).jpg", Lengthoftrip = "יום מלא", KindTrip = KindTrip.אטרקציה.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = " אדם בטבע  ", Description = "  ??? משק עיזים משפחתי עם מחלבה ליצור גבינות ומרכז מבקרים.אירוח קבוצות, סדנאות, חנות מעדנייה, ארוחת גבינות וקפה.", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString() + "," + Audience.משפחות.ToString(), ActivityTime = "  ימים א' עד ו' משעה 10:00 עד שעה 18:00", Phone = "02 - 9914882 ", Website = "", Area = "השפלה וירושלים", Settlement = " מחסיה", Email = " adambateva@gmail.com", Address = "מחסיה ", Contact = "עדי רפאפורט", Img = "Adam.jpg", Lengthoftrip = "טיול יותר מיום", KindTrip = KindTrip.אטרקציה.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = "עיזה פזיזה משק צבן", Description = "", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString()+"," + Audience.זוגות.ToString() + "," + Audience.ילדים.ToString() + "," + Audience.משפחות.ToString(), ActivityTime = "א' עד ו' משעה 10:00 עד שעה 18:00", Phone = " 08 - 9390834", Website = " http://izapzizadairy.com/", Area = "השפלה וירושלים", Settlement = "טל שחר", Email = "izapzizadairy@gmail.com", Address = "	נהר הירדן 17, מושב טל שחר, מיקוד 76805", Contact = "	אלון צבן", Img = "nvFile4052617.jpg", Lengthoftrip = "טיול יותר מיום", KindTrip = KindTrip.אטרקציה.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = " קיימא חוקוק: סדנה על קיימות, סביבה וחברה ", Description = "     חוות קיימא -חוקוק היא עמותה המספקת תעסוקה לבני נוער המחפשים מסגרת אלטרנטיבית מלאה או חלקית למסגרת החינוכית הרגילה.החווה מציעה לנוער עבודה תמורת שכר, בשדה חקלאי בו מגדלים ירקות בשיטות גידול אורגניות.", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString()+',' + Audience.זוגות.ToString() + "," + Audience.ילדים.ToString() + "," + Audience.משפחות.ToString(), ActivityTime = "ימים א'-ה' מ: 07:00 עד 16:00", Phone = " 08 - 9390834", Website = "  https://www.kaimahukuk.org.il/", Area = "צפון", Settlement = "חוקוק", Email = "kaima.hukuk@gmail.com", Address = "חוות קיימא חוקוק מיקוד 12923", Contact = "לוי קדיש אסתי", Img = "chokek.jpg", Lengthoftrip = "חצי יום", KindTrip = KindTrip.אטרקציה.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = " שמן זית בוטיק משק חבוב", Description = " פעילויות באתר: מכירת שמן זית וסיור עונתיים ותצפית. ", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.משפחות.ToString().ToString(), ActivityTime = " ימים א'-ו' מ: 08:00 עד 17:00", Phone = "08 - 9228256 ", Website = "  https://www.kaimahukuk.org.il/", Area = "השפלה וירושלים", Settlement = "עזריה", Email = " 9226179@walla.com", Address = "עזריה  המייסדים 76, מושב עזריה", Contact = "אורה חבוב", Img = "Botik.png", Lengthoftrip = "יום מלא", KindTrip = KindTrip.אטרקציה.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = " החווה של חוה ", Description = " ", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.משפחות.ToString()+',' + Audience.קבוצות.ToString(), ActivityTime = " ימים א'-ו' מ: 08:00 עד 17:00", Phone = " 08 - 8593679", Website = "https://www.havafarm.co.il", Area = "השפלה וירושלים", Settlement = "חפץ חיים", Email = "havafarm@gmail.com", Address = "	קיבוץ חפץ חיים, חפץ חיים 1", Contact = "קרן חמיאל", Img = "chava.jpg", Lengthoftrip = "יום מלא", KindTrip = KindTrip.אטרקציה.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = " מרכז מבקרים בראשית", Description = "  טיולי אופניים מודרכים בשטחים החקלאיים של הקיבוץ.הסיור כולל רכיבה מנקודה לנקודה ומגידול לגידול, לצד הסברים על החקלאות המתקדמת שבקיבוץ, אופן השימוש במים, סוגי הגידולים, אתרים היסטוריים, צפייה בעיבודים עונתיים ותצפית ", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.קבוצות.ToString() + "," + Audience.ילדים.ToString() + "," + Audience.משפחות.ToString(), ActivityTime = "ימים א'-ה' מ: 08:00 עד 15:30", Phone = " 04 - 6961488 ", Website = "http://www.pri-beresheet.co.il/", Area = "צפון", Settlement = "מרום גולן", Email = "	info@prib.co.il", Address = "מרום גולן, רחוב בראשית מיקוד 12436", Contact = "איריס קמחי	", Img = "breshite.jpg", Lengthoftrip = "חצי יום", KindTrip = KindTrip.אטרקציה.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = "  אגריתור קיבוץ מגל", Description = "  עוסקת מזה מספר שנים באירוח משלחות וקבוצות מכל העולם לביקור חקלאי, קיבוצי, ארץ ישראלי חדשני אחר ", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience =  Audience.משפחות.ToString() + Audience.קבוצות.ToString(), ActivityTime = " ימים א'-ו' מ: 08:00 עד 20:00 ", Phone = "", Website = "  http://www.agritour-magal.com/he/home", Area = "שרון", Settlement = "מגל", Email = "agritour@kmagal.co.il", Address = "קיבוץ מגל, מיקוד 38845", Contact = "דנה לנדאו ", Img = "agritor.jpg", Lengthoftrip = "טיול יותר מיום", KindTrip = KindTrip.טבע.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = " מרכז מבקרים חצר הטירה ", Description = " תולדות הקיבוץ בעזרת מוצגים תמונות סיפורי וותיקים מראשיתו. ", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience =  Audience.משפחות.ToString() + "," + Audience.קבוצות.ToString(), ActivityTime = " א'-ו' משעה 08:00 עד 20:00  ", Phone = " 04 - 6586953", Website = "https://www.havafarm.co.il", Area = "צפון", Settlement = "טירת הצבי ", Email = "  danishor@tiratzvi.org.il", Address = "	טירת הצבי ", Contact = " נילי שור", Img = "tira.jpg", Lengthoftrip = "יום מלא", KindTrip = KindTrip.מוזיאון.ToString() });

                ctx.TripSite.Add(new TripSite() { SiteName = " יענקל'ס שטעטל בע", Description = " מסע לעיירה יהודית חיה ופועמת, הדרכות למבוגרים בתיבול הומור יהודי", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience =  Audience.משפחות.ToString()+"," + Audience.קבוצות.ToString(), ActivityTime = "	א' - ו' משעה 08:00 עד 23:00 תוכניות שישי עד שעתיים לפני כניסת שבת ", Phone = "  04-9040430 ", Website = "", Area = "הכרמל וחיפה", Settlement = "כפר חסידים א ", Email = "jakob.shtetl @gmail.com", Address = " הפועל מזרחי 43 כפר חסידים א', מיקוד 20400", Contact = "גדי יעקב ", Img = "shtale.jpg", Lengthoftrip = "יום מלא", KindTrip = KindTrip.מוזיאון.ToString() });
                ctx.TripSite.Add(new TripSite() { SiteName = "חדר בריחה", Description = "", Season = Season.סתיו.ToString() + "," + Season.אביב.ToString() + "," + Season.קיץ.ToString() + "," + Season.חורף, Audience = Audience.משפחות.ToString()+"," + Audience.קבוצות.ToString(), ActivityTime = "	א' - ו' משעה 08:00 עד 23:00 תוכניות שישי עד שעתיים לפני כניסת שבת ", Phone = "  04-9040430 ", Website = "", Area = "הכרמל וחיפה", Settlement = "כפר חסידים א ", Email = "jakob.shtetl @gmail.com", Address = " הפועל מזרחי 43 כפר חסידים א', מיקוד 20400", Contact = "גדי יעקב ", Img = "--205.jpg", Lengthoftrip = "יום מלא", KindTrip = KindTrip.מוזיאון.ToString() });

                //    ctx.TripSite.Add(new TripSite() { SiteName = " למדבר - חוויה חקלאית בערבה ", Description = " טיולי אופניים מודרכים בשטחים החקלאיים של הקיבוץ.הסיור כולל רכיבה מנקודה לנקודה ומגידול לגידול, לצד הסברים על החקלאות המתקדמת שבקיבוץ, אופן השימוש במים, סוגי הגידולים, אתרים היסטוריים, צפייה בעיבודים עונתיים ותצפית ", Season = Season.Fall| Season.Spring| Season.Winter , Audience =  Audience.Families| Audience.Groups |Audience.Children| Audience.Couples , ActivityTime = "   ימים א'-ו' מ: 06:00 עד 18:00", Phone = "", Website = "", Area = "דרום", Settlement = "חצבה", Email = " ben.hashitin @gmail.com", Address = "	חצבה", Contact = "מיטל לויטה ", Img = "" });

                //ctx.TripSite.Add(new TripSite() { SiteName = "פעימות מדבר", Description = "פעימות מדבר הוא מיזם תיירותימשפחתי וחדשני המזמין אתכם למסלולי טיול מיוחדים באיזור עין יהב שבערבה", Season = Season.Fall | Season.Spring | Season.Winter | Season.Summer, Audience = Audience.Families | Audience.Groups| Audience.Children , ActivityTime = "", Phone = " 03 - 6849629", Website = " https://www.peimot-midbar.co.il/", Area = "דרום", Settlement = "עין יהב", Email = "peimotmidbar@gmail.com", Address = "עין יהב, משק 171, מיקוד 86825", Contact = "עמית מרב ", Img = "" });
                //    ctx.TripSite.Add(new TripSite() { SiteName = "שיח השדה - פעילויות חווייתיות עם בעלי חיים", Description = " אנחנו, משפחת דביר, &nbsp; מאוד אוהבים ילדים ובעלי חיים לכן החלטנו לשלב בין שתי האהבות שלנו. במשק שלנו,משק דביר הקמנו עסק משפחתי הכולל פינת ליטוף מתוקה, הכנת פיתת בטאבון, פעילות חבלים אתגרית ויצירה. ", ActivityTime = "א'-ו' משעה 8:00 - 20:00 ", Phone = "", Website = "", Area = "צפון", Settlement = "הזורעים", Email = "talcohen905@gmail.com", Address = "מושב הזורעים 77, מיקוד 15205", Contact = "טל דביר", Img = "", Season = Season.Fall | Season.Spring | Season.Winter | Season.Summer , Audience = Audience.Families | Audience.Groups | Audience.Children | Audience.Couples  });

                //    ctx.TripSite.Add(new TripSite() { SiteName = " יקב בית אל", Description = " לאוהבי הטבע וארץ ישראל היפה.", ActivityTime = " א'-ו' משעה 8:00 עד 19:00 ", Phone = " 054 - 5240936", Website = " http://www.beitelwinery.com/ ", Area = " השפלה וירושלים", Settlement = "בית אל", Email = "hillelmanne@gmail.com", Address = " ארץ חמדה 44 מיקוד 90628, בית אל", Contact = " נינה מן", Img = "", Season = Season.Fall | Season.Spring | Season.Summer , Audience
                //= Audience.Families | Audience.Groups | Audience.Children | Audience.Couples  });

                //    ctx.TripSite.Add(new TripSite() { SiteName = " מקלט הקופים הישראלי ", Description = " מקלט הקופים הישראלי הוא עמותה המשקמת קופים.בחלק הפתוח לקהל,ניתן לפגוש את הקופים במקרוב ולהנות ממתקני ג'ימבורי, ספורט אתגרי ופינת יצירה. במקום מתקיימות פעילויות מיוחדות לקבוצות ובתי ספר. ", ActivityTime = "א' - שבת משעה 10:00 עד 17:00 ", Phone = "08 - 9285115", Website = "", Area = "השפלה וירושלים ", Settlement = " כפר דניאל", Email = "monkeypk@netvision.net.il", Address = " כפר דניאל,73125", Contact = " תמר פרדמן", Img = "", Season = Season.Fall | Season.Spring | Season.Summer , Audience = Audience.Families | Audience.Groups | Audience.Children  });

                //    ctx.TripSite.Add(new TripSite() { SiteName = "ג'ימי ג'יפ ", Description = "טיולי ג'יפים במורדות הגולן הגולשים אל הכינרת, תצפיות נוף מהממות, מעינות שופעי מים חיים ופינות חמד נסתרות עם דגש מיוחד על שטחי המרעה של עדרי הבקר. נצפה ונקבל הסברים על איך פועל ענף חקלאי מעניין ומיוחד זה.", ActivityTime = "א'-ש' משעה: 09:00 עד 20:", Phone = "04-6763405", Website = "http://www.jimyjeep.co.il/", Area = "צפון", Settlement = " גבעת יואב ", Email = "jimyjeep@gmail.com ", Address = "גבעת יואב 3, מיקוד 12946 ", Contact = "מיפורה שעל", Img = "", Season = Season.Fall | Season.Spring | Season.Winter | Season.Summer , Audience = Audience.Families | Audience.Groups  });

                //    ctx.TripSite.Add(new TripSite() { SiteName = "יקב הר ברכה - מרכז מבקרים ומסעדה", Description = "יקב הר ברכה השוכן בהר גריזים.הפעילות כוללת סיור בכרמים מעל עשרה איש וביקב וכן טעימות יין במרכז המבקרים.קיימת אפשרות לסיורים גם על ההר בשכונת השומרונים, בתצפית יוסף ובמפעל הטחינה.", ActivityTime = " א'- ה משעה: 10:00 עד 17:00,ד' משעה: 18:00 עד 22:00, ו' משעה: 9:00 עד 13:00 ", Phone = "02-9971788", Website = "", Area = "השפלה וירושלים", Settlement = "ברכה", Email = "grizimtour@gmail.com", Address = "ברכה 84, מיקוד 44835 ", Contact = "ניר לביא ", Img = "", Season = Season.Fall | Season.Spring | Season.Winter | Season.Summer , Audience = Audience.Families | Audience.Groups | Audience.Children  });

                //    ctx.TripSite.Add(new TripSite() { SiteName = " חוות הסוסים בית אל ", Description = " רכיבה טיפולית,טיולי רכיבה זוגיים וקבוצתיים,רכיבה מערבית,פעילויות גיבוש,אירועים ועוד בתיאום מראש.", ActivityTime = " א'- ה' משעה 9:00 - 21:00 , ו' 9:00-15:00 ", Phone = "", Website = "", Area = "השפלה וירושלים", Settlement = "בית אל ", Email = "beitelsusim@gmail.com ", Address = "המסילה, בית אל 90628 ", Contact = "", Img = "", Season = Season.Fall | Season.Spring | Season.Summer  , Audience = Audience.Families | Audience.Groups | Audience.Children | Audience.Couples  });

                //    ctx.TripSite.Add(new TripSite() { SiteName = " קסם התמר ", Description = "קסם התמר מזמין את הציבור לגלות את הקסם שבתמר בסיור רב חושי יראו ויחושו את עץ התמר יטעמו מתמרים משובחים ולקנח בסדנת סילן טעימה או סדנת קליעה מאתגרת.", ActivityTime = " א'-ה' משעה 08:00 עד 17:00 ,ו' משעה 08:00 עד 13:00 ", Phone = "02-3730025", Website = "", Area = "השפלה וירושלים ", Settlement = " ייטב", Email = "dmeravall@gmail.com", Address = "ייטב, מבואות יריחו 5, מיקוד 90670", Contact = "אלוש מירב ", Img = "", Season = Season.Fall | Season.Spring | Season.Winter | Season.Summer , Audience = Audience.Families | Audience.Groups });

                //    ctx.TripSite.Add(new TripSite() { SiteName = "מופ חקלאי רמת הנגב ", Description = " הסיור מציג בגאווה את הישגיה המדהימים של ישראל, ותחנת המחקר החקלאי של רמת הנגב, בפיתוח חקלאות משגשגת, כנגד כל הסיכויים בתנאי מדבר קיצוני, תוך שימוש במים מליחים ועל קרקע חולית", ActivityTime = "", Phone = "077-4701894", Website = "", Area = "דרום ", Settlement = "אשלים ", Email = "nurit@negevberama.co.il ", Address = "אשלים ", Contact = "נורית גיא", Img = "", Season = Season.Fall | Season.Spring | Season.Winter , Audience = Audience.Families | Audience.Groups  });


                ctx.SaveChanges();
            }
            //using (Database6 ctx = new Database6())
            //{
            //    ctx.Database.ExecuteSqlCommand("delete from Definitions");
            //    ctx.Definition.Add(new Definition() { NameDefinition="גודל קבוצה מקסימלית לאוטבוס",Value=50});
            //    ctx.Definition.Add(new Definition() { NameDefinition = "גודל קבוצה מינימלית לאוטבוס", Value = 40 });
            //    ctx.Definition.Add(new Definition() { NameDefinition = "גודל קבוצה מקסימלית למיניבוס", Value = 20 });
            //    ctx.Definition.Add(new Definition() { NameDefinition = "גודל קבוצה מינימלית למיניבוס", Value = 15 });
            //    ctx.Definition.Add(new Definition() { NameDefinition = "מחיר לקמ למיניבוס", Value = 10 });
            //    ctx.Definition.Add(new Definition() { NameDefinition = "מחיר לקמ לאוטובוס", Value = 15 });
            //    ctx.SaveChanges();
            //}
            using (Database6 ctx = new Database6())
            {
                ctx.Database.ExecuteSqlCommand("delete from TripPrices");
                ctx.TripPrice.Add(new TripPrice() { vehicleType = vehicleType.אוטבוס.ToString(), Numberofseats = 50, Mintravels = 40, Priceperkilometer = 15 });
                ctx.TripPrice.Add(new TripPrice() { vehicleType = vehicleType.מניבוס.ToString(), Numberofseats = 20, Mintravels = 15, Priceperkilometer = 10 });

                ctx.SaveChanges();
            }
            using (Database6 ctx = new Database6())
            {
                ctx.Database.ExecuteSqlCommand("delete from CompanyOfProfessions");
                ctx.CompanyOfProfession.Add(new CompanyOfProfession() { ProfessionalName = "שומר", PriceperHour = 70, Telphone = "0547757174" });
                ctx.CompanyOfProfession.Add(new CompanyOfProfession() { ProfessionalName ="פרמדיק", PriceperHour = 85, Telphone = "0509257698" });
                ctx.CompanyOfProfession.Add(new CompanyOfProfession() { ProfessionalName = "מדריך טיולים", PriceperHour = 40, Telphone = "052492814" });
                ctx.CompanyOfProfession.Add(new CompanyOfProfession() { ProfessionalName = "מתלמד", PriceperHour = 35, Telphone = "0506874174" });


                ctx.SaveChanges();
            }
            using (Database6 ctx = new Database6())
            {
                ctx.Database.ExecuteSqlCommand("delete from Users");
                ctx.User.Add(new User() {UserId=1, FirstName = "Manager", Mail = "tripyaeleden@gmail.com", Phone="0559545441" });

                ctx.SaveChanges();
            }



            //private void button1_Click_1(object sender, EventArgs e)
            //{"

            //}

        }
    }
}
