/*
 * Copyright (c) 2025 A-Maze Games
 * Website: www.a-maze.games
 * All rights reserved.
 */
using UnrealBuildTool;

public class BP2AI : ModuleRules
{
    public BP2AI(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "WebBrowser",
            "WebBrowserWidget"
            // Add other public dependencies if needed by public headers
        });

        PrivateDependencyModuleNames.AddRange(new string[] {
            "Engine", // Added Engine for FPaths, FString, etc. if not pulled indirectly
            "InputCore", // For potential input node processing
            "Slate",
            "SlateCore",
            "ApplicationCore", // For FPaths potentially
            "UnrealEd",
            "BlueprintGraph",
            "GraphEditor",
            "Kismet",
            "ToolMenus",
            "EditorFramework",
            "KismetCompiler",
            "Projects", // For IPluginManager
            "UMG", // Already present, needed for UUserWidget and UI elements
            "ToolWidgets", // May be needed for some Slate editor widgets
            "EditorStyle", // Needed for default icons potentially
            "Blutility", 
            "UMGEditor", 
            "InputBlueprintNodes", 
            "EnhancedInput", 
            
      
            "WebBrowser",          // For SWebBrowser widget
            "WebBrowserWidget",    // For web browser functionality
            "HTTP",                // For web requests if needed
            
            // Add other private dependencies if needed
        });

        // Setup include paths if needed - typically automatic for Public/Private structure
        // PublicIncludePaths.AddRange(new string[] { ModuleDirectory + "/Public" });
        // PrivateIncludePaths.AddRange(new string[] { ModuleDirectory + "/Private" });
        // Add these for WebBrowser support
        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            PrivateDependencyModuleNames.Add("CEF3Utils");
        }
        
    }
}