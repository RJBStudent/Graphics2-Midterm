#pragma once
#define UNITY_TEST_DLL __declspec(dllexport)

extern "C"
{
	UNITY_TEST_DLL int foo();
}