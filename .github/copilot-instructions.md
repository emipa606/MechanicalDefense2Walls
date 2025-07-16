# Copilot Instructions for RimWorld Mod: MD2 Mechanical Walls

## Mod Overview and Purpose

The **MD2 Mechanical Walls** mod is designed to enhance the base-building mechanics in RimWorld by introducing a variety of mechanical wall types. These walls offer players new strategic options for defense, aesthetics, and utility in their colonies. The mod primarily focuses on adding walls that provide different functionalities, such as embrasures for fortified shooting positions, extendable walls for offensive or defensive positioning, and recessed walls for a more compact design.

## Key Features and Systems

- **Mechanical Walls**: Introduces several new wall types with unique functionalities.
  - **Embrasure Walls**: Provide defensive positions to allow colonists to shoot while being protected.
  - **Extendable Walls**: Allow dynamic wall length adjustments for tactical advantages.
  - **Recessed Walls**: Offer a slim profile to save space while maintaining structural integrity.

## Coding Patterns and Conventions

- Use of abstract base classes, such as `Building_MechWall`, to encapsulate shared functionality and enable polymorphic behavior across different mechanical wall types.
- Follow the C# naming conventions where class names use PascalCase and method names also employ PascalCase.
- Constants and key fields are managed in a static class (`Keys`), ensuring that configurable elements are easy to find and modify.

## XML Integration

- XML files are used to define new building items and their properties, such as materials required, research prerequisites, and crafting time.
- Ensure valid XML structure to avoid parsing errors; review file integrity often and utilize XML format checkers if needed.
- Key XML configurations involve mapping the C# classes to in-game objects, specifying paths to textures, and defining interaction behaviors.

## Harmony Patching

- Utilize Harmony patches to modify existing RimWorld behaviors or introduce new mechanics.
- Ensure patches are non-destructive and reversible wherever possible. Document the original method signatures and the intended modifications.
- Follow safe patching practices to maintain compatibility with updates and other mods, testing patches across common game scenarios.

## Suggestions for Copilot

- When implementing new features, leverage the base class `Building_MechWall` to maintain consistency and minimize code duplication.
- Use comments to clearly describe the purpose and behavior of methods, especially those that modify game mechanics or integrate with XML systems.
- Enable meaningful IntelliSense suggestions by ensuring members are appropriately named and document critical class structures thoroughly.
- Encourage adding test scenarios to validate any new Harmony patches, ensuring they do not conflict with existing game functionality or other mods.
- Provide examples of correctly formatted XML snippets as reference when developing XML files for the mod.

By adhering to these guidelines, developers can ensure that contributions to the **MD2 Mechanical Walls** mod are consistent, robust, and maintainable.
