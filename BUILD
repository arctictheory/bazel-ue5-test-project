load("@rules_unreal//:unreal_rules.bzl", "compile_blueprint", "list_blueprints_in_project")

compile_blueprint(
  name = "compile_bp",
  engine_executable = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
  project_file = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
  blueprint = "@root_workspace//BazelTestProjectGame:Content/ThirdPerson/Blueprints/BP_ThirdPersonCharacter.uasset"
  )

list_blueprints_in_project(
  name = "list_blueprints",
  engine_executable = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
  project_file = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
  )