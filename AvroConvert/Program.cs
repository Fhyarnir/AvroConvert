﻿using System;

namespace AvroConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var serialized = AvroConvert.Serialize(1);

            var avroString = System.IO.File.ReadAllBytes("result.avro");


            var dx = AvroConvert.Deserialize(serialized);
        }
    }

    class User
    {
        public string name { get; set; }
        public int? favorite_number { get; set; }
        public string favorite_color { get; set; }
    }
}
