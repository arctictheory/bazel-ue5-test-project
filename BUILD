load("@rules_unreal//:unreal_rules.bzl", "build_game", "load_map")

load_map(name = "LoadMap",
  unreal_engine_executable = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor.exe",
  project_file = "@root_workspace//:ProjectDawnGame/ProjectDawnPreview.uproject",
  map_file = "@root_workspace//:ProjectDawnGame/Content/ProjectDawn/Levels/Map_Projectdawn_P.uasset"
  )
