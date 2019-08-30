# Photon Cloud API UE4 Sample Project
More information and documentation here:

http://photonue4.xixgames.com/

This is a guide on how to integrate Photon with an existing UE4 project
 
For a reference project please go to 
https://github.com/juaxix/photon_api_ue4_sample

1. Download all the photon sdks you want to use in your project from:
https://www.photonengine.com/en-US/sdks#realtime

2. Only the header files and pre-built libraries are required.
Copy ,from each SDK using this template:
Plugins\PhotonCloudAPI\Source\ThirdParty\Photon
|   +---lib
|   |   +---Android 
|   |   	(*.a)
|   |   +---iOS
|   |   	(*.a)
|   |   \---Windows
|   |   	(*.lib)
|   |   \---Mac
|   |       (*.lib)
|   |   \---Linux
|   |       (*.lib) -only 64bits-
|   |   \---PS4
|   |       (*.lib)
|   |   \---XBoxOne
|   |       (*.lib)
|   |   \---Switch
|   |       (*.lib)

3. Modify the Photon headers to workaround any incompatibility with the UE4 headers 

3.1: rename all FLOAT to EG_FLOAT in these files (case sensitive)

- Photon/Common-cpp/inc/Enums/TypeCode.h (around line 18)
- Photon/Common-cpp/inc/Helpers/ConfirmAllowed.h (around line 46)
- Photon/Common-cpp/inc/Helpers/ConfirmAllowedKey.h (around line 73)

3.2. Left only this two precompiler checks around line 14 
================================================
#if defined _CPPRTTI || defined __GXX_RTTI 
================================================
in this file : Photon/Common-cpp/inc/Helpers/TypeName.h


3.3. If you want to compile for Android, remove all the JString template definitions (you will need to do your own if you want to compare JString from the plugin):
	 
     - File: Photon/Common-cpp/inc/JString.h
	      - Comment all these functions (definition and implementation): see diff here: https://www.diffchecker.com/CQp4QycZ
        /*template<typename Etype> JString operator+(const JString& Lsh, const Etype& Rsh);
        template<typename Etype> JString operator+(const Etype& Lsh, const JString& Rsh);
        template<typename Etype> bool operator==(const JString& Lsh, const Etype& Rsh);
        template<typename Etype> bool operator==(const Etype& Lsh, const JString& Rsh);
        template<typename Etype> bool operator!=(const JString& Lsh, const Etype& Rsh);
        template<typename Etype> bool operator!=(const Etype& Lsh, const JString& Rsh);
        template<typename Etype> bool operator<(const JString& Lsh, const Etype& Rsh);
        template<typename Etype> bool operator<(const Etype& Lsh, const JString& Rsh);
        template<typename Etype> bool operator>(const JString& Lsh, const Etype& Rsh);
        template<typename Etype> bool operator>(const Etype& Lsh, const JString& Rsh);
        template<typename Etype> bool operator<=(const JString& Lsh, const Etype& Rsh);
        template<typename Etype> bool operator<=(const Etype& Lsh, const JString& Rsh);
        template<typename Etype> bool operator>=(const JString& Lsh, const Etype& Rsh);
        template<typename Etype> bool operator>=(const Etype& Lsh, const JString& Rsh);
        template<typename Etype> bool operator>=(const Etype& Lsh, const JString& Rsh);*/
		
		