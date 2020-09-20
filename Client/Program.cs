﻿using System;
using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace Client
{
    class Program
    {
        public class Options
        {
            [Value(0, Required = true, HelpText = "Host name or IP addres.")]
            public string Host { get; set; }
            [Value(1, Required = true, HelpText = "Host port.")]
            public string Port { get; set; }
        }
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(Run)
                .WithNotParsed(Error);
        }

        private static void Error(IEnumerable<Error> obj)
        {
            throw new NotImplementedException();
        }

        static void Run(Options opt)
        {
            Console.WriteLine("Starting client");

            Console.WriteLine($"{opt.Host}:{opt.Port}");



            /**
             * 1. client.exe ip/hostname port
             */
        }
    }
}