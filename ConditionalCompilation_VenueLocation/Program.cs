// See https://aka.ms/new-console-template for more information
using ConditionalCompilation;
using System;

Console.WriteLine("Hello, World!");

var venue = new Venue();

// this should not error, and Location should be included.
venue.Location = null;