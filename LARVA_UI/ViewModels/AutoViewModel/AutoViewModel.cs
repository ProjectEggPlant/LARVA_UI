using DevExpress.Mvvm;
using System;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm.CodeGenerators;
using LARVA_UI.Views;
using DevExpress.Xpf.Core;
using EPLE.App;
using EPLE.IO;
using EPLE.Core;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Collections.ObjectModel;
using System.Linq;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;
using System.Collections.Generic;
using LARVA.Scheduler;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class AutoViewModel
    {
        private string[] _boxButtonNames = new string[30];

        [GenerateProperty]
        private int selectedZoneNumber;

        public ObservableCollection<string> BoxButtonNames { get; private set; }

        public ObservableCollection<string> SelectedBoxes { get; private set; }

        [GenerateCommand]
        public void ToggleBoxSelection(string boxName)
        {
            if (SelectedBoxes.Contains(boxName))
                SelectedBoxes.Remove(boxName);
            else
                SelectedBoxes.Add(boxName);
        }

        public ICommand[] ChangeBoxZoneCommands { get; private set; }

        public AutoViewModel()
        {
            BoxButtonNames = new ObservableCollection<string>(Enumerable.Repeat("Initial Name", 240));

            for (int i = 0; i < 240; i++)
            {
                LOCATION_INFO shelfinfo = LocationManager.Instance.GetLocationList().FindAll((x) => (x.LOCATION_ID == i)).FirstOrDefault();
                BoxButtonNames[i] = shelfinfo.LOCATION_NAME;
            }

            SelectedBoxes = new ObservableCollection<string>();
            InitializeCommands();

        }

        [GenerateCommand]
        private void TobbabSupplyClicked(RoutedEventArgs args)
        {
            //LocationManager.Instance.GetLocationList()
            //JobManager.Instance.CreateNewJob("TOBBAB_SUPPLY", )
        }

        [GenerateCommand]
        private void StockLampOffClicked(RoutedEventArgs args)
        {

            switch(selectedZoneNumber)
            {
                case 1:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.OFF);
                    break;
                case 2:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.OFF);
                    break;
                case 3:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.OFF);
                    break;
                case 4:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.OFF);
                    break;
                case 5:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.OFF);
                    break;
                case 6:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.OFF);
                    break;
                case 7:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.OFF);
                    break;
                case 8:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.OFF);
                    break;
            }
           
        }

        [GenerateCommand]
        private void StockLampOn50Clicked(RoutedEventArgs args)
        {

            switch (selectedZoneNumber)
            {
                case 1:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.ON_50);
                    break;
                case 2:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.ON_50);
                    break;
                case 3:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.ON_50);
                    break;
                case 4:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.ON_50);
                    break;
                case 5:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.ON_50);
                    break;
                case 6:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.ON_50);
                    break;
                case 7:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.ON_50);
                    break;
                case 8:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.ON_50);
                    break;
            }

        }

        [GenerateCommand]
        private void StockLampOn100Clicked(RoutedEventArgs args)
        {

            switch (selectedZoneNumber)
            {
                case 1:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone1_OnOff, (int)eLedCmd.ON_100);
                    break;
                case 2:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone2_OnOff, (int)eLedCmd.ON_100);
                    break;
                case 3:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone3_OnOff, (int)eLedCmd.ON_100);
                    break;
                case 4:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone4_OnOff, (int)eLedCmd.ON_100);
                    break;
                case 5:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone5_OnOff, (int)eLedCmd.ON_100);
                    break;
                case 6:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone6_OnOff, (int)eLedCmd.ON_100);
                    break;
                case 7:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone7_OnOff, (int)eLedCmd.ON_100);
                    break;
                case 8:
                    DataManager.Instance.SET_INT_DATA(IoNameHelper.oLed_nZone8_OnOff, (int)eLedCmd.ON_100);
                    break;
            }

        }

        private void InitializeCommands()
        {
            ChangeBoxZoneCommands = new ICommand[8];
            for (int i = 0; i < 8; i++)
            {
                int zoneNumber = i + 1;
                ChangeBoxZoneCommands[i] = new DelegateCommand(() => ChangeBoxZone(zoneNumber));
            }
        }

        private void ChangeBoxZone(int zoneNumber)
        {
            for (int i = 0; i < 30; i++)
            {
                LOCATION_INFO shelfinfo = LocationManager.Instance.GetLocationList().FindAll((x) => (x.LOCATION_ID == (i + ((zoneNumber - 1) * 30)))).FirstOrDefault();
                BoxButtonNames[i] = $"{shelfinfo.LOCATION_NAME}\n{shelfinfo.LEVEL}";
            }

            selectedZoneNumber = zoneNumber;
        }

        public void ClearSelectedBoxes()
        {
            SelectedBoxes.Clear();
        }

        public void SetBoxLevel(string boxname, string shelflevel)
        {
            string newBoxname = null;
            if (boxname.Contains("\n"))
            {
                newBoxname = boxname.Substring(0, boxname.IndexOf('\n'));
            }
            else
            {
                newBoxname= boxname;
            }
            LOCATION_INFO shelfinfo = LocationManager.Instance.GetLocationList().FindAll((x) => (x.LOCATION_NAME == newBoxname)).FirstOrDefault();
            LocationManager.Instance.UpdateLocationLevel(shelfinfo.LOCATION_ID, shelflevel);
        }
    }
}
