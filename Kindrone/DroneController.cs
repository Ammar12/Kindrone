using AR.Drone.Client;
using AR.Drone.Client.Command;
using AR.Drone.Data.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// DISBALED Rolling due to unexpected bugs

/*
 * Skeleton of Kindrone:
 * - Declares classes underneath Kindrone.
 *   | - Classes provide the bootstrap for beginning
 *   |   the parrot AR drone SDK, OpenKinect SDK and
 *
 * */

namespace Kindrone
{
    class DroneController
    {
        public class DroneCommandChangedEventArgs
        {
            public string CommandText { get; set; }
        }

        public delegate void DroneCommandChangedDelegate(object sender, DroneCommandChangedEventArgs args);

        public event DroneCommandChangedDelegate DroneCommandChanged;

        private DroneClient _client;

        /* Controls that were tied to our specified client
         * - Start, Stop Hover, Emergy, Reset Emergy
         * -
         * -
         */

        // Drone Client IP address for connecting to.
        public DroneController()
        {
            _client = new DroneClient("192.168.1.1");
        }

        public DroneController(DroneClient client)
        {
            _client = client;
        }


        /* Basic controls that were tied to our specified client:
         * - Start, Stop, Hover, Emergency, ResetEmergency
         */
        public void Start()
        {
            _client.Start();
            _client.FlatTrim();
        }

        public void Stop()
        {
            _client.Stop();
        }

        public void Hover()
        {
            _client.Hover();
        }

        public void Emergency()
        {
            _client.Emergency();
        }

        public void ResetEmergency()
        {
            _client.ResetEmergency();
        }

        // Tracking the position changes of both hands
        public void SubscribeToGestures()
        {
            // Right Hand
            GestureDetection.RightHandUpDownChanged += GestureDetection_RightHandUpDownChanged;
           /// GestureDetection.RightHandLeftRightChanged += GestureDetection_RightHandLeftRightChanged;
            GestureDetection.RightHandBackForwardsChanged += GestureDetection_RightHandBackForwardsChanged;

            // Left Hand
            GestureDetection.LeftHandUpDownChanged += GestureDetection_LeftHandUpDownChanged;
            GestureDetection.LeftHandLeftRightChanged += GestureDetection_LeftHandLeftRightChanged;
            GestureDetection.LeftHandBackForwardsChanged += GestureDetection_LeftHandBackForwardsChanged;
        }


        // Left Hand:
        // Tying gesture detections from Kinect to commands
        // based on the ARDrone SDK Client
        void GestureDetection_LeftHandBackForwardsChanged(object sender, HandPositionChangedArgs args)
        {
            switch (args.Position)
            {
                // Base action (do nothing)
                case HandPosition.Center:
                    break;

                // If HandPosition has changed by a negative value
                // (hand moved down) and the navigation command was
                // initiated:
                // -| Command Flat Trim is instantiated
                // -| Passes command name to GUI
                case HandPosition.Backwards:
                    if (_client.NavigationData.State == (NavigationState.Landed | NavigationState.Command))
                        _client.FlatTrim();
                        DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Flat Trim " });
                    break;

                // If Hand position has changed by a positive value
                // (hand moved up):
                // -| Instantiate command Hover
                // -| Pass command name to GUI
                case HandPosition.Forwards:
                    _client.Hover();
                    DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Hover" });
                    break;
            }
        }

        // Right Hand:
        // Tying gesture detections from Kinect's right hand
        // gesture detection to ARDrone SDK Client actions
        void GestureDetection_RightHandBackForwardsChanged(object sender, HandPositionChangedArgs args)
        {
            switch (args.Position)
            {
                // If the right hand's position is located to the center
                // -| Do nothing
                case HandPosition.Center:
                    break;

                // If the right hand's position has changed by a neg.
                // value
                // -| Instantiate a flight command with 
                //    0.05 positive pitch (meaning it moves backwards)
                case HandPosition.Backwards:
                    _client.Progress(FlightMode.Progressive, pitch: 0.05f);
                    DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Moving Backwards" });
                    break;

                // If the right hand's position has changed by a pos.
                // value
                // -| Instantiate a flight command with -0.05
                //    negative pitch (meaning it moves forwards)
                case HandPosition.Forwards:
                    _client.Progress(FlightMode.Progressive, pitch: -0.05f);
                    DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Moving Forwards" });
                    break;
            }
        }

// Roll is REALLY buggy

      ///---  void GestureDetection_RightHandLeftRightChanged(object sender, HandPositionChangedArgs args)
      ///  {
          ///  switch (args.Position)
           /// {
           ///     case HandPosition.Center:
              ///      break;
             ///   case HandPosition.Left:
              ///      _client.Progress(FlightMode.Progressive, roll: -0.05f);
              ///      DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Rolling to the Left" });
               ///     break;
               /// case HandPosition.Right:
                 ///   _client.Progress(FlightMode.Progressive, roll: 0.05f);
                  ///  DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Rolling to the Right" });
                  ///  break;
            ///}
      ///  }


        
        void GestureDetection_LeftHandLeftRightChanged(object sender, HandPositionChangedArgs args)
        {
            switch (args.Position)
            {
                case HandPosition.Center:
                    break;
                case HandPosition.Left:
                    _client.Progress(FlightMode.Progressive, yaw: 0.25f);
                    DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Turning Left" });
                    break;
                case HandPosition.Right:
                    _client.Progress(FlightMode.Progressive, yaw: -0.25f);
                    DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Turning Right" });
                    break;
            }
        }

        void GestureDetection_RightHandUpDownChanged(object sender, HandPositionChangedArgs args)
        {
            switch (args.Position)
            {
                case HandPosition.Up:
                    _client.Progress(FlightMode.Progressive, gaz: 0.25f);
                    DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Going Up" });
                    break;
                case HandPosition.Center:
                    break;
                case HandPosition.Down:
                    _client.Progress(FlightMode.Progressive, gaz: -0.25f);
                    DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Going Down" });
                    break;
            }
        }

        void GestureDetection_LeftHandUpDownChanged(object sender, HandPositionChangedArgs args)
        {
            switch (args.Position)
            {
                case HandPosition.Up:
                    _client.Takeoff();
                    DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Taking Off" });
                    break;
                case HandPosition.Center:
                    break;
                case HandPosition.Down:
                    _client.Land();
                    DroneCommandChanged(_client, new DroneCommandChangedEventArgs { CommandText = "Landing" });
                    break;
            }
        }
    }
}
