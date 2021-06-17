# URPShaderCreator
Unity tool to create URP shader files (not shader graphs) from templates, as is possible with Built-in RP shaders.

# Usage
- Copy the **URPShaderCreator** directory into your project's Assets directory.

- To create a shader, navigate to **Assets (or right-click in the Project view) -> Create -> Shader -> URPShaderCreator**, and select the shader template.

- There are currently 4 shader templates to choose from.
  - **Unlit -> Unlit Shader**: A basic unlit shader with a texture and color.
  - **Unlit -> Unlit Transparent Shader**: A basic unlit tranparency shader with a texture and color;
  - **Unlit -> Unlit Cutout Shader**: A basic unlit cutout shader with a texture, color, and alpha cutoff value.
  - **Lit -> Lit Shader**: A basic lit shader with the following features:
      - Diffuse lighting (main light + additional lights)
      - Specular highlights with specular map
      - Normal map
      - Emission map
      - Shadow casting and receiving
      - Depth/DepthNormals prepass
      - Light maps
  - All shader templates are SRP Batcher compatible.
  
- If you wish to modify the shader templates, they are located under **Editor/ShaderTemplates**.
