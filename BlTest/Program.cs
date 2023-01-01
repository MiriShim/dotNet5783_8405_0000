// See https://aka.ms/new-console-template for more information
using BlApi;

using InputLibrary;

Console.ReadLine();


IBL bl = new BlImlementation.BL();


BO.Order order = new BO.Order() { Status =BO.OrderStatus.Recived,CustumerAdress="aaaaaaaa",CustomerEmail="dsdsdsd",CustomerName="Tamara"};
BO.Product  product = new BO.Product () {   Price=99.99,InStock=99,category=BO.Category.Nails ,Name="Geranume"};


bl.Product .Add(product  );

//Input.ReadInt("Input OK");

bl.Product .GetAll().ToList().ForEach(o=>Console.WriteLine(o));



//נקלוט את כל הנתונים הרלוונטיים הדרושים לזימון הפעולה
//נכין את הנתונים ואת המופעים הנדרשים לפעולה
//נזמן את הפעולה (דרך תכונה מתאימה של המשתנה המכיל הפניה לאובייקט של BL כנ"ל)
//נדפיס את תוצאות הפעולה, בהתאם לסוג ערך מוחזר
//בהדפסות:
//אובייקטים של ישויות נתונים יודפסו בעזרת מתודת ToString ישירות
//נ.ב. אסור לזמן את המתודה ToString בצורה מפורשת!
//אוסף יודפס בעזרת לולאת foreach ובתוכה הדפסת אובייקטים כנ"ל נתפוס את החריגות הצפויות (עבור הפעולה המסוימת) של שכבת BL
//נתפוס את החריגות הצפויות (עבור הפעולה המסוימת) של שכבת BL
//נ.ב. לא נתפוס שום חריגות אחרות - על מנת לקבל אפשרות לדבג במקרה ומתרחשות
//עבור כל חריגה שנתפסה נדפיס את המידע על החריגה: שם החריגה, הודעה שבחריגה, מידע על חריגה פנימית (אם יש)
//לבונוס: לצורך המרות של מספרים ותאריכים מהקלט - להשתמש בפונקציה TryParse

