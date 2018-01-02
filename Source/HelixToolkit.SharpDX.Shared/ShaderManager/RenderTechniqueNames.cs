﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
using System.Collections.Generic;
#if !NETFX_CORE
namespace HelixToolkit.Wpf.SharpDX
#else
namespace HelixToolkit.UWP
#endif
{
    public struct DefaultRenderTechniqueNames
    {
        public const string Blinn = "RenderBlinn";
        public const string Diffuse = "RenderDiffuse";
        public const string Colors = "RenderColors";
        public const string Positions = "RenderPositions";
        public const string Normals = "RenderNormals";
        public const string PerturbedNormals = "RenderPerturbedNormals";
        public const string Tangents = "RenderTangents";
        public const string TexCoords = "RenderTexCoords";
        public const string Lines = "RenderLines";
        public const string Points = "RenderPoints";
        public const string CubeMap = "RenderCubeMap";
        public const string BillboardText = "RenderBillboard";
        public const string BillboardInstancing = "RenderBillboardInstancing";
        public const string InstancingBlinn = "RenderInstancingBlinn";
        public const string BoneSkinBlinn = "RenderBoneSkinBlinn";
        public const string ParticleStorm = "ParticleStorm";
        public const string CrossSection = "RenderCrossSectionBlinn";
        public const string ViewCube = "RenderViewCube";
    }

    public struct DefaultPassNames
    {
        public const string Default = "Default";
        public const string MeshTriTessellation = "MeshTriTessellation";
        public const string MeshQuadTessellation = "MeshQuadTessellation";
        public const string MeshOutline = "RenderMeshOutline";
        public const string MeshXRay = "RenderMeshXRay";
        public const string ShadowPass = "RenderShadow";
        public const string Backface = "RenderBackface";
        public const string ScreenQuad = "ScreenQuad";
    }

    public struct DefaultParticlePassNames
    {
        public const string Insert = "InsertParticle";//For compute shader
        public const string Update = "UpdateParticle";//For compute shader
        public const string Default = "Default";//For rendering
    }

    //public struct TessellationRenderTechniqueNames
    //{
    //    public const string PNTriangles = "RenderPNTriangs";
    //    public const string PNQuads = "RenderPNQuads";
    //}

    public struct DeferredRenderTechniqueNames
    {
        public const string Deferred = "RenderDeferred";
        public const string GBuffer = "RenderGBuffer";
        public const string DeferredLighting = "RenderDeferredLighting";
        public const string ScreenSpace = "RenderScreenSpace";
    }
}