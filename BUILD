load("@rules_unreal//:unreal_rules.bzl", "compile_blueprint", "run_commandlet")

compile_blueprint(
  name = "compile_bp",
  engine_executable = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
  project_file = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
  blueprint = "@root_workspace//BazelTestProjectGame:Content/ThirdPerson/Blueprints/BP_ThirdPersonCharacter.uasset"
  )

run_commandlet(
  name = "run_resave_packages",   
  engine_executable = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
  project_file = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
  commandlet = "DataValidation"
  )