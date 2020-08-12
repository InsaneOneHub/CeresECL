﻿namespace CeresECL
{
    /// <summary> Base class for any logics implementations. </summary>
    public abstract class Logic
    {
        /// <summary> Parent entity of this component. </summary>
        [CeresIgnoreInject]
        public Entity Entity;
        
        [CeresIgnoreInject]
        public bool IsInitialized; // C# 8.0 feature for interfaces, so it is there :/
    }
    
    /// <summary> Interface for Initialization logic, which will be runned once when Logic work started. </summary>
    public interface IInitLogic
    {
        void Init();
    }
    
    /// <summary> Interface for Run logic, which will be runned in Update cycle. </summary>
    public interface IRunLogic
    {
        void Run();
    }
}