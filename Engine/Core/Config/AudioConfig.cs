/*
 * Voxeliq Engine, Copyright (C) 2011 - 2013 Int6 Studios - All Rights Reserved. - http://www.int6.org - https://github.com/raistlinthewiz/voxeliq
 *
 * This file is part of Voxeliq Engine project. This program is free software; you can redistribute it and/or modify 
 * it under the terms of the Microsoft Public License (Ms-PL).
 */

namespace Engine.Core.Config
{
    public class AudioConfig
    {
        #region configurable parameters

        /// <summary>
        /// Is audio enabled?
        /// </summary>
        public bool Enabled { get; set; }

        #endregion

        /// <summary>
        /// Creates a new instance of audio config.
        /// </summary>
        internal AudioConfig()
        {
            // set the defaults.
            this.Enabled = false;
        }

        /// <summary>
        /// Validates the configuration.
        /// </summary>
        /// <returns></returns>
        internal bool Validate()
        {
            return true;
        }
    }
}
