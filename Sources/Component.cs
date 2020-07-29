﻿namespace CeresECL
{
    /// <summary> Base class to derive your components from. Component should contain only data, no any logics implementations. </summary>
    public class Component
    {
        /// <summary> Parent entity of this component. </summary>
        public Entity Entity;
    }
}