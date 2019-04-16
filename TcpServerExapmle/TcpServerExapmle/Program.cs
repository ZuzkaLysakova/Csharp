using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using NDesk.Options;

namespace TcpServerExapmle
{
    class Program
    {
        static (string, int, bool) ProcesArgs(string[] args)
        {
            string ipAdress = "127.0.0.1";
            string portStr = "1200";
            //byte[] message;
            bool showHelp = false;

            var options = new OptionSet
            {
                { "i|ipAdress=", "the name of directory.", name => analyzer.DirectoryName = name },
                { "p|port", "print all information about foulders and files", val => analyzer.PrintInfos = true },
                { "h|help", "show this message and exit", val => showHelp = val != null }
            };

            IList<string> extra = options.Parse(args);
            if (extra.Count > 0)
            {
                throw new ArgumentException("Illegal parameters");
            }
            if (showHelp)
            {
                ShowHelp(options);
            }
            if(!int.TryParse(portStr, out int port))
            {
                port = 1200;
            }
            return (ipAdress, port, showHelp);
        }

        private static void ShowHelp(OptionSet options)
        {
            throw new NotImplementedException();
        }

        private static void StartTCPServer(string ipAdress, int port)
        {
            TcpServer server = new TcpServer(new ConsoleMessageProcessor(), ipAdress, port);

        }


        static void Main(string[] args)
        {

            Console.Title = "TCP Server";
            Console.WriteLine("Starting TCP server");


            string ipAdresa;
            int port;
            //byte[] message;
            bool showHelp;

            try
            {
                (ipAdresa, port, showHelp) = ProcesArgs(args);
                if (showHelp) return;
                StartTCPServer(ipAdresa, port);

            }catch(OptionException e)
            {
                Console.WriteLine($"{ Console.Title}: {e.Message}");
                Console.WriteLine($"Try '{Console.Title} --help' fro more information.");
                return;
        }
    }

       
    }

    internal class OptionSet
    {
    }

    [Serializable]
    internal class OptionException : Exception
    {
        public OptionException()
        {
        }

        public OptionException(string message) : base(message)
        {
        }

        public OptionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OptionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }