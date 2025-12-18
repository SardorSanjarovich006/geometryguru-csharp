using GeometryGuru.Aplication.Services;
using GeometryGuru.Domain;
using GeometryGuru.Infrastucture;

namespace GeometryGuru.Client
{
    public class Program
    {
        static GeometryService service = new GeometryService();
        static DbContext db = new DbContext();
        static int index = 0;

        static void Main(string[] args)
        {
            Console.Write("Ismingizni kiriting: ");
            string name = Console.ReadLine();


            Console.WriteLine($"Geometry Guru loyixasiga xush kelibsiz :), {name} ");

            MainMenu();
        }


        static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- ASOSIY MENYU ---");
                Console.WriteLine("1. Doira");
                Console.WriteLine("2. Ko‘pburchaklar");
                Console.WriteLine("3. Hisoblashlar tarixi");
                Console.WriteLine("0. Chiqish");
                Console.Write("Tanlang: ");

                string c = Console.ReadLine().Trim();

                if (c == "1") CircleMenu();
                else if (c == "2") PolygonMenu();
                else if (c == "3") ShowHistory();
                else if (c == "0") return;
            }
        }

        static void CircleMenu()
        {
            Console.Write(" Iltimos doirani radiusini kiriting : ");
            double r = double.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("\n1. Yuzi");
                Console.WriteLine("2. Uzunligi");
                Console.WriteLine("0. Orqaga");
                Console.Write("Tanlang: ");

                string c = Console.ReadLine();

                Geometry g = new Geometry();
                g.radius = r;
                g.ShapeName = "Doira";

                if (c == "1")
                {
                    g.Operation = "Doira yuzi : ";
                    g.Result = service.CircleArea(r);
                }
                else if (c == "2")
                {
                    g.Operation = "Doira uzunligi : ";
                    g.Result = service.CircleLength(r);
                }
                else if (c == "0") return;
                else continue;

                Save(g);
                Console.WriteLine($"{g.Operation} = {g.Result}");
            }
        }


        static void PolygonMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- KO‘PBURCHAKLAR ---");
                Console.WriteLine("1. Uchburchak");
                Console.WriteLine("2. To‘rtburchak");
                Console.WriteLine("3. Kvadrat");
                Console.WriteLine("4. Trapetsiya");
                Console.WriteLine("5. Parallelogram");
                Console.WriteLine("0. Orqaga");
                Console.Write("Tanlang: ");

                string c = Console.ReadLine();

                if (c == "1") TriangleMenu();
                else if (c == "2") RectangleMenu();
                else if (c == "3") SquareMenu();
                else if (c == "4") TrapezoidMenu();
                else if (c == "5") ParallelogramMenu();
                else if (c == "0") return;
            }
        }

        static void ParallelogramMenu()
        {
            Geometry g = new Geometry();
            g.ShapeName = "Parallelogram";
            Console.Write("1 -  tomonini kiriting  = "); g.tomon1 = double.Parse(Console.ReadLine());
            Console.Write("2 - tomonini kiriting = "); g.tomon2 = double.Parse(Console.ReadLine());
            Console.Write("1 - tomonga tushurilgan balandlikni kiriting  = "); g.balandlik = double.Parse(Console.ReadLine());
            Console.WriteLine("1. Yuzini hisoblash : ");
            Console.WriteLine("2. Perimetri hisoblash : ");
            Console.Write("Tanlang: ");
            string c = Console.ReadLine();
            if (c == "1")
            {
                g.Operation = "Parallelogram yuzasi : ";
                g.Result = service.ParallelogramArea(g.tomon1, g.balandlik);
            }
            else
            {
                g.Operation = "Parallelogram perimetri";
                g.Result = service.ParallelogramPerimeter(g.tomon1, g.tomon2);
            }
            Save(g);
            Console.WriteLine($"{g.Operation} = {g.Result}");
        }



        static void TriangleMenu()
        {
            Geometry g = new Geometry();
            g.ShapeName = "Uchburchak";

            Console.Write("a tomoni  = "); g.tomon1 = double.Parse(Console.ReadLine());
            Console.Write("b tomoni  = "); g.tomon2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"\n 3 - Tomonn  quyidagi oraliqda bo'lishi kerak !!!!!!! :  {Math.Abs(g.tomon1 - g.tomon2)}  < C < {g.tomon1 + g.tomon2} ");
            Console.Write("c tomoni  = "); g.tomon3 = double.Parse(Console.ReadLine());



            Console.WriteLine("1. Yuzi");
            Console.WriteLine("2. Perimetri");
            Console.Write("Tanlang: ");
            string c = Console.ReadLine();


            if (c == "1")
            {
                g.Operation = "Yuzi";
                g.Result = service.TriangleArea(g.tomon1, g.tomon2, g.tomon3);
            }
            else
            {
                g.Operation = "Perimetri";
                g.Result = service.TrianglePerimeter(g.tomon1, g.tomon2, g.tomon3);
            }

            Save(g);
            Console.WriteLine($"{g.Operation} = {g.Result}");
        }


        static void RectangleMenu()
        {
            Geometry g = new Geometry();
            g.ShapeName = "To‘rtburchak";

            Console.Write("a = "); g.tomon1 = double.Parse(Console.ReadLine());
            Console.Write("b = "); g.tomon2 = double.Parse(Console.ReadLine());

            Console.WriteLine("1. Yuzi");
            Console.WriteLine("2. Perimetri");
            Console.Write("Tanlang: ");
            string c = Console.ReadLine();

            if (c == "1")
            {
                g.Operation = "Yuzi";
                g.Result = service.RectangleArea(g.tomon1, g.tomon2);
            }
            else
            {
                g.Operation = "Perimetri";
                g.Result = service.RectanglePerimeter(g.tomon1, g.tomon2);
            }

            Save(g);
            Console.WriteLine($"{g.Operation} = {g.Result}");
        }

        static void SquareMenu()
        {
            Geometry g = new Geometry();
            g.ShapeName = "Kvadrat";

            Console.Write("Kvadratning tomonini kiriting = ");
            g.tomon1 = double.Parse(Console.ReadLine());

            Console.WriteLine("1. Yuzi");
            Console.WriteLine("2. Perimetri");
            Console.Write("Tanlang: ");
            string c = Console.ReadLine();

            if (c == "1")
            {
                g.Operation = "Yuzi";
                g.Result = service.SquareArea(g.tomon1);
            }
            else
            {
                g.Operation = "Perimetri";
                g.Result = service.SquarePerimeter(g.tomon1);
            }

            Save(g);
            Console.WriteLine($"{g.Operation} = {g.Result}");
        }


        static void TrapezoidMenu()
        {
            Geometry g = new Geometry();
            g.ShapeName = "Trapetsiya";

            Console.WriteLine("1. Yuzani hisoblash : ");
            Console.WriteLine("2.Peremetrini hisoblash :");
            Console.WriteLine("0. Orqaga qaytish :");
            string r = Console.ReadLine();

            if (r == "1")
            {
                Console.Write("kichik asosini kiriting  = "); g.tomon1 = double.Parse(Console.ReadLine());
                Console.Write("Katta asosini kiriting  = "); g.tomon2 = double.Parse(Console.ReadLine());
                Console.Write("Balandligini kiriting = "); g.balandlik = double.Parse(Console.ReadLine());

                service.TrapezoidArea(g.tomon1, g.tomon2, g.balandlik);
                g.Operation = "Yuzi";
                g.Result = service.TrapezoidArea(g.tomon1, g.tomon2, g.balandlik);
            }
            else if (r == "2")
            {
                Console.Write("kichik asosini kiriting  = "); g.tomon1 = double.Parse(Console.ReadLine());
                Console.Write("Katta asosini kiriting  = "); g.tomon2 = double.Parse(Console.ReadLine());
                Console.WriteLine($" Yon tomonlari  quyidagi oraliqda bo'lishi kerak !!!!!!! :  {Math.Abs(g.tomon1 - g.tomon2)}  < C < {g.tomon1 + g.tomon2} ");
                Console.Write("1 - yon tomonini kiriting  = "); g.tomon3 = double.Parse(Console.ReadLine());
                Console.Write("2 - yon tomonini kiriting  = "); g.tomon4 = double.Parse(Console.ReadLine());
                service.TrapezoidPerimeter(g.tomon1, g.tomon2, g.tomon3, g.tomon4);
                g.Operation = "Perimetri";
                g.Result = service.TrapezoidPerimeter(g.tomon1, g.tomon2, g.tomon3, g.tomon4);
            }
            else if (r == "0") return;






            Save(g);
            Console.WriteLine($"Yuzi = {g.Result}");
        }


        static void Save(Geometry g)
        {
            if (index < db.Geometry.Length)
                db.Geometry[index++] = g;
        }


        static void ShowHistory()
        {
            Console.WriteLine("\n--- HISOBLASH TARIXI ---");

            foreach (var g in db.Geometry)
            {
                if (g == null) continue;

                Console.WriteLine(
                    $"{g.ShapeName} | {g.Operation} | Natija: {g.Result} | " +
                    $"radius:{g.radius} | a tomon :{g.tomon1} | b tomon :{g.tomon2} | c tomon :{g.tomon3} | d tomon : {g.tomon4} |  h:{g.balandlik}"
                );
            }
        }


    }

}