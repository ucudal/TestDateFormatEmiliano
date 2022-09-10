using Library;
using TestDateFormat;
using NUnit.Framework;
using System;

namespace Library.Tests;

[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFormatOK()
    {
        const string expected = "2003-09-28";
        const string test1 = "28/09/2003";
        string tested1 = DateFormatter.ChangeFormat(test1);
        Assert.AreEqual(expected, tested1);
    }

    [Test]
    public void TestWrongFormat()
    {
        const string test2 = "2004/20/09";
        const string expected = "(Formato inválido)";
        string tested2 = DateFormatter.ChangeFormat(test2);
        Assert.AreEqual( expected , tested2 );
    }

    [Test]
    public void TestNullInput()
    {
        const string test3 = "";
        string tested3 = DateFormatter.ChangeFormat(test3);
        Assert.IsNull(tested3);
    }
}