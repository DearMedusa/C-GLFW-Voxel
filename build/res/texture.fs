#version 330 core
out vec4 FragColor;

in vec2 TexCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    //interpolate entre les 2 textures
    FragColor = texture(texture1, TexCoord);
}
