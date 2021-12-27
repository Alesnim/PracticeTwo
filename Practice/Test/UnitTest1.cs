using NUnit.Framework;
using System.Reflection;
using System;
using System.Collections;
namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test, Category("Figure")]
    public void testExistFileFigure()
    {


        Assert.That(@"../../../../Practice/Figure.cs", Does.Exist, "Не забудьте создать файл для класса");
    }


    [Test, Category("Point")]
    public void testClassExist()
    {
        Assembly assembly = typeof(Program).Assembly;
        ArrayList classes = new ArrayList();
        foreach (Type type in assembly.GetTypes())
        {
            classes.Add(type.FullName);
        }
        Assert.True(classes.Contains("Figure"), "Добавьте класс Point в файл");

    }




    [Test]
    public void testAddNumberExist()
    {
        MethodInfo[] methods = typeof(Figure).GetMethods();
        ArrayList met = new ArrayList();
        foreach (MethodInfo meth in methods)
        {
            met.Add(meth.Name);
        }
        Assert.True(met.Contains("GetSquare"));

    }

    [Test]
    public void testExistFileSquare()
    {


        Assert.That(@"../../../../Practice/Square.cs", Does.Exist, "Не забудьте создать файл для класса");
    }


    [Test]
    public void testConstructorWork()
    {
        int x = 42;
        Figure p = new Square(x);
        Assert.AreEqual(p.Width, x, "Реализуйте конструктор с одним аругментов в соответствии с заданием");
        Assert.AreEqual(p.Height, x, "Реализуйте конструктор с одним аругментов в соответствии с заданием");
    }


    [Test]
    public void testSquareGetSquare()
    {
        Figure p = new Square(4);

        Assert.AreEqual(p.GetSquare(), 4 * 4, "Реализуйте метод в соответствии с заданием");

    }



    [Test]
    public void testExistFileRectangle()
    {


        Assert.That(@"../../../../Practice/Rectangle.cs", Does.Exist, "Не забудьте создать файл для класса");
    }


    [Test]
    public void testConstructorRectangleWork()
    {
        int x = 42;
        int y = 24;
        Figure p = new Rectangle(x, y);
        Assert.AreEqual(p.Width, x, "Реализуйте конструктор с двумя аругментов в соответствии с заданием");
        Assert.AreEqual(p.Height, y, "Реализуйте конструктор с двумя аругментов в соответствии с заданием");
    }


    [Test]
    public void testRectangleGetSquare()
    {
        Figure p = new Rectangle(4, 2);

        Assert.AreEqual(p.GetSquare(), 2 * 4, "Реализуйте метод в соответствии с заданием");

    }


    [Test]
    public void testExistFileCircle()
    {


        Assert.That(@"../../../../Practice/Circle.cs", Does.Exist, "Не забудьте создать файл для класса");
    }


    [Test]
    public void testConstructorCircleWork()
    {
        int x = 24;
        Figure p = new Circle(x);
        Assert.AreEqual(p.Width, x*2, "Реализуйте конструктор с одним аругментов в соответствии с заданием");
        Assert.AreEqual(p.Height, x*2, "Реализуйте конструктор с одним аругментов в соответствии с заданием");
    }


    [Test]
    public void testCircleGetSquare()
    {
        Figure p = new Circle(4);

        Assert.AreEqual(p.GetSquare(), ((int)(2 * Math.PI * 4 * 4)), "Реализуйте метод в соответствии с заданием");

    }




}