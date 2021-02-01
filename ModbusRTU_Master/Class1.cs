using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Modbus;
using Modbus.Device;
using Modbus.Data;
using Modbus.Message;
using System.IO.Ports;  //for serial port
//tcp
using System.Net;         //for tcp client
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Diagnostics;
namespace ModbusRTU_Master
{
    public class PCS_delta_100kw
    {
        public void pcs_read_AFC(ModbusSerialMaster master)
        {
            try
            {
                master.ReadHoldingRegisters(1, 5395, 2);
            }
            catch (Exception ee)
            {
                Debug.Print(ee.Message);
            } 
        }
    }
        class Class1
    {
    }
}
