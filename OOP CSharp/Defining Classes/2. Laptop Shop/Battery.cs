using System;

class Battery
{
    public string BatteryModel { get; set; }
    public int BatteryLife { get; set; }
    public Battery():this("[no batteryModel]", 0)
    {
    }
    public Battery(string batteryModel, int batteryLife)
    {
        this.BatteryModel = batteryModel;
        this.BatteryLife = batteryLife;
    }
    public override string ToString()
    {
        
        return string.Format("Battery:\nModel - {0} / Life - {1} mins.", this.BatteryModel, this.BatteryLife);
    }
}
