﻿using FluentValidation;
using Grand.Core.Validators;
using Grand.Services.Localization;
using Grand.Admin.Models.Courses;
using System.Collections.Generic;

namespace Grand.Admin.Validators.Courses
{
    public class CourseLessonValidator : BaseGrandValidator<CourseLessonModel>
    {
        public CourseLessonValidator(
            IEnumerable<IValidatorConsumer<CourseLessonModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Courses.Course.Lesson.Fields.Name.Required"));
            RuleFor(x => x.CourseId).NotEmpty().WithMessage(localizationService.GetResource("Admin.Courses.Course.Lesson.Fields.CourseId.Required"));
            RuleFor(x => x.SubjectId).NotEmpty().WithMessage(localizationService.GetResource("Admin.Courses.Course.Lesson.Fields.SubjectId.Required"));
        }
    }
}