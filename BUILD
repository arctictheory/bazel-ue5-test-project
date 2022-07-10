load("@rules_unreal//:unreal_rules.bzl", "compile_blueprint",)

compile_blueprint(
  name = "compile_bp",
  engine_executable = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
  project_file = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
  blueprint = "@root_workspace//BazelTestProjectGame:Content/ThirdPerson/Blueprints/BP_ThirdPersonCharacter.uasset"
  )
