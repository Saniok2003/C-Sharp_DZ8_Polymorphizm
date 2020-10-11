using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DZ_8
{
    class Comp
    {
        public int countDisk;
        public int countPrintDevice;
        public Disk[] disks;
        public IprintInformation[] printDevice;
        ///////////////////////////////////////
        void AddDevice(int index, IprintInformation si)
        {

        }
        void AddDisk(int index, Disk d)
        {

        }
        bool CheckDisk(string device)
        {
            return true;
        }
        public Comp(int d, int pd)
        {
            countDisk = d;
            countPrintDevice = pd;
        }
        void InsertReject(string device, bool b)
        {

        }
        bool PrintInfo(string text, string device)
        {
            return true;
        }
        bool ReadInfo(string device)
        {
            return true;
        }
        void ShowDisk()
        {

        }
        void ShowPrintDevice()
        {

        }
        bool WriteInfo(string text, string showDevice)
        {
            return true;
        }


    }
    interface IDisk
    {
        string Read();
        void Write(string text);
    }
    class Disk : IDisk
    {
        public string memory;
        public int memSize;
        public string Memory { get; set; }
        public int MemSize { get; set; }
        ///////////////////////////////////////
        public Disk()
        {
            memory = "No memory";
            memSize = 0;
        }
        public Disk(string m, int ms)
        {
            memory = m;
            memSize = ms;
        }
        string IDisk.Read()
        {
            return "Read - OK";
        }
        void IDisk.Write(string text)
        {
            Console.WriteLine(text);
        }
    }
    ///////////////////////////////////////
    interface IprintInformation
    {
        string SetName(string str);
        string GetName();
        void Print(string str);
    }
    class Printer : IprintInformation
    {
        private string name;
        string IprintInformation.SetName(string str)
        {
            return name = str;
        }
        string IprintInformation.GetName()
        {
            return name;
        }
        void IprintInformation.Print(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Monitor : IprintInformation
    {
        private string name;
        string IprintInformation.SetName(string str)
        {
            return name = str;
        }
        string IprintInformation.GetName()
        {
            return name;
        }
        void IprintInformation.Print(string str)
        {
            Console.WriteLine(str);
        }
    }
    ///////////////////////////////////////
    interface IRemoveableDisk
    {
        bool HasDisk { get; }
        void Insert();
        void Reject();
    }
    class CD : Disk, IRemoveableDisk
    {
        public bool hasDisk;
        public bool HasDisk { get; }
        string GetName()
        {
            return memory;
        }
        void IRemoveableDisk.Insert()
        {
            Console.WriteLine("Inserting...");
        }
        void IRemoveableDisk.Reject()
        {
            Console.WriteLine("Rejecting...");
        }
    }
    class Flash : Disk, IRemoveableDisk
    {
        public bool hasDisk;
        public bool HasDisk { get; }
        string GetName()
        {
            return memory;
        }
        void IRemoveableDisk.Insert()
        {
            Console.WriteLine("Inserting...");
        }
        void IRemoveableDisk.Reject()
        {
            Console.WriteLine("Rejecting...");
        }
    }
    class HDD : Disk
    {
        string GetName()
        {
            return memory;
        }
    }
    class DVD : Disk, IRemoveableDisk
    {
        public bool hasDisk;
        public bool HasDisk { get; }
        string GetName()
        {
            return memory;
        }
        void IRemoveableDisk.Insert()
        {
            Console.WriteLine("Inserting...");
        }
        void IRemoveableDisk.Reject()
        {
            Console.WriteLine("Rejecting...");
        }
    }
    ///////////////////////////////////////

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
