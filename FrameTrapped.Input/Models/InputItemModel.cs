﻿namespace FrameTrapped.Input.Models
{
    using System;
    using System.Linq;

    /**
    * the timeline classes are the core of this application.
    * they represent an entry in the timeline listbox. there are currently 4 types
    * press input, hold input, release input and wait frame.
    * these differences are represented by the following class hierarchy
    * 
    * InputItemModel --- WaitFrameItemModel
    *          |
    *          |------ InputItemModel
    *                      |
    *                      |--- PressItemModel
    *                      |--- HoldItemModel
    *                      |--- ReleaseItemModel
    */

    /**
     * The new layout will incorporate the InputItemModel as the base for Press, Hold and Release.
     * However we will be removing WaitFrameItemModel and incorporating it into InputItemModel.
     * There is no reason to have the WaitFrameItem as we can make the PressItemModel act upon
     * its behalf by inputing a neutral input. This creates a waitframe without any inputs.
     *      
     *          InputItemModel --- Buttons pressed
     *                         --- Buttons released
     */

    [Serializable()]
    public class InputItemModel
    {
        /// <summary>
        /// Array that defines directional inputs.
        /// </summary>
        public static Input[] Directions = new Input[] { Input.P1_UP, Input.P1_DN, Input.P1_LE, Input.P1_RI, Input.P1_BK, Input.P1_FW };

        /// <summary>
        /// Array that defines button inputs.
        /// </summary>
        public static Input[] Buttons = new Input[] { Input.P1_LP, Input.P1_MP, Input.P1_HP, Input.P1_LK, Input.P1_MK, Input.P1_HK };

        /// <summary>
        /// The frame duration of this Time Line Item.
        /// </summary>
        public int Frames { get; set; }

        /// <summary>
        /// If set to true, will play a sound on the time line item being played in the time line.
        /// </summary>
        public bool PlaySound = false;

        /// <summary>
        /// Gets an array of inputs from the InputCommandState.
        /// </summary>
        public Input[] Inputs
        {
            get
            {
                return InputCommandState.ToInputsPressedArray();
            }
            set
            {
                // Directions
                if (value.Contains(Input.P1_UP) && value.Contains(Input.P1_BK))
                {
                    InputCommandState.DirectionState = InputCommandModel.DirectionStateEnum.UpBack;
                }
                else if (value.Contains(Input.P1_UP) && value.Contains(Input.P1_FW))
                {
                    InputCommandState.DirectionState = InputCommandModel.DirectionStateEnum.UpForward;
                }
                else if (value.Contains(Input.P1_UP))
                {
                    InputCommandState.DirectionState = InputCommandModel.DirectionStateEnum.Up;
                }
                else if (value.Contains(Input.P1_DN) && value.Contains(Input.P1_BK))
                {
                    InputCommandState.DirectionState = InputCommandModel.DirectionStateEnum.DownBack;
                }
                else if (value.Contains(Input.P1_DN) && value.Contains(Input.P1_FW))
                {
                    InputCommandState.DirectionState = InputCommandModel.DirectionStateEnum.DownForward;
                }
                else if (value.Contains(Input.P1_DN))
                {
                    InputCommandState.DirectionState = InputCommandModel.DirectionStateEnum.Down;
                }
                else if (value.Contains(Input.P1_BK))
                {
                    InputCommandState.DirectionState = InputCommandModel.DirectionStateEnum.Back;
                }
                else if (value.Contains(Input.P1_FW))
                {
                    InputCommandState.DirectionState = InputCommandModel.DirectionStateEnum.Forward;
                }
                else
                {
                    InputCommandState.DirectionState = InputCommandModel.DirectionStateEnum.Neutral;
                }

                // Buttons
                if (value.Contains(Input.P1_LP))
                {
                    InputCommandState.LightPunch = InputCommandModel.ButtonStateEnum.Pressed;
                }
                if (value.Contains(Input.P1_MP))
                {
                    InputCommandState.MediumPunch = InputCommandModel.ButtonStateEnum.Pressed;
                }
                if (value.Contains(Input.P1_HP))
                {
                    InputCommandState.HardPunch = InputCommandModel.ButtonStateEnum.Pressed;
                }
                if (value.Contains(Input.P1_LK))
                {
                    InputCommandState.LightKick = InputCommandModel.ButtonStateEnum.Pressed;
                }
                if (value.Contains(Input.P1_MK))
                {
                    InputCommandState.MediumKick = InputCommandModel.ButtonStateEnum.Pressed;
                }
                if (value.Contains(Input.P1_HK))
                {
                    InputCommandState.HardKick = InputCommandModel.ButtonStateEnum.Pressed;
                }

            }
        }

        /// <summary>
        /// The InputCommandState that is configured by the view model.
        /// </summary>
        public InputCommandModel InputCommandState { get; set; }

        /// <summary>
        /// The serialize function for turning the inputs into a string.
        /// </summary>
        /// <returns><see cref="string"/></returns>
        public string Serialize()
        {
            string obj = string.Empty;

            obj += (PlaySound ? 1 : 0) + "#";
            obj += Frames + "#";

            obj += (int)InputCommandState.DirectionState;

            obj += (int)InputCommandState.LightPunch;
            obj += (int)InputCommandState.MediumPunch;
            obj += (int)InputCommandState.HardPunch;

            obj += (int)InputCommandState.LightKick;
            obj += (int)InputCommandState.MediumKick;
            obj += (int)InputCommandState.HardKick;

            return obj;
        }

        /// <summary>         
        /// Static definition for deserializing a string into a set of inputs.
        /// </summary>
        /// <param name="value">The <see cref="string"/> value to deserialize.</param>
        ///<returns><see cref="InputItemModel"/> containing the inputs from the string.</returns>
        public static InputItemModel Deserialize(string value)
        {
            /**
             * Creates a timeline object from a string serialization and assumes the following
             * formats (specified by the respective Serialize methods)
             * 
             * InputItemModel:     ItemType#PlaySound#NumFrames#NumInputs[#Input1,#Input2...]
             *                        
             */
            String[] tokens = value.ToUpper().Split('#');

            // Big change: this is the new default to help transform old file type.
            int n;
            bool isNumeric = int.TryParse(tokens[0].ToString(), out n);
            if (isNumeric)
            {
                InputItemModel item = new InputItemModel();
                item.PlaySound = int.Parse(tokens[0].ToString()) == 0 ? false : true;
                item.Frames = int.Parse(tokens[1].ToString());

                char[] inputs = tokens[2].ToString().ToCharArray();


                item.InputCommandState.DirectionState = (InputCommandModel.DirectionStateEnum)int.Parse(inputs[0].ToString());
                item.InputCommandState.LightPunch = (InputCommandModel.ButtonStateEnum)int.Parse(inputs[1].ToString());
                item.InputCommandState.MediumPunch = (InputCommandModel.ButtonStateEnum)int.Parse(inputs[2].ToString());
                item.InputCommandState.HardPunch = (InputCommandModel.ButtonStateEnum)int.Parse(inputs[3].ToString());
                item.InputCommandState.LightKick = (InputCommandModel.ButtonStateEnum)int.Parse(inputs[4].ToString());
                item.InputCommandState.MediumKick = (InputCommandModel.ButtonStateEnum)int.Parse(inputs[5].ToString());
                item.InputCommandState.HardKick = (InputCommandModel.ButtonStateEnum)int.Parse(inputs[6].ToString());
                return item;

            }

            throw new FormatException("Failed to deserialize TimelineItem, wrong string format: " + value);
        }

        /// <summary>
        /// Parses inputs from string to an input enum.
        /// </summary>
        /// <param name="str">The <see cref="string"/> to convert.</param>
        /// <returns><see cref="Input"/></returns>
        public static Input ParseInput(String str)
        {
            foreach (Input input in Directions)
            {
                if (str.Equals(input.ToString())) { return input; }
            }
            foreach (Input input in Buttons)
            {
                if (str.Equals(input.ToString())) { return input; }
            }
            throw new FormatException("Cannot parse Input for " + str);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputItemModel"/> class.
        /// </summary>
        /// <param name="inputCommand">The input command model to use for this input.</param>
        public InputItemModel(Input[] inputArray)
        {
            Inputs = inputArray;
            PlaySound = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputItemModel"/> class.
        /// </summary>
        /// <param name="inputCommand">The input command model to use for this input.</param>
        public InputItemModel(InputCommandModel inputCommand)
        {
            InputCommandState = inputCommand;
            PlaySound = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputItemModel"/> class.
        /// </summary>
        public InputItemModel() : this(new InputCommandModel()) { }
    }
}