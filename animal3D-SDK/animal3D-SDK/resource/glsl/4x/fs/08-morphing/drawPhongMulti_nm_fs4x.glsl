/*
	Copyright 2011-2019 Daniel S. Buckstein

	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at

		http://www.apache.org/licenses/LICENSE-2.0

	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.
*/

/*
	animal3D SDK: Minimal 3D Animation Framework
	By Daniel S. Buckstein
	
	drawPhongMulti_nm_fs4x.glsl
	Calculate and output Phong shading model for multiple lights using data 
		from prior shader; set up and perform normal mapping.
*/

#version 410

// ****TO-DO: 
//	0) copy original Phong shader
//	1) declare varyings passed from tangent basis VS
//	2) replace original values used for lighting and shading with new inputs

out vec4 rtFragColor;

void main()
{
	// DUMMY OUTPUT: all fragments are FADED CYAN
	rtFragColor = vec4(0.5, 1.0, 1.0, 1.0);
}
