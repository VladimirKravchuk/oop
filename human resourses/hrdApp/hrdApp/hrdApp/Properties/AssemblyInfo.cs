﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Общие сведения об этой сборке предоставляются следующим набором
// набора атрибутов. Измените значения этих атрибутов, чтобы изменить сведения,
// связанные со сборкой.
[assembly: AssemblyTitle("hrdApp")]
[assembly: AssemblyDescription("Програма представляє собою систему управління базою даних " +
                               "відділу кадрів. " +
                               "Структура бази даних типова для подібного призначення " +
                               "та включає в себе 5 таблиць: " +
                               "employees, family, post, furlough та service. \r\n" +
                               "Програма працює на основі SQLite біблітек версії 3 для .NET. " +
                               "Безпосередньо файл пустої бази даних створений у середовищі SQLiteStudio 3.2.1. \r\n" + 
                               "--------------------------------------------------------------------------------------------- \r\n" +
                               "Реалізовано інструменти для створення та редагування облікових записів працівників, " +
                               "призначення на посаду та звільнення працівників, призначення та видалення відпусток, " +
                               "є можливість створення нової пустої бази даних або підключення вже існуючих. " +
                               "Звіти з бази даних формуються в головній формі програми. Реалізовано пошукові функції " +
                               "по базі даних за допомогою ключових слів.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Державний університет «Житомирська політехніка»")]
[assembly: AssemblyProduct("Information search engine " + "\"Human Resources Department App\"")]
[assembly: AssemblyCopyright("Copyright © 2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Установка значения False для параметра ComVisible делает типы в этой сборке невидимыми
// для компонентов COM. Если необходимо обратиться к типу в этой сборке через
// COM, задайте атрибуту ComVisible значение TRUE для этого типа.
[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов, если этот проект будет видимым для COM
[assembly: Guid("724122f5-03b6-44fb-997c-04208c63c4b3")]

// Сведения о версии сборки состоят из следующих четырех значений:
//
//      Основной номер версии
//      Дополнительный номер версии
//   Номер сборки
//      Редакция
//
// Можно задать все значения или принять номер сборки и номер редакции по умолчанию.
// используя "*", как показано ниже:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
