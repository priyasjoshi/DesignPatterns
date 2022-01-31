using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    //Client
    class RemoteControlTest
    {
        //public static void Main(String [] args) {
        //    //Simple remote control test 
        //    //SimpleRemoteControl remote = new SimpleRemoteControl();
        //    //Light l = new Light();
        //    //LightOnCommand lo = new LightOnCommand(l);
        //    //remote.setCommand(lo);
        //    //remote.buttonWasPressed();
        //    //GarageDoor g = new GarageDoor();
        //    //GarageDoorOpen go = new GarageDoorOpen(g);
        //    //remote.setCommand(go);
        //    //remote.buttonWasPressed();
        //    //-------------------------
        //    //Final Remote Control test
        //    RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();
        //    //Receiver Objects
        //    Light LivingRoomLight = new Light();
        //    //Light KitchenLight = new Light();
        //    //GarageDoor garageDoor = new GarageDoor();
        //    Stereo stereo = new Stereo();

        //    //Creating command objects
        //    //Light commands
        //    LightOnCommand livingRoomLightOn = 
        //        new LightOnCommand(LivingRoomLight);
        //    LightOffCommand livingRoomLightOff = 
        //        new LightOffCommand(LivingRoomLight);
        //    //LightOnCommand kitchenLightOn =
        //    //    new LightOnCommand(KitchenLight);
        //    //LightOffCommand kitchenLightOff =
        //    //    new LightOffCommand(KitchenLight);

        //    //Garage commands
        //    //GarageDoorOpen garageDoorup = new GarageDoorOpen(garageDoor);
        //    //GarageDoorDown garageDoordown = new GarageDoorDown(garageDoor);

        //    //Stereo commands
        //    StereoOnWithCDCommand stereoOn = new StereoOnWithCDCommand(stereo);
        //    stereoOff stereoOff = new stereoOff(stereo);

        //    //setting remote control command objects
        //    //remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
        //    //remoteControl.setCommand(1, kitchenLightOn,kitchenLightOff);
        //    //remoteControl.setCommand(2, garageDoorup,garageDoordown);
        //    //remoteControl.setCommand(3, stereoOn,stereoOff);

           

        //    //Rolling down our remote 
        //    //remoteControl.onButtonWasPushed(0);
        //    //remoteControl.offButtonWasPushed(0);
        //    //remoteControl.onButtonWasPushed(1);
        //    //remoteControl.offButtonWasPushed(1);
        //    //remoteControl.onButtonWasPushed(2);
        //    //remoteControl.offButtonWasPushed(2);
        //    //remoteControl.onButtonWasPushed(3);
        //    //remoteControl.offButtonWasPushed(3);
        //    //remoteControl.undoButtonWasPushed();

        //    //using macro commands
        //    Command[] partyon = {livingRoomLightOff,stereoOn};
        //    Command[] partyoff = {livingRoomLightOn,stereoOff };
        //    MacroCommands PartyOnMacro = new MacroCommands(partyon);
        //    MacroCommands PartyOffMacro = new MacroCommands(partyoff);
        //    remoteControl.setCommand(0, PartyOnMacro, PartyOffMacro);
        //    //Printing remote control
        //    Console.WriteLine("Remote looks like: " + remoteControl.ToString());
        //    Console.WriteLine("------- Pushing macro on ----------");
        //    remoteControl.onButtonWasPushed(0);
        //    //Console.WriteLine("------- Pushing macro off ---------");
        //    //remoteControl.offButtonWasPushed(0);
        //    Console.WriteLine("-------- Pushing undo macro --------");
        //    remoteControl.undoButtonWasPushed();
        //    Console.ReadKey();
        //}
    }
}
