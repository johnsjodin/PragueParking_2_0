namespace PragueParking_2_0_Logic
{
    public static class ValidateRegistration
    {
        public static bool TryValidateRegistration(string registration, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(registration))
            {
                error = "Registration number cannot be empty.";
                return false;
            }

            if (registration.Length != 6)
            {
                error = "Registration number must be 6 characters long.";
                return false;
            }

            foreach (char c in registration)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    error = "Registration number contains invalid characters.";
                    return false;
                }
            }

            return true;
        }
    }
}
