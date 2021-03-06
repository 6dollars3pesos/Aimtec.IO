﻿namespace iKhazix.Interfaces
{
    internal interface IModule
    {
        /// <summary>
        ///     On Load
        /// </summary>
        void OnLoad();

        /// <summary>
        ///     Gets the Module Name
        /// </summary>
        /// <returns>string</returns>
        string GetName();

        /// <summary>
        ///     Gets the module description
        /// </summary>
        /// <returns>string</returns>
        string GetDescription();

        /// <summary>
        ///     Checks if the module can be executed
        /// </summary>
        /// <returns></returns>
        bool CanExecute();

    }

    internal interface IUpdateModule : IModule
    {
        void Execute();
    }

    internal interface IEventModule<in T, in TE> : IModule
    {
        void Execute(T sender, TE args);
    }
}
