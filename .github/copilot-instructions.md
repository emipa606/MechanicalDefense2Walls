# GitHub Copilot Instructions for Mechanical Defense 2 - Walls (Continued)

This mod is an update of "Mechanical Defense 2 - mechanical walls" and aims to add new technologies for your colony to utilize, including autonomous droids and coal-burning power generators. The mod incorporates a modular structure, allowing users to choose from different independent modules. Mechanical Walls are a key feature, allowing walls to be raised, lowered, or set to embrasure state to allow shooting through.

## Mod Overview and Purpose

Mechanical Defense 2 - Walls (Continued) is an update to the original "Mechanical Defense 2 - mechanical walls" mod. This mod adds new technologies to the RimWorld game, such as autonomous droids and coal-burning power generators. The mod is modular in nature, allowing users to choose from different independent modules to play with the features they want and leave out the ones they don't. The Mechanical Walls feature is a key part of this mod, allowing walls to be raised, lowered, or set to embrasure state to allow shooting through.

## Key Features and Systems

- **Mechanical Walls**: Walls that can be raised, lowered, or set to embrasure state to allow shooting through.
- **Autonomous Droids**: Droids that can perform tasks for the player.
- **Coal-Burning Power Generators**: Power generators that burn coal to produce electricity.
- **Modular Structure**: Allows users to choose from different independent modules to play with the features they want and leave out the ones they don't.

## Coding Patterns and Conventions

### C# Files

- **Building_MechWall.cs**: Contains the implementation for the Mechanical Wall building, including methods for toggling states and checking for power.
- **Building_MechWallRecessed.cs**: Contains the implementation for the Recessed Mechanical Wall building, including methods for toggling states and checking for power.
- **Keys.cs**: Contains the keys for the mod, such as the toggle state keys.
- **Building_MechWallEmbrasure.cs**: Contains the implementation for the Embrasure Mechanical Wall building, including methods for toggling states and checking for power.
- **Building_MechWallExtended.cs**: Contains the implementation for the Extended Mechanical Wall building, including methods for toggling states and checking for power.

### XML Files

- **MD2_mechwalls_ResearchProjectDefs.xml**: Contains the definition for the research project for the Mechanical Walls.
- **MD2_mechwalls_ThingDefs_base.xml**: Contains the base definitions for the Mechanical Walls.
- **MD2_mechwalls_ThingDefs_mechembrasure.xml**: Contains the definitions for the Embrasure Mechanical Walls.
- **MD2_mechwalls_ThingDefs_mechwalls.xml**: Contains the definitions for the Mechanical Walls.
- **ResearchTab_Patch.xml**: Contains the patch for the Research Tab.

## XML Integration

XML integration is a crucial part of RimWorld modding. The XML files contain the definitions for the mod's features, such as research projects, thing definitions, and patches. These definitions are used by the game engine to create and manage the mod's features.

## Harmony Patching

Harmony patching is another important aspect of RimWorld modding. Harmony patches allow modders to modify the game's code without having to modify the original game files. This allows for more flexibility and customization in the mod.

## Suggestions for Copilot

- Use XML integration to define the mod's features, such as research projects and thing definitions.
- Use Harmony patching to modify the game's code and add new features to the mod.
- Use C# to implement the mod's features, such as the Mechanical Wall building.
- Use the mod's modular structure to allow users to choose from different independent modules.

## Contact Information

For support and error reporting, please use the Discord channel. Always post your log using the Log Uploader. Use RimSort to sort your mods.

## Tags

- modular structure

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

