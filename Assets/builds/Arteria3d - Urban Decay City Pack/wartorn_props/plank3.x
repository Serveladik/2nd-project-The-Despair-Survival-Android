xof 0303txt 0032

// DirectX 9.0 file
// Creator: Ultimate Unwrap3D Pro v3.19
// Website: http://www.unwrap3d.com
// Time: Sun Oct 25 09:40:23 2009

// Start of Templates

template VertexDuplicationIndices {
 <b8d65549-d7c9-4995-89cf-53a9a8b031e3>
 DWORD nIndices;
 DWORD nOriginalVertices;
 array DWORD indices[nIndices];
}

template FVFData {
 <b6e70a0e-8ef9-4e83-94ad-ecc8b0c04897>
 DWORD dwFVF;
 DWORD nDWords;
 array DWORD data[nDWords];
}

template Header {
 <3D82AB43-62DA-11cf-AB39-0020AF71E433>
 WORD major;
 WORD minor;
 DWORD flags;
}

template Vector {
 <3D82AB5E-62DA-11cf-AB39-0020AF71E433>
 FLOAT x;
 FLOAT y;
 FLOAT z;
}

template Coords2d {
 <F6F23F44-7686-11cf-8F52-0040333594A3>
 FLOAT u;
 FLOAT v;
}

template Matrix4x4 {
 <F6F23F45-7686-11cf-8F52-0040333594A3>
 array FLOAT matrix[16];
}

template ColorRGBA {
 <35FF44E0-6C7C-11cf-8F52-0040333594A3>
 FLOAT red;
 FLOAT green;
 FLOAT blue;
 FLOAT alpha;
}

template ColorRGB {
 <D3E16E81-7835-11cf-8F52-0040333594A3>
 FLOAT red;
 FLOAT green;
 FLOAT blue;
}

template IndexedColor {
 <1630B820-7842-11cf-8F52-0040333594A3>
 DWORD index;
 ColorRGBA indexColor;
}

template Material {
 <3D82AB4D-62DA-11cf-AB39-0020AF71E433>
 ColorRGBA faceColor;
 FLOAT power;
 ColorRGB specularColor;
 ColorRGB emissiveColor;
 [...]
}

template TextureFilename {
 <A42790E1-7810-11cf-8F52-0040333594A3>
 STRING filename;
}

template MeshFace {
 <3D82AB5F-62DA-11cf-AB39-0020AF71E433>
 DWORD nFaceVertexIndices;
 array DWORD faceVertexIndices[nFaceVertexIndices];
}

template MeshTextureCoords {
 <F6F23F40-7686-11cf-8F52-0040333594A3>
 DWORD nTextureCoords;
 array Coords2d textureCoords[nTextureCoords];
}

template MeshMaterialList {
 <F6F23F42-7686-11cf-8F52-0040333594A3>
 DWORD nMaterials;
 DWORD nFaceIndexes;
 array DWORD faceIndexes[nFaceIndexes];
 [Material]
}

template MeshNormals {
 <F6F23F43-7686-11cf-8F52-0040333594A3>
 DWORD nNormals;
 array Vector normals[nNormals];
 DWORD nFaceNormals;
 array MeshFace faceNormals[nFaceNormals];
}

template MeshVertexColors {
 <1630B821-7842-11cf-8F52-0040333594A3>
 DWORD nVertexColors;
 array IndexedColor vertexColors[nVertexColors];
}

template Mesh {
 <3D82AB44-62DA-11cf-AB39-0020AF71E433>
 DWORD nVertices;
 array Vector vertices[nVertices];
 DWORD nFaces;
 array MeshFace faces[nFaces];
 [...]
}

template FrameTransformMatrix {
 <F6F23F41-7686-11cf-8F52-0040333594A3>
 Matrix4x4 frameMatrix;
}

template Frame {
 <3D82AB46-62DA-11cf-AB39-0020AF71E433>
 [...]
}

template FloatKeys {
 <10DD46A9-775B-11cf-8F52-0040333594A3>
 DWORD nValues;
 array FLOAT values[nValues];
}

template TimedFloatKeys {
 <F406B180-7B3B-11cf-8F52-0040333594A3>
 DWORD time;
 FloatKeys tfkeys;
}

template AnimationKey {
 <10DD46A8-775B-11cf-8F52-0040333594A3>
 DWORD keyType;
 DWORD nKeys;
 array TimedFloatKeys keys[nKeys];
}

template AnimationOptions {
 <E2BF56C0-840F-11cf-8F52-0040333594A3>
 DWORD openclosed;
 DWORD positionquality;
}

template Animation {
 <3D82AB4F-62DA-11cf-AB39-0020AF71E433>
 [...]
}

template AnimationSet {
 <3D82AB50-62DA-11cf-AB39-0020AF71E433>
 [Animation]
}

template XSkinMeshHeader {
 <3CF169CE-FF7C-44ab-93C0-F78F62D172E2>
 WORD nMaxSkinWeightsPerVertex;
 WORD nMaxSkinWeightsPerFace;
 WORD nBones;
}

template SkinWeights {
 <6F0D123B-BAD2-4167-A0D0-80224F25FABB>
 STRING transformNodeName;
 DWORD nWeights;
 array DWORD vertexIndices[nWeights];
 array FLOAT weights[nWeights];
 Matrix4x4 matrixOffset;
}

template AnimTicksPerSecond {
 <9E415A43-7BA6-4a73-8743-B73D47E88476>
 DWORD AnimTicksPerSecond;
}

AnimTicksPerSecond {
 4800;
}

// Start of Frames

Frame Body {
   FrameTransformMatrix {
    1.000000, 0.000000, 0.000000, 0.000000,
    0.000000, 1.000000, 0.000000, 0.000000,
    0.000000, 0.000000, 1.000000, 0.000000,
    0.000000, 0.000000, 0.000000, 1.000000;;
   }

   Mesh staticMesh {
    24;
    5.891850; 149.694672; -22.762299;,
    -5.891850; 149.694672; -22.762299;,
    5.891850; 150.109650; -20.545399;,
    -5.891850; 150.109650; -20.545399;,
    5.891850; 0.000000; 20.545403;,
    5.891850; 149.694672; -22.762299;,
    5.891850; 0.415627; 22.762299;,
    5.891850; 150.109650; -20.545399;,
    -5.891850; 0.000000; 20.545403;,
    5.891850; 0.000000; 20.545403;,
    -5.891850; 0.415627; 22.762299;,
    5.891850; 0.415627; 22.762299;,
    -5.891850; 149.694672; -22.762299;,
    -5.891850; 0.000000; 20.545403;,
    -5.891850; 150.109650; -20.545399;,
    -5.891850; 0.415627; 22.762299;,
    5.891850; 0.000000; 20.545403;,
    -5.891850; 0.000000; 20.545403;,
    5.891850; 149.694672; -22.762299;,
    -5.891850; 149.694672; -22.762299;,
    -5.891850; 0.415627; 22.762299;,
    5.891850; 0.415627; 22.762299;,
    -5.891850; 150.109650; -20.545399;,
    5.891850; 150.109650; -20.545399;;
    12;
    3;0, 1, 2;,
    3;1, 3, 2;,
    3;4, 5, 6;,
    3;5, 7, 6;,
    3;8, 9, 10;,
    3;9, 11, 10;,
    3;12, 13, 14;,
    3;13, 15, 14;,
    3;16, 17, 18;,
    3;17, 19, 18;,
    3;20, 21, 22;,
    3;21, 23, 22;;

   MeshNormals {
    24;
    0.000000; 0.982928; -0.183993;,
    0.000000; 0.982928; -0.183993;,
    0.000000; 0.982928; -0.183993;,
    0.000000; 0.982928; -0.183993;,
    1.000000; 0.000000; 0.000000;,
    1.000000; 0.000000; 0.000000;,
    1.000000; 0.000000; 0.000000;,
    1.000000; 0.000000; 0.000000;,
    0.000000; -0.982876; 0.184271;,
    0.000000; -0.982876; 0.184271;,
    0.000000; -0.982876; 0.184271;,
    0.000000; -0.982876; 0.184271;,
    -1.000000; 0.000000; 0.000000;,
    -1.000000; 0.000000; 0.000000;,
    -1.000000; 0.000000; 0.000000;,
    -1.000000; 0.000000; 0.000000;,
    0.000000; -0.277910; -0.960607;,
    0.000000; -0.277910; -0.960607;,
    0.000000; -0.277910; -0.960607;,
    0.000000; -0.277910; -0.960607;,
    0.000000; 0.277911; 0.960607;,
    0.000000; 0.277911; 0.960607;,
    0.000000; 0.277911; 0.960607;,
    0.000000; 0.277911; 0.960607;;
    12;
    3;0, 1, 2;,
    3;1, 3, 2;,
    3;4, 5, 6;,
    3;5, 7, 6;,
    3;8, 9, 10;,
    3;9, 11, 10;,
    3;12, 13, 14;,
    3;13, 15, 14;,
    3;16, 17, 18;,
    3;17, 19, 18;,
    3;20, 21, 22;,
    3;21, 23, 22;;
   }

   MeshTextureCoords {
    24;
    0.309348; 0.684954;,
    0.309348; 0.656694;,
    0.300487; 0.684954;,
    0.300487; 0.656694;,
    0.274573; 0.950412;,
    0.286916; 0.576759;,
    0.265584; 0.950826;,
    0.277928; 0.577174;,
    0.300487; 0.685793;,
    0.300487; 0.714054;,
    0.309348; 0.685793;,
    0.309348; 0.714054;,
    0.263254; 0.572880;,
    0.275597; 0.946533;,
    0.272242; 0.573294;,
    0.284586; 0.946946;,
    0.253869; 0.942798;,
    0.300970; 0.942798;,
    0.253869; 0.583793;,
    0.300970; 0.583793;,
    0.302368; 0.942796;,
    0.349469; 0.942796;,
    0.302368; 0.583793;,
    0.349469; 0.583793;;
   }

   MeshVertexColors {
    24;
    0; 1.000000; 1.000000; 1.000000; 1.000000;,
    1; 1.000000; 1.000000; 1.000000; 1.000000;,
    2; 1.000000; 1.000000; 1.000000; 1.000000;,
    3; 1.000000; 1.000000; 1.000000; 1.000000;,
    4; 1.000000; 1.000000; 1.000000; 1.000000;,
    5; 1.000000; 1.000000; 1.000000; 1.000000;,
    6; 1.000000; 1.000000; 1.000000; 1.000000;,
    7; 1.000000; 1.000000; 1.000000; 1.000000;,
    8; 1.000000; 1.000000; 1.000000; 1.000000;,
    9; 1.000000; 1.000000; 1.000000; 1.000000;,
    10; 1.000000; 1.000000; 1.000000; 1.000000;,
    11; 1.000000; 1.000000; 1.000000; 1.000000;,
    12; 1.000000; 1.000000; 1.000000; 1.000000;,
    13; 1.000000; 1.000000; 1.000000; 1.000000;,
    14; 1.000000; 1.000000; 1.000000; 1.000000;,
    15; 1.000000; 1.000000; 1.000000; 1.000000;,
    16; 1.000000; 1.000000; 1.000000; 1.000000;,
    17; 1.000000; 1.000000; 1.000000; 1.000000;,
    18; 1.000000; 1.000000; 1.000000; 1.000000;,
    19; 1.000000; 1.000000; 1.000000; 1.000000;,
    20; 1.000000; 1.000000; 1.000000; 1.000000;,
    21; 1.000000; 1.000000; 1.000000; 1.000000;,
    22; 1.000000; 1.000000; 1.000000; 1.000000;,
    23; 1.000000; 1.000000; 1.000000; 1.000000;;
   }

   MeshMaterialList {
    1;
    12;
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0;

    Material war_torn3 {
     0.992157; 0.992157; 0.992157; 1.000000;;
     128.000000;
     0.150000; 0.150000; 0.150000;;
     0.000000; 0.000000; 0.000000;;

     TextureFilename {
      "war_torn3.jpg";
     }
    }

   }
  }
}
