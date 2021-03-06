﻿namespace FrameTrapped.StreetFighterLibrary.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows.Data;
    
    using Caliburn.Micro;

    using FrameTrapped.ComboTrainer.Messages;
    using FrameTrapped.ComboTrainer.ViewModels;
    using FrameTrapped.Input.ViewModels;

    public class FighterViewModel : PropertyChangedBase
    {
        public enum FighterTypeEnum
        {
            Shoto,
            Rushdown,
            Grappler,
            Zoner,
            Charge
        } 

        public string Name { get; private set; }

        public Uri Image { get; private set; }
        public Uri Icon { get; private set; }

        public FighterTypeEnum FighterType { get; private set; }

        public int Stamina { get; private set; }

        public int Stun { get; private set; }

        public float ForwardMovementSpeed { get; private set; }

        public float BackwardMovementSpeed { get; private set; }

        public float JumpHeight { get; private set; }

        public float JumpLength { get; private set; } 

        public ObservableCollection<MoveViewModel> MovesList { get; private set; }

        public void Group()
        {
            ICollectionView collection = CollectionViewSource.GetDefaultView(MovesList);
            if (collection != null && collection.CanGroup == true)
            {
                collection.GroupDescriptions.Clear();
                collection.GroupDescriptions.Add(new PropertyGroupDescription("MoveType"));
                //collection.GroupDescriptions.Add(new PropertyGroupDescription("BlockType"));
            }

            NotifyOfPropertyChange(() => MovesList);
        }

        public void Ungroup()
        {
            ICollectionView collection = CollectionViewSource.GetDefaultView(MovesList);
            if (collection != null)
            {
                collection.GroupDescriptions.Clear();
            }
        }

        public FighterViewModel(string name, FighterTypeEnum figherType, int stamina, int stun, float forwardMovementSpeed, float backwardMovementSpeed, ObservableCollection<MoveViewModel> movesList)
        {
            Name = name;
            Image = new Uri("pack://application:,,,/FrameTrapped.StreetFighterLibrary;component/Resources/Images/ssf4-" + string.Join("", Name.ToLower().Replace(' ', '_').Split('.')) + ".jpg");
            Icon = new Uri("pack://application:,,,/FrameTrapped.StreetFighterLibrary;component/Resources/Images/FighterListIcons/" + string.Join("", Name.ToLower().Replace(' ', '_').Split('.')) + ".gif");
            FighterType = figherType;
            Stamina = stamina;
            Stun = stun;
            ForwardMovementSpeed = forwardMovementSpeed;
            BackwardMovementSpeed = backwardMovementSpeed;
            MovesList = movesList;
        }
    }
}
