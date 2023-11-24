using System;

abstract class Storage
{
    protected string name;
    protected string model;

    public abstract double GetMemoryVolume();

    public abstract void CopyData(double dataSize);

    public abstract double GetFreeMemory();

    public virtual void GetDeviceInfo()
    {
        Console.WriteLine($"Name: {name}, Model: {model}");
    }
}

class Flash : Storage
{
    private double usbSpeed;
    private double memorySize;

    public Flash(string name, string model, double usbSpeed, double memorySize)
    {
        this.name = name;
        this.model = model;
        this.usbSpeed = usbSpeed;
        this.memorySize = memorySize;
    }

    public override double GetMemoryVolume()
    {
        return memorySize;
    }

    public override void CopyData(double dataSize)
    {
        double time = dataSize / usbSpeed;
        Console.WriteLine($"Copying data to Flash Memory. Time taken: {time} seconds.");
    }

    public override double GetFreeMemory()
    {
        return memorySize * 0.8;
    }
}

class DVD : Storage
{
    private double readWriteSpeed;
    private string type;

    public DVD(string name, string model, double readWriteSpeed, string type)
    {
        this.name = name;
        this.model = model;
        this.readWriteSpeed = readWriteSpeed;
        this.type = type;
    }

    public override double GetMemoryVolume()
    {
        return type == "односторонний" ? 4.7 : 9;
    }

    public override void CopyData(double dataSize)
    {
        double time = dataSize / readWriteSpeed;
        Console.WriteLine($"Copying data to DVD. Time taken: {time} seconds.");
    }

    public override double GetFreeMemory()
    {
        return GetMemoryVolume();
    }
}

class HDD : Storage
{
    private double usbSpeed;
    private int partitions;
    private double partitionVolume;

    public HDD(string name, string model, double usbSpeed, int partitions, double partitionVolume)
    {
        this.name = name;
        this.model = model;
        this.usbSpeed = usbSpeed;
        this.partitions = partitions;
        this.partitionVolume = partitionVolume;
    }

    public override double GetMemoryVolume()
    {
        return partitions * partitionVolume;
    }

    public override void CopyData(double dataSize)
    {
        double time = dataSize / usbSpeed;
        Console.WriteLine($"Copying data to HDD. Time taken: {time} seconds.");
    }

    public override double GetFreeMemory()
    {
        return partitions * partitionVolume * 0.9;
    }
}

class Program
{
    static void Main()
    {
        Storage[] devices = new Storage[]
        {
            new Flash("Flash Drive", "ABC123", 150, 64),
            new DVD("DVD Disk", "XYZ456", 12, "односторонний"),
            new HDD("External HDD", "123DEF", 60, 2, 500)
        };

        double totalMemory = 0;

        foreach (var device in devices)
        {
            totalMemory += device.GetMemoryVolume();
        }

        Console.WriteLine($"Total memory of all devices: {totalMemory} GB");

        double dataSizeToCopy = 300; 
        Console.WriteLine($"\nData size to copy: {dataSizeToCopy} GB");

        foreach (var device in devices)
        {
            device.CopyData(dataSizeToCopy);
        }

        double numDevicesRequired = dataSizeToCopy / totalMemory;
        Console.WriteLine($"\nNumber of devices required for transfer: {Math.Ceiling(numDevicesRequired)}");
    }
}
