// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*********** Line Comparision Using Class *****************");

using LineComparisionUsingClass;
LineComp lc = new LineComp();
double length1 = lc.CalcLength();

LineComp lc2 = new LineComp();
double length2 = lc2.CalcLength();


Console.WriteLine("Length of First Line " + length1);
Console.WriteLine("Length of Second Line " + length2);

lc.EqualityMethod(length1.ToString(), length2.ToString());
lc2.CompareLines(length1.ToString(), length2.ToString());

