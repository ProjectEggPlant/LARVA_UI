using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using System;
using System.Windows;
using EPLE.IO;
using EPLE.App;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Media;
using DevExpress.Xpf.Core;
using EPLE.Core.Manager;
using EPLE.Core.Manager.Model;

namespace LARVA_UI.ViewModels
{
    [GenerateViewModel]
    public partial class ManualViewModel
    {
        [GenerateProperty]
        private SolidColorBrush loaderShutterOpenBG;
        [GenerateProperty]
        private SolidColorBrush loaderShutterCloseBG;
        [GenerateProperty]
        private SolidColorBrush loaderShuttleFWBG;
        [GenerateProperty]
        private SolidColorBrush loaderShuttleBWBG;
        [GenerateProperty]
        private SolidColorBrush upperCoverUpBG;
        [GenerateProperty]
        private SolidColorBrush upperCoverDnBG;
        [GenerateProperty]
        private SolidColorBrush impactCylinderOnBG;
        [GenerateProperty]
        private SolidColorBrush impactCylinderOffBG;
        [GenerateProperty]
        private SolidColorBrush outConveyorOnBG;  //out io get
        [GenerateProperty]
        private SolidColorBrush outConveyorOffBG;
        [GenerateProperty]
        private SolidColorBrush flipOutShutterOpenBG;
        [GenerateProperty]
        private SolidColorBrush flipOutShutterCloseBG;
        [GenerateProperty]
        private SolidColorBrush hoperMotorOnBG; //out io get
        [GenerateProperty]
        private SolidColorBrush hoperMotorOffBG;
        [GenerateProperty]
        private SolidColorBrush hotAirBlowerOnBG;  //out io get
        [GenerateProperty]
        private SolidColorBrush hotAirBlowerOffBG;
        [GenerateProperty]
        private SolidColorBrush uVLampOnBG;  //out io get
        [GenerateProperty]
        private SolidColorBrush uVLampOffBG;
        [GenerateProperty]
        private SolidColorBrush mistOnBG;
        [GenerateProperty]
        private SolidColorBrush mistOffBG;
        [GenerateProperty]
        private SolidColorBrush tbsShutterOpenBG;
        [GenerateProperty]
        private SolidColorBrush tbsShutterCloseBG;
        [GenerateProperty]
        private SolidColorBrush flatMotorOnBG;
        [GenerateProperty]
        private SolidColorBrush flatMotorOffBG;
        [GenerateProperty]
        private SolidColorBrush swingOnBG;
        [GenerateProperty]
        private SolidColorBrush swingOffBG;
        [GenerateProperty]
        private SolidColorBrush mixerOnBG;
        [GenerateProperty]
        private SolidColorBrush mixerOffBG;
        [GenerateProperty]
        private SolidColorBrush waterTankValveOpenBG;
        [GenerateProperty]
        private SolidColorBrush waterTankValveCloseBG;
        [GenerateProperty]
        private SolidColorBrush washWaterOpenBG;
        [GenerateProperty]
        private SolidColorBrush washWaterCloseBG;
        [GenerateProperty]
        private SolidColorBrush waterPumpOpenBG;
        [GenerateProperty]
        private SolidColorBrush waterPumpCloseBG;
        [GenerateProperty]
        private SolidColorBrush zone1BG;
        [GenerateProperty]
        private SolidColorBrush zone2BG;
        [GenerateProperty]
        private SolidColorBrush zone3BG;
        [GenerateProperty]
        private SolidColorBrush zone4BG;
        [GenerateProperty]
        private SolidColorBrush zone5BG;
        [GenerateProperty]
        private SolidColorBrush zone6BG;
        [GenerateProperty]
        private SolidColorBrush zone7BG;
        [GenerateProperty]
        private SolidColorBrush zone8BG;
        [GenerateProperty]
        private SolidColorBrush floor1BG;
        [GenerateProperty]
        private SolidColorBrush floor2BG;
        [GenerateProperty]
        private SolidColorBrush floor3BG;
        [GenerateProperty]
        private SolidColorBrush floor4BG;
        [GenerateProperty]
        private SolidColorBrush floor5BG;
        [GenerateProperty]
        private SolidColorBrush column1BG;
        [GenerateProperty]
        private SolidColorBrush column2BG;
        [GenerateProperty]
        private SolidColorBrush column3BG;
        [GenerateProperty]
        private SolidColorBrush rackMoveBG;
        [GenerateProperty]
        private SolidColorBrush rackLoadingBG;
        [GenerateProperty]
        private SolidColorBrush rackUnloadingBG;
        [GenerateProperty]
        private SolidColorBrush tRSHandLeftBG;
        [GenerateProperty]
        private SolidColorBrush tRSHandRightBG;
        [GenerateProperty]
        private SolidColorBrush tRSClampOpenBG;
        [GenerateProperty]
        private SolidColorBrush tRSClampCloseBG;
        [GenerateProperty]
        private SolidColorBrush tRSCoverUpBG;
        [GenerateProperty]
        private SolidColorBrush tRSCoverDnBG;
        [GenerateProperty]
        private SolidColorBrush tRSCoverVacOnBG;
        [GenerateProperty]
        private SolidColorBrush tRSCoverOffBG;
        [GenerateProperty]
        private SolidColorBrush circulatorOnBG;
        [GenerateProperty]
        private SolidColorBrush circulatorOffBG;
        [GenerateProperty]
        private SolidColorBrush ammoniaOnBG;
        [GenerateProperty]
        private SolidColorBrush ammoniaOffBG;

        [GenerateProperty]
        private SolidColorBrush flipSelectBG;
        [GenerateProperty]
        private SolidColorBrush tobbabSelectBG;
        [GenerateProperty]
        private SolidColorBrush loaderSelectBG;
        [GenerateProperty]
        private SolidColorBrush visionSelectBG;
        [GenerateProperty]
        private SolidColorBrush washSelectBG;
        [GenerateProperty]
        private SolidColorBrush bufferSelectBG;

        private string selectedZone;
        private string selectedFloor;
        private string selectedColumn;
        private string selectedProcess;

        public ManualViewModel()
        {
           
            DataManager.Instance.DataAccess.DataChangedEvent += new EventHandler<DataChangedEventHandlerArgs>(OnDataChanged);
            Initialize();
        }

        private void Initialize()
        {
            selectedZone = "1";
            Zone1BG = new SolidColorBrush(Colors.LightGreen);
            Zone2BG = new SolidColorBrush(Colors.Transparent);
            Zone3BG = new SolidColorBrush(Colors.Transparent);
            Zone4BG = new SolidColorBrush(Colors.Transparent);
            Zone5BG = new SolidColorBrush(Colors.Transparent);
            Zone6BG = new SolidColorBrush(Colors.Transparent);
            Zone7BG = new SolidColorBrush(Colors.Transparent);
            Zone8BG = new SolidColorBrush(Colors.Transparent);

            selectedFloor = "1";
            Floor1BG = new SolidColorBrush(Colors.LightGreen); 
            Floor2BG = new SolidColorBrush(Colors.Transparent);
            Floor3BG = new SolidColorBrush(Colors.Transparent);
            Floor4BG = new SolidColorBrush(Colors.Transparent);
            Floor5BG = new SolidColorBrush(Colors.Transparent);

            selectedColumn = "1";
            Column1BG = new SolidColorBrush(Colors.LightGreen);
            Column2BG = new SolidColorBrush(Colors.Transparent);
            Column3BG = new SolidColorBrush(Colors.Transparent);

            selectedProcess = "로더";
            LoaderSelectBG = new SolidColorBrush(Colors.LightGreen);
            BufferSelectBG = new SolidColorBrush(Colors.Transparent);
            FlipSelectBG = new SolidColorBrush(Colors.Transparent);
            WashSelectBG = new SolidColorBrush(Colors.Transparent);
            TobbabSelectBG = new SolidColorBrush(Colors.Transparent);
            VisionSelectBG  = new SolidColorBrush(Colors.Transparent);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnDataChanged(object sender, DataChangedEventHandlerArgs e)
        {
            int tmp;
            bool result;
            tmp = DataManager.Instance.GET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, out result);

            Data data = (Data)e.Data;

            if (Application.Current == null) return;

            Application.Current.Dispatcher.Invoke(() =>
            {
                if (tmp == (int)eOnOff.OFF || tmp == (int)eOnOff.ON)
                {
                    if (tmp == (int)eOnOff.ON)
                    {
                        OutConveyorOnBG = new SolidColorBrush(Colors.LightGreen);
                        OutConveyorOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (tmp == (int)eOnOff.OFF)
                    {
                        OutConveyorOnBG = new SolidColorBrush(Colors.Transparent);
                        OutConveyorOffBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        OutConveyorOnBG = new SolidColorBrush(Colors.Transparent);
                        OutConveyorOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                }

                if (data.Name == IoNameHelper.iLoader_nShutter_UpDown)
                {
                    if (Convert.ToInt32(data.Value) == (int)eUpDown.DOWN)
                    {
                        LoaderShutterOpenBG = new SolidColorBrush(Colors.LightGreen);
                        LoaderShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eUpDown.UP)
                    {
                        LoaderShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        LoaderShutterCloseBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        LoaderShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        LoaderShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iLoader_nShuttle_FwdBwd)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        LoaderShuttleFWBG = new SolidColorBrush(Colors.LightGreen);
                        LoaderShuttleBWBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        LoaderShuttleFWBG = new SolidColorBrush(Colors.Transparent);
                        LoaderShuttleBWBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        LoaderShuttleFWBG = new SolidColorBrush(Colors.Transparent);
                        LoaderShuttleBWBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iFlip_nUpperCover_UpDown)
                {
                    if (Convert.ToInt32(data.Value) == (int)eUpDown.UP)
                    {
                        UpperCoverUpBG = new SolidColorBrush(Colors.LightGreen);
                        UpperCoverDnBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eUpDown.DOWN)
                    {
                        UpperCoverUpBG = new SolidColorBrush(Colors.Transparent);
                        UpperCoverDnBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        UpperCoverUpBG = new SolidColorBrush(Colors.Transparent);
                        UpperCoverDnBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.oFlip_nBoxImpact_RunStop)
                {
                    if (Convert.ToInt32(data.Value) == (int)eRunStop.RUN)
                    {
                        ImpactCylinderOnBG = new SolidColorBrush(Colors.LightGreen);
                        ImpactCylinderOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eRunStop.STOP)
                    {
                        ImpactCylinderOnBG = new SolidColorBrush(Colors.Transparent);
                        ImpactCylinderOffBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        ImpactCylinderOnBG = new SolidColorBrush(Colors.Transparent);
                        ImpactCylinderOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iFlip_nOutShutter_UpDown)
                {
                    if (Convert.ToInt32(data.Value) == (int)eUpDown.UP)
                    {
                        FlipOutShutterOpenBG = new SolidColorBrush(Colors.LightGreen);
                        FlipOutShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eUpDown.DOWN)
                    {
                        FlipOutShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        FlipOutShutterCloseBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        FlipOutShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        FlipOutShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTBS_nFlatCyl_FwdBwd)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        TbsShutterOpenBG = new SolidColorBrush(Colors.LightGreen);
                        TbsShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        TbsShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        TbsShutterCloseBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TbsShutterOpenBG = new SolidColorBrush(Colors.Transparent);
                        TbsShutterCloseBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTBS_nSwingCyl_FwdBwd)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        SwingOnBG = new SolidColorBrush(Colors.LightGreen);
                        SwingOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        SwingOnBG = new SolidColorBrush(Colors.Transparent);
                        SwingOffBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        SwingOnBG = new SolidColorBrush(Colors.Transparent);
                        SwingOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTrans_nHandLeft_FwdBwd)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        TRSHandLeftBG = new SolidColorBrush(Colors.LightGreen);
                        TRSHandRightBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        TRSHandLeftBG = new SolidColorBrush(Colors.Transparent);
                        TRSHandRightBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TRSHandLeftBG = new SolidColorBrush(Colors.Transparent);
                        TRSHandRightBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTrans_nClamp_LockUnlock)
                {
                    if (Convert.ToInt32(data.Value) == (int)eFwdBwd.FORWARD)
                    {
                        TRSClampCloseBG = new SolidColorBrush(Colors.LightGreen);
                        TRSClampOpenBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eFwdBwd.BACKWARD)
                    {
                        TRSClampCloseBG = new SolidColorBrush(Colors.Transparent);
                        TRSClampOpenBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TRSClampCloseBG = new SolidColorBrush(Colors.Transparent);
                        TRSClampOpenBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTrans_nBoxCover_UpDown)
                {
                    if (Convert.ToInt32(data.Value) == (int)eUpDown.UP)
                    {
                        TRSCoverUpBG = new SolidColorBrush(Colors.LightGreen);
                        TRSCoverDnBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eUpDown.DOWN)
                    {
                        TRSCoverUpBG = new SolidColorBrush(Colors.Transparent);
                        TRSCoverDnBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TRSCoverUpBG = new SolidColorBrush(Colors.Transparent);
                        TRSCoverDnBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
                else if (data.Name == IoNameHelper.iTrans_nBoxCoverVac_OnOff)
                {
                    if (Convert.ToInt32(data.Value) == (int)eOnOff.ON)
                    {
                        TRSCoverVacOnBG = new SolidColorBrush(Colors.LightGreen);
                        TRSCoverOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                    else if (Convert.ToInt32(data.Value) == (int)eOnOff.OFF)
                    {
                        TRSCoverVacOnBG = new SolidColorBrush(Colors.Transparent);
                        TRSCoverOffBG = new SolidColorBrush(Colors.LightGreen);
                    }
                    else
                    {
                        TRSCoverVacOnBG = new SolidColorBrush(Colors.Transparent);
                        TRSCoverOffBG = new SolidColorBrush(Colors.Transparent);
                    }
                }
            });
        }

        [GenerateCommand(Name = "MistCommandClicked")]
        private void MistCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMist_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMist_OnOff, (int)eOnOff.OFF);
            }
        }
        [GenerateCommand(Name = "TbsShutterCommandClicked")]
        private void TbsShutterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatCyl_RunStop, (int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatCyl_RunStop, (int)eRunStop.STOP);
            }
        }
        
        [GenerateCommand(Name = "FlatMotorCommandClicked")]
        private void FlatMotorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatMotor_RunStop, (int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nFlatMotor_RunStop, (int)eRunStop.STOP);
            }
        }

        [GenerateCommand(Name = "SwingCommandClicked")]
        private void SwingCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nSwingCyl_RunStop, (int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nSwingCyl_RunStop, (int)eRunStop.STOP);
            }
        }

        [GenerateCommand(Name = "MixerCommandClicked")]
        private void MixerCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nMixer_Motor, (int)eMotorCmd.CW);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, (int)eMotorCmd.OFF);
            }
        }

        [GenerateCommand(Name = "WaterTankValveCommandClicked")]
        private void WaterTankValveCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nTankValve_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nTankValve_OnOff, (int)eOnOff.OFF);
            }
        }

        [GenerateCommand(Name = "WashWaterCommandClicked")]
        private void WashWaterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterValve_OnOff, (int)eOnOff.OFF);
            }
        }
        [GenerateCommand(Name = "WaterPumpCommandClicked")]
        private void WaterPumpCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterPump_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oWash_nWaterPump_OnOff, (int)eOnOff.OFF);
            }
        }



        [GenerateCommand]
        private void ZoneSelectClick(RoutedEventArgs args)
        {
            SimpleButton btn = (SimpleButton)args.OriginalSource;
            selectedZone = (string)btn.Content;
            //selectedZone

            Zone1BG = new SolidColorBrush(Colors.Transparent);
            Zone2BG = new SolidColorBrush(Colors.Transparent);
            Zone3BG = new SolidColorBrush(Colors.Transparent);
            Zone4BG = new SolidColorBrush(Colors.Transparent);
            Zone5BG = new SolidColorBrush(Colors.Transparent);
            Zone6BG = new SolidColorBrush(Colors.Transparent);
            Zone7BG = new SolidColorBrush(Colors.Transparent);
            Zone8BG = new SolidColorBrush(Colors.Transparent);

            if (selectedZone == "1")
            {
                Zone1BG = new SolidColorBrush(Colors.LightGreen);
            }
            else if (selectedZone == "2")
            {
                Zone2BG = new SolidColorBrush(Colors.LightGreen);
            }
            else if (selectedZone == "3")
            {
                Zone3BG = new SolidColorBrush(Colors.LightGreen);
            }
            else if (selectedZone == "4")
            {
                Zone4BG = new SolidColorBrush(Colors.LightGreen);
            }
            else if (selectedZone == "5")
            {
                Zone5BG = new SolidColorBrush(Colors.LightGreen);
            }
            else if (selectedZone == "6")
            {
                Zone6BG = new SolidColorBrush(Colors.LightGreen);
            }
            else if (selectedZone == "7")
            {
                Zone7BG = new SolidColorBrush(Colors.LightGreen);
            }
            else if (selectedZone == "8")
            {
                Zone8BG = new SolidColorBrush(Colors.LightGreen);
            }
        }

        [GenerateCommand]
        private void FloorSelectClick(RoutedEventArgs args)
        {
            SimpleButton btn = (SimpleButton)args.OriginalSource;
            selectedFloor = (string)btn.Content;
        }

        [GenerateCommand]
        private void ColumnSelectClick(RoutedEventArgs args)
        {
            SimpleButton btn = (SimpleButton)args.OriginalSource;
            selectedColumn = (string)btn.Content;
        }

        [GenerateCommand]
        private void LoaderSelectClick(RoutedEventArgs args)
        {
            LoaderSelectBG = new SolidColorBrush(Colors.LightGreen);
            BufferSelectBG = new SolidColorBrush(Colors.Transparent);
            TobbabSelectBG = new SolidColorBrush(Colors.Transparent);
            WashSelectBG = new SolidColorBrush(Colors.Transparent);
            VisionSelectBG = new SolidColorBrush(Colors.Transparent);
            FlipSelectBG = new SolidColorBrush(Colors.Transparent);

            selectedProcess = "LOADER";
        }

        [GenerateCommand]
        private void BufferSelectClick(RoutedEventArgs args)
        {
            LoaderSelectBG = new SolidColorBrush(Colors.Transparent);
            BufferSelectBG = new SolidColorBrush(Colors.LightGreen);
            TobbabSelectBG = new SolidColorBrush(Colors.Transparent);
            WashSelectBG = new SolidColorBrush(Colors.Transparent);
            VisionSelectBG = new SolidColorBrush(Colors.Transparent);
            FlipSelectBG = new SolidColorBrush(Colors.Transparent);

            selectedProcess = "BUFFER";
        }

        [GenerateCommand]
        private void TobbabSelectClick(RoutedEventArgs args)
        {
            LoaderSelectBG = new SolidColorBrush(Colors.Transparent);
            BufferSelectBG = new SolidColorBrush(Colors.Transparent);
            TobbabSelectBG = new SolidColorBrush(Colors.LightGreen);
            WashSelectBG = new SolidColorBrush(Colors.Transparent);
            VisionSelectBG = new SolidColorBrush(Colors.Transparent);
            FlipSelectBG = new SolidColorBrush(Colors.Transparent);

            selectedProcess = "TOBBAB";
        }

        [GenerateCommand]
        private void WashSelectClick(RoutedEventArgs args)
        {
            LoaderSelectBG = new SolidColorBrush(Colors.Transparent);
            BufferSelectBG = new SolidColorBrush(Colors.Transparent);
            TobbabSelectBG = new SolidColorBrush(Colors.Transparent);
            WashSelectBG = new SolidColorBrush(Colors.LightGreen);
            VisionSelectBG = new SolidColorBrush(Colors.Transparent);
            FlipSelectBG = new SolidColorBrush(Colors.Transparent);

            selectedProcess = "WASH";
        }

        [GenerateCommand]
        private void VisionSelectClick(RoutedEventArgs args)
        {
            LoaderSelectBG = new SolidColorBrush(Colors.Transparent);
            BufferSelectBG = new SolidColorBrush(Colors.Transparent);
            TobbabSelectBG = new SolidColorBrush(Colors.Transparent);
            WashSelectBG = new SolidColorBrush(Colors.Transparent);
            VisionSelectBG = new SolidColorBrush(Colors.LightGreen);
            FlipSelectBG = new SolidColorBrush(Colors.Transparent);

            selectedProcess = "VISION";
        }

        [GenerateCommand]
        private void FlipSelectClick(RoutedEventArgs args)
        {
            LoaderSelectBG = new SolidColorBrush(Colors.Transparent);
            BufferSelectBG = new SolidColorBrush(Colors.Transparent);
            TobbabSelectBG = new SolidColorBrush(Colors.Transparent);
            WashSelectBG = new SolidColorBrush(Colors.Transparent);
            VisionSelectBG = new SolidColorBrush(Colors.Transparent);
            FlipSelectBG = new SolidColorBrush(Colors.LightGreen);

            selectedProcess = "FLIP";
        }


        [GenerateCommand(Name = "RackMoveClickedCommand")]
        private void RackMoveClicked(RoutedEventArgs args)
        {
            int nSelectedColumn = (int.Parse(selectedColumn) * 2) - 1;
            string location_name = string.Format("STOCK {0}_{1}{2}", selectedZone, selectedFloor, nSelectedColumn);
            LOCATION_INFO loc = LocationManager.Instance.GetLocationList().Find((location) => { return (location.LOCATION_NAME == location_name); });
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTransMove_LocationId, Convert.ToInt32(loc.LOCATION_ID));
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nMove_RunStop, (int)eRunStop.RUN);
        }

        [GenerateCommand(Name = "ProcessMoveClickedCommand")]
        private void ProcessMoveClicked(RoutedEventArgs args)
        {
            int location_id = 0;

            if (selectedProcess.Equals("TOBBAB"))
            {
                location_id = (int)eLocationId.TOBBAB;
            }
            else if (selectedProcess.Equals("FLIP"))
            {
                location_id = (int)eLocationId.FLIP;
            }
            else if (selectedProcess.Equals("WASH"))
            {
                location_id = (int)eLocationId.WASH;
            }
            else if (selectedProcess.Equals("LOAD"))
            {
                location_id = (int)eLocationId.LOAD;
            }
            else if (selectedProcess.Equals("BUFFER"))
            {
                location_id = (int)eLocationId.BUFFER;
            }
            else if (selectedProcess.Equals("VISION"))
            {
                location_id = (int)eLocationId.VISION;
            }
            else
            {
                location_id = (int)eLocationId.VISION;
            }


            DataManager.Instance.SET_INT_DATA(IoNameHelper.oParam_nTransMove_LocationId, location_id);
            DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nMove_RunStop, (int)eRunStop.RUN);
        }

        [GenerateCommand(Name = "CirculatorCommandClicked")]
        private void CirculatorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAir_nCirculatorFan_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAir_nCirculatorFan_OnOff, (int)eOnOff.OFF);
            }
        }


        [GenerateCommand(Name = "AmmoniaCommandClicked")]
        private void AmmoniaCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAmmo_nExhaustFan_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oAmmo_nExhaustFan_OnOff, (int)eOnOff.OFF);
            }
        }

        [GenerateCommand(Name = "TRSHandCommandClicked")]
        private void TRSHandCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("왼쪽"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nHand_LeftRight, (int)eFwdBwd.BACKWARD);
            }
        }

        [GenerateCommand(Name = "TRSClampCommandClicked")]
        private void TRSClampCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_BoxClamp_LockUnlock, (int)eLockUnlock.UNLOCK);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_BoxClamp_LockUnlock, (int)eLockUnlock.LOCK);
            }
        }

        [GenerateCommand(Name = "TRSCoverCommandClicked")]
        private void TRSCoverCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("위로"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxCover_UpDown, (int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nBoxCover_UpDown, (int)eUpDown.DOWN);
            }
        }

        [GenerateCommand(Name = "TRSCoverVacCommandClicked")]
        private void TRSCoverVacCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("흡착"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVac_OnOff, (int)eOnOff.ON);
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.OFF);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVac_OnOff, (int)eOnOff.OFF);
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTrans_nCoverVacEject_OnOFF, (int)eOnOff.ON);
            }
        }

        [GenerateCommand(Name = "UVLampCommandClicked")]
        private void UVLampCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("켜짐"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nUVLamp_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nUVLamp_OnOff, (int)eOnOff.OFF);
            }
        }

        [GenerateCommand(Name = "HotAirBlowerCommandClicked")]
        private void HotAirBlowerCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("켜짐"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oHotAir_nBlower_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oHotAir_nBlower_OnOff, (int)eOnOff.OFF);
            }
        }

        [GenerateCommand(Name = "HoperMotorCommandClicked")]
        private void HoperMotorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("구동"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nHopper_Motor, (int)eMotorCmd.CW);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oTBS_nHopper_Motor, (int)eMotorCmd.OFF);
            }
        }

        [GenerateCommand(Name = "FlipOutShutterCommandClicked")]
        private void FlipOutShutterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutShutter_UpDown, (int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutShutter_UpDown, (int)eUpDown.DOWN);
            }
        }

        [GenerateCommand(Name = "OutConveyorCommandClicked")]
        private void OutConveyorCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "구동")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, (int)eOnOff.ON);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nOutConv_OnOff, (int)eOnOff.OFF);
            }
        }

        [GenerateCommand(Name = "ImpactCylinderCommandClicked")]
        private void ImpactCylinderCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "구동")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nBoxImpact_RunStop, (int)eRunStop.RUN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nBoxImpact_RunStop, (int)eRunStop.STOP);
            }
        }

        [GenerateCommand(Name = "UpperCoverCommandClicked")]
        private void UpperCoverCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString() == "위로")
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nUpperCover_UpDown, (int)eUpDown.UP);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oFlip_nUpperCover_UpDown, (int)eUpDown.DOWN);
            }

        }

        [GenerateCommand(Name = "LoaderShuttleCommandClicked")]
        private void LoaderShuttleCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("전진"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShuttle_FwdBwd, (int)eFwdBwd.FORWARD);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShuttle_FwdBwd, (int)eFwdBwd.BACKWARD);
            }
        }

        [GenerateCommand(Name = "LoaderShutterCommandClicked")]
        private void LoaderShutterCommand(RoutedEventArgs args)
        {
            if (((ContentControl)args.OriginalSource).Content.ToString().Equals("열림"))
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShutter_UpDown, (int)eUpDown.DOWN);
            }
            else
            {
                DataManager.Instance.SET_INT_DATA(IoNameHelper.oLoader_nShutter_UpDown, (int)eUpDown.UP);
            }
        }
    }
}
