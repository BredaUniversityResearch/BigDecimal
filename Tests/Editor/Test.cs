using System;
using System.Numerics;
using NUnit.Framework;
using Cradle;

public class Test
{
    [Test]
    public void DefaultConstruct()
    {
        var bigDecimal = new BigDecimal();
        Assert.IsNotNull(bigDecimal);
        Assert.AreEqual(bigDecimal, (BigDecimal)0);
    }

    [Test]
    public void ConstructFromBigInteger()
    {
        var bigInteger = new BigInteger(100000);
        var bigDecimal = new BigDecimal(bigInteger, 32);
        Assert.IsNotNull(bigDecimal);
    }

    [Test]
    public void Add()
    {
        BigDecimal two = 2;
        BigDecimal three = 3;

        var five = two + three;

        Assert.AreEqual(five, (BigDecimal)5);
    }

    [Test]
    public void Subtract()
    {
        BigDecimal two = 2;
        BigDecimal three = 3;

        var minOne = two - three;

        Assert.AreEqual(minOne, (BigDecimal)(-1));
    }

    [Test]
    public void Multiply()
    {
        BigDecimal two = 2;
        BigDecimal three = 3;

        var six = two * three;

        Assert.AreEqual(six, (BigDecimal)6);
    }

    [Test]
    public void Divide()
    {
        BigDecimal ten = 10;
        BigDecimal five = 5;

        var two = ten / five;

        Assert.AreEqual(two, (BigDecimal)2);
    }

    [Test]
    public void Increment()
    {
        BigDecimal one = 1;
        ++one;

        Assert.AreEqual(one, (BigDecimal)2);
    }

    [Test]
    public void Decrement()
    {
        BigDecimal two = 2;

        --two;

        Assert.AreEqual(two, (BigDecimal)1);
    }
}
