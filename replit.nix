{ pkgs }: {
	deps = [
   pkgs.chicken
		pkgs.jq.bin
  pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}