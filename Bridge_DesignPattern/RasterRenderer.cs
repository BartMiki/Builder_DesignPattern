namespace Bridge_DesignPattern
{
    public class RasterRenderer : IRenderer
    {
        public RasterRenderer()
        {
            WhatToRenderAs = "Drawing {Name} as pixels";
        }
        public string WhatToRenderAs { get; }
    }
}