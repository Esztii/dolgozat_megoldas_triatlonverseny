using dolgozat_megoldas_triatlonverseny;
using System.Text;

List<Verseny> versenyzok = [];

using StreamReader sr = new("..\\..\\..\\src\\forras.txt", Encoding.UTF8);

while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"1. feladat: versenyzok száma: {versenyzok.Count}");

var f1 = versenyzok.Count(s => s.Kategoria == "elit");
Console.WriteLine($"Versenyzők száma elit kategóriában: {f1}");

var f2 = versenyzok.Where(s => !s.Nem).Average(s => 2014 - s.Szuletesev);
Console.WriteLine($"Női versenyzők átlag életkora: {f2:0.00}");

var f3 = versenyzok.Sum(s => s.VersenyIdok["kerékpár"].TotalHours) ;
Console.WriteLine($"Kerékpározással töltött összidő: {f3:0.00} óra");

var f4 = versenyzok.Where(s => s.Kategoria == "elit junior").Average(s => s.VersenyIdok["úszás"].TotalMinutes) ;
Console.WriteLine($"Elit juniorok átlagos úszási ideje: {f4/60:0.00} perc");

var f5 = versenyzok.Where(s => s.Nem).MinBy(s => s.OsszIdoSec) ;
Console.WriteLine($"Férfi győztes: {f5}");

var f6 = versenyzok.GroupBy(s => s.Kategoria).OrderBy(s => s.Key);
Console.WriteLine("Versenyt befejezők száma:");
foreach (var grp in f6) Console.WriteLine(
    $"{grp.Key,11}:" +
    $" {grp.Count(),2} fő, " +
    $"avg depo: {grp.Average(
        s => s.VersenyIdok["I. depó"].TotalMinutes
        + s.VersenyIdok["II. depó"].TotalMinutes):0.00} sec");


// csopi 2

var sz1 = versenyzok.Count(sz => sz.Kategoria == "elit junior");
Console.WriteLine($"Versenyzők száma elit junior kategóriában: {sz1}");

var sz2 = versenyzok.Where(sz => sz.Nem).Average(sz => 2014 - sz.Szuletesev);
Console.WriteLine($"Férfi versenyzők átlagéletkora: {sz2:0.00}");

var sz3 = versenyzok.Sum(sz => sz.VersenyIdok["futás"].TotalHours);
Console.WriteLine($"Futásssal töltött összidő: {sz3:0.00} óra");

var sz4 = versenyzok.Where(sz => sz.Kategoria == "20-24").Average(sz => sz.VersenyIdok["úszás"].TotalMinutes);
Console.WriteLine($"20-24 kategóriában átlagos úszási idő: {sz4 / 60:0.00}");

var sz5 = versenyzok.Where(sz => !sz.Nem).MinBy(sz => sz.OsszIdoSec);
Console.WriteLine($"Női győztes: {sz5}");

var sz6 = versenyzok.GroupBy(sz => sz.Nem).OrderBy(sz => sz.Key);
Console.WriteLine("Versenyt befejezők száma:");
foreach (var grp in sz6)
    if (grp.Key == false) 
    {
        Console.WriteLine(

            $"\tNők :" +
            $" {grp.Count(),2} fő, " +
            $"avg depo: {grp.Average(
                s => s.VersenyIdok["I. depó"].TotalMinutes
                + s.VersenyIdok["II. depó"].TotalMinutes):0.00} sec"
        );
    }
    else
    {
        Console.WriteLine(

           $"\tFérfiak :" +
           $" {grp.Count(),2} fő, " +
           $"avg depo: {grp.Average(
               s => s.VersenyIdok["I. depó"].TotalMinutes
               + s.VersenyIdok["II. depó"].TotalMinutes):0.00} sec"
        );
    }
;
    


//csoport 3
var l1 = versenyzok.Count(l => l.Kategoria == "25-29");
Console.WriteLine($"Versenyzők száma 25-29 kategóriában: {l1}");

var l2 = versenyzok.Average(l => 2014 - l.Szuletesev);
Console.WriteLine($"versenyzők átlagéletkora: {l2:0.00}");

var l3 = versenyzok.Sum(l=> l.VersenyIdok["úszás"].TotalHours);
Console.WriteLine($"Úszással töltött összidő: {l3:0.00} óra");

var l4 = versenyzok.Where(l => l.Kategoria == "elit").Average(l => l.VersenyIdok["úszás"].TotalMinutes);
Console.WriteLine($"Elit kategóriában átlagos úszási idő: {l4 / 60:0.00}");

var l5 = versenyzok.Where(l => l.Nem).MinBy(l => l.OsszIdoSec);
Console.WriteLine($"Férfi győztes: {l5}");

var l6 = versenyzok.GroupBy(l => l.Kategoria).OrderBy(l => l.Key);
Console.WriteLine("Versenyt befejezők száma:");
foreach (var grp in l6) Console.WriteLine(
    $"{grp.Key,11}:" +
    $" {grp.Count(),2} fő, " +
    $"avg depo: {grp.Average(
        s => s.VersenyIdok["I. depó"].TotalMinutes
        + s.VersenyIdok["II. depó"].TotalMinutes):0.00} sec");
