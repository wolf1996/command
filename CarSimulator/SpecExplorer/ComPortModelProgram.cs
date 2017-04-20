using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Microsoft.Modeling;
using SpecExplorer.Sample;

namespace SpecExplorer
{
    /// <summary>
    /// An example model program.
    /// </summary>
    public static class ComPortModelProgram
    {
        enum ComPortState
        {
            WaitingForOpen,
            Opened,
            WaitingForClose,
            Closed,
            Sending
        }

        static ComPortState state;
        static COMPort com = new COMPort();

        [Rule]
        public static void create_obj(string port_name)
        {
            COMPort.create(port_name);
            state = ComPortState.Closed;
        }

        [Rule]
        public static void open(string port_name)
        {
            //Condition.IsTrue(com.get_state() == false);
            COMPort.open(port_name);
            state = ComPortState.WaitingForOpen;
            //Condition.IsTrue(com.get_state() == true);
            state = ComPortState.Opened;
        }

        [Rule]
        public static void send(string msg)
        {
            state = ComPortState.Sending;
            COMPort.send(msg);  
            //Condition.IsTrue(com.get_state() == false);
            state = ComPortState.Opened;
        }

        [Rule]
        public static void close(string port_name)
        {
            state = ComPortState.WaitingForClose;
            COMPort.close(port_name);
            //Condition.IsTrue(com.get_state() == false);
            state = ComPortState.Closed;
        }

        
    }
}