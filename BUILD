<<<<<<< HEAD
load("@rules_unreal//:unreal_rules.bzl", "compile_blueprint", "run_commandlet")
=======
load("@rules_unreal//:unreal_rules.bzl", "compile_blueprint",)
>>>>>>> fa4787e0b3bb7c3e7d900f609af52fddca8c9e54

compile_blueprint(
  name = "compile_bp",
  engine_executable = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
  project_file = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
  blueprint = "@root_workspace//BazelTestProjectGame:Content/ThirdPerson/Blueprints/BP_ThirdPersonCharacter.uasset"
  )
<<<<<<< HEAD

run_commandlet(
  name = "run_resave_packages",   
  engine_executable = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
  project_file = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
  commandlet = "DataValidation"
  )
=======
>>>>>>> fa4787e0b3bb7c3e7d900f609af52fddca8c9e54
