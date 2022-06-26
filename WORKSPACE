workspace(name = "root_workspace")
load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")
load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")



git_repository(
    name = "rules_unreal",
    remote = "git@github.com:arctictheory/bazel_rules_unreal.git",
    commit = "edf9820d7edf3672d76cfa915b7a94e14549b93e"
    )

"""
local_repository(
    name = "rules_unreal",
    path = "D:/Work/ArcticTheory/bazel_rules_unreal"
    )
"""

new_local_repository(
    name = "unreal_engine",
    build_file = "@rules_unreal//ue5/engine:ue5_engine.BUILD",
    path = "D:/Work/ArcticTheory/ProjectDawn/UnrealEngine"
    )
    
http_archive(
    name = "rules_python",
    sha256 = "9fcf91dbcc31fde6d1edb15f117246d912c33c36f44cf681976bd886538deba6",
    strip_prefix = "rules_python-0.8.0",
    url = "https://github.com/bazelbuild/rules_python/archive/refs/tags/0.8.0.tar.gz",
)

load("@rules_python//python:repositories.bzl", "python_register_toolchains")

python_register_toolchains(
    name = "python3_9",
    python_version = "3.9",
)

load("@python3_9//:defs.bzl", "interpreter")

"""
load("@rules_python//python:pip.bzl", "pip_install")
pip_install(
    name = "pip_install_package",
    requirements = "//:requirements.txt",
    python_interpreter_target = interpreter
)
"""
