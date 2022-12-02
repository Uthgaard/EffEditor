# EffEditor

This project is active development of a GUI tool to directly edit _sounds.eff binaries, rather than convert them to plaintext emt files.

I chose to break away from converting eff files to emt files, because the emt file supports fewer features and the conversion tends to cause some audio bugs.

This really should be a fork of the eff2emt code repo, but I couldn't figure out how to turn a clone into a fork

Current issues: The final line of the import process tends to zero out UnkRef00 or misplace its value into UnkRef04, depending on the total length of the binary.
This is the only incorrect value, no others in the row get misplaced when that happens.

Current development needs: Once the import bug is corrected, convert the values back to the native binary and rewrite the eff file.
