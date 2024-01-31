using Smart.PowerCUBE.Api;
using static Smart.PowerCUBE.Api.RealPointDataModel;

namespace PowerCubeTest;

public class PowerCubeDemo
{
    public static PowerCubeServerApi powerCubeServerApi { get; set; } = new PowerCubeServerApi();

    public static void GetMidLive()
    {
        bool ret = powerCubeServerApi.IsConnect();
        Console.WriteLine($"GetMidLive={ret}");
    }

    public static void GetControlPointNames()
    {
        var names = powerCubeServerApi.GetControlPointNames();
        foreach( string name in names )
        {
            Console.WriteLine( name );
        }
    }
    public static void GetEventPointNames()
    {
        var names = powerCubeServerApi.GetEventPointNames();
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
    public static void GetMessagePointNames()
    {
        var names = powerCubeServerApi.GetMessagePointNames();
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
    public static void GetRealPointNames()
    {
        var names = powerCubeServerApi.GetRealPointNames(ConnectMidServer.Partner);
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
    public static void GetRealPointDataWithTypeName()
    {
        //PowerCubeApi.GetRealPointDataWithTypeName(string)
        // RealPointWithTypeNameDataModel
        var rp = powerCubeServerApi.GetRealPointDataWithTypeName("COMPUTER/SNMP1");
        Console.WriteLine($"포인트 이름:{rp.RealPointName}");
        foreach (var rpdata in rp.PointData)
        {
            Console.WriteLine($"{rpdata.TypeName}\t{rpdata.DataTypeName} = {rpdata.DataValue}");
        }
    }

    public static void GetRealPointDataWithTypeNameList()
    {
        var rps = powerCubeServerApi.GetRealPointDataWithTypeName(new List<string> { "PROGRAM/PRO1", "PROGRAM/PRO2", "PROGRAM/PRO3" });
        foreach (var rp in rps)
        {
            Console.WriteLine($"포인트 이름:{rp.RealPointName}");
            foreach (var rpdata in rp.PointData)
            {
                Console.WriteLine($"{rpdata.TypeName}\t{rpdata.DataTypeName} = {rpdata.DataValue}");
            }
        }
    }

    // PowerCubeApi.UpdateRealDataPoint(Smart.PowerCUBE.Api.RealPointDataModel)
    // PowerCubeApi.GetRealPointData(string)
    public static void UpdateRealDataPoint()
    {
        var rp = powerCubeServerApi.GetRealPointData("PROGRAM/PRO3", ConnectMidServer.Current);
        if(rp != null)
        {
            Console.WriteLine($"포인트 이름:{rp.RealPointName}");
            foreach (var rpdata in rp.PointData)
            {
                Console.WriteLine($"{rpdata.DataTypeName} = {rpdata.DataValue}");
            }

            Smart.PowerCUBE.Api.RealPointDataModel updaterp = new()
            {
                RealPointName = "PROGRAM/PRO3",
                PointData = new()
            {
                new RealPointData {
                    DataTypeName = "status", DataValue = "1"
                },
                new RealPointData {
                    DataTypeName = "start_tm", DataValue = "2024-01-05 12:12:12"
                }
            }
            };
            int ret = powerCubeServerApi.UpdateRealDataPoint(updaterp);
            Console.WriteLine($"REAL DATA 업데이트(ret:{ret})");
        }

    }

    public static void GetCubeBoxInfo()
    {
        var msgInfo = powerCubeServerApi.GetCubeBoxInfo(CubeBoxType.CubePoint_MSG, "MSG_FEP_P001");
        Console.WriteLine();

    }


    public static void ServerInfo()
    {
        Console.WriteLine($"서버이름 : {powerCubeServerApi.GetServerName()} 서버MOD:{powerCubeServerApi.GetServerMode()} 서버코드:{powerCubeServerApi.GetServerCode()}");
    }
}
