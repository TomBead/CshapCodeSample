//类名和class名可以不同
//一个name'space里面有多个不同的class
//一个namespace里面只能有一个main入口函数
namespace VarSample
{

    //变量
    class varSample
    {
        //
        char cc = 'a';
        //
        bool isok = false;
        //sbyte	8 位有符号整数类型	-128 到 127
        sbyte sb = sbyte.MinValue;
        //0 到 255
        byte b = 0;
        //	16 位有符号整数类型	-32,768 到 32,767
        short ss = 2;
        // 16 位无符号整数类型	0 到 65,535
        ushort ss2 = 3;
        //	32 位有符号整数类型	-2,147,483,648 到 2,147,483,647
        int i = 10;
        //32 位无符号整数类型	0 到 4,294,967,295
        uint ii = 0;

        //	64 位有符号整数类型	-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807
        long l = 41;
        //ulong	64 位无符号整数类型	0 到 18,446,744,073,709,551,615
        ulong ul = 44;

        //32 位单精度浮点型	-3.4 x 1038 到 + 3.4 x 1038
        float f = 0.0f;
        //	64 位双精度浮点型	(+/-)5.0 x 10-324 到 (+/-)1.7 x 10308
        double d = 0.0f;
        //	128 位精确的十进制值，28-29 有效位数	(-7.9 x 1028 到 7.9 x 1028) / 100 到 28
        decimal dd = 0;

        //字符串
        string str = "这是一个字符串";

        //
        int? count = 3;

        //求变量所占的大小
        public void sizeofVar()
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.ReadLine();
        }

        //变量转化
        public void qiangzhuan()
        {

            byte b = 10;
            // 隐式转换，不需要显示转换
            int i = b;
            // 显式转换，需要使用强制类型转换符号
            byte b2 = (byte)i;

            //转化为string
            i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool isok = true;


            //string转化为int
            string locstr = "123";
            //
            //方法一: 用 Convert 
            int x = Convert.ToInt16(locstr);

            //方法二: 用 Parse
            int ii = int.Parse(locstr);

        }

        //可空类型
        void canNull()
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // 显示值
            //显示可空类型的值： , 45,  , 3.14157
            //一个可空的布尔值：
            Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值： {0}", boolval);

            //
            double? numA = null;
            double? numB = 3.14157;
            double numC;
            //
            numC = numA ?? 5.34;
            Console.WriteLine("num3 的值： {0}", numC);
            numC = numB ?? 5.34;
            Console.WriteLine("num3 的值： {0}", numC);
            Console.ReadLine();

        }


        void testTime()
        {
            DateTime dt = new DateTime(2017, 4, 1, 13, 16, 32, 108);
            string.Format("{0:y yy yyy yyyy}", dt); //17 17 2017 2017
            string.Format("{0:M MM MMM MMMM}", dt);//4  04 四月 四月
            string.Format("{0:d dd ddd dddd}", dt);//1  01 周六 星期六
            string.Format("{0:t tt}", dt);//下 下午
            string.Format("{0:H HH}", dt);//13 13
            string.Format("{0:h hh}", dt);//1  01
            string.Format("{0:m mm}", dt);//16 16
            string.Format("{0:s ss}", dt);//32 32
            string.Format("{0:F FF FFF FFFF FFFFF FFFFFF FFFFFFF}", dt);//1 1  108 108  108   108    108
            string.Format("{0:f ff fff ffff fffff ffffff fffffff}", dt);//1 10 108 1080 10800 108000 1080000
            string.Format("{0:z zz zzz}", dt);//+8 +08 +08:00

            string.Format("{0:yyyy/MM/dd HH:mm:ss.fff}", dt);  //2017/04/01 13:16:32.108
            string.Format("{0:yyyy/MM/dd dddd}", dt);      //2017/04/01 星期六
            string.Format("{0:yyyy/MM/dd dddd tt hh:mm}", dt); //2017/04/01 星期六 下午 01:16
            string.Format("{0:yyyyMMdd}", dt);         //20170401
            string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", dt);　//2017-04-01 13:16:32.108

            //DateTime dt = new DateTime(2017, 4, 1, 13, 16, 32, 108);
            dt.ToString("y yy yyy yyyy");//17 17 2017 2017
            dt.ToString("M MM MMM MMMM");//4  04 四月 四月
            dt.ToString("d dd ddd dddd");//1  01 周六 星期六
            dt.ToString("t tt");//下 下午
            dt.ToString("H HH");//13 13
            dt.ToString("h hh");//1  01
            dt.ToString("m mm");//16 16
            dt.ToString("s ss");//32 32
            dt.ToString("F FF FFF FFFF FFFFF FFFFFF FFFFFFF");//1 1  108 108  108   108    108
            dt.ToString("f ff fff ffff fffff ffffff fffffff");//1 10 108 1080 10800 108000 1080000
            dt.ToString("z zz zzz");//+8 +08 +08:00

            dt.ToString("yyyy/MM/dd HH:mm:ss.fff"); //2017/04/01 13:16:32.108
            dt.ToString("yyyy/MM/dd dddd");      //2017/04/01 星期六
            dt.ToString("yyyy/MM/dd dddd tt hh:mm"); //2017/04/01 星期六 下午 01:16
            dt.ToString("yyyyMMdd");         //20170401
            dt.ToString("yyyy-MM-dd HH:mm:ss.fff");　//2017-04-01 13:16:32.108
        }

        //添加判断
        void panduanFun()
        {
            //* 局部变量定义 */
            int a = 100;
            int b = 200;
            /* 检查布尔条件 */
            if (a == 100)
            {
                /* 如果条件为真，则检查下面的条件 */
                if (b == 200)
                {
                    /* 如果条件为真，则输出下面的语句 */
                    Console.WriteLine("a 的值是 100，且 b 的值是 200");
                }
            }
        }





        void funFor()
        {
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibarray)
            {
                System.Console.WriteLine(element);
            }
            System.Console.WriteLine();


            // 类似 foreach 循环
            for (int i = 0; i < fibarray.Length; i++)
            {
                System.Console.WriteLine(fibarray[i]);
            }
            System.Console.WriteLine();
        }

    }


    class Rectangle
    {
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("请输入长度：");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入宽度：");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }//end class Rectangle    


    //结构体
    //    类 vs 结构
    //类和结构有以下几个基本的不同点：

    //类是引用类型，结构是值类型。
    //结构不支持继承。
    //结构不能声明默认的构造函数。

    //结构和类的适用场合分析：

    // 1、当堆栈的空间很有限，且有大量的逻辑对象时，创建类要比创建结构好一些；
    // 2、对于点、矩形和颜色这样的轻量对象，假如要声明一个含有许多个颜色对象的数组，则CLR需要为每个对象分配内存，在这种情况下，使用结构的成本较低；
    //3、在表现抽象和多级别的对象层次时，类是最好的选择，因为结构不支持继承。
    //4、大多数情况下，目标类型只是含有一些数据，或者以数据为主。
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
        //不能赋值，报错
        //public int book_sex=0;
    };



    class ExecuteRectangle
    {
        //枚举类型
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void Main(string[] args)
        {
            //第一个是0
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);


            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();



            Books Book1;        /* 声明 Book1，类型为 Books */
            Books Book2;        /* 声明 Book2，类型为 Books */

            //能new，
            Books book3 = new Books();

            /* book 1 详述 */
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

            /* book 2 详述 */
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;

            /* 打印 Book1 信息 */
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            /* 打印 Book2 信息 */
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);


            Console.WriteLine("Book 3 book_id : {0}", book3.book_id);

            Console.ReadKey();
            //等待输入
            Console.ReadLine();

        }
    }
}