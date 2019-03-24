#include <a3_dylib_config_export.h>
#include "UnityDllGate.h"
#include <SDKDDKVer.h>
#include <windows.h>

extern "C"
{

	int A3DYLIBSYMBOL foo()
	{
		return 26;
	}

}