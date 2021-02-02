using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tam
    {
        // bỏ phần emailconfirm, phonenumberconfirm, twoFactorEnabled, lockoutEnabled, accessFailedCount
        //return await WithConnection(async conn =>
        //{
        //    var sql = $@"UPDATE Users SET FirstName = @firstName, LastName = @lastName, PasswordHash = @password, StatusId = @statusId,
        //                Position = @position, Avatar = @avatar, Gender = @gender, BirthDay = @birthDay, PhoneNumber = @phoneNumber,
        //                Street = @street, City = @city, ProvinceId = @provinceId, CountryId = @countryId, AcademicRankId = @academicRankId,
        //                AcademicDegreeId = @academicDegreeId, TimeZoneId = @timeZoneId, UserTypeId = @userTypeId,
        //                OrganizationalStructureId = @organizationalStructureId, Story = @story, 
        //                WHERE Email = @email";
        //    return await conn.QueryFirstAsync<int>(sql, new
        //    {
        //        firstName = user.FirstName,
        //        lastName = user.LastName,        
        //        password = user.Password,
        //        email = user.Email,
        //        statusId = user.StatusId,              
        //        position = user.Position,
        //        avatar = user.Avatar,
        //        gender = user.Gender,
        //        birthDay = user.BirthDay,
        //        phoneNumber = user.PhoneNumber,
        //        street = user.Street,
        //        city = user.City,
        //        provinceId = user.ProvinceId,
        //        countryId = user.CountryId,
        //        academicRankId = user.AcademicRankId,
        //        academicDegreeId = user.AcademicDegreeId,
        //        timeZoneId = user.TimeZoneId,
        //        userTypeId = user.UserTypeId,
        //        organizationalStructureId = user.OrganizationalStructureId,
        //        story = user.Story,
        //    });
        //});
    }
}
