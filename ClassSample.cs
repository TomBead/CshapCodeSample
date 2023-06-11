namespace FatherSon
{

    class Line
    {
        // 线条的长度
        private double length;
        //
        public Line()
        {
            Console.WriteLine("对象已创建");
        }
        // 参数化构造函数
        public Line(double len)
        {
            Console.WriteLine("对象已创建，length = {0}", len);
            length = len;
        }

        //析构函数
        //析构函数的名称是在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数。
        //析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。
        ~Line()
        {
            Console.WriteLine("对象已删除");
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }

    class StaticVar
    {
        //所有类公用一个变量
        public static int num;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
        //静态方法只能类名.方法调用
        public static int getNumSta()
        {
            return num;
        }
    }



    //比如说：一个人A为父类，他的儿子B，妻子C，私生子D（注：D不在他家里）

    //如果我们给A的事情增加修饰符：

    // public事件，地球人都知道，全公开
    // protected事件，A，B，D知道（A和他的所有儿子知道，妻子C不知道）
    // private事件，只有A知道（隐私？心事？）
    // internal事件，A，B，C知道（A家里人都知道，私生子D不知道）
    // protected internal事件，A，B，C，D都知道,其它人不知道
    class Rectangle
    {
        //public 可以访问
        public int x;
        // 私有变量无法访问
        private int y;
        //internal
        internal double length;
        internal double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        //如果没有指定访问修饰符，则使用类成员的默认访问修饰符，即为 private。
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

    //继承父类
    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w)
        { }
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("成本： {0}", GetCost());
        }
    }


    ///==================多重继承==================
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // 基类 PaintCost
    public interface PaintCost
    {
        int getCost(int area);

    }
    // 派生类，
    //使用
    //MyRect Rect = new MyRect();
    //int area;
    //Rect.setWidth(5);
    //     Rect.setHeight(7);
    //     area = Rect.getArea();
    //     // 打印对象的面积
    //     Console.WriteLine("总面积： {0}",  Rect.getArea());
    //     Console.WriteLine("油漆总成本： ${0}" , Rect.getCost(area));
    //     Console.ReadKey();
    class MyRect : Shape, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }



    //==================多重继承end==================
    //
    //===============多态start==================
    //抽象类，继承的子类需要实现抽象方法
    abstract class ShapeXX
    {
        abstract public int area();
    }


    class RectangleXX : ShapeXX
    {
        private int length;
        private int width;
        public RectangleXX(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        //实现抽象方法
        public override int area()
        {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * length);
        }
    }


    public class ShapeXX1
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // 虚方法，继承的子类需要实现虚方法
        public virtual void Draw()
        {
            Console.WriteLine("执行基类的画图任务");
        }
    }
    //
    class Circle : ShapeXX1
    {
        public override void Draw()
        {
            Console.WriteLine("画一个圆形");
            base.Draw();
        }
    }

    //===============多态end==================
    //
    //
    //
    //===============运算符重载==================
    class Box
    {
        private double length;      // 长度
        private double breadth;     // 宽度
        private double height;      // 高度

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }
        // 重载 + 运算符来把两个 Box 对象相加
        //使用  Box3 = Box1 + Box2;
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height
               && lhs.breadth == rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.height != rhs.height
                || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator <(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length < rhs.length && lhs.height
                < rhs.height && lhs.breadth < rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length > rhs.length && lhs.height
                > rhs.height && lhs.breadth > rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length <= rhs.length && lhs.height
                <= rhs.height && lhs.breadth <= rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length >= rhs.length && lhs.height
               >= rhs.height && lhs.breadth >= rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }

    }
    //===============运算符重载end==================

    //======================接口start=========================

    interface IParentInterface
    {
        void ParentInterfaceMethod();
    }

    interface IMyInterface : IParentInterface
    {
        void MethodToImplement();
    }

    class InterfaceImplementer : IMyInterface
    {
        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterfaceMethod() called.");
        }
        //需要实现父类和子类两个方法，
        //static void Main()
        //{
        //    InterfaceImplementer iImp = new InterfaceImplementer();
        //    iImp.MethodToImplement();
        //    iImp.ParentInterfaceMethod();
        //}

    }


    //======================接口end=========================
    //class ExecuteRectangle
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle r = new Rectangle();
    //        r.length = 4.5;
    //        r.width = 3.5;
    //        r.Display();
    //        Console.ReadLine();
    //    }

    //=======================
    //打印结果
    //对象已创建
    //线条的长度： 6
    //对象已删除
    //=======================
    //Line line = new Line();
    //// 设置线条长度
    //line.setLength(6.0);
    //     Console.WriteLine("线条的长度： {0}", line.getLength());      
    //}

}
