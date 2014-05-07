﻿namespace SF4ComboTrainer.StreetFighterLibrary.Utilities
{
    using System.Collections.ObjectModel;

    using SF4ComboTrainer.StreetFighterLibrary.ViewModels;
    using SF4ComboTrainer.Input.ViewModels;
    using SF4ComboTrainer.Input.Models;
    using Caliburn.Micro;

    public static class FighterDataAE2012
    {

        public static FighterViewModel RyuData()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            BindableCollection<MoveViewModel> moveList = new BindableCollection<MoveViewModel>();

            // Close Punches

            // Close Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 3, 6, 2, 5, ""));

            moveList.Add(new MoveViewModel("Close Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 3, 21, -3, 3, ""));

            moveList.Add(new MoveViewModel("Close Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 80, 200, 150, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 7, 26, -15, -10, "Forces stand, less damage and stun on 3~5f"));

            moveList.Add(new MoveViewModel("Close Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Kicks

            // Close Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 5, 7, -1, 2, ""));

            moveList.Add(new MoveViewModel("Close Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 5, 16, -7, -2, ""));

            moveList.Add(new MoveViewModel("Close Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 125, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Super }, 8, 8, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 75, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 2, 4, 15, -1, 4, ""));

            moveList.Add(new MoveViewModel("Close Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Punches

            // Far Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 3, 6, 2, 5, ""));

            moveList.Add(new MoveViewModel("Far Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 4, 14, -4, -1, ""));

            moveList.Add(new MoveViewModel("Far Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 120, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 8, 3, 15, 0, -4, ""));

            moveList.Add(new MoveViewModel("Far Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Kicks

            // Far Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 6, 6, -1, 2, ""));

            moveList.Add(new MoveViewModel("Far Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 8, 2, 17, -5, -2, ""));

            moveList.Add(new MoveViewModel("Far Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Far Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 110, 0, 125, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 9, 4, 20, -6, -2, ""));

            moveList.Add(new MoveViewModel("Far Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Punches

            // Crouch Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 2, 7, 2, 5, ""));

            moveList.Add(new MoveViewModel("Crouch Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 4, 8, 2, 5, ""));

            moveList.Add(new MoveViewModel("Crouch Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 90, 0, 200, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 8, 28, -18, -13, "Forces stand"));

            moveList.Add(new MoveViewModel("Crouch Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Kicks

            // Crouch Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 20, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 4, 3, 9, -1, 2, ""));

            moveList.Add(new MoveViewModel("Crouch Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 60, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 5, 12, -3, 0, ""));

            moveList.Add(new MoveViewModel("Crouch Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Crouch Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Down, Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 90, 0, 100, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 5, 4, 28, -14, 0, "Untechable knockdown"));

            moveList.Add(new MoveViewModel("Crouch Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Punches

            // Neutral Jump Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 10, 7, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Neutral Jump Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 5, 5, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Neutral Jump Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 6, 5, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Neutral Jump Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Kicks

            // Neutral Jump Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 9, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Neutral Jump Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 6, 10, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Neutral Jump Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Neutral Jump Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Up, Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 200, 0, 100, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 4, 4, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Neutral Jump Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Punches

            // Angled Jump Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 4, 7, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Angled Jump Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 7, 3, 0, 0, 0, "Legs projectile invincible until end of startup frames, [1st Air hit] floats opponent,"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 0, 4, 0, 0, 0, "[2nd Air hit] knock down and can juggle"));

            moveList.Add(new MoveViewModel("Angled Jump Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 6, 5, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Angled Jump Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Kicks

            // Angled Jump Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 40, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 4, 8, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Angled Jump Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 80, 0, 100, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 6, 6, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Angled Jump Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Angled Jump Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.UpForward, Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Low, 200, 0, 100, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 7, 7, 0, 0, 0, "Legs projectile invincible until end of startup frames"));

            moveList.Add(new MoveViewModel("Angled Jump Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Unique Punches

            // Collarbone Breaker
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Forward, Medium_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 17, 1, 0, 1, 1, "Overhead attack"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 1, 2, 14, -2, 3, ""));

            moveList.Add(new MoveViewModel("Collarbone Breaker", MoveViewModel.MoveTypeEnum.Unique, tmpHitList, tmpCommand));

            // Solar Plexus Strike
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction=InputCommandModel.DirectionStateEnum.Forward, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 50, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 17, 2, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 0, 2, 18, 0, 4, ""));

            moveList.Add(new MoveViewModel("Solar Plexus Strike", MoveViewModel.MoveTypeEnum.Unique, tmpHitList, tmpCommand));

            // Focus Attacks

            // Focus Attack Level 1
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Medium_Punch = true, Medium_Kick = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 60, 0, 100, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 21, 2, 35, -21, -21, ""));

            moveList.Add(new MoveViewModel("Focus Attack Level 1", MoveViewModel.MoveTypeEnum.Focus, tmpHitList, tmpCommand));

            // Focus Attack Level 2
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true, Medium_Kick = true, WaitFrames = 17 }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 150, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 17, 2, 35, -15, 0, ""));

            moveList.Add(new MoveViewModel("Focus Attack Level 2", MoveViewModel.MoveTypeEnum.Focus, tmpHitList, tmpCommand));

            // Focus Attack Level 3
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true, Medium_Kick = true, WaitFrames = 65 }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Unblockable, 140, 0, 200, 0, 60, new HitViewModel.CancelAbilityEnum[] { }, 65, 2, 35, 0, 0, ""));

            moveList.Add(new MoveViewModel("Focus Attack Level 3", MoveViewModel.MoveTypeEnum.Focus, tmpHitList, tmpCommand));

            // Throw Attacks

            // Forward Throw
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Light_Punch = true, Light_Kick = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Techable, 130, 0, 140, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 20, 0, 0, "Untechable knockdown, Range 0.9 Units"));

            moveList.Add(new MoveViewModel("Forward Throw", MoveViewModel.MoveTypeEnum.Throw, tmpHitList, tmpCommand));

            // Backward Throw
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Back, Light_Punch = true, Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Techable, 130, 0, 120, 0, 40, new HitViewModel.CancelAbilityEnum[] { }, 3, 2, 20, 0, 0, "Untechable knockdown, Range 0.9 Units"));

            moveList.Add(new MoveViewModel("Backward Throw", MoveViewModel.MoveTypeEnum.Throw, tmpHitList, tmpCommand));

            // Special Attacks

            // Light Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 13, 0, 45, -6, -2, "[Air hit] knock down, 16~17f focus cancellable without hit"));

            moveList.Add(new MoveViewModel("Light Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));
            
            // Medium Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 13, 0, 45, -6, -2, "[Air hit] knock down, 16~17f focus cancellable without hit"));

            moveList.Add(new MoveViewModel("Medium Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));
            
            // Hard Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 10, new[] { HitViewModel.CancelAbilityEnum.Super }, 13, 0, 45, -6, -2, "[Air hit] knock down, 16~17f focus cancellable without hit"));

            moveList.Add(new MoveViewModel("Hard Hadoken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Hadoken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward, Light_Punch = true, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, -250, new[] { HitViewModel.CancelAbilityEnum.Super }, 12, 0, 45, 0, 0, "Knock down, can juggle, [counterhit] floats opponent, 15~16f focus cancellable"));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 0, new[] { HitViewModel.CancelAbilityEnum.Super }, 0, 0, 50, 1, 0, ""));

            moveList.Add(new MoveViewModel("EX Hadoken", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

            // Light Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward, Light_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 70, 200, 200, 30, new[] { HitViewModel.CancelAbilityEnum.Super }, 3, 14, 24, -17, 0, "1~2f Invincible, 3~4f unthrowable, 3~16f lower body invincibility, 4f~ airborne, knock down, [] refers to active frames 3~14f"));

            moveList.Add(new MoveViewModel("Light Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Medium Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {  
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 150, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Super }, 3, 2, 0, 0, 0, "1~5f Invincible, 6~16f lower body invincibility, 5f~ airborne, knock down, "));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 0, 12, 43, -34, 0, "[2nd hit] can juggle"));

            moveList.Add(new MoveViewModel("Medium Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // Hard Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {  
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward, Hard_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 160, 60, 200, 50, 20, new HitViewModel.CancelAbilityEnum[] { }, 3, 14, 46, -37, 0, "1~4f Invincible, 3~4f unthrowable, 5~16f lower body invincibility, 3f~ airborne, knock down, [] refers to active frames 3~14f"));

            moveList.Add(new MoveViewModel("Hard Shoryuken", MoveViewModel.MoveTypeEnum.Special, tmpHitList, tmpCommand));

            // EX Shoryuken
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down },
                new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward,  Light_Punch = true, Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, -250, new[] { HitViewModel.CancelAbilityEnum.Super }, 3, 2, 45, 0, 0, "1~16f Invincible, 6f~ airborne, knock down, "));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 50, 0, 50, 0, 0, new[] { HitViewModel.CancelAbilityEnum.Super }, 0, 12, 48, -39, 0, "[2nd hit] can juggle"));

            moveList.Add(new MoveViewModel("EX Shoryuken", MoveViewModel.MoveTypeEnum.ExtraSpecial, tmpHitList, tmpCommand));

            // Initialise Ryu:
            FighterViewModel ryuFighter = new FighterViewModel("Ryu", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return ryuFighter;
        }


        public static FighterViewModel KenData()
        {
            BindableCollection<HitViewModel> tmpHitList; ;
            CommandViewModel tmpCommand;

            BindableCollection<MoveViewModel> moveList = new BindableCollection<MoveViewModel>();

            // Close Jab
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                new InputItemViewModel() { Light_Punch = true } 
            });

            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new[] { HitViewModel.CancelAbilityEnum.Chain, HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 3, 6, 2, 5, ""));

            moveList.Add(new MoveViewModel("Close Jab", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Strong
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Punch = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 3, 21, -3, 3, ""));

            moveList.Add(new MoveViewModel("Close Strong", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Fierce
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() {
                //new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Down } ,
                //new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.DownForward } ,
                //new InputItemViewModel() { Direction = InputCommandModel.DirectionStateEnum.Forward } ,
                new InputItemViewModel() { Hard_Punch = true } 
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 100, 80, 200, 150, 60, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 5, 7, 26, -15, -10, "Forces stand, less damage and stun on frames 3~5"));

            moveList.Add(new MoveViewModel("Close Fierce", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Short
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Light_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 30, 0, 50, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 5, 5, 7, -1, 2, ""));

            moveList.Add(new MoveViewModel("Close Short", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Long
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Medium_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 80, 0, 100, 0, 40, new[] { HitViewModel.CancelAbilityEnum.Special, HitViewModel.CancelAbilityEnum.Super }, 3, 5, 16, -7, -2, ""));

            moveList.Add(new MoveViewModel("Close Long", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            // Close Roundhouse
            tmpCommand = new CommandViewModel(new BindableCollection<InputItemViewModel>() { 
                new InputItemViewModel() { Hard_Kick = true }
            });
            tmpHitList = new BindableCollection<HitViewModel>();
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 40, 0, 125, 0, 60, new[] { HitViewModel.CancelAbilityEnum.Super }, 8, 8, 0, 0, 0, ""));
            tmpHitList.Add(new HitViewModel(HitViewModel.BlockTypeEnum.Mid, 70, 0, 75, 0, 20, new HitViewModel.CancelAbilityEnum[] { }, 2, 4, 15, -1, 4, ""));

            moveList.Add(new MoveViewModel("Close Roundhouse", MoveViewModel.MoveTypeEnum.Normal, tmpHitList, tmpCommand));

            FighterViewModel kenFighter = new FighterViewModel("Ken", FighterViewModel.FighterTypeEnum.Shoto, 1000, 1000, 0.045f, 0.030f, moveList);
            return kenFighter;
        }
    }
}
