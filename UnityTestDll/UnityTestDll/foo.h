#pragma once

#ifdef UNITYTESTDLL_EXPORTS
#define FOO_API __declspec(dllexport)
#else
#define FOO_API __declspec(dllimport)
#endif

extern "C"
{
	int FOO_API foo();
}